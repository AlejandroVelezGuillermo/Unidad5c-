namespace Unidad5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            archivosDataGridView = new DataGridView();
            Aspecto = new DataGridViewTextBoxColumn();
            Archivos_Fisicos = new DataGridViewTextBoxColumn();
            Archivos_Digitales = new DataGridViewTextBoxColumn();
            Almacenamiento_En_La_Nuve = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)archivosDataGridView).BeginInit();
            SuspendLayout();
            // 
            // archivosDataGridView
            // 
            archivosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            archivosDataGridView.Columns.AddRange(new DataGridViewColumn[] { Aspecto, Archivos_Fisicos, Archivos_Digitales, Almacenamiento_En_La_Nuve });
            archivosDataGridView.Location = new Point(12, 91);
            archivosDataGridView.Name = "archivosDataGridView";
            archivosDataGridView.RowHeadersWidth = 51;
            archivosDataGridView.Size = new Size(776, 347);
            archivosDataGridView.TabIndex = 0;
            // 
            // Aspecto
            // 
            Aspecto.HeaderText = "Aspecto";
            Aspecto.MinimumWidth = 6;
            Aspecto.Name = "Aspecto";
            Aspecto.Width = 125;
            // 
            // Archivos_Fisicos
            // 
            Archivos_Fisicos.HeaderText = "Archivos_Fisicos";
            Archivos_Fisicos.MinimumWidth = 6;
            Archivos_Fisicos.Name = "Archivos_Fisicos";
            Archivos_Fisicos.Width = 125;
            // 
            // Archivos_Digitales
            // 
            Archivos_Digitales.HeaderText = "Archivos_Digitales";
            Archivos_Digitales.MinimumWidth = 6;
            Archivos_Digitales.Name = "Archivos_Digitales";
            Archivos_Digitales.Width = 125;
            // 
            // Almacenamiento_En_La_Nuve
            // 
            Almacenamiento_En_La_Nuve.HeaderText = "Almacenamiento_En_La_Nuve";
            Almacenamiento_En_La_Nuve.MinimumWidth = 6;
            Almacenamiento_En_La_Nuve.Name = "Almacenamiento_En_La_Nuve";
            Almacenamiento_En_La_Nuve.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(12, 56);
            button1.Name = "button1";
            button1.Size = new Size(173, 29);
            button1.TabIndex = 1;
            button1.Text = "Cargar Datos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(archivosDataGridView);
            Name = "Form1";
            Text = "Cargar";
            ((System.ComponentModel.ISupportInitialize)archivosDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView archivosDataGridView;
        private Button button1;
        private DataGridViewTextBoxColumn Aspecto;
        private DataGridViewTextBoxColumn Archivos_Fisicos;
        private DataGridViewTextBoxColumn Archivos_Digitales;
        private DataGridViewTextBoxColumn Almacenamiento_En_La_Nuve;
    }
}
