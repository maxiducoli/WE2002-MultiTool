using System.Reflection;

namespace WE2002___MultiTool____by_CARP_____maxiducoli
{
    public partial class frmWEMiniTool : Form
    {
        string basePath = Application.StartupPath + "dll\\";
        public frmWEMiniTool()
        {
            InitializeComponent();
        }
        /*
                private void CargarForm(string nombreDLL, string nameSpace)
                {
                    // Ruta a la DLL
                    string dllPath = basePath + nombreDLL;

                    // Cargar el ensamblado
                    Assembly assembly = Assembly.LoadFrom(dllPath);

                    // Obtener el tipo del formulario (ajusta el nombre del namespace y de la clase)
                    Type formType = assembly.GetType(nameSpace);

                    if (formType == null)
                    {
                        Console.WriteLine("No se pudo encontrar el tipo de formulario.");
                        return;
                    }

                    // Crear una instancia del formulario
                    Form form = (Form)Activator.CreateInstance(formType);

                    // Verificar si la instancia es un formulario
                    if (form != null)
                    {
                        // Iniciar la aplicación con el formulario
                        Application.EnableVisualStyles();
        //                Application.SetCompatibleTextRenderingDefault(false);
                        form.ShowDialog();
                    }
                    else
                    {
                        Console.WriteLine("No se pudo crear una instancia del formulario.");
                    }
                }
        */

        private void CargarForm(string nombreDLL, string nameSpace)
        {
            try
            {
                // Ruta a la DLL
                string dllPath = basePath + nombreDLL;

                // Cargar el ensamblado
                Assembly assembly = Assembly.LoadFrom(dllPath);

                // Obtener el tipo del formulario (ajusta el nombre del namespace y de la clase)
                Type formType = assembly.GetType(nameSpace);

                if (formType == null)
                {
                    Console.WriteLine("No se pudo encontrar el tipo de formulario.");
                    return;
                }

                // Crear una instancia del formulario
                Form form = (Form)Activator.CreateInstance(formType);

                // Verificar si la instancia es un formulario
                if (form != null)
                {
                    // Iniciar la aplicación con el formulario
                    Application.EnableVisualStyles();
                    // Application.SetCompatibleTextRenderingDefault(false);
                    form.ShowDialog();
                }
                else
                {
                    Console.WriteLine("No se pudo crear una instancia del formulario.");
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Error de acceso no autorizado: " + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Archivo no encontrado: " + ex.Message);
            }
            catch (FileLoadException ex)
            {
                Console.WriteLine("Error al cargar el archivo: " + ex.Message);
            }
            catch (BadImageFormatException ex)
            {
                Console.WriteLine("El archivo no es un ensamblado válido: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            CargarForm("Winning Eleven Stadium Maker.dll", "frmTMDMaker.frmTMDMaker");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CargarForm("SinSalaBIN.dll", "SinSalaBIN.frmSinSalaBIN");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarForm("RaMaker.dll", "RaMaker.frmRaMaker");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CargarForm("Winnin Eleven TMD Extractor.dll", "WE_TMDMaker.frmExtractTMD");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CargarForm("La pinta.dll", "GraphicsTools.Form1");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CargarForm("T_NAME Maker.dll", "T_NAME_Maker.frmT_NAME");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CargarForm("WE Bin File Tool.dll", "Bin_File_Tool.frmBinFileTool");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CargarForm("VagExtractor.dll", "VagExtractor.frmVagExtractor");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CargarForm("WeCompress.dll", "WeCompress.frmWeC");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CargarForm("Winning Eleven - Nombres largos.dll", "Winning_Eleven___Nombres_largos.frmWinningElevenNombresLargos");
        }
    }
}
