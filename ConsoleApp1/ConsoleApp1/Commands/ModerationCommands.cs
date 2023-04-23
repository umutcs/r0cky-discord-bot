using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.CommandsNext;
using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;

namespace r0cky.Commands
{
    public class ModerationCommands : BaseCommandModule
    {
        [Command("kick")]
        public async Task kick(CommandContext ctx, DiscordMember member)
        {
            if (member.Roles != null)
            {
                try
                {
                    var rolestoremoveid = new List<ulong> { };
                    var rolestoremove = member.Roles.Where(r => rolestoremoveid.Contains(r.Id)).ToList();

                    if (member.Roles != null)
                    {
                        if (rolestoremove.Any())
                        {
                            foreach (var item in rolestoremove)
                            {
                                await member.RevokeRoleAsync(item);
                            }
                        }
                        await member.RemoveAsync();
                    }
                    else
                    {
                        await member.RemoveAsync();
                    }
                }
                catch (Exception ex)
                {
                    var embed = new DiscordEmbedBuilder
                    {
                        Title = "Hata",
                        Description = ex.Message
                    };
                    await ctx.RespondAsync(embed);
                }
            }
        }
        [Command("mute")]
        public async Task Mute(CommandContext ctx, DiscordMember member)
        {
            if (member.IsMuted != true)
            {
                await member.SetMuteAsync(true, "Muted by r0cky bot");
                var embed = new DiscordEmbedBuilder
                {
                    Title = "Muted",
                    Description = "User muted by r0cky bot",
                    ImageUrl = member.AvatarUrl
                };
                await ctx.RespondAsync(embed);
            }
            else
            {
                await ctx.RespondAsync("User already muted!");
            }
        }


        [Command("ban")]
        public async Task ban(CommandContext ctx, DiscordMember member)
        {

            var rolesToRemoveIds = new List<ulong>() { 1098988937134997626 };

            var rolesToRemove = member.Roles.Where(r => rolesToRemoveIds.Contains(r.Id)).ToList();
            if (rolesToRemove.Any())
            {
                foreach (var item in rolesToRemove)
                {
                    await member.RevokeRoleAsync(item);
                }
            }
            await member.BanAsync();
        }
    }
}
