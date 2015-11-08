///////////////////////////////////////////////////////////////////////
// Executive.cs - Executive file for the project                     //
// ver 1.0                                                           //
// Language:    C#, 2008, .Net Framework 4.0                         //
// Application: CSE681, Project #2, Fall 2014                        //
// Author:      Nirav Gandhi, MS in CE, Syracuse University          //
//              (315) 395-4842, nigandhi@syr.edu                     //   
///////////////////////////////////////////////////////////////////////
/*
 * Package Operations:
 * -------------------
 * This package is the main package necessary for the communicating 
 * with different packages. It is specific to Project#2 requirements. 
 * 
 */
/* Required Files:
 *   IRuleAndAction.cs, RulesAndActions.cs, Parser.cs, ScopeStack.cs,
 *   Semi.cs, Toker.cs, Display.cs, CommandLineProcessing.cs
 *   FileMgr.cs, XML.cs, Analyzer.cs
 *   
 * Maintenance History:
 * --------------------
 * ver 1.0 : 08 Oct 2014
 * - first release
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CodeAnalysis
{
    class Executive
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.Write("Please enter Command Line Arguments.\n\n");
                return;
            }
            Console.Write("Current path:\n {0}", Directory.GetCurrentDirectory());
            CommandLine.CommandLineProcessing clp = new CommandLine.CommandLineProcessing();
            CodeAnalysis.FileMgr fm = new CodeAnalysis.FileMgr();

            clp.ProcessCommandLine(args);
            fm.setrecurseflag(clp.getrecursiveflag());
            fm.setPattern(clp.getPatterns());
            fm.findFiles(clp.getPath());

            CodeAnalysis.Analyzer.doAnalysis(fm.getFiles().ToArray(), clp.getrelationshipflag());
            CodeAnalysis.Display dis = new CodeAnalysis.Display();
            dis.Displayfiles(fm.getFiles());
            try {
                CodeAnalysis.XML xml = new CodeAnalysis.XML();
                dis.DisplayData(clp);
                xml.XMLWrite(clp.getrelationshipflag());
            }
            catch (Exception ex) {
                Console.Write("\n\n  {0}\n", ex.Message);
            }
        }
    }
}
