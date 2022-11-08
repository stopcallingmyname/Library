
namespace fiku_
{
    partial class mainWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Account = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.acc_notification = new System.Windows.Forms.Label();
            this.accountButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle35;
            this.dataGridView1.Location = new System.Drawing.Point(7, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(804, 444);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Account);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.acc_notification);
            this.panel1.Controls.Add(this.accountButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 41);
            this.panel1.TabIndex = 2;
            // 
            // Account
            // 
            this.Account.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Account.AutoSize = true;
            this.Account.ForeColor = System.Drawing.Color.Black;
            this.Account.Location = new System.Drawing.Point(681, 10);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(80, 13);
            this.Account.TabIndex = 5;
            this.Account.Text = "Пользователь";
            this.Account.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(684, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(73, 3);
            this.panel2.TabIndex = 4;
            // 
            // acc_notification
            // 
            this.acc_notification.AutoSize = true;
            this.acc_notification.ForeColor = System.Drawing.Color.Black;
            this.acc_notification.Location = new System.Drawing.Point(647, 14);
            this.acc_notification.Name = "acc_notification";
            this.acc_notification.Size = new System.Drawing.Size(113, 13);
            this.acc_notification.TabIndex = 3;
            this.acc_notification.Text = "Войдите в аккаунт ->";
            // 
            // accountButton
            // 
            this.accountButton.BackgroundImage = global::fiku_.Properties.Resources.user;
            this.accountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.accountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accountButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.accountButton.FlatAppearance.BorderSize = 0;
            this.accountButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.accountButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.accountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountButton.Location = new System.Drawing.Point(766, 7);
            this.accountButton.Name = "accountButton";
            this.accountButton.Size = new System.Drawing.Size(26, 26);
            this.accountButton.TabIndex = 2;
            this.accountButton.UseVisualStyleBackColor = true;
            this.accountButton.Click += new System.EventHandler(this.accountButton_Click);
            this.accountButton.MouseLeave += new System.EventHandler(this.accountButton_MouseLeave);
            this.accountButton.MouseHover += new System.EventHandler(this.accountButton_MouseHover);
            // 
            // addButton
            // 
            this.addButton.BackgroundImage = global::fiku_.Properties.Resources.add;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(10, 7);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(28, 28);
            this.addButton.TabIndex = 1;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Visible = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(819, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(835, 546);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(835, 546);
            this.Name = "mainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ">fiku$";
            this.Activated += new System.EventHandler(this.mainWindow_update);
            this.Deactivate += new System.EventHandler(this.mainWindow_update);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button accountButton;
        private System.Windows.Forms.Label acc_notification;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Account;
    }
}

