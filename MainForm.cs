using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.IO;
using System.Windows.Forms;

namespace ExWrapper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private bool Source2Exe(string source, string icon, string outputExe)
        {
            CSharpCodeProvider compiler = new CSharpCodeProvider();
            CompilerParameters comParms = new CompilerParameters();

            comParms.GenerateExecutable = true;
            comParms.GenerateInMemory = false;
            comParms.IncludeDebugInformation = false;

            comParms.MainClass = "ExWrapper.Wrapper.Program";
            //如果加/target:winexe可以生成gui exe
            comParms.CompilerOptions = "/optimize";
            comParms.OutputAssembly = outputExe;
            comParms.TreatWarningsAsErrors = false;

            comParms.ReferencedAssemblies.AddRange(new string[] { "mscorlib.dll", "System.dll", 
                "System.Data.dll", "System.Xml.dll" });

            if (!String.IsNullOrEmpty(icon))
            {
                comParms.CompilerOptions += $" /win32icon:\"{icon}\"";
            }

            CompilerResults comRes = compiler.CompileAssemblyFromSource(comParms, source);

            return comRes.Errors != null && comRes.Errors.Count == 0;
        }

        private string escape2src(string old)
        {
            return old.Replace("\"", "\"\"");
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

                    bool useEmbed = false;
                    string source = Properties.Resources.Wrapper;
                    if (useEmbed)
                    {
                        source = source.Replace("${embed}", escape2src(textEmbed.Text));
                    }
                    else
                    {
                        source = source.Replace("${cmd}", escape2src(textRun.Text));
                        source = source.Replace("${para}", escape2src(textPara.Text));
                        source = source.Replace("${dir}", escape2src(textDir.Text));
                    }
                    source = source.Replace("${hide}", cbShowConsole.Checked ? "false" : "true");
                    Source2Exe(source, textIcon.Text, outputExe);
                }
            }
        }

        private void textIcon_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Title = "Select a icon file";
                openDialog.Filter = "Icon Files (*.ico)|*.ico";
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    textIcon.Text = openDialog.FileName;
                }
            }
        }


        private void radioEmbed_CheckedChanged(object sender, EventArgs e)
        {
            groupCall.Enabled = radioCall.Checked;
            groupEmbed.Enabled = radioEmbed.Checked;
        }

        private void textRun_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Title = "Select a executable file";
                openDialog.Filter = "Executable Files (*.*)|*.*";
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    textRun.Text = Path.GetFileName(openDialog.FileName);
                }
            }
        }
    }
}