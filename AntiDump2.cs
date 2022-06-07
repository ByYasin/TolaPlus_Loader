using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Timers;
using System.Net.Http;
using System.IO;

namespace KeyAuth
{
    class anticrack
    {
        private static string PR;

        public static void Start()
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1500;
            timer.Elapsed += Call;
            timer.Start();
        }

        static void Call(object sender, ElapsedEventArgs e)
        {
            KeyAuth.anticrack.Shock();
        }

        public static void restart()
        {
            //System.Diagnostics.Process.Start("shutdown.exe", "-r -t 0");
        }
        public static void Shock()
        {
            try
            {
                foreach (Process processt in Process.GetProcessesByName("Process Monitor"))
                {
                    processt.Kill();
                    PR = processt.ProcessName;

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process processtt in Process.GetProcessesByName("Procmon64"))
                {
                    processtt.Kill();
                    PR = processtt.ProcessName;

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }

                foreach (Process process57 in Process.GetProcessesByName("ProcessHacker"))
                {
                    process57.Kill();
                    PR = process57.ProcessName;

                    Application.Exit();
                    Environment.Exit(0);

                }
                foreach (Process process58 in Process.GetProcessesByName("Procmon"))
                {
                    process58.Kill();
                    PR = process58.ProcessName;
                    //API.log(Auth.appName, process58.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process59 in Process.GetProcessesByName("Procmon32"))
                {
                    process59.Kill();
                    PR = process59.ProcessName;
                    //API.log(Auth.appName, process59.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process processk in Process.GetProcessesByName("ProcMonX"))
                {
                    processk.Kill();
                    PR = processk.ProcessName;
                    //API.log(Auth.appName, processk.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process processkk in Process.GetProcessesByName("apimonitor-x86"))
                {
                    processkk.Kill();
                    PR = processkk.ProcessName;
                    //API.log(Auth.appName, processkk.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process processll in Process.GetProcessesByName("apimonitor-x64"))
                {
                    processll.Kill();
                    PR = processll.ProcessName;
                    //API.log(Auth.appName, processll.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process processmm in Process.GetProcessesByName("SpyStudio"))
                {
                    processmm.Kill();
                    PR = processmm.ProcessName;
                    //API.log(Auth.appName, processmm.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process processnn in Process.GetProcessesByName("x32dbg"))
                {
                    processnn.Kill();
                    PR = processnn.ProcessName;
                    //API.log(Auth.appName, processnn.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process processoo in Process.GetProcessesByName("x64dbg"))
                {
                    processoo.Kill();
                    PR = processoo.ProcessName;
                    //API.log(Auth.appName, processoo.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process processpp in Process.GetProcessesByName("dnSpy-x86"))
                {
                    processpp.Kill();
                    PR = processpp.ProcessName;
                    //API.log(Auth.appName, processpp.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process processqq in Process.GetProcessesByName("dnSpy-x64"))
                {
                    processqq.Kill();
                    PR = processqq.ProcessName;
                    //API.log(Auth.appName, processqq.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process processgg in Process.GetProcessesByName("ollydbg"))
                {
                    processgg.Kill();
                    PR = processgg.ProcessName;
                    //API.log(Auth.appName, processgg.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process2 in Process.GetProcessesByName("ida"))
                {
                    process2.Kill();
                    PR = process2.ProcessName;
                    //API.log(Auth.appName, process2.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process3 in Process.GetProcessesByName("ida64"))
                {
                    process3.Kill();
                    PR = process3.ProcessName;
                    //API.log(Auth.appName, process3.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process4 in Process.GetProcessesByName("idag"))
                {
                    process4.Kill();
                    PR = process4.ProcessName;
                    //API.log(Auth.appName, process4.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process5 in Process.GetProcessesByName("idag64"))
                {
                    process5.Kill();
                    PR = process5.ProcessName;
                    //API.log(Auth.appName, process5.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process6 in Process.GetProcessesByName("idaw"))
                {
                    process6.Kill();
                    PR = process6.ProcessName;
                    //API.log(Auth.appName, process6.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process7 in Process.GetProcessesByName("idaw64"))
                {
                    process7.Kill();
                    PR = process7.ProcessName;
                    //API.log(Auth.appName, process7.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process8 in Process.GetProcessesByName("idaq"))
                {
                    process8.Kill();
                    PR = process8.ProcessName;
                    //API.log(Auth.appName, process8.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process9 in Process.GetProcessesByName("idaq64"))
                {
                    process9.Kill();
                    PR = process9.ProcessName;
                    //API.log(Auth.appName, process9.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process10 in Process.GetProcessesByName("idau"))
                {
                    process10.Kill();
                    PR = process10.ProcessName;
                    //API.log(Auth.appName, process10.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process11 in Process.GetProcessesByName("idau64"))
                {
                    process11.Kill();
                    PR = process11.ProcessName;
                    //API.log(Auth.appName, process11.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process12 in Process.GetProcessesByName("scylla"))
                {
                    process12.Kill();
                    PR = process12.ProcessName;
                    //API.log(Auth.appName, process12.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process13 in Process.GetProcessesByName("scylla_x64"))
                {
                    process13.Kill();
                    PR = process13.ProcessName;
                    //API.log(Auth.appName, process13.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process14 in Process.GetProcessesByName("scylla_x86"))
                {
                    process14.Kill();
                    PR = process14.ProcessName;
                    //API.log(Auth.appName, process14.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process15 in Process.GetProcessesByName("protection_id"))
                {
                    process15.Kill();
                    PR = process15.ProcessName;
                    //API.log(Auth.appName, process15.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process16 in Process.GetProcessesByName("x64dbg"))
                {
                    process16.Kill();
                    PR = process16.ProcessName;
                    //API.log(Auth.appName, process16.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process17 in Process.GetProcessesByName("x32dbg"))
                {
                    process17.Kill();
                    PR = process17.ProcessName;
                    //API.log(Auth.appName, process17.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process18 in Process.GetProcessesByName("windbg"))
                {
                    process18.Kill();
                    PR = process18.ProcessName;
                    //API.log(Auth.appName, process18.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process19 in Process.GetProcessesByName("reshacker"))
                {
                    process19.Kill();
                    PR = process19.ProcessName;
                    //API.log(Auth.appName, process19.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process20 in Process.GetProcessesByName("ImportREC"))
                {
                    process20.Kill();
                    PR = process20.ProcessName;
                    //API.log(Auth.appName, process20.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process21 in Process.GetProcessesByName("IMMUNITYDEBUGGER"))
                {
                    process21.Kill();
                    PR = process21.ProcessName;
                    //API.log(Auth.appName, process21.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process22 in Process.GetProcessesByName("MegaDumper"))
                {
                    process22.Kill();
                    PR = process22.ProcessName;
                    //API.log(Auth.appName, process22.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process23 in Process.GetProcessesByName("OLLYDBG"))
                {
                    process23.Kill();
                    PR = process23.ProcessName;
                    //API.log(Auth.appName, process23.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process24 in Process.GetProcessesByName("ida"))
                {
                    process24.Kill();
                    PR = process24.ProcessName;
                    //API.log(Auth.appName, process24.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process25 in Process.GetProcessesByName("disassembly"))
                {
                    process25.Kill();
                    PR = process25.ProcessName;
                    //API.log(Auth.appName, process25.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process26 in Process.GetProcessesByName("scylla"))
                {
                    process26.Kill();
                    PR = process26.ProcessName;
                    //API.log(Auth.appName, process26.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process27 in Process.GetProcessesByName("Debug"))
                {
                    process27.Kill();
                    PR = process27.ProcessName;
                    //API.log(Auth.appName, process27.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process28 in Process.GetProcessesByName("[CPU"))
                {
                    process28.Kill();
                    PR = process28.ProcessName;
                    //API.log(Auth.appName, process28.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process29 in Process.GetProcessesByName("Immunity"))
                {
                    process29.Kill();
                    PR = process29.ProcessName;
                    //API.log(Auth.appName, process29.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process30 in Process.GetProcessesByName("WinDbg"))
                {
                    process30.Kill();
                    PR = process30.ProcessName;
                    //API.log(Auth.appName, process30.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process31 in Process.GetProcessesByName("x32dbg"))
                {
                    process31.Kill();
                    PR = process31.ProcessName;
                    //API.log(Auth.appName, process31.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process32 in Process.GetProcessesByName("x64dbg"))
                {
                    process32.Kill();
                    PR = process32.ProcessName;
                    //API.log(Auth.appName, process32.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process33 in Process.GetProcessesByName("Import reconstructor"))
                {
                    process33.Kill();
                    PR = process33.ProcessName;
                    //API.log(Auth.appName, process33.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process34 in Process.GetProcessesByName("MegaDumper"))
                {
                    process34.Kill();
                    PR = process34.ProcessName;
                    //API.log(Auth.appName, process34.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process35 in Process.GetProcessesByName("MegaDumper 1. by CodeCracker / SnD"))
                {
                    process35.Kill();
                    PR = process35.ProcessName;
                    //API.log(Auth.appName, process35.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process36 in Process.GetProcessesByName("codecracker"))
                {
                    process36.Kill();
                    PR = process36.ProcessName;
                    //API.log(Auth.appName, process36.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process37 in Process.GetProcessesByName("x32dbg"))
                {
                    process37.Kill();
                    PR = process37.ProcessName;
                    //API.log(Auth.appName, process37.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process38 in Process.GetProcessesByName("x64dbg"))
                {
                    process38.Kill();
                    PR = process38.ProcessName;
                    //API.log(Auth.appName, process38.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process39 in Process.GetProcessesByName("ollydbg"))
                {
                    process39.Kill();
                    PR = process39.ProcessName;
                    //API.log(Auth.appName, process39.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process40 in Process.GetProcessesByName("ida -"))
                {
                    process40.Kill();
                    PR = process40.ProcessName;
                    //API.log(Auth.appName, process40.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process41 in Process.GetProcessesByName("charles"))
                {
                    process41.Kill();
                    PR = process41.ProcessName;
                    //API.log(Auth.appName, process41.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process42 in Process.GetProcessesByName("dnspy"))
                {
                    process42.Kill();
                    PR = process42.ProcessName;
                    //API.log(Auth.appName, process42.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process43 in Process.GetProcessesByName("simpleassembly"))
                {
                    process43.Kill();
                    PR = process43.ProcessName;
                    //API.log(Auth.appName, process43.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process44 in Process.GetProcessesByName("peek"))
                {
                    process44.Kill();
                    PR = process44.ProcessName;
                    //API.log(Auth.appName, process44.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process45 in Process.GetProcessesByName("httpanalyzer"))
                {
                    process45.Kill();
                    PR = process45.ProcessName;
                    //API.log(Auth.appName, process45.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process46 in Process.GetProcessesByName("httpdebug"))
                {
                    process46.Kill();
                    PR = process46.ProcessName;
                    //API.log(Auth.appName, process46.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process47 in Process.GetProcessesByName("fiddler"))
                {
                    process47.Kill();
                    PR = process47.ProcessName;
                    //API.log(Auth.appName, process47.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process48 in Process.GetProcessesByName("wireshark"))
                {
                    process48.Kill();
                    PR = process48.ProcessName;
                    //API.log(Auth.appName, process48.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process49 in Process.GetProcessesByName("dbx"))
                {
                    process49.Kill();
                    PR = process49.ProcessName;
                    //API.log(Auth.appName, process49.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process50 in Process.GetProcessesByName("mdbg"))
                {
                    process50.Kill();
                    PR = process50.ProcessName;
                    //API.log(Auth.appName, process50.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process51 in Process.GetProcessesByName("gdb"))
                {
                    process51.Kill();
                    PR = process51.ProcessName;
                    //API.log(Auth.appName, process51.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process52 in Process.GetProcessesByName("windbg"))
                {
                    process52.Kill();
                    PR = process52.ProcessName;
                    //API.log(Auth.appName, process52.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process53 in Process.GetProcessesByName("dbgclr"))
                {
                    process53.Kill();
                    PR = process53.ProcessName;
                    //API.log(Auth.appName, process53.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process54 in Process.GetProcessesByName("kdb"))
                {
                    process54.Kill();
                    PR = process54.ProcessName;
                    //API.log(Auth.appName, process54.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process55 in Process.GetProcessesByName("kgdb"))
                {
                    process55.Kill();
                    PR = process55.ProcessName;
                    //API.log(Auth.appName, process55.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process56 in Process.GetProcessesByName("mdb"))
                {
                    process56.Kill();
                    PR = process56.ProcessName;
                    //API.log(Auth.appName, process56.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }

                foreach (Process process68 in Process.GetProcessesByName("Reflector"))
                {
                    process68.Kill();
                    PR = process68.ProcessName;
                    //API.log(Auth.appName, process68.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process69 in Process.GetProcessesByName("ida"))
                {
                    process69.Kill();
                    PR = process69.ProcessName;
                    //API.log(Auth.appName, process69.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process70 in Process.GetProcessesByName("Black_Olly"))
                {
                    process70.Kill();
                    PR = process70.ProcessName;
                    //API.log(Auth.appName, process70.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process71 in Process.GetProcessesByName("OLLYDBG"))
                {
                    process71.Kill();
                    PR = process71.ProcessName;
                    //API.log(Auth.appName, process71.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process72 in Process.GetProcessesByName("BladeAPIMonitor"))
                {
                    process72.Kill();
                    PR = process72.ProcessName;
                    //API.log(Auth.appName, process72.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process73 in Process.GetProcessesByName("ProcMonX"))
                {
                    process73.Kill();
                    PR = process73.ProcessName;
                    //API.log(Auth.appName, process73.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process74 in Process.GetProcessesByName("Wireshark"))
                {
                    process74.Kill();
                    PR = process74.ProcessName;
                    //API.log(Auth.appName, process74.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process75 in Process.GetProcessesByName("ProcessActivityView"))
                {
                    process75.Kill();
                    PR = process75.ProcessName;
                    //API.log(Auth.appName, process75.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process76 in Process.GetProcessesByName("ranko"))
                {
                    process76.Kill();
                    PR = process76.ProcessName;
                    //API.log(Auth.appName, process76.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process77 in Process.GetProcessesByName("x86dbg"))
                {
                    process77.Kill();
                    PR = process77.ProcessName;
                    //API.log(Auth.appName, process77.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process78 in Process.GetProcessesByName("pizza"))
                {
                    process78.Kill();
                    PR = process78.ProcessName;
                    //API.log(Auth.appName, process78.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process79 in Process.GetProcessesByName("pepper"))
                {
                    process79.Kill();
                    PR = process79.ProcessName;
                    //API.log(Auth.appName, process79.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process80 in Process.GetProcessesByName("reverse"))
                {
                    process80.Kill();
                    PR = process80.ProcessName;
                    //API.log(Auth.appName, process80.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process81 in Process.GetProcessesByName("reversal"))
                {
                    process81.Kill();
                    PR = process81.ProcessName;
                    //API.log(Auth.appName, process81.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process82 in Process.GetProcessesByName("ReverseSeal"))
                {
                    process82.Kill();
                    PR = process82.ProcessName;
                    //API.log(Auth.appName, process82.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process83 in Process.GetProcessesByName("de4dot"))
                {
                    process83.Kill();
                    PR = process83.ProcessName;
                    //API.log(Auth.appName, process83.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process84 in Process.GetProcessesByName("pc-ret"))
                {
                    process84.Kill();
                    PR = process84.ProcessName;
                    //API.log(Auth.appName, process84.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process85 in Process.GetProcessesByName("crack"))
                {
                    process85.Kill();
                    PR = process85.ProcessName;
                    //API.log(Auth.appName, process85.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process86 in Process.GetProcessesByName("ILSpy"))
                {
                    process86.Kill();
                    PR = process86.ProcessName;
                    //API.log(Auth.appName, process86.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process87 in Process.GetProcessesByName("sharpod"))
                {
                    process87.Kill();
                    PR = process87.ProcessName;
                    //API.log(Auth.appName, process87.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process88 in Process.GetProcessesByName("x32_dbg"))
                {
                    process88.Kill();
                    PR = process88.ProcessName;
                    //API.log(Auth.appName, process88.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process89 in Process.GetProcessesByName("x64_dbg"))
                {
                    process89.Kill();
                    PR = process89.ProcessName;
                    //API.log(Auth.appName, process89.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process90 in Process.GetProcessesByName("debug"))
                {
                    process90.Kill();
                    PR = process90.ProcessName;
                    //API.log(Auth.appName, process90.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process91 in Process.GetProcessesByName("dbg"))
                {
                    process91.Kill();
                    PR = process91.ProcessName;
                    //API.log(Auth.appName, process91.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process92 in Process.GetProcessesByName("strongod"))
                {
                    process92.Kill();
                    PR = process92.ProcessName;
                    //API.log(Auth.appName, process92.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process93 in Process.GetProcessesByName("PhantOm"))
                {
                    process93.Kill();
                    PR = process93.ProcessName;
                    //API.log(Auth.appName, process93.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process94 in Process.GetProcessesByName("titanHide"))
                {
                    process94.Kill();
                    PR = process94.ProcessName;
                    //API.log(Auth.appName, process94.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process95 in Process.GetProcessesByName("scyllaHide"))
                {
                    process95.Kill();
                    PR = process95.ProcessName;
                    //API.log(Auth.appName, process95.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process96 in Process.GetProcessesByName("ilspy"))
                {
                    process96.Kill();
                    PR = process96.ProcessName;
                    //API.log(Auth.appName, process96.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process97 in Process.GetProcessesByName("graywolf"))
                {
                    process97.Kill();
                    PR = process97.ProcessName;
                    //API.log(Auth.appName, process97.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process98 in Process.GetProcessesByName("simpleassemblyexplorer"))
                {
                    process98.Kill();
                    PR = process98.ProcessName;
                    //API.log(Auth.appName, process98.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process99 in Process.GetProcessesByName("MegaDumper"))
                {
                    process99.Kill();
                    PR = process99.ProcessName;
                    //API.log(Auth.appName, process99.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process100 in Process.GetProcessesByName("megadumper"))
                {
                    process100.Kill();
                    PR = process100.ProcessName;
                    //API.log(Auth.appName, process100.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process101 in Process.GetProcessesByName("X64NetDumper"))
                {
                    process101.Kill();
                    PR = process101.ProcessName;
                    //API.log(Auth.appName, process101.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process102 in Process.GetProcessesByName("x64netdumper"))
                {
                    process102.Kill();
                    PR = process102.ProcessName;
                    //API.log(Auth.appName, process102.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process103 in Process.GetProcessesByName("HxD"))
                {
                    process103.Kill();
                    PR = process103.ProcessName;
                    //API.log(Auth.appName, process103.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process104 in Process.GetProcessesByName("hxd"))
                {
                    process104.Kill();
                    PR = process104.ProcessName;
                    //API.log(Auth.appName, process104.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process105 in Process.GetProcessesByName("PETools"))
                {
                    process105.Kill();
                    PR = process105.ProcessName;
                    //API.log(Auth.appName, process105.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process106 in Process.GetProcessesByName("petools"))
                {
                    process106.Kill();
                    PR = process106.ProcessName;
                    //API.log(Auth.appName, process106.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process107 in Process.GetProcessesByName("Protection_ID"))
                {
                    process107.Kill();
                    PR = process107.ProcessName;
                    //API.log(Auth.appName, process107.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process108 in Process.GetProcessesByName("die"))
                {
                    process108.Kill();
                    PR = process108.ProcessName;
                    //API.log(Auth.appName, process108.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process109 in Process.GetProcessesByName("process hacker 2"))
                {
                    process109.Kill();
                    PR = process109.ProcessName;
                    //API.log(Auth.appName, process109.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process110 in Process.GetProcessesByName("process"))
                {
                    process110.Kill();
                    PR = process110.ProcessName;
                    //API.log(Auth.appName, process110.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process111 in Process.GetProcessesByName("hacker"))
                {
                    process111.Kill();
                    PR = process111.ProcessName;
                    //API.log(Auth.appName, process111.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process112 in Process.GetProcessesByName("ida -"))
                {
                    process112.Kill();
                    PR = process112.ProcessName;
                    //API.log(Auth.appName, process112.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process113 in Process.GetProcessesByName("Dnspy"))
                {
                    process113.Kill();
                    PR = process113.ProcessName;
                    //API.log(Auth.appName, process113.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process114 in Process.GetProcessesByName("dnSpy"))
                {
                    process114.Kill();
                    PR = process114.ProcessName;
                    //API.log(Auth.appName, process114.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process115 in Process.GetProcessesByName("fiddler"))
                {
                    process115.Kill();
                    PR = process115.ProcessName;
                    //API.log(Auth.appName, process115.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process116 in Process.GetProcessesByName("proxifier"))
                {
                    process116.Kill();
                    PR = process116.ProcessName;
                    //API.log(Auth.appName, process116.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process117 in Process.GetProcessesByName("mitmproxy"))
                {
                    process117.Kill();
                    PR = process117.ProcessName;
                    //API.log(Auth.appName, process117.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process118 in Process.GetProcessesByName("process hacker"))
                {
                    process118.Kill();
                    PR = process118.ProcessName;
                    //API.log(Auth.appName, process118.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process119 in Process.GetProcessesByName("process monitor"))
                {
                    process119.Kill();
                    PR = process119.ProcessName;
                    //API.log(Auth.appName, process119.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process120 in Process.GetProcessesByName("system explorer"))
                {
                    process120.Kill();
                    PR = process120.ProcessName;
                    //API.log(Auth.appName, process120.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process121 in Process.GetProcessesByName("systemexplorer"))
                {
                    process121.Kill();
                    PR = process121.ProcessName;
                    //API.log(Auth.appName, process121.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process122 in Process.GetProcessesByName("systemexplorerservice"))
                {
                    process122.Kill();
                    PR = process122.ProcessName;
                    //API.log(Auth.appName, process122.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process123 in Process.GetProcessesByName("WPE PRO"))
                {
                    process123.Kill();
                    PR = process123.ProcessName;
                    //API.log(Auth.appName, process123.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process124 in Process.GetProcessesByName("ghidra"))
                {
                    process124.Kill();
                    PR = process124.ProcessName;
                    //API.log(Auth.appName, process124.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process125 in Process.GetProcessesByName("folderchangesview"))
                {
                    process125.Kill();
                    PR = process125.ProcessName;
                    //API.log(Auth.appName, process125.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process126 in Process.GetProcessesByName("folder"))
                {
                    process126.Kill();
                    PR = process126.ProcessName;
                    //API.log(Auth.appName, process126.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process127 in Process.GetProcessesByName("dump"))
                {
                    process127.Kill();
                    PR = process127.ProcessName;
                    //API.log(Auth.appName, process127.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process128 in Process.GetProcessesByName("proxy"))
                {
                    process128.Kill();
                    PR = process128.ProcessName;
                    //API.log(Auth.appName, process128.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process129 in Process.GetProcessesByName("de4dotmodded"))
                {
                    process129.Kill();
                    PR = process129.ProcessName;
                    //API.log(Auth.appName, process129.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process130 in Process.GetProcessesByName("StringDecryptor"))
                {
                    process130.Kill();
                    PR = process130.ProcessName;
                    //API.log(Auth.appName, process130.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process131 in Process.GetProcessesByName("Centos"))
                {
                    process131.Kill();
                    PR = process131.ProcessName;
                    //API.log(Auth.appName, process131.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process132 in Process.GetProcessesByName("SAE"))
                {
                    process132.Kill();
                    PR = process132.ProcessName;
                    //API.log(Auth.appName, process132.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process133 in Process.GetProcessesByName("monitor"))
                {
                    process133.Kill();
                    PR = process133.ProcessName;
                    //API.log(Auth.appName, process133.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process134 in Process.GetProcessesByName("brute"))
                {
                    process134.Kill();
                    PR = process134.ProcessName;
                    //API.log(Auth.appName, process134.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process135 in Process.GetProcessesByName("checker"))
                {
                    process135.Kill();
                    PR = process135.ProcessName;
                    //API.log(Auth.appName, process135.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process136 in Process.GetProcessesByName("zed"))
                {
                    process136.Kill();
                    PR = process136.ProcessName;
                    //API.log(Auth.appName, process136.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process137 in Process.GetProcessesByName("sniffer"))
                {
                    process137.Kill();
                    PR = process137.ProcessName;
                    //API.log(Auth.appName, process137.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process138 in Process.GetProcessesByName("http"))
                {
                    process138.Kill();
                    PR = process138.ProcessName;
                    //API.log(Auth.appName, process138.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process139 in Process.GetProcessesByName("debugger"))
                {
                    process139.Kill();
                    PR = process139.ProcessName;
                    //API.log(Auth.appName, process139.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process140 in Process.GetProcessesByName("james"))
                {
                    process140.Kill();
                    PR = process140.ProcessName;
                    //API.log(Auth.appName, process140.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process141 in Process.GetProcessesByName("exeinfope"))
                {
                    process141.Kill();
                    PR = process141.ProcessName;
                    //API.log(Auth.appName, process141.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process142 in Process.GetProcessesByName("MethodFinder"))
                {
                    process142.Kill();
                    PR = process142.ProcessName;
                    //API.log(Auth.appName, process141.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process143 in Process.GetProcessesByName("procexp64"))
                {
                    process143.Kill();
                    PR = process143.ProcessName;
                    //API.log(Auth.appName, process141.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process144 in Process.GetProcessesByName("procexp"))
                {
                    process144.Kill();
                    PR = process144.ProcessName;
                    //API.log(Auth.appName, process141.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process145 in Process.GetProcessesByName("ProcessExplorer"))
                {
                    process145.Kill();
                    PR = process145.ProcessName;
                    //API.log(Auth.appName, process141.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process146 in Process.GetProcessesByName("tcplogview"))
                {
                    process146.Kill();
                    PR = process146.ProcessName;
                    //API.log(Auth.appName, process141.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process147 in Process.GetProcessesByName("WinPrefetchView"))
                {
                    process147.Kill();
                    PR = process147.ProcessName;
                    //API.log(Auth.appName, process147.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process148 in Process.GetProcessesByName("ollydbgida"))
                {
                    process148.Kill();
                    PR = process148.ProcessName;
                    //API.log(Auth.appName, process148.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process149 in Process.GetProcessesByName("x32dbg,windbg"))
                {
                    process149.Kill();
                    PR = process149.ProcessName;
                    //API.log(Auth.appName, process149.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process150 in Process.GetProcessesByName("x64dbg,windbg"))
                {
                    process150.Kill();
                    PR = process150.ProcessName;
                    //API.log(Auth.appName, process150.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process151 in Process.GetProcessesByName("x86dbg,windbg"))
                {
                    process151.Kill();
                    PR = process151.ProcessName;
                    //API.log(Auth.appName, process151.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process152 in Process.GetProcessesByName("ProcessHacker2"))
                {
                    process152.Kill();
                    PR = process152.ProcessName;
                    //API.log(Auth.appName, process152.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process153 in Process.GetProcessesByName("Fiddler2"))
                {
                    process153.Kill();
                    PR = process153.ProcessName;
                    //API.log(Auth.appName, process153.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process154 in Process.GetProcessesByName("WebExplorer"))
                {
                    process154.Kill();
                    PR = process154.ProcessName;
                    //API.log(Auth.appName, process154.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process155 in Process.GetProcessesByName("HTTPDebugger"))
                {
                    process155.Kill();
                    PR = process155.ProcessName;
                    //API.log(Auth.appName, process155.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process156 in Process.GetProcessesByName("HTTPDebuggerUI"))
                {
                    process156.Kill();
                    PR = process156.ProcessName;
                    //API.log(Auth.appName, process156.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process157 in Process.GetProcessesByName("VMProtect"))
                {
                    process157.Kill();
                    PR = process157.ProcessName;
                    //API.log(Auth.appName, process157.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process158 in Process.GetProcessesByName("SbieCtrl"))
                {
                    process158.Kill();
                    PR = process158.ProcessName;
                    //API.log(Auth.appName, process158.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process159 in Process.GetProcessesByName("ExtremeDumper"))
                {
                    process159.Kill();
                    PR = process159.ProcessName;
                    //API.log(Auth.appName, process159.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }
                foreach (Process process160 in Process.GetProcessesByName("test"))
                {
                    process160.Kill();
                    PR = process160.ProcessName;
                    //API.log(Auth.appName, process160.ProcessName);

                    restart();
                    Application.Exit();
                    Environment.Exit(0);
                }



            }
            catch (Exception)
            {

            }
        }
    }
}
