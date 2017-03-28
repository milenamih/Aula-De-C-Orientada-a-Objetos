namespace Grava_Arq_Texto
{
    partial class gavararqform
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.EndLabel = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.EndtextBox = new System.Windows.Forms.TextBox();
            this.GravarButton = new System.Windows.Forms.Button();
            this.EstadoCivilComboBox = new System.Windows.Forms.ComboBox();
            this.pais = new System.Windows.Forms.ListBox();
            this.UnipLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SexoGroupBox = new System.Windows.Forms.GroupBox();
            this.FemradioButton = new System.Windows.Forms.RadioButton();
            this.MascradioButton = new System.Windows.Forms.RadioButton();
            this.PresencialCheckBox = new System.Windows.Forms.CheckBox();
            this.SexoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(71, 51);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Nome:";
            // 
            // EndLabel
            // 
            this.EndLabel.AutoSize = true;
            this.EndLabel.Location = new System.Drawing.Point(68, 102);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(56, 13);
            this.EndLabel.TabIndex = 1;
            this.EndLabel.Text = "Endereço:";
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(127, 48);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(100, 20);
            this.NametextBox.TabIndex = 3;
            // 
            // EndtextBox
            // 
            this.EndtextBox.Location = new System.Drawing.Point(127, 99);
            this.EndtextBox.Name = "EndtextBox";
            this.EndtextBox.Size = new System.Drawing.Size(100, 20);
            this.EndtextBox.TabIndex = 4;
            // 
            // GravarButton
            // 
            this.GravarButton.Location = new System.Drawing.Point(127, 296);
            this.GravarButton.Name = "GravarButton";
            this.GravarButton.Size = new System.Drawing.Size(289, 23);
            this.GravarButton.TabIndex = 5;
            this.GravarButton.Text = "Gravar";
            this.GravarButton.UseVisualStyleBackColor = true;
            this.GravarButton.Click += new System.EventHandler(this.GravarButton_Click);
            // 
            // EstadoCivilComboBox
            // 
            this.EstadoCivilComboBox.FormattingEnabled = true;
            this.EstadoCivilComboBox.Items.AddRange(new object[] {
            "Casado",
            "Solteiro",
            "Separado",
            "Outros"});
            this.EstadoCivilComboBox.Location = new System.Drawing.Point(65, 215);
            this.EstadoCivilComboBox.Name = "EstadoCivilComboBox";
            this.EstadoCivilComboBox.Size = new System.Drawing.Size(121, 21);
            this.EstadoCivilComboBox.TabIndex = 8;
            // 
            // pais
            // 
            this.pais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pais.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pais.FormattingEnabled = true;
            this.pais.ItemHeight = 37;
            this.pais.Items.AddRange(new object[] {
            "Argentina",
            "Bolivia",
            "Brasil",
            "Canada",
            "Chile",
            "Eua"});
            this.pais.Location = new System.Drawing.Point(374, 37);
            this.pais.Name = "pais";
            this.pais.Size = new System.Drawing.Size(175, 226);
            this.pais.Sorted = true;
            this.pais.TabIndex = 9;
            // 
            // UnipLinkLabel
            // 
            this.UnipLinkLabel.AutoSize = true;
            this.UnipLinkLabel.Location = new System.Drawing.Point(456, 328);
            this.UnipLinkLabel.Name = "UnipLinkLabel";
            this.UnipLinkLabel.Size = new System.Drawing.Size(68, 13);
            this.UnipLinkLabel.TabIndex = 10;
            this.UnipLinkLabel.TabStop = true;
            this.UnipLinkLabel.Text = "www.Unip.br";
            this.UnipLinkLabel.VisitedLinkColor = System.Drawing.Color.Fuchsia;
            // 
            // SexoGroupBox
            // 
            this.SexoGroupBox.Controls.Add(this.MascradioButton);
            this.SexoGroupBox.Controls.Add(this.FemradioButton);
            this.SexoGroupBox.Location = new System.Drawing.Point(64, 137);
            this.SexoGroupBox.Name = "SexoGroupBox";
            this.SexoGroupBox.Size = new System.Drawing.Size(203, 41);
            this.SexoGroupBox.TabIndex = 11;
            this.SexoGroupBox.TabStop = false;
            this.SexoGroupBox.Text = "Sexo";
            // 
            // FemradioButton
            // 
            this.FemradioButton.AutoSize = true;
            this.FemradioButton.Location = new System.Drawing.Point(10, 20);
            this.FemradioButton.Name = "FemradioButton";
            this.FemradioButton.Size = new System.Drawing.Size(67, 17);
            this.FemradioButton.TabIndex = 0;
            this.FemradioButton.TabStop = true;
            this.FemradioButton.Text = "Feminino";
            this.FemradioButton.UseVisualStyleBackColor = true;
            // 
            // MascradioButton
            // 
            this.MascradioButton.AutoSize = true;
            this.MascradioButton.Location = new System.Drawing.Point(101, 20);
            this.MascradioButton.Name = "MascradioButton";
            this.MascradioButton.Size = new System.Drawing.Size(73, 17);
            this.MascradioButton.TabIndex = 1;
            this.MascradioButton.TabStop = true;
            this.MascradioButton.Text = "Masculino";
            this.MascradioButton.UseVisualStyleBackColor = true;
            // 
            // PresencialCheckBox
            // 
            this.PresencialCheckBox.AutoSize = true;
            this.PresencialCheckBox.Location = new System.Drawing.Point(192, 215);
            this.PresencialCheckBox.Name = "PresencialCheckBox";
            this.PresencialCheckBox.Size = new System.Drawing.Size(75, 17);
            this.PresencialCheckBox.TabIndex = 12;
            this.PresencialCheckBox.Text = "Presencial";
            this.PresencialCheckBox.UseVisualStyleBackColor = true;
            // 
            // gavararqform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 350);
            this.Controls.Add(this.PresencialCheckBox);
            this.Controls.Add(this.SexoGroupBox);
            this.Controls.Add(this.UnipLinkLabel);
            this.Controls.Add(this.pais);
            this.Controls.Add(this.EstadoCivilComboBox);
            this.Controls.Add(this.GravarButton);
            this.Controls.Add(this.EndtextBox);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.EndLabel);
            this.Controls.Add(this.NameLabel);
            this.HelpButton = true;
            this.Name = "gavararqform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GRAVAÇÃO DE ARQUIVO TEXTO";
            this.SexoGroupBox.ResumeLayout(false);
            this.SexoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label EndLabel;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox EndtextBox;
        private System.Windows.Forms.Button GravarButton;
        private System.Windows.Forms.ComboBox EstadoCivilComboBox;
        private System.Windows.Forms.ListBox pais;
        private System.Windows.Forms.LinkLabel UnipLinkLabel;
        private System.Windows.Forms.GroupBox SexoGroupBox;
        private System.Windows.Forms.RadioButton MascradioButton;
        private System.Windows.Forms.RadioButton FemradioButton;
        private System.Windows.Forms.CheckBox PresencialCheckBox;
    }
}

