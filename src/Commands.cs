using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using System;
using System.Threading.Tasks;

namespace GoSBot
{
    class Commands
    {

        [Command("formula")]
        [Description("This is the formula for Vizier Power.")]
        public async Task Formula(CommandContext ctx)
        {
            await ctx.RespondAsync("((Vizier Level * 5000) * Total Military Talent) + Military Attributes");
        }

        [Command("vpform")]
        [Description("You use this command to figure out your power")]
        public async Task VizierPowerForm(CommandContext ctx, [Description("Your viziers power")] ulong vLevel,
            [Description("Your viziers military talent Total!")] ulong tMTalent, [Description("Your military attribute total")] ulong mAttributes)
        {
            var power = ((vLevel * 5000) * tMTalent) + mAttributes;
            await ctx.RespondAsync($"Your vizier's power is: {power}");
        }
        [Command("empirebooks")]
        [Description("This gets the total of your books.")]
        public async Task bookNumbers(CommandContext ctx, [Description("100 Attribute book count, this includes all 100 attribute books.")]ulong sBook, [Description
            ("500 Attribute total count. All of them")]ulong mBook, [Description("Your 1000 attribute count total. All books")]ulong lBook, [Description
            ("Your 5000 book attribute count total. Use all of them.")] ulong xlBook, [Description("This is your almighty book counts.")]ulong almightyBook, [Description("Your total empire power")]ulong empirePower)
        {
            ulong smallTotal = sBook * 100;
            ulong mediumTotal = mBook * 500;
            ulong largeTotal = lBook * 1000;
            ulong xLargeTotal = xlBook * 5000;
            ulong almightyTotal = almightyBook * 40000;
            ulong bookTotal = smallTotal + mediumTotal + largeTotal + xLargeTotal + almightyTotal;
            ulong topPower = bookTotal + empirePower;
            ulong gainedPower = topPower - empirePower;
            await ctx.RespondAsync($"Your gain was : {gainedPower}. Your total power is: {topPower}");
        }
        [Command("militarybadges")]
        [Description("This is the total of what military badges would give you to your empire power.")]
        public async Task militarybadges(CommandContext ctx, [Description("Enter how many military badges your wanting to check")] ulong mBadges,
           [Description("Enter in the stars for the talent your wanting to level")] ulong mStars, [Description("Enter your vizier level")] ulong vLevel)
        {
            switch (mStars)
            {
                case 1:
                    {
                        ulong totalBadge = 1 * mBadges;
                        ulong totalMilitaryTalent = totalBadge;
                        ulong militaryEmpire = totalMilitaryTalent * ((((vLevel - 1) * (vLevel + 2)) / 10) + 10);
                        await ctx.RespondAsync($"Your military badges give you a gain of: {militaryEmpire}.");
                        break;
                    }
                case 2:
                    {
                        double totalBadge = 0.5 * mBadges;
                        if (totalBadge < 1)
                        {
                            ulong militaryEmpire = 0;
                            await ctx.RespondAsync($"Your military badges give you a gain of: {militaryEmpire}.");
                        }
                        else
                        {
                            ulong totalMilitaryTalent = Convert.ToUInt64(Math.Truncate(totalBadge));
                            ulong militaryEmpire = totalMilitaryTalent * ((((vLevel - 1) * (vLevel + 2)) / 10) + 10);
                            await ctx.RespondAsync($"Your military badges give you a gain of: {militaryEmpire}.");
                        }
                        break;
                    }
                case 3:
                    {
                        double totalBadge = 0.33 * mBadges;
                        if (totalBadge < .99)
                        {
                            ulong militaryEmpire = 0;
                            await ctx.RespondAsync($"Your military badges give you a gain of: {militaryEmpire}.");
                        }
                        else
                        {
                            ulong totalMilitaryTalent = Convert.ToUInt64(Math.Truncate(totalBadge));
                            ulong militaryEmpire = totalMilitaryTalent * ((((vLevel - 1) * (vLevel + 2)) / 10) + 10);
                            await ctx.RespondAsync($"Your military badges give you a gain of: {militaryEmpire}.");
                        }
                        break;
                    }
                case 4:
                    {
                        double totalBadge = 0.25 * mBadges;
                        if (totalBadge < 1)
                        {
                            ulong militaryEmpire = 0;
                            await ctx.RespondAsync($"Your military badges give you a gain of: {militaryEmpire}.");
                        }
                        else
                        {
                            ulong totalMilitaryTalent = Convert.ToUInt64(Math.Truncate(totalBadge));
                            ulong militaryEmpire = totalMilitaryTalent * ((((vLevel - 1) * (vLevel + 2)) / 10) + 10);
                            await ctx.RespondAsync($"Your military badges give you a gain of: {militaryEmpire}.");
                        }
                        break;
                    }
                case 5:
                    {
                        double totalBadge = 0.2 * mBadges;
                        if (totalBadge < 1)
                        {
                            ulong militaryEmpire = 0;
                            await ctx.RespondAsync($"Your military badges give you a gain of: {militaryEmpire}.");
                        }
                        else
                        {
                            ulong totalMilitaryTalent = Convert.ToUInt64(Math.Truncate(totalBadge));
                            ulong militaryEmpire = totalMilitaryTalent * ((((vLevel - 1) * (vLevel + 2)) / 10) + 10);
                            await ctx.RespondAsync($"Your military badges give you a gain of: {militaryEmpire}.");
                        }
                        break;
                    }
                case 6:
                    {
                        double totalBadge = 0.17 * mBadges;
                        if (totalBadge < 1)
                        {
                            ulong militaryEmpire = 0;
                            await ctx.RespondAsync($"Your military badges give you a gain of: {militaryEmpire}.");
                        }
                        else
                        {
                            ulong totalMilitaryTalent = Convert.ToUInt64(Math.Truncate(totalBadge));
                            ulong militaryEmpire = totalMilitaryTalent * ((((vLevel - 1) * (vLevel + 2)) / 10) + 10);
                            await ctx.RespondAsync($"Your military badges give you a gain of: {militaryEmpire}.");
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
        [Command("researchbadges")]
        [Description("The amount of power your research badges give you!")]
        public async Task researchBadges(CommandContext ctx, [Description("Enter how many research badges your wanting to check")] ulong rBadges,
           [Description("Enter in the stars for the talent your wanting to level")] ulong rStars, [Description("Enter your vizier level")] ulong vLevel)
        {
            switch (rStars)
            {
                case 1:
                    {
                        ulong researchTotal = 1 * rBadges;
                        ulong totalResearch = researchTotal;
                        ulong researchEmpire = totalResearch * ((((vLevel - 1) * (vLevel + 2)) / 10) + 10);
                        await ctx.RespondAsync($"Your research badges give you a gain of: {researchEmpire}.");
                        break;
                    }
                case 2:
                    {
                        double researchTotal = .5 * rBadges;
                        if (researchTotal < 1)
                        {
                            ulong researchEmpire = 0;
                            await ctx.RespondAsync($"Your research badges give you a gain of: {researchEmpire}.");
                        }
                        else
                        {
                            ulong researchTotalBadge = Convert.ToUInt64(Math.Truncate(researchTotal));
                            ulong researchEmpire = researchTotalBadge * ((((vLevel - 1) * (vLevel + 2)) / 10) + 10);
                            await ctx.RespondAsync($"Your research badges give you a gain of: {researchEmpire}.");
                        }
                        break;
                    }
                case 3:
                    {
                        double researchTotal = .33 * rBadges;
                        if (researchTotal < 1)
                        {
                            ulong researchEmpire = 0;
                            await ctx.RespondAsync($"Your research badges give you a gain of: {researchEmpire}.");
                        }
                        else
                        {
                            ulong researchTotalBadge = Convert.ToUInt64(Math.Truncate(researchTotal));
                            ulong researchEmpire = researchTotalBadge * ((((vLevel - 1) * (vLevel + 2)) / 10) + 10);
                            await ctx.RespondAsync($"Your research badges give you a gain of: {researchEmpire}.");
                        }
                        break;
                    }
                case 4:
                    {
                        double researchTotal = .25 * rBadges;
                        if (researchTotal < 1)
                        {
                            ulong researchEmpire = 0;
                            await ctx.RespondAsync($"Your research badges give you a gain of: {researchEmpire}.");
                        }
                        else
                        {
                            ulong researchTotalBadge = Convert.ToUInt64(Math.Truncate(researchTotal));
                            ulong researchEmpire = researchTotalBadge * ((((vLevel - 1) * (vLevel + 2)) / 10) + 10);
                            await ctx.RespondAsync($"Your research badges give you a gain of: {researchEmpire}.");
                        }
                        break;
                    }
                case 5:
                    {
                        double researchTotal = .20 * rBadges;
                        if (researchTotal < 1)
                        {
                            ulong researchEmpire = 0;
                            await ctx.RespondAsync($"Your research badges give you a gain of: {researchEmpire}.");
                        }
                        else
                        {
                            ulong researchTotalBadge = Convert.ToUInt64(Math.Truncate(researchTotal));
                            ulong researchEmpire = researchTotalBadge * ((((vLevel - 1) * (vLevel + 2)) / 10) + 10);
                            await ctx.RespondAsync($"Your research badges give you a gain of: {researchEmpire}.");
                        }
                        break;
                    }
                case 6:
                    {
                        double researchTotal = .17 * rBadges;
                        if (researchTotal < 1)
                        {
                            ulong researchEmpire = 0;
                            await ctx.RespondAsync($"Your research badges give you a gain of: {researchEmpire}.");
                        }
                        else
                        {
                            ulong researchTotalBadge = Convert.ToUInt64(Math.Truncate(researchTotal));
                            ulong researchEmpire = researchTotalBadge * ((((vLevel - 1) * (vLevel + 2)) / 10) + 10);
                            await ctx.RespondAsync($"Your research badges give you a gain of: {researchEmpire}.");
                        }
                        break;
                    }
                default:
                    {
                        await ctx.RespondAsync("You must enter the star rating!");
                        break;
                    }

            }
        }
        [Command("politicalbadges")]
        [Description("Get the total of empire gain from political badges.")]
        public async Task politicalBadges(CommandContext ctx, [Description("Enter how many political badges your wanting to check")] ulong poBadges,
           [Description("Enter in the stars for the talent your wanting to level")] ulong poStars, [Description("Enter your vizier level")] ulong vLevel)
        {
            switch (poStars)
            {
                case 1:
                    {
                        double politicalBadge = 1 * poBadges;
                        ulong politicalTotal = Convert.ToUInt64(politicalBadge);
                        ulong politicalEmpire = politicalTotal * ((((vLevel - 1) * (vLevel + 2)) / 10) + 10);
                        await ctx.RespondAsync($"Your political badges give you a gain of: {politicalEmpire}.");
                        break;
                    }
                case 2:
                    {
                        double politicalBadge = .5 * poBadges;
                        if (politicalBadge < 1)
                        {
                            ulong politicalEmpire = 0;
                            await ctx.RespondAsync($"Your political badges give you a gain of: {politicalEmpire}.");
                        }
                        else
                        {
                            ulong polTotalB = Convert.ToUInt64(Math.Truncate(politicalBadge));
                            ulong politicalEmpire = polTotalB * ((((vLevel - 1) * (vLevel + 2)) / 10) + 10);
                            await ctx.RespondAsync($"Your political badges give you a gain of: {politicalEmpire}.");
                        }
                        break;
                    }
                case 3:
                    {
                        double politicalBadge = .33 * poBadges;
                        if (politicalBadge < .99)
                        {
                            ulong politicalEmpire = 0;
                            await ctx.RespondAsync($"Your political badges give you a gain of: {politicalEmpire}.");
                        }
                        else
                        {
                            ulong polTotalB = Convert.ToUInt64(Math.Truncate(politicalBadge));
                            ulong politicalEmpire = polTotalB * ((((vLevel - 1) * (vLevel + 2)) / 10) + 10);
                            await ctx.RespondAsync($"Your political badges give you a gain of: {politicalEmpire}.");
                        }
                        break;
                    }
                case 4:
                    {
                        double politicalBadge = .25 * poBadges;
                        if (politicalBadge < 1)
                        {
                            ulong politicalEmpire = 0;
                            await ctx.RespondAsync($"Your political badges give you a gain of: {politicalEmpire}.");
                        }
                        else
                        {
                            ulong polTotalB = Convert.ToUInt64(Math.Truncate(politicalBadge));
                            ulong politicalEmpire = polTotalB * ((((vLevel - 1) * (vLevel + 2)) / 10) + 10);
                            await ctx.RespondAsync($"Your political badges give you a gain of: {politicalEmpire}.");
                        }
                        break;
                    }
                case 5:
                    {
                        double politicalBadge = .20 * poBadges;
                        if (politicalBadge < 1)
                        {
                            ulong politicalEmpire = 0;
                            await ctx.RespondAsync($"Your political badges give you a gain of: {politicalEmpire}.");
                        }
                        else
                        {
                            ulong polTotalB = Convert.ToUInt64(Math.Truncate(politicalBadge));
                            ulong politicalEmpire = polTotalB * ((((vLevel - 1) * (vLevel + 2)) / 10) + 10);
                            await ctx.RespondAsync($"Your political badges give you a gain of: {politicalEmpire}.");
                        }
                        break;
                    }
                case 6:
                    {
                        double politicalBadge = .17 * poBadges;
                        if (politicalBadge < 1)
                        {
                            ulong politicalEmpire = 0;
                            await ctx.RespondAsync($"Your political badges give you a gain of: {politicalEmpire}.");

                        }
                        else
                        {
                            ulong polTotalB = Convert.ToUInt64(Math.Truncate(politicalBadge));
                            ulong politicalEmpire = polTotalB * ((((vLevel - 1) * (vLevel + 2)) / 10) + 10);
                            await ctx.RespondAsync($"Your political badges give you a gain of: {politicalEmpire}.");
                        }
                        break;
                    }
                default:
                    {
                        await ctx.RespondAsync("You must enter a star rating");
                        break;
                    }
            }
        }
        [Command("prestigebadges")]
        [Description("Measures your prestiage badge increase to empire power")]
        public async Task prestigeBadges(CommandContext ctx, [Description("Enter how many prestige badges your wanting to check")] ulong prBadges,
           [Description("Enter in the stars for the talent your wanting to level")] ulong prStars, [Description("Enter your vizier level")] ulong vLevel)
        {

            switch (prStars)
            {
                case 1:
                    {
                        double prestigeBadges = 1 * prBadges;
                        ulong prestigeTotal = Convert.ToUInt64(prestigeBadges);
                        ulong prestigeEmpire = prestigeTotal * ((((vLevel - 1) * (vLevel + 2)) / 10) + 10);
                        await ctx.RespondAsync($"Your prestige badges give you a gain of: {prestigeEmpire}.");
                        break;
                    }
                case 2:
                    {
                        double prestigeTotal = .5 * prBadges;
                        if (prestigeTotal < 1)
                        {
                            ulong prestigeEmpire = 0;
                            await ctx.RespondAsync($"Your prestige badges give you a gain of: {prestigeEmpire}.");

                        }
                        else
                        {
                            ulong pTotalB = Convert.ToUInt64(Math.Truncate(prestigeTotal));
                            ulong prestigeEmpire = pTotalB * ((((vLevel - 1) * (vLevel + 2)) / 10) + 10);
                            await ctx.RespondAsync($"Your prestige badges give you a gain of: {prestigeEmpire}.");
                        }
                        break;
                    }
                case 3:
                    {
                        double prestigeTotal = .33 * prBadges;
                        if (prestigeTotal < .99)
                        {
                            ulong prestigeEmpire = 0;
                            await ctx.RespondAsync($"Your prestige badges give you a gain of: {prestigeEmpire}.");
                        }
                        else
                        {
                            ulong pTotalB = Convert.ToUInt64(Math.Truncate(prestigeTotal));
                            ulong prestigeEmpire = pTotalB * ((((vLevel - 1) * (vLevel + 2)) / 10) + 10);
                            await ctx.RespondAsync($"Your prestige badges give you a gain of: {prestigeEmpire}.");
                        }
                        break;
                    }
                case 4:
                    {
                        double prestigeTotal = .25 * prBadges;
                        if (prestigeTotal < 1)
                        {
                            ulong prestigeEmpire = 0;
                            await ctx.RespondAsync($"Your prestige badges give you a gain of: {prestigeEmpire}.");
                        }
                        else
                        {
                            ulong pTotalB = Convert.ToUInt64(Math.Truncate(prestigeTotal));
                            ulong prestigeEmpire = pTotalB * ((((vLevel - 1) * (vLevel + 2)) / 10) + 10);
                            await ctx.RespondAsync($"Your prestige badges give you a gain of: {prestigeEmpire}.");
                        }
                        break;
                    }
                case 5:
                    {
                        double prestigeTotal = .20 * prBadges;
                        if (prestigeTotal < 1)
                        {
                            ulong prestigeEmpire = 0;
                            await ctx.RespondAsync($"Your prestige badges give you a gain of: {prestigeEmpire}.");
                        }
                        else
                        {
                            ulong pTotalB = Convert.ToUInt64(Math.Truncate(prestigeTotal));
                            ulong prestigeEmpire = pTotalB * ((((vLevel - 1) * (vLevel + 2)) / 10) + 10);
                            await ctx.RespondAsync($"Your prestige badges give you a gain of: {prestigeEmpire}.");
                        }
                        break;
                    }
                case 6:
                    {
                        double prestigeTotal = .17 * prBadges;
                        if (prestigeTotal < 1)
                        {
                            ulong prestigeEmpire = 0;
                            await ctx.RespondAsync($"Your prestige badges give you a gain of: {prestigeEmpire}.");
                        }
                        else
                        {
                            ulong pTotalB = Convert.ToUInt64(Math.Truncate(prestigeTotal));
                            ulong prestigeEmpire = pTotalB * ((((vLevel - 1) * (vLevel + 2)) / 10) + 10);
                            await ctx.RespondAsync($"Your prestige badges give you a gain of: {prestigeEmpire}.");
                        }
                        break;
                    }
                default:
                    {
                        await ctx.RespondAsync("Must enter a star rating");
                        break;
                    }
            }
        }
        [Command("totalgain")]
        [Description("This tallies up all the gain from books and badges.")]
        public async Task totalGain(CommandContext ctx, [Description("Your total book xp gain.")] ulong books, [Description("Your total military badge gain.")] ulong military,
            [Description("Your total research badge gain")] ulong research, [Description("Your total political badge gain.")] ulong political,
            [Description("Your total prestige gain.")] ulong prestige)
        {
            ulong empirePower = books + military + research + political + prestige;
            var embed = new DiscordEmbedBuilder
            {
                Description = $"Your total gain is {empirePower}",
                Author = new DiscordEmbedBuilder.EmbedAuthor
                {
                    Name = ctx.Message.Author is DiscordMember m ? m.Username : ctx.Message.Author.Username,
                    IconUrl = ctx.Message.Author.AvatarUrl
                }
            };
            await ctx.RespondAsync(embed: embed);
        }
        [Command("grantrole"), Description("Give user role indicated."), RequirePermissions(DSharpPlus.Permissions.ManageRoles)]
        public async Task GiveRole(CommandContext ctx, [Description("the user you want to change the role of.")] DiscordMember member,
                [Description("role your wanting to change them to")]DiscordRole discordRole)
        {
            try
            {

                var roleGiven = discordRole.Name;
                var verifyRole = discordRole.Id;
                var roleCheck = member.Guild.GetRole(verifyRole).ToString();
                string[] membersInfo = roleCheck.Split(" ");
                bool results = false; 
                for (int i = 0; i < membersInfo.Length; i++)
                {
                    if (membersInfo[i] == roleGiven)
                    {
                        results = true;
                    }
                    else
                    {
                        await member.GrantRoleAsync(discordRole);
                    }
                }
                
            }
            catch (Exception)
            {
                var emoji = DiscordEmoji.FromName(ctx.Client, ":-1:");
                await ctx.RespondAsync(emoji);
            }
        }
        [Command("removerole"), Description("Remove user role indicated."), RequirePermissions(DSharpPlus.Permissions.ManageRoles)]
        public async Task RemoveRole(CommandContext ctx, [Description("the user you want to change the role of.")] DiscordMember member,
                [Description("role your wanting to remove")]DiscordRole discordRole)
        {
            try
            {
                var roleGiven = discordRole.Name;
                var verifyRole = discordRole.Id;
                var roleCheck = member.Guild.GetRole(verifyRole).ToString();
                string[] membersInfo = roleCheck.Split(" ");
                for (int i = 0; i < membersInfo.Length; i++)
                {
                    if (membersInfo[i] == roleGiven)
                    {
                        await member.RevokeRoleAsync(discordRole);
                        await ctx.RespondAsync($"The user {member} has lost {discordRole}!");
                    }
                    else
                    {
                        await ctx.RespondAsync("User does not contain that role!");
                    }
                }
            }
            catch (Exception)
            {
                var emoji = DiscordEmoji.FromName(ctx.Client, ":-1:");
                await ctx.RespondAsync(emoji);
            }
        }
        [Command("nick"), Description("Give nickname to user"), RequirePermissions(DSharpPlus.Permissions.ManageNicknames)]
        public async Task Nick(CommandContext ctx, [Description("the user your changing the nickname of")] DiscordMember member,
                [RemainingText, Description("name your wanting to place")]string nickName)
        {
            await member.ModifyAsync(nickName, reason: $"Changed by {ctx.User.Username}({ ctx.User.Id})");
        }
        [Command("getroleid"), Description("Gets role ID"), RequireUserPermissions(DSharpPlus.Permissions.ManageRoles)]
        public async Task getRoleID(CommandContext ctx, [Description("Gets role ID")]ulong role)
        {
            var roles = ctx.Member.Guild.GetRole(role);
            await ctx.RespondAsync(roles.ToString());

        }
        [Command("addsuggestion"),Description("Adds to the correct channel.")]
        public async Task addSuggestion(CommandContext ctx, [RemainingText][Description("The user's suggestion")]string suggestion)
        {
           
                var embed = new DiscordEmbedBuilder
                {
                    Description = $"{suggestion}",
                    Color = ctx.Member.Color,
                    Author = new DiscordEmbedBuilder.EmbedAuthor
                    {
                        Name = ctx.Message.Author is DiscordMember m ? m.Username : ctx.Message.Author.Username,
                        IconUrl = ctx.Message.Author.AvatarUrl
                    }

                };
                await ctx.RespondAsync(embed: embed);
            
        }
        [Command("tutorandheir"),Description("Displays information on tutor and heir help")]
        public async Task tutorandheir(CommandContext ctx)
        { 
            await ctx.RespondAsync("https://gossultan.wordpress.com/2019/07/06/heir-dispatch-and-tutoring/");
        }
        [Command("nextrush")]
        public async Task nextRush(CommandContext ctx, [Description("Displays rush schedule from now")]string rush)
        {
            string[] rushSchedule = new string[4] { "power", "arena", "intimacy", "union" };
            int count = 0;
                for (int i = 0; i < rushSchedule.Length; i++)
                {
                    if (rushSchedule[i] == rush)
                    {
                        count = i;
                        
                    if (i > 3)
                    {
                        count = 0;
                        i = 0;
                    }
                    break;
                }
                    
                }
                await ctx.RespondAsync($"The current rush is {rush}.");
            if (count >= 3)
            {
                count = 0;
                await ctx.RespondAsync($"The next rush is {rushSchedule[count]}");

            }
        }
    }
}
