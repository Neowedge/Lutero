namespace Lutero
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbLenguaje = new System.Windows.Forms.ComboBox();
            this.btNuevoLenguaje = new System.Windows.Forms.Button();
            this.GroupBoxTextos = new System.Windows.Forms.GroupBox();
            this.btGeneraCodigo = new System.Windows.Forms.Button();
            this.btTodos = new System.Windows.Forms.Button();
            this.btCodigo = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.txBuscar = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.cbTags = new System.Windows.Forms.ComboBox();
            this.DataGridViewTextos = new System.Windows.Forms.DataGridView();
            this.ColumnCodLenguaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLenguaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTexto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTags = new System.Windows.Forms.Label();
            this.btExaminar = new System.Windows.Forms.Button();
            this.btConfiguracion = new System.Windows.Forms.Button();
            this.chkOnTop = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.GroupBoxTextos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTextos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbLenguaje
            // 
            this.cbLenguaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbLenguaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLenguaje.FormattingEnabled = true;
            this.cbLenguaje.Location = new System.Drawing.Point(7, 179);
            this.cbLenguaje.Name = "cbLenguaje";
            this.cbLenguaje.Size = new System.Drawing.Size(151, 21);
            this.cbLenguaje.TabIndex = 12;
            // 
            // btNuevoLenguaje
            // 
            this.btNuevoLenguaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btNuevoLenguaje.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btNuevoLenguaje.Location = new System.Drawing.Point(164, 178);
            this.btNuevoLenguaje.Name = "btNuevoLenguaje";
            this.btNuevoLenguaje.Size = new System.Drawing.Size(125, 23);
            this.btNuevoLenguaje.TabIndex = 11;
            this.btNuevoLenguaje.Text = "Nuevo Lenguaje";
            this.btNuevoLenguaje.UseVisualStyleBackColor = true;
            this.btNuevoLenguaje.Click += new System.EventHandler(this.btNuevoLenguaje_Click);
            // 
            // GroupBoxTextos
            // 
            this.GroupBoxTextos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxTextos.Controls.Add(this.cbLenguaje);
            this.GroupBoxTextos.Controls.Add(this.btNuevoLenguaje);
            this.GroupBoxTextos.Controls.Add(this.btGeneraCodigo);
            this.GroupBoxTextos.Controls.Add(this.btTodos);
            this.GroupBoxTextos.Controls.Add(this.btCodigo);
            this.GroupBoxTextos.Controls.Add(this.btGuardar);
            this.GroupBoxTextos.Controls.Add(this.btEliminar);
            this.GroupBoxTextos.Controls.Add(this.txBuscar);
            this.GroupBoxTextos.Controls.Add(this.btBuscar);
            this.GroupBoxTextos.Controls.Add(this.cbTags);
            this.GroupBoxTextos.Controls.Add(this.DataGridViewTextos);
            this.GroupBoxTextos.Controls.Add(this.lbTags);
            this.GroupBoxTextos.Enabled = false;
            this.GroupBoxTextos.Location = new System.Drawing.Point(12, 41);
            this.GroupBoxTextos.Name = "GroupBoxTextos";
            this.GroupBoxTextos.Size = new System.Drawing.Size(690, 207);
            this.GroupBoxTextos.TabIndex = 12;
            this.GroupBoxTextos.TabStop = false;
            this.GroupBoxTextos.Text = "Textos";
            // 
            // btGeneraCodigo
            // 
            this.btGeneraCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btGeneraCodigo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btGeneraCodigo.Location = new System.Drawing.Point(452, 178);
            this.btGeneraCodigo.Name = "btGeneraCodigo";
            this.btGeneraCodigo.Size = new System.Drawing.Size(151, 23);
            this.btGeneraCodigo.TabIndex = 7;
            this.btGeneraCodigo.Text = "Genera Código Constantes";
            this.btGeneraCodigo.UseVisualStyleBackColor = true;
            this.btGeneraCodigo.Click += new System.EventHandler(this.btGeneraCodigo_Click);
            // 
            // btTodos
            // 
            this.btTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTodos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btTodos.Location = new System.Drawing.Point(609, 15);
            this.btTodos.Name = "btTodos";
            this.btTodos.Size = new System.Drawing.Size(75, 23);
            this.btTodos.TabIndex = 10;
            this.btTodos.Text = "Todos";
            this.btTodos.UseVisualStyleBackColor = true;
            this.btTodos.Click += new System.EventHandler(this.btTodos_Click);
            // 
            // btCodigo
            // 
            this.btCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCodigo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btCodigo.Location = new System.Drawing.Point(528, 46);
            this.btCodigo.Name = "btCodigo";
            this.btCodigo.Size = new System.Drawing.Size(75, 23);
            this.btCodigo.TabIndex = 9;
            this.btCodigo.Text = "Código";
            this.btCodigo.UseVisualStyleBackColor = true;
            this.btCodigo.Click += new System.EventHandler(this.btCodigo_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btGuardar.Enabled = false;
            this.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btGuardar.Location = new System.Drawing.Point(609, 178);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 4;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btEliminar.Location = new System.Drawing.Point(609, 46);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 23);
            this.btEliminar.TabIndex = 8;
            this.btEliminar.Text = "Eliminar Tag";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // txBuscar
            // 
            this.txBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.txBuscar.Location = new System.Drawing.Point(9, 17);
            this.txBuscar.Name = "txBuscar";
            this.txBuscar.Size = new System.Drawing.Size(513, 20);
            this.txBuscar.TabIndex = 7;
            // 
            // btBuscar
            // 
            this.btBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btBuscar.Location = new System.Drawing.Point(528, 15);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 6;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // cbTags
            // 
            this.cbTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTags.BackColor = System.Drawing.SystemColors.Window;
            this.cbTags.FormattingEnabled = true;
            this.cbTags.Location = new System.Drawing.Point(87, 48);
            this.cbTags.Name = "cbTags";
            this.cbTags.Size = new System.Drawing.Size(435, 21);
            this.cbTags.TabIndex = 2;
            this.cbTags.SelectedValueChanged += new System.EventHandler(this.cbTags_SelectedValueChanged);
            this.cbTags.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTags_KeyPress);
            // 
            // DataGridViewTextos
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridViewTextos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewTextos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewTextos.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.DataGridViewTextos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTextos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodLenguaje,
            this.ColumnLenguaje,
            this.ColumnTexto});
            this.DataGridViewTextos.Location = new System.Drawing.Point(6, 75);
            this.DataGridViewTextos.MultiSelect = false;
            this.DataGridViewTextos.Name = "DataGridViewTextos";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewTextos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewTextos.Size = new System.Drawing.Size(678, 97);
            this.DataGridViewTextos.TabIndex = 5;
            this.DataGridViewTextos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTextos_CellValueChanged);
            this.DataGridViewTextos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataGridViewTextos_KeyPress);
            // 
            // ColumnCodLenguaje
            // 
            this.ColumnCodLenguaje.HeaderText = "CodLenguaje";
            this.ColumnCodLenguaje.Name = "ColumnCodLenguaje";
            this.ColumnCodLenguaje.Visible = false;
            // 
            // ColumnLenguaje
            // 
            this.ColumnLenguaje.HeaderText = "Lenguaje";
            this.ColumnLenguaje.Name = "ColumnLenguaje";
            this.ColumnLenguaje.ReadOnly = true;
            // 
            // ColumnTexto
            // 
            this.ColumnTexto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTexto.HeaderText = "Texto";
            this.ColumnTexto.Name = "ColumnTexto";
            // 
            // lbTags
            // 
            this.lbTags.AutoSize = true;
            this.lbTags.Location = new System.Drawing.Point(6, 51);
            this.lbTags.Name = "lbTags";
            this.lbTags.Size = new System.Drawing.Size(75, 13);
            this.lbTags.TabIndex = 3;
            this.lbTags.Text = "Tag a cambiar";
            // 
            // btExaminar
            // 
            this.btExaminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btExaminar.Location = new System.Drawing.Point(12, 12);
            this.btExaminar.Name = "btExaminar";
            this.btExaminar.Size = new System.Drawing.Size(289, 23);
            this.btExaminar.TabIndex = 11;
            this.btExaminar.Text = "Cargar carpeta de lenguajes...";
            this.btExaminar.UseVisualStyleBackColor = true;
            this.btExaminar.Click += new System.EventHandler(this.btExaminar_Click);
            // 
            // btConfiguracion
            // 
            this.btConfiguracion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btConfiguracion.Location = new System.Drawing.Point(540, 12);
            this.btConfiguracion.Name = "btConfiguracion";
            this.btConfiguracion.Size = new System.Drawing.Size(75, 23);
            this.btConfiguracion.TabIndex = 14;
            this.btConfiguracion.Text = "Config...";
            this.btConfiguracion.UseVisualStyleBackColor = true;
            this.btConfiguracion.Click += new System.EventHandler(this.btConfiguracion_Click);
            // 
            // chkOnTop
            // 
            this.chkOnTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkOnTop.AutoSize = true;
            this.chkOnTop.Location = new System.Drawing.Point(634, 16);
            this.chkOnTop.Name = "chkOnTop";
            this.chkOnTop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkOnTop.Size = new System.Drawing.Size(62, 17);
            this.chkOnTop.TabIndex = 13;
            this.chkOnTop.Text = "On Top";
            this.chkOnTop.UseVisualStyleBackColor = true;
            this.chkOnTop.CheckedChanged += new System.EventHandler(this.chkOnTop_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 260);
            this.Controls.Add(this.GroupBoxTextos);
            this.Controls.Add(this.btExaminar);
            this.Controls.Add(this.btConfiguracion);
            this.Controls.Add(this.chkOnTop);
            this.Name = "MainForm";
            this.Text = "Lutero";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.GroupBoxTextos.ResumeLayout(false);
            this.GroupBoxTextos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTextos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cbLenguaje;
        internal System.Windows.Forms.Button btNuevoLenguaje;
        internal System.Windows.Forms.GroupBox GroupBoxTextos;
        internal System.Windows.Forms.Button btGeneraCodigo;
        internal System.Windows.Forms.Button btTodos;
        internal System.Windows.Forms.Button btCodigo;
        internal System.Windows.Forms.Button btGuardar;
        internal System.Windows.Forms.Button btEliminar;
        internal System.Windows.Forms.TextBox txBuscar;
        internal System.Windows.Forms.Button btBuscar;
        internal System.Windows.Forms.ComboBox cbTags;
        internal System.Windows.Forms.DataGridView DataGridViewTextos;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodLenguaje;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ColumnLenguaje;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ColumnTexto;
        internal System.Windows.Forms.Label lbTags;
        internal System.Windows.Forms.Button btExaminar;
        internal System.Windows.Forms.Button btConfiguracion;
        internal System.Windows.Forms.CheckBox chkOnTop;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}