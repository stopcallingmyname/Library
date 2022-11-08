
namespace fiku_
{
    partial class loginWindow
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
            this.label2 = new System.Windows.Forms.Label();
            this.accTypeComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.acceptAccButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(39, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Тип Аккаунта";
            // 
            // accTypeComboBox
            // 
            this.accTypeComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.accTypeComboBox.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accTypeComboBox.FormattingEnabled = true;
            this.accTypeComboBox.Location = new System.Drawing.Point(7, 31);
            this.accTypeComboBox.Name = "accTypeComboBox";
            this.accTypeComboBox.Size = new System.Drawing.Size(165, 23);
            this.accTypeComboBox.TabIndex = 12;
            this.accTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.get_accType);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.acceptAccButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.accTypeComboBox);
            this.panel2.Location = new System.Drawing.Point(7, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 103);
            this.panel2.TabIndex = 22;
            // 
            // acceptAccButton
            // 
            this.acceptAccButton.Location = new System.Drawing.Point(35, 60);
            this.acceptAccButton.Name = "acceptAccButton";
            this.acceptAccButton.Size = new System.Drawing.Size(105, 24);
            this.acceptAccButton.TabIndex = 13;
            this.acceptAccButton.Text = "Login";
            this.acceptAccButton.UseVisualStyleBackColor = true;
            this.acceptAccButton.Visible = false;
            this.acceptAccButton.Click += new System.EventHandler(this.acceptAccButton_Click);
            // 
            // loginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(199, 123);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(215, 162);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(215, 162);
            this.Name = "loginWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Account";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox accTypeComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button acceptAccButton;
    }
}