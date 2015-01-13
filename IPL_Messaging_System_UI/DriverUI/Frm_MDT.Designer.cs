namespace IPL_MSGUI.DriverUI
{
    partial class Frm_MDT
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnText = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnCheMsg = new System.Windows.Forms.Button();
            this.btnSendACK = new System.Windows.Forms.Button();
            this.tbxLine1 = new System.Windows.Forms.TextBox();
            this.tbxLine2 = new System.Windows.Forms.TextBox();
            this.tbxLine3 = new System.Windows.Forms.TextBox();
            this.tbxLine4 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.21311F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.82787F));
            this.tableLayoutPanel1.Controls.Add(this.btnText, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnMenu, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCheMsg, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSendACK, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbxLine1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbxLine2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbxLine3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbxLine4, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(488, 286);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnText
            // 
            this.btnText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnText.Location = new System.Drawing.Point(3, 74);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(67, 65);
            this.btnText.TabIndex = 0;
            this.btnText.Text = "Text";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenu.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(3, 145);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(67, 65);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnCheMsg
            // 
            this.btnCheMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCheMsg.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.btnCheMsg.Location = new System.Drawing.Point(403, 74);
            this.btnCheMsg.Name = "btnCheMsg";
            this.btnCheMsg.Size = new System.Drawing.Size(82, 65);
            this.btnCheMsg.TabIndex = 2;
            this.btnCheMsg.Text = "CheckMsg";
            this.btnCheMsg.UseVisualStyleBackColor = true;
            this.btnCheMsg.Click += new System.EventHandler(this.btnCheMsg_Click);
            // 
            // btnSendACK
            // 
            this.btnSendACK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSendACK.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendACK.Location = new System.Drawing.Point(403, 145);
            this.btnSendACK.Name = "btnSendACK";
            this.btnSendACK.Size = new System.Drawing.Size(82, 65);
            this.btnSendACK.TabIndex = 3;
            this.btnSendACK.Text = "Send ACK";
            this.btnSendACK.UseVisualStyleBackColor = true;
            this.btnSendACK.Click += new System.EventHandler(this.btnSendACK_Click);
            // 
            // tbxLine1
            // 
            this.tbxLine1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxLine1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLine1.Location = new System.Drawing.Point(76, 3);
            this.tbxLine1.MaxLength = 20;
            this.tbxLine1.Multiline = true;
            this.tbxLine1.Name = "tbxLine1";
            this.tbxLine1.Size = new System.Drawing.Size(321, 65);
            this.tbxLine1.TabIndex = 4;
            this.tbxLine1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxLine2
            // 
            this.tbxLine2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxLine2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLine2.Location = new System.Drawing.Point(76, 74);
            this.tbxLine2.MaxLength = 20;
            this.tbxLine2.Multiline = true;
            this.tbxLine2.Name = "tbxLine2";
            this.tbxLine2.Size = new System.Drawing.Size(321, 65);
            this.tbxLine2.TabIndex = 5;
            this.tbxLine2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxLine3
            // 
            this.tbxLine3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxLine3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLine3.Location = new System.Drawing.Point(76, 145);
            this.tbxLine3.MaxLength = 20;
            this.tbxLine3.Multiline = true;
            this.tbxLine3.Name = "tbxLine3";
            this.tbxLine3.Size = new System.Drawing.Size(321, 65);
            this.tbxLine3.TabIndex = 6;
            this.tbxLine3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxLine4
            // 
            this.tbxLine4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxLine4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLine4.Location = new System.Drawing.Point(76, 216);
            this.tbxLine4.MaxLength = 20;
            this.tbxLine4.Multiline = true;
            this.tbxLine4.Name = "tbxLine4";
            this.tbxLine4.Size = new System.Drawing.Size(321, 67);
            this.tbxLine4.TabIndex = 7;
            this.tbxLine4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 286);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MDT";
            this.Text = "MDT";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnCheMsg;
        private System.Windows.Forms.Button btnSendACK;
        private System.Windows.Forms.TextBox tbxLine1;
        private System.Windows.Forms.TextBox tbxLine2;
        private System.Windows.Forms.TextBox tbxLine3;
        private System.Windows.Forms.TextBox tbxLine4;
    }
}

