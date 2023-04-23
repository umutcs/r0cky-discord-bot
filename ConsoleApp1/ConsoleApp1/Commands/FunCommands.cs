using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using DSharpPlus.Interactivity.Extensions;
using DSharpPlus.VoiceNext;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace r0cky.Commands
{

    public class FunCommands : BaseCommandModule
    {
        [Command("avatar")]
        public async Task Avatar(CommandContext ctx)
        {
            var avatarUrl = ctx.User.AvatarUrl;

            var embed = new DiscordEmbedBuilder
            {
                Title = "User Avatar",
                ImageUrl = avatarUrl
            };
            await ctx.RespondAsync("Sıfatını sikim bu ne la KJASHDJLKADJLKASDJLKA");
            await ctx.Channel.SendMessageAsync(embed: embed);

        }

        [Command("hikaye")]
        public async Task Hikayes(CommandContext ctx)
        {
            string[] flood = new string[] { "Düşünsenize.. Kılıçdaroğlu gizli akpliymiş odasında reisin posteri asılıymış. Her gece yatmadan önce kuran okuyup dua edip allahım ümmeti-islamı reissiz bırakma diyormuş.\r\n\r\nMitinglerde reise sesini yükselttiği için uyuyamıyormuş geceleri. Ama bu onun kutsal göreviymiş, Chplilerin oylarını almak için kafir gibi davranmanın vicdani yüküyle böyle baş ediyormuş. Ah bir de reisin elini doya doya öpebilseymiş…\r\n\r\nYıl 2023 Chp seçimi kazanıyor. Herkes balkon konuşması bekliyor. O sırada balkonda uzun bir silüet beliriyor ve yanında daha kısa gözlüklü biri,sarmaş dolaşlar.Meydanda bekleyen binlerce kişi şok içinde açıklama bekliyor. Kılıçdaroğlu göz ucuyla reise bakıp izin vermesini bekliyor. Erdoğan başını sallayıp konuşmasını söylüyor. Kılıçdaroğlu diyor ki:\r\n\r\n\\-Ülkemizde bulunan dinsiz, ahlaksız kesimin oylarını almak için böyle bir şey yapmak zorunda kaldım. Yalan söylediğim için sizden özür diliyorum. Ülkemizi yıllardır islamla şereflendiren Yüce liderimiz Recep Tayyip Erdoğan, partimizin başkanlığına ve dolayısıyla Cumhurbaşkanlığı makamına,hakettiği yere ömrünün sonuna kadar (kısık sesle ömrü uzun olsun der ,mahzunlaştığı farkedilir) geçirilmiş bulunmaktadır. Yeni kurallar şu şekildedir.\r\n\r\n1- İkinci bir emre kadar sosyal medyadan seçim hakkında konuşmak yasaklanmıştır.\r\n\r\n2-Reisimize saygısızlık yapan gazeteciler en sert şekilde cezalandırılacaktır.\r\n\r\n3-İmam hatipleri genele yayarak tüm liseleri İmam Hatip lisesine çevirmiş bulunmaktayız.\r\n\r\nKalabalık duydukları karşısında şok içindedir. Bir kaç kişi sesini yükseltecek olur,o anda gökyüzünde jet uçakları uçmaya başlar. Kimse söylemese de herkes bunun bir tehdit olduğunu anlar ve kalabalık bazıları ağlayarak bazıları öfkeden deliye dönmüş bir şekilde dağılır. İntiharı düşünenler kendilerini teskin etmeye çalışır. Çoğu kişiyse hala bunun gerçek olduğuna inanmamaktadır. Sosyal medyadan bilgi almaya çalıştıklarında otomatik olarak allahaiman.com adlı bir siteye yönlendirilirler. Facebook, Twitter, Instagram ve diğer sosyal medya uygulamalarının 3 gün için yasak olduğu duyurulur camilerden.\r\n\r\n3 ay sonra…\r\n\r\nHer cuma namazını Reisle beraber eda eden Kılıçdaroğlu, Ekrem İmamoğlu ve Mansur Yavaş’ın tatil dönüşünde maalesef kaza geçirdiğini ve kaldırıldıkları hastanede hayatını kaybettiklerini açıklar. Kimse inanmaz ama en ufak bir ses şiddetle bastırılmaktadır. Ailesinden birileri bir anda kaybolan insanların sayısı oldukça fazladır. Buna rağmen halkın şeriata bakışı değişmiş, ülkenin bir kısmının kaynaklarının hükümete açıkça destek olanlara aktarılmasıyla eskiden Akp destekçisi ılımlılar şeriat istemeye başlamışlardır.\r\n\r\nKılıçdaroğlu Ayasofyada öğlen namazı sonrasında ufuğa diker gözlerini. Yıllarca söylediği yalanlara, oynadığı rollere değmiş Allah’ın dini tüm ülkeyi kaplamıştır. Afganistana gidecek olan silah sevkiyatı işini tanıdık bir firmaya verdikten sonra, reisle ufak bir görüşme yapacak sonrasında villasında huzurlu bir şekilde cennetteki köşkünü hayal edip tatlı bir uykuya dalacaktır.",
            "Okuldan çıktım, karnım acıkmış. Cebimde 5 lira var. Sene 2014 5 TL iyi para. Çiğköftecinin başına geldim(seyyar satıcı), adama diyorum ki “Merhaba.” Bak biraz daha akıllı olsa gerizekalı olacak insan bile buna cevap verir. Orospu çocuğu çiğköftecinin surat beş karış bana bakıyor. İçinde ne olsun, ne olmasın söyleyip beklemeye başladım. Bu adam Adıyaman’dan gelen genleri ile coşmuş, kıllı kolları ile benim dürümü hazırlamaya başladı. Dürümü aldım çıkarken bir kez daha insanlık etmek geldi aklıma. O aklıma sokayım. Giderken “Kolay gelsin.” Dedim, yine cevap yok. Cevap gelmeyince galiba biraz yüksek sesle küfür etmiş olacağım ki bu primat olduğu yerden kalktı ve 1.65 boyu ile üzerime yürümeye başladı. Neyine güvendiğine de anlam vermeyerek ben de buna yürümeye başladım. Kendimi kavgaya hazırlamışken bu neandartel kılıklı dağ ayısı kaçmaya başladı. Ama ben nasıl havalı hissediyorum. Sonra arkamı döndüm karşımda zabıta. Orospu çocuğu zabıtadan kaçmış",
            "Genj adam biz buralarda bulgurluları sevmeyiz. Onları av olarak görürüz. Bazen avda iken çok acımasız olabiliriz. “Ya düzgünce konuşun niye down atıyorsunuz. Burada admin yok mu anama bacıma sövüyorlar” diye bazen avlarımız debelenebilir. Ama bizim gözümüz av sırasında hiçbir şeyi görmez. Avımız bizim odak noktamızdır. Neden sevmediğimize gelirsek, kendileri arasında “meme” olarak yaptıkları sikimtrak mizahı komik bulamıyoruz. Bu bizi güldürmek yerine sinirlendiriyor. Genellikle bulgurcu gördüğümüzde çok sinirli ve agresif oluruz. Bazen sakin ve sevecen şekilde uyarılarımız olmuyor değil fakat şu zamana kadar hiç bir olumlu yaklaşım iyi sonuçlanmadı. Olumlu tavrımıza karşı çok alıngan ve duygusal yaklaştılar, kimileri agresif davrandı. Agresif davrananları avladık.Eğer bulgur mizajını bulgurda bırakır buraya getirmezsen genj adam senle iyi anlaşabiliriz. Sana amk n*wi deriz. Aramızda bir sicaklık oluşur. Eğer ki bulgur mizajını buraya taşımaya çalışırsan üzgünüm ama sende av olursun.",
            "Hiç bi sikim olmuyo ben kavgada bıçaklandım hissetmedim amk kavgaya devam ettim sonra baktım cocuk 2 3 kere daha soktu o zaman ayıktım yine de kavgaya devam ettim aq sjsjsjjssj zaten 30 40 sn sonra bacağında hissizlik oluşuyo otamatik yere düşüyon istemsizce yani bıçaklaninca pek bişey olmuyo ama iyileşme süreci biraz sancılı",
            "Mimimi Beytullah, kendisi 2 üniversite mezunu ve tarzanca ingilizcesi mevcut. Ama o aslında çok olgun. Yaşıtlarına göre çok zeki. Çünkü o kurtlar vadisi izliyor. mimimi Beytullah sabah 7.40 de uyandı. Uykusunda lazyanın kızını siktiğini gördü. Ne güzel bir rüyaydı bu. Kalktı tuvalete gitti. Tuvalette tam keşan postasına atmalık bir makale buldu. makale  şuydu. İshalsindir, Osurucağım sanırsın ama SIÇARSIN. Mükemmel bir makaleydi bu. Ama bir sorun vardı. O onaylı yazar değildi. Bu yüzden önce özgün haberler com’a atmalıydı. Tuvaletten çıktı. Hemen bilgisayarını açtı. Makalesini paylaştı. Ama o da ne? Mimimi Beytullah Makalesini incisözlük diye bir siteye attı. Neyse burada da herhalde böyle güzel bir makaleye yorum, beğeni atarlar, diye düşündü. Yemeğini yemeye gitti. Ama babası uyanmamıştı. Bu yüzden dünden kalan makarnasını ısıtıp onu yedi. Yemeğini yerken bi de sadece Polat videosu açtı. Bu adam mükemmel sıkıyordu. Yemeği bitti. İnternete girdi o da ne? Mükemmel makalesine asdafazdawazqweyvraz diye bir adam saçma sapan uzun yazılar atıyordu. Diğer yorumlara baktı. Orada da babasına ateist diyorlardı. Hemen admin çağırdı. admin de babayın amk ha dedi. Gidip babasının odasına baktı. Çok sükür kimse yoktu. makalesini sildi. Babası uyandı. Babasına ” Baba saklan incisözlük yazarları bizi sikicek” dedi. Babası ne diyon oğlum dedi. Ve ekmek almaya yolladı. Fırına girdi. Fırıncı telefondan bir türkü açmıştı. Mimimi Beytullah bu türküyü beğenmeyip bir kurtlarvadisi şarkısı açtı. Fırıncı telefonu Mimimi Beytullah‘ın elinden aldı. Beytullah siz burada yahudi mi yakıyordunuz diye sordu. Fırıncı kim diyor evladım dedi. Beytullah ” Hamza” dedi. Fırıncı hamza kim diye sordu. Beytullah gülmekten altına sıçtı. Ve eve doğru yol aldı.",
           "porno",
           "Bir kızla kanka olmak kadar beni azdiran başka bisey yok. O kıza ulaşamıyor olmanın verdiği haz kadar beni erekte eden başka bisey yok. Ama kankam olduğum kızlar bunu bilmiyorlar! Bana her kanka dediklerinde penisimin kalktığını ve oracıkta boşaldigimi gözümün zevkten döndüğünü bilmiyorlar!",
           "Seni sevmek ölümse koyam götüne gülümse "
            };
            int msg = new Random().Next(0, flood.Length);
            await ctx.RespondAsync(flood[msg]);
        }


        [Command("rps")]
        public async Task RockPaperScissors(CommandContext ctx, string input = null)
        {
            if (string.IsNullOrEmpty(input))
            {
                await ctx.Channel.SendMessageAsync("Lütfen taş (t), kağıt (k) ya da makas (m) seçin.");
                return;
            }

            var validInputs = new List<string> { "t", "k", "m" };
            if (!validInputs.Contains(input))
            {
                await ctx.Channel.SendMessageAsync("Geçersiz seçim. Lütfen taş (t), kağıt (k) ya da makas (m) seçin.");
                return;
            }

            var random = new Random();
            var computerInput = validInputs[random.Next(validInputs.Count)];

            string message = "Bilgisayar: ";
            switch (computerInput)
            {
                case "t":
                    message += "Taş";
                    break;
                case "k":
                    message += "Kağıt";
                    break;
                case "m":
                    message += "Makas";
                    break;
            }

            message += "\nSiz: ";
            switch (input)
            {
                case "t":
                    message += "Taş";
                    break;
                case "k":
                    message += "Kağıt";
                    break;
                case "m":
                    message += "Makas";
                    break;
            }

            if (input == computerInput)
            {
                message += "\nBerabere!";
            }
            else if (input == "t" && computerInput == "m" || input == "k" && computerInput == "t" || input == "m" && computerInput == "k")
            {
                message += "\nTebrikler, kazandınız!";
            }
            else
            {
                message += "\nMaalesef, kaybettiniz!";
            }

            await ctx.Channel.SendMessageAsync(message);
        }
        [Command("wheel")]
        
        private async Task SpinWheel(CommandContext context)
        {
            string[] wheelOptions = new string[] { "1", "2", "3", "4", "5","6","7","8","9","10" };
            string[] wheelSpinOptions = new string[] { "3", "2", "5", "4", "1", "6", "7", "8", "9", "10" };
            await context.Channel.SendMessageAsync("Bahis yapmak istediğiniz sayıyı seçin (1-10):");
            var response = await context.Channel.GetNextMessageAsync();
            if (!wheelOptions.Contains(response.Result.Content))
            {
                await context.Channel.SendMessageAsync("Geçersiz seçenek. Lütfen 1-10 arasında bir sayı girin.");
                return;
            }
            string result = wheelSpinOptions[new Random().Next(wheelSpinOptions.Length)];
            if (result == response.Result.Content)
            {
                await context.Channel.SendMessageAsync("Tebrikler! Kazandınız!");
            }
            else
            {
                await context.Channel.SendMessageAsync($"Malesef kaybettiniz. Tekerlek {result} durağında durdu.");
            }
        }



        [Command("random")]
        public async Task RandomNumber(CommandContext ctx, string input = null)
        {
            int userNumber;
            if (string.IsNullOrEmpty(input))
            {
                var interactivity = ctx.Client.GetInteractivity();
                await ctx.Channel.SendMessageAsync("Lütfen 0 ile 100 arasında bir sayı girin:");
                var response = await interactivity.WaitForMessageAsync(x => x.Author.Id == ctx.User.Id && x.ChannelId == ctx.Channel.Id && int.TryParse(x.Content, out int _), TimeSpan.FromSeconds(30));
                userNumber = int.Parse(response.Result.Content);
            }
            else
            {
                if (!int.TryParse(input, out userNumber) || userNumber < 0 || userNumber > 100)
                {
                    await ctx.Channel.SendMessageAsync("Lütfen geçerli bir sayı girin (0-100 arasında)!");
                    return;
                }
            }

            int botNumber = new Random().Next(0, 101);
            await ctx.Channel.SendMessageAsync($"Bot {botNumber} sayısını seçti.");
            if (userNumber > botNumber)
            {
                await ctx.Channel.SendMessageAsync("Tebrikler, kazandınız!");
            }
            else if (userNumber < botNumber)
            {
                await ctx.Channel.SendMessageAsync("Maalesef, kaybettiniz!");
            }
            else
            {
                await ctx.Channel.SendMessageAsync("Berabere!");
            }
        }
    }
}