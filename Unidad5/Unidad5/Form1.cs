namespace Unidad5
{
    public partial class Form1 : Form
    {
        private List<Archivo> archivos = new List<Archivo>();
        public Form1()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Configuraci�n de la DataGridView
            archivosDataGridView.AutoGenerateColumns = false;
            archivosDataGridView.Columns.Add("Nombre", "Nombre");
            archivosDataGridView.Columns.Add("Tipo", "Tipo");
            archivosDataGridView.Columns.Add("Tama�o", "Tama�o");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Aqu� puedes agregar la l�gica para agregar archivos
            // en este ejemplo se agregan datos de muestra
            archivos.Add(new Archivo { Aspecto = "Costo inicial", ArchivosFisicos = "Bajo costo inicial para establecerlo.", ArchivosDigitales = "Costo moderado para la infraestructura.", AlmacenamientoEnLaNube = "Puede requerir un costo inicial moderado." });
            archivos.Add(new Archivo { Aspecto = "Costo operativo.", ArchivosFisicos = "Mantenimiento f�sico y seguridad.", ArchivosDigitales = "Costos de electricidad y mantenimiento.", AlmacenamientoEnLaNube = "Costos de suscripci�n o almacenamiento." });
            archivos.Add(new Archivo {Aspecto = "Accesibilidad", ArchivosFisicos = "Acceso limitado dependiendo de la ubicaci�n f�sica.", ArchivosDigitales = "Acceso remoto desde cualquier ubicaci�n.", AlmacenamientoEnLaNube = "Acceso remoto desde cualquier ubicaci�n." });
            archivos.Add(new Archivo { Aspecto = "Escalabilidad", ArchivosFisicos = "Limitada por espacio f�sico.", ArchivosDigitales = "Escalabilidad alta sin limitaciones f�sicas.", AlmacenamientoEnLaNube = "Escalabilidad alta sin limitaciones f�sicas." });
            archivos.Add(new Archivo { Aspecto = "Seguridad", ArchivosFisicos = "Riesgo de p�rdida por desastres naturales.", ArchivosDigitales = "Vulnerable a ciberataques y fallos de hardware.", AlmacenamientoEnLaNube = "Mayor seguridad con cifrado y redundancia." });

            // Actualizar la DataGridView
            ActualizarDataGridView();
        }
        private void ActualizarDataGridView()
        {
            archivosDataGridView.Rows.Clear();

            foreach (var archivo in archivos)
            {
                archivosDataGridView.Rows.Add(archivo.Aspecto, archivo.ArchivosFisicos, archivo.ArchivosDigitales, archivo.AlmacenamientoEnLaNube);
            }
        }
        public class Archivo
        {
            public string Aspecto { get; set; }
            public string ArchivosFisicos { get; set; }
            public string ArchivosDigitales { get; set; }
            public string AlmacenamientoEnLaNube { get; set; }
        }
    }
}
