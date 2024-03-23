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
            // Configuración de la DataGridView
            archivosDataGridView.AutoGenerateColumns = false;
            archivosDataGridView.Columns.Add("Nombre", "Nombre");
            archivosDataGridView.Columns.Add("Tipo", "Tipo");
            archivosDataGridView.Columns.Add("Tamaño", "Tamaño");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Aquí puedes agregar la lógica para agregar archivos
            // en este ejemplo se agregan datos de muestra
            archivos.Add(new Archivo { Aspecto = "Costo inicial", ArchivosFisicos = "Bajo costo inicial para establecerlo.", ArchivosDigitales = "Costo moderado para la infraestructura.", AlmacenamientoEnLaNube = "Puede requerir un costo inicial moderado." });
            archivos.Add(new Archivo { Aspecto = "Costo operativo.", ArchivosFisicos = "Mantenimiento físico y seguridad.", ArchivosDigitales = "Costos de electricidad y mantenimiento.", AlmacenamientoEnLaNube = "Costos de suscripción o almacenamiento." });
            archivos.Add(new Archivo {Aspecto = "Accesibilidad", ArchivosFisicos = "Acceso limitado dependiendo de la ubicación física.", ArchivosDigitales = "Acceso remoto desde cualquier ubicación.", AlmacenamientoEnLaNube = "Acceso remoto desde cualquier ubicación." });
            archivos.Add(new Archivo { Aspecto = "Escalabilidad", ArchivosFisicos = "Limitada por espacio físico.", ArchivosDigitales = "Escalabilidad alta sin limitaciones físicas.", AlmacenamientoEnLaNube = "Escalabilidad alta sin limitaciones físicas." });
            archivos.Add(new Archivo { Aspecto = "Seguridad", ArchivosFisicos = "Riesgo de pérdida por desastres naturales.", ArchivosDigitales = "Vulnerable a ciberataques y fallos de hardware.", AlmacenamientoEnLaNube = "Mayor seguridad con cifrado y redundancia." });

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
