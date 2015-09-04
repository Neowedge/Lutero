namespace Lutero
{
    partial class ConfigurationForm
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
            this.gbCodigo = new System.Windows.Forms.GroupBox();
            this.lbConstante = new System.Windows.Forms.Label();
            this.txAccessor = new System.Windows.Forms.TextBox();
            this.txCode = new System.Windows.Forms.TextBox();
            this.lbFuncion = new System.Windows.Forms.Label();
            this.TableLayoutPanelBotones = new System.Windows.Forms.TableLayoutPanel();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.gbCodigo.SuspendLayout();
            this.TableLayoutPanelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCodigo
            // 
            this.gbCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCodigo.Controls.Add(this.lbConstante);
            this.gbCodigo.Controls.Add(this.txAccessor);
            this.gbCodigo.Controls.Add(this.txCode);
            this.gbCodigo.Controls.Add(this.lbFuncion);
            this.gbCodigo.Location = new System.Drawing.Point(11, 11);
            this.gbCodigo.Name = "gbCodigo";
            this.gbCodigo.Size = new System.Drawing.Size(352, 150);
            this.gbCodigo.TabIndex = 3;
            this.gbCodigo.TabStop = false;
            this.gbCodigo.Text = "Código";
            // 
            // lbConstante
            // 
            this.lbConstante.AutoSize = true;
            this.lbConstante.Location = new System.Drawing.Point(6, 20);
            this.lbConstante.Name = "lbConstante";
            this.lbConstante.Size = new System.Drawing.Size(46, 13);
            this.lbConstante.TabIndex = 3;
            this.lbConstante.Text = "Acceso:";
            // 
            // txAccessor
            // 
            this.txAccessor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txAccessor.Location = new System.Drawing.Point(70, 17);
            this.txAccessor.Name = "txAccessor";
            this.txAccessor.Size = new System.Drawing.Size(267, 20);
            this.txAccessor.TabIndex = 2;
            // 
            // txCode
            // 
            this.txCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txCode.Location = new System.Drawing.Point(70, 48);
            this.txCode.Multiline = true;
            this.txCode.Name = "txCode";
            this.txCode.Size = new System.Drawing.Size(267, 96);
            this.txCode.TabIndex = 1;
            // 
            // lbFuncion
            // 
            this.lbFuncion.AutoSize = true;
            this.lbFuncion.Location = new System.Drawing.Point(6, 51);
            this.lbFuncion.Name = "lbFuncion";
            this.lbFuncion.Size = new System.Drawing.Size(43, 13);
            this.lbFuncion.TabIndex = 0;
            this.lbFuncion.Text = "Código:";
            // 
            // TableLayoutPanelBotones
            // 
            this.TableLayoutPanelBotones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanelBotones.ColumnCount = 2;
            this.TableLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelBotones.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanelBotones.Controls.Add(this.Cancel_Button, 1, 0);
            this.TableLayoutPanelBotones.Location = new System.Drawing.Point(217, 167);
            this.TableLayoutPanelBotones.Name = "TableLayoutPanelBotones";
            this.TableLayoutPanelBotones.RowCount = 1;
            this.TableLayoutPanelBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelBotones.Size = new System.Drawing.Size(146, 29);
            this.TableLayoutPanelBotones.TabIndex = 2;
            // 
            // OK_Button
            // 
            this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OK_Button.Location = new System.Drawing.Point(3, 3);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(67, 23);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "Aceptar";
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(76, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(67, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancelar";
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 208);
            this.Controls.Add(this.gbCodigo);
            this.Controls.Add(this.TableLayoutPanelBotones);
            this.Name = "ConfigurationForm";
            this.Text = "ConfigurationForm";
            this.Load += new System.EventHandler(this.ConfigurationForm_Load);
            this.gbCodigo.ResumeLayout(false);
            this.gbCodigo.PerformLayout();
            this.TableLayoutPanelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gbCodigo;
        internal System.Windows.Forms.Label lbConstante;
        internal System.Windows.Forms.TextBox txAccessor;
        internal System.Windows.Forms.TextBox txCode;
        internal System.Windows.Forms.Label lbFuncion;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanelBotones;
        internal System.Windows.Forms.Button OK_Button;
        internal System.Windows.Forms.Button Cancel_Button;
    }
}