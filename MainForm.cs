using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExWrapper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private bool Source2Exe(string source, string outputExe)
        {
            CSharpCodeProvider compiler = new CSharpCodeProvider();
            CompilerParameters comParms = new CompilerParameters();

            comParms.GenerateExecutable = true;
            comParms.GenerateInMemory = false;
            comParms.IncludeDebugInformation = false;

            comParms.MainClass = "ExWrapper.Wrapper.Program";
            comParms.CompilerOptions = "/optimize";
            comParms.OutputAssembly = outputExe;
            comParms.TreatWarningsAsErrors = false;

            comParms.ReferencedAssemblies.AddRange(new string[] { "mscorlib.dll", "System.dll", 
                "System.Data.dll", "System.Xml.dll" });
            CompilerResults comRes = compiler.CompileAssemblyFromSource(comParms, source);

            return comRes.Errors != null && comRes.Errors.Count == 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Save As";
                saveFileDialog.Filter = "Exe Files (*.exe)|*.exe";
                saveFileDialog.OverwritePrompt = true; 

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string outputExe = saveFileDialog.FileName;

                    bool useEmbed = true;
                    string source = Properties.Resources.Wrapper;
                    if (useEmbed)
                    {
                        source = source.Replace("${embed}", textEmbed.Text);
                    }
                    else
                    {
                        source = source.Replace("${cmd}", textRun.Text);
                        source = source.Replace("${para}", textPara.Text);
                        source = source.Replace("${dir}", textDir.Text);
                    }
                    Source2Exe(source, outputExe);
                }
            }
        }
    }
}