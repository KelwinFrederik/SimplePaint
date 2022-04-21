
namespace SimplePaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.optionsGroupBox = new System.Windows.Forms.GroupBox();
            this.borrachaButton = new System.Windows.Forms.Button();
            this.limparButton = new System.Windows.Forms.Button();
            this.salvarButton = new System.Windows.Forms.Button();
            this.espessuraComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.corButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.paintPanel = new System.Windows.Forms.Panel();
            this.optionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsGroupBox.Controls.Add(this.borrachaButton);
            this.optionsGroupBox.Controls.Add(this.limparButton);
            this.optionsGroupBox.Controls.Add(this.salvarButton);
            this.optionsGroupBox.Controls.Add(this.espessuraComboBox);
            this.optionsGroupBox.Controls.Add(this.label2);
            this.optionsGroupBox.Controls.Add(this.corButton);
            this.optionsGroupBox.Controls.Add(this.label1);
            this.optionsGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.optionsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(864, 62);
            this.optionsGroupBox.TabIndex = 0;
            this.optionsGroupBox.TabStop = false;
            this.optionsGroupBox.Text = "Opções";
            // 
            // borrachaButton
            // 
            this.borrachaButton.BackColor = System.Drawing.Color.Transparent;
            this.borrachaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.borrachaButton.ForeColor = System.Drawing.Color.White;
            this.borrachaButton.Location = new System.Drawing.Point(84, 25);
            this.borrachaButton.Name = "borrachaButton";
            this.borrachaButton.Size = new System.Drawing.Size(63, 23);
            this.borrachaButton.TabIndex = 6;
            this.borrachaButton.Text = "Borracha";
            this.borrachaButton.UseVisualStyleBackColor = false;
            this.borrachaButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.borrachaButton_MouseUp);
            // 
            // limparButton
            // 
            this.limparButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.limparButton.BackColor = System.Drawing.Color.Transparent;
            this.limparButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limparButton.ForeColor = System.Drawing.Color.White;
            this.limparButton.Location = new System.Drawing.Point(686, 25);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(75, 23);
            this.limparButton.TabIndex = 5;
            this.limparButton.Text = "Limpar";
            this.limparButton.UseVisualStyleBackColor = false;
            this.limparButton.Click += new System.EventHandler(this.limparButton_Click);
            // 
            // salvarButton
            // 
            this.salvarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salvarButton.BackColor = System.Drawing.Color.Transparent;
            this.salvarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salvarButton.ForeColor = System.Drawing.Color.White;
            this.salvarButton.Location = new System.Drawing.Point(767, 25);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(75, 23);
            this.salvarButton.TabIndex = 4;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.UseVisualStyleBackColor = false;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // espessuraComboBox
            // 
            this.espessuraComboBox.FormattingEnabled = true;
            this.espessuraComboBox.Location = new System.Drawing.Point(274, 25);
            this.espessuraComboBox.Name = "espessuraComboBox";
            this.espessuraComboBox.Size = new System.Drawing.Size(82, 23);
            this.espessuraComboBox.TabIndex = 3;
            this.espessuraComboBox.SelectedIndexChanged += new System.EventHandler(this.espessuraComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(182, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Espessura :";
            // 
            // corButton
            // 
            this.corButton.BackColor = System.Drawing.Color.Red;
            this.corButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.corButton.Location = new System.Drawing.Point(54, 25);
            this.corButton.Name = "corButton";
            this.corButton.Size = new System.Drawing.Size(24, 23);
            this.corButton.TabIndex = 1;
            this.corButton.UseVisualStyleBackColor = false;
            this.corButton.Click += new System.EventHandler(this.CorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cor :";
            // 
            // paintPanel
            // 
            this.paintPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paintPanel.BackColor = System.Drawing.Color.White;
            this.paintPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paintPanel.Location = new System.Drawing.Point(12, 80);
            this.paintPanel.Name = "paintPanel";
            this.paintPanel.Size = new System.Drawing.Size(864, 358);
            this.paintPanel.TabIndex = 1;
            this.paintPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paintPanel_MouseDown);
            this.paintPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paintPanel_MouseMove);
            this.paintPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paintPanel_MouseUp);
            this.paintPanel.Resize += new System.EventHandler(this.paintPanel_Resize);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.paintPanel);
            this.Controls.Add(this.optionsGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(609, 489);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Simple Paint";
            this.optionsGroupBox.ResumeLayout(false);
            this.optionsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.ComboBox espessuraComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button corButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel paintPanel;
        private System.Windows.Forms.Button borrachaButton;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.Button salvarButton;
    }
}

