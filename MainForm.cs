using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
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

                    bool useEmbed = true;
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
                    Source2Exe(source, outputExe);
                }
            }
        }
    }
}