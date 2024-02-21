using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panpan_Bullying_Simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                                                                                        ");
            Console.WriteLine("                    Hello there! Welcome to panpan bullying simulator.");
            Console.WriteLine("                                                                                        ");
            Console.WriteLine("   Type 1 to start!  ");
            Console.WriteLine("                                                                                        ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("                                                                                        ");
            Console.WriteLine("                                                                                        ");
            Console.WriteLine("     The round begins and you (Breach), is defending A site with panpan (Skye).");
            Console.WriteLine("                                                                                        ");
            Console.WriteLine("     You currently have the skills; Aftershock (C), Flashpoint (Q), and Fault Line (E).");
            Console.WriteLine("                                                                                        ");
            Console.WriteLine("     This is your first chance to bully panpan, what skill will you use first?");
            Console.WriteLine("                                                                                        ");



            char skill = Convert.ToChar(Console.ReadLine());
            char AfterShock = 'c';
            char FlashPoint = 'q';
            char FaultLine = 'e';

            if (skill == AfterShock)
            {
                Console.WriteLine("                                                                                        ");
                Console.WriteLine("     You pressed C, you aim the Aftershock at an unsuspecting panpan holding sewers.");
                Console.WriteLine("     You launch the aftershock at panpan, she takes damage and runs away.");
                Console.WriteLine("     She then stares at you for a while, silently judging your decision");
                Console.WriteLine("                                                                                        ");
                Console.WriteLine("    Great Job! But you're still not done until she dies.");
                Console.WriteLine("                                                                                        ");
                Console.WriteLine("     You still have; Flashpoint (Q), and Fault Line (E)");
                Console.WriteLine("                                                                                        ");
                Console.WriteLine("     What skill will you use next?");
                Console.WriteLine("                                                                                        ");

                char skill2 = Convert.ToChar(Console.ReadLine());

                if (skill2 == FlashPoint)
                {
                    Console.WriteLine("                                                                                        ");
                    Console.WriteLine("     Enemies are pushing through long, panpan repositions herself behind the radianite boxes.");
                    Console.WriteLine("     You pressed Q, and aim the flash towards long, panpan peeks and you execute your flash.");
                    Console.WriteLine("     The enemies dodge the flash, but panpan does not. She gets one tapped by the enemy Cypher.");
                    Console.WriteLine("                                                                                        ");
                    Console.WriteLine("                                                                                        ");
                    Console.BackgroundColor = ConsoleColor.DarkCyan; Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("CONGRATS, YOU'VE SUCCESFULLY BULLIED (KILLED) PANPAN!!!!!");
                    Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
                }

                if (skill2 == FaultLine)
                {
                    Console.WriteLine("                                                                                        ");
                    Console.WriteLine("     The enemies start their push towards A site. 2 players sewers, 2  players through long, and 1 lurking through mid.");
                    Console.WriteLine("     Our sage quickly rotates, and heals panpan. Panpan returns to hold sewers.");
                    Console.WriteLine("     Panpan and the enemies cross paths and they begin to shoot at each other. Panpan gets the enemy Jett.");
                    Console.WriteLine("     You quickly use your E to 'assist' panpan. She gets stunned as well as the enemy Omen.");
                    Console.WriteLine("     She takes heavy damage and is about to get traded, but Sage comes and assist her, killing the Omen.");
                    Console.WriteLine("                                                                                        ");
                    Console.WriteLine("    Oooh, that was close! Don't worry you still have your Flashpoint (Q)!");
                    Console.WriteLine("                                                                                        ");

                    char skill3 = Convert.ToChar(Console.ReadLine());

                    if (skill3 == FlashPoint)
                    {
                        Console.WriteLine("     The enemies call to rotate. The lurking Cypher has fully secured B site, giving the enemies full B control.");
                        Console.WriteLine("     You, panpan and Sage rotate to B. Panpan uses Skye's Trailblazer to get intel. ");
                        Console.WriteLine("     Site is clear, panpan and sage slowly push. Panpan gets caught in a Cypher Trip.");
                        Console.WriteLine("     She gets killed by the Cypher.");
                        Console.WriteLine("                                                                                        ");
                        Console.WriteLine("                                                                                        ");
                        Console.BackgroundColor = ConsoleColor.Red; Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("YOU FAILED");
                        Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
            if (skill == FaultLine)
            {
                Console.WriteLine("                                                                                        ");
                Console.WriteLine("     Panpan peeks sewers, there are no enemies. You quickly use your E. Stunning panpan.");
                Console.WriteLine("     Enemies push sewers, avoiding the stun");
                Console.WriteLine("     Panpan gets picked by the enemy Omen.");
                Console.WriteLine("                                                                                        ");
                Console.WriteLine("                                                                                        ");
                Console.BackgroundColor = ConsoleColor.DarkCyan; Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("CONGRATS, YOU'VE SUCCESFULLY BULLIED (KILLED) PANPAN!!!!!");
                Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
            }
            if (skill == FlashPoint)
            {
                Console.WriteLine("                                                                                        ");
                Console.WriteLine("     Panpan hears an enemy in sewers. She peeks and you immediately use your Flashpoint to blind her.");
                Console.WriteLine("     It blinds the lurking Cypher instead of panpan, and panpan kills the enemy Cypher.");
                Console.WriteLine("     Meanwhile on C site two of your teammates had died and the enemy has taken control of site.");
                Console.WriteLine("                                                                                        ");
                Console.WriteLine("    Nice Try, you still have one Flashpoint (Q), Aftershock (C), and Fault Line (E).");
                Console.WriteLine("                                                                                        ");
                Console.WriteLine("    What skill will you use next?");
                Console.WriteLine("                                                                                        ");

                char skill2 = Convert.ToChar(Console.ReadLine());

                if (skill2 == FlashPoint)
                {
                    Console.WriteLine("     You and panpan rush through Defender Spawn to retake C site.");
                    Console.WriteLine("     You press Q and use Flash Point. It blinds panpan.");
                    Console.WriteLine("                                                                                        ");
                    Console.WriteLine("    Great Job! But you're still not done until she dies.");
                    Console.WriteLine("                                                                                        ");
                    Console.WriteLine("     You still have; After Shock (C), and Fault Line (E)");
                    Console.WriteLine("                                                                                        ");
                    Console.WriteLine("     What skill will you use next?");
                    Console.WriteLine("                                                                                        ");

                    char skill3 = Convert.ToChar(Console.ReadLine());

                    if (skill3 == AfterShock)
                    {
                        Console.WriteLine("     You and panpan hold C link, she uses Skye's Trailblazer to get intel.");
                        Console.WriteLine("     You immediately use your Aftershock on her, dealing damage and cancelling her skill.");
                        Console.WriteLine("     The enemy Jett in Garage Window hears the both of you and peeks.");
                        Console.WriteLine("     You both get killed by Jett, leaving the teammate Astra in a 1v4 situation.");
                        Console.WriteLine("     She immediately gets killed by the Jett.");
                        Console.WriteLine("     You get flamed in Team Chat by the rest of your teammates");
                        Console.WriteLine("                                                                                        ");
                        Console.WriteLine("                                                                                        ");
                        Console.BackgroundColor = ConsoleColor.DarkCyan; Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("CONGRATS, YOU'VE SUCCESFULLY BULLIED (KILLED) PANPAN!!!!!");
                        Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (skill3 == FaultLine)
                    {
                        Console.WriteLine("     Spike gets planted.");
                        Console.WriteLine("     As you and panpan arrive at C Link. You immediately use your E. It misses panpan and stuns the Jett at Garage Windows.");
                        Console.WriteLine("     Panpan kills Jett, and you two push through Garage. You kill the enemy Omen.");
                        Console.WriteLine("     Your teammate, Astra flanks through C Lobby, getting a kill on the enemy Sova in position for a lineup.");
                        Console.WriteLine("     Panpan low on health rushes to defuse the spike.");
                        Console.WriteLine("                                                                                        ");
                        Console.WriteLine("    Great Job! But she's still not dead.");
                        Console.WriteLine("                                                                                        ");
                        Console.WriteLine("     You still have your Aftershock (C).");
                        Console.WriteLine("                                                                                        ");
                        Console.WriteLine("     Press C.");
                        Console.WriteLine("                                                                                        ");

                        char skill4 = Convert.ToChar(Console.ReadLine());

                        if (skill4 == AfterShock)
                        {
                            Console.WriteLine("     As panpan defuses the spike, you press C and use your Aftershock.");
                            Console.WriteLine("     She dies, your teammates shout at you through voice chat.");
                            Console.WriteLine("                                                                                        ");
                            Console.WriteLine("                                                                                        ");
                            Console.BackgroundColor = ConsoleColor.DarkCyan; Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("CONGRATS, YOU'VE SUCCESFULLY BULLIED (KILLED) PANPAN!!!!!");
                            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;

                            char afterstory = Convert.ToChar(Console.ReadLine());
                            char clutch = 'f';

                            if (afterstory == clutch)
                            {
                                Console.WriteLine("     You rush to defuse the spike while Astra defends you.");
                                Console.WriteLine("     The enemy Skye arrives and kills Astra. Your E has recharged.");
                                Console.WriteLine("                                                                                        ");
                                Console.WriteLine("    Use your E?");

                                string skill5 = Convert.ToString(Console.ReadLine());
                                string Use = "yes";
                                string Dont = "no";
                                if (skill5 == Use)
                                {
                                    Console.WriteLine("     You use your E, stunning the Skye allowing you to kill her.");
                                    Console.WriteLine("     You then return to defuse the spike on top of panpan's dead body.");
                                    Console.WriteLine("     The spike is defused, and you see panpan's dead body.");
                                    Console.WriteLine("                                                                                        ");
                                    Console.WriteLine("    Would you like to teabag panpan?");

                                    string skill6 = Convert.ToString(Console.ReadLine());

                                    if (skill6 == Use)
                                    {
                                        Console.WriteLine("     You teabbagged panpan, she curses at you in party chat.");
                                        Console.WriteLine("                                                                                        ");
                                        Console.BackgroundColor = ConsoleColor.DarkCyan; Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("CONGRATS YOU'VE FINISHED THE SECRET ENDING AND FULLY BULLIED PANPAN!!");
                                        Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;

                                        string Do = "spray";
                                        string gun = "gun";
                                        string ez = "ez";
                                        string spray = Convert.ToString(Console.ReadLine());

                                        if (spray == Do)
                                        {
                                            Console.WriteLine("                                                                                        ");
                                            Console.WriteLine("    You decide to use a spray on panpan's dead body.");
                                            Console.WriteLine("                                                                                        ");
                                            Console.WriteLine("    What spray would you like to use?.");
                                            Console.WriteLine("                                                                                        ");
                                            Console.WriteLine("    You currently have the sprays; Mic Drop (1), Huh? (2), Salt Shaker (3) and Dap Team (4).");

                                            int Spray = Convert.ToInt16(Console.ReadLine());
                                            int MicDrop = 1;
                                            int Huh = 2;
                                            int SaltShaker = 3;
                                            int DapTeam = 4;

                                            if (Spray == MicDrop)
                                            {
                                                Console.WriteLine("     You used the spray Mic Drop, your teammates and panpan sigh.");

                                                string Gun = Convert.ToString(Console.ReadLine());

                                                if (Gun == gun)
                                                {
                                                    Console.WriteLine("     You pulled on your gun, and spray the leftover bullets on panpan's dead body.");

                                                    string toxic = Convert.ToString(Console.ReadLine());

                                                    if (toxic == ez)
                                                    {

                                                        Console.WriteLine("     You typed in all chat ez as the round ends.");
                                                        Console.WriteLine("                                                                                        ");
                                                        Console.WriteLine("WOAH THERE BUDDY! YOU'VE BECOME WAY TOO TOXIC! ALRIGHT LET ME SHUT THE SIMULATOR DOWN BEFORE YOU GET WORSE!");
                                                    }
                                                }
                                            }
                                            if (Spray == Huh)
                                            {
                                                Console.WriteLine("     You used the spray Huh?, panpan gets mad at team chat. Your teammates tell you that you're toxic.");

                                                string Gun = Convert.ToString(Console.ReadLine());

                                                if (Gun == gun)
                                                {
                                                    Console.WriteLine("     You pulled on your gun, and spray the leftover bullets on panpan's dead body.");

                                                    string toxic = Convert.ToString(Console.ReadLine());

                                                    if (toxic == ez)
                                                    {

                                                        Console.WriteLine("     You typed in all chat ez as the round ends.");
                                                        Console.WriteLine("                                                                                        ");
                                                        Console.WriteLine("WOAH THERE BUDDY! YOU'VE BECOME WAY TOO TOXIC! ALRIGHT LET ME SHUT THE SIMULATOR DOWN BEFORE YOU GET WORSE!");
                                                    }
                                                }
                                            }
                                            if (Spray == SaltShaker)
                                            {
                                                Console.WriteLine("     You use the spray Salt Shaker, panpan get angrier and curses at you more. ");

                                                string Gun = Convert.ToString(Console.ReadLine());

                                                if (Gun == gun)
                                                {
                                                    Console.WriteLine("     You pulled on your gun, and spray the leftover bullets on panpan's dead body.");

                                                    string toxic = Convert.ToString(Console.ReadLine());

                                                    if (toxic == ez)
                                                    {

                                                        Console.WriteLine("     You typed in all chat ez as the round ends.");
                                                        Console.WriteLine("                                                                                        ");
                                                        Console.WriteLine("WOAH THERE BUDDY! YOU'VE BECOME WAY TOO TOXIC! ALRIGHT LET ME SHUT THE SIMULATOR DOWN BEFORE YOU GET WORSE!");
                                                    }
                                                }
                                            }
                                            if (Spray == DapTeam)
                                            {
                                                Console.WriteLine("     You used the spray Dap Team, your teammates disagree with you in team chat.");

                                                string Gun = Convert.ToString(Console.ReadLine());

                                                if (Gun == gun)
                                                {
                                                    Console.WriteLine("     You pulled on your gun, and spray the leftover bullets on panpan's dead body.");

                                                    string toxic = Convert.ToString(Console.ReadLine());

                                                    if (toxic == ez)
                                                    {

                                                        Console.WriteLine("     You typed in all chat ez as the round ends.");
                                                        Console.WriteLine("                                                                                        ");
                                                        Console.WriteLine("WOAH THERE BUDDY! YOU'VE BECOME WAY TOO TOXIC! ALRIGHT LET ME SHUT THE SIMULATOR DOWN BEFORE YOU GET WORSE!");
                                                    }
                                                }
                                            }
                                        }
                                    }

                                    if (skill6 == Dont)
                                    {
                                        Console.WriteLine("     You decide to not teabag panpan. The round ends in your team's victory.");
                                        Console.WriteLine("                                                                                        ");
                                        Console.BackgroundColor = ConsoleColor.DarkCyan; Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Round Win");
                                        Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
                                    }
                                }
                                if (skill5 == Dont)
                                {
                                    Console.WriteLine("     You decide not to use your E. The enemy Skye flashes you, and kills you. Losing you and your team's round.");
                                    Console.WriteLine("     Your team flames you in chat.");
                                    Console.WriteLine("                                                                                        ");
                                    Console.BackgroundColor = ConsoleColor.Red; Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine("ROUND LOST");
                                    Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
                                }
                            }
                        }
                    }
                }
                if (skill2 == FaultLine)
                {
                    Console.WriteLine("     As you and panpan rush through Defender Spawn, you use your E. Missing panpan.");
                    Console.WriteLine("     The enemy Jett at C link sees the Fault Line, and rushes you both. She one taps panpan. You kill Jett getting a trade.");
                    Console.WriteLine("                                                                                        ");
                    Console.WriteLine("                                                                                        ");
                    Console.BackgroundColor = ConsoleColor.DarkCyan; Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("CONGRATS, YOU'VE SUCCESFULLY BULLIED (KILLED) PANPAN!!!!!");
                    Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;

                }
                if (skill2 == AfterShock)
                {
                    Console.WriteLine("     You and panpan rush through B site, you use your Aftershock. It misses panpan.");
                    Console.WriteLine("                                                                                        ");
                    Console.WriteLine("    Nice Try, you still have one Flashpoint (Q), and Fault Line (E).");
                    Console.WriteLine("                                                                                        ");
                    Console.WriteLine("    What skill will you use next?");
                    Console.WriteLine("                                                                                        ");

                    char skill3 = Convert.ToChar(Console.ReadLine());

                    if (skill3 == FlashPoint)
                    {
                        Console.WriteLine("     You and panpan arrive at C link, you use your Flashpoint. Blinding the enemy Jett instead.");
                        Console.WriteLine("     Panpan kills the enemy Jett, and starts to use Skye's Trailblaze to gather intel.");
                        Console.WriteLine("     You get knifed at the back by a lurking enemy Skye. She also kills panpan who is still using Trailblaze.");
                        Console.WriteLine("                                                                                        ");
                        Console.WriteLine("                                                                                        ");
                        Console.BackgroundColor = ConsoleColor.Red; Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("YOU FAILED");
                        Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (skill3 == FaultLine)
                    {
                        Console.WriteLine("     You and panpan arrive at C link, you charge your Faultline to sabotage panpan.");
                        Console.WriteLine("     The enemy Jett peeks through Garage Window and one taps the both of you.");
                        Console.WriteLine("                                                                                        ");
                        Console.WriteLine("                                                                                        ");
                        Console.BackgroundColor = ConsoleColor.Red; Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("YOU FAILED");
                        Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
        }
    }
}
