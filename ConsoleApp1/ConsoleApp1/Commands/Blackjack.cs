using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Interactivity.Extensions;

namespace r0cky.Commands
{
    public class Blackjack : BaseCommandModule
    {
        [Command("blackjack")]

        public async Task PlayBlackjack(CommandContext ctx)
        {
            var interactivity = ctx.Client.GetInteractivity();
            var deck = new Deck();
            deck.Shuffle();

          
            var playerHand = new List<Card> { deck.DrawCard(), deck.DrawCard() };
            var botHand = new List<Card> { deck.DrawCard(), deck.DrawCard() };

           
            var playerHandString = string.Join(", ", playerHand.Select(card => card.ToString()));
            await ctx.Channel.SendMessageAsync($"Senin elin: {playerHandString}");

            
            await ctx.Channel.SendMessageAsync($"Bot'un eli: {botHand[0]}, [Kapalı]");

            while (true)
            {
                await ctx.Channel.SendMessageAsync("Hit veya Stand yap?");
                var response = await interactivity.WaitForMessageAsync(x => x.Author.Id == ctx.User.Id && x.ChannelId == ctx.Channel.Id && (x.Content.ToLower() == "hit" || x.Content.ToLower() == "stand"), TimeSpan.FromSeconds(30));


                if (response.Result.Content.ToLower() == "hit")
                {
                    var card = deck.DrawCard();
                    playerHand.Add(card);
                    await ctx.Channel.SendMessageAsync($"Çekilen kart: {card}");
                    playerHandString = string.Join(", ", playerHand.Select(c => c.ToString()));
                    await ctx.Channel.SendMessageAsync($"Yeni elin: {playerHandString}");

                    if (CalculateHandValue(playerHand) > 21)
                    {
                        await ctx.Channel.SendMessageAsync("21'den fazla, kaybettin!");
                        return;
                    }
                }
                else
                {
                    break;
                }
            }

            while (CalculateHandValue(botHand) < 17)
            {
                var card = deck.DrawCard();
                botHand.Add(card);
                await ctx.Channel.SendMessageAsync($"Bot {card} çekti.");
            }

           
            var botHandString = string.Join(", ", botHand.Select(card => card.ToString()));
            await ctx.Channel.SendMessageAsync($"Bot'un eli: {botHandString}");

            
            var playerHandValue = CalculateHandValue(playerHand);
            var botHandValue = CalculateHandValue(botHand);
            if (playerHandValue > botHandValue && playerHandValue <= 21 || botHandValue > 21 && playerHandValue <= 21)
            {
                await ctx.Channel.SendMessageAsync("Tebrikler, kazandın!");
            }





            else if (botHandValue > playerHandValue && botHandValue <= 21 || playerHandValue > 21 && botHandValue <= 21)
            {
                await ctx.Channel.SendMessageAsync("Maalesef, kaybettin!");
            }

            else
            {
                await ctx.Channel.SendMessageAsync("Berabere!");
            }
        }

        
        private int CalculateHandValue(List<Card> hand)
        {
            var value = 0;
            var aceCount = 0;


            foreach (var card in hand)
            {
                if (card.Rank == Rank.Ace)
                {
                    aceCount++;
                    value += 11;
                }
                else if (card.Rank == Rank.Jack || card.Rank == Rank.Queen || card.Rank == Rank.King)
                {
                    value += 10;
                }
                else
                {
                    value += (int)card.Rank;
                }
            }

            while (value > 21 && aceCount > 0)
            {
                value -= 10;
                aceCount--;
            }

            return value;
        }

        
        public class Deck
        {
            private List<Card> _cards;
            private int _currentIndex;


            public Deck()
            {
                _cards = new List<Card>();
                _currentIndex = 0;

                foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                {
                    foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                    {
                        _cards.Add(new Card(suit, rank));
                    }
                }
            }

            public void Shuffle()
            {
                _cards = _cards.OrderBy(x => Guid.NewGuid()).ToList();
                _currentIndex = 0;
            }

            public Card DrawCard()
            {
                var card = _cards[_currentIndex];
                _currentIndex++;
                return card;
            }
        }

        public class Card
        {
            public Suit Suit { get; }
            public Rank Rank { get; }


            public Card(Suit suit, Rank rank)
            {
                Suit = suit;
                Rank = rank;
            }

            public override string ToString()
            {
                return $"{Rank} of {Suit}";
            }
        }

       
        public enum Suit
        {
            Clubs,
            Diamonds,
            Hearts,
            Spades
        }

        
        public enum Rank
        {
            Two = 2,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
            Ace
        }
    }
}
