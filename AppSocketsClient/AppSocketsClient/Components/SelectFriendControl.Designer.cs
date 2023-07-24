namespace AppSocketsClient.Components
{
    partial class SelectFriendControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectFriendControl));
            this.pnlFriend = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblIsOnline = new System.Windows.Forms.Label();
            this.pnlFriend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFriend
            // 
            this.pnlFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.pnlFriend.Controls.Add(this.pictureBox1);
            this.pnlFriend.Controls.Add(this.lblIsOnline);
            this.pnlFriend.Controls.Add(this.lblUserName);
            this.pnlFriend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlFriend.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFriend.ForeColor = System.Drawing.Color.White;
            this.pnlFriend.Location = new System.Drawing.Point(13, 3);
            this.pnlFriend.Name = "pnlFriend";
            this.pnlFriend.Size = new System.Drawing.Size(281, 53);
            this.pnlFriend.TabIndex = 0;
            this.pnlFriend.Click += new System.EventHandler(this.pnlFriend_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(72, 16);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(87, 19);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "John Doe";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppSocketsClient.Properties.Resources.man;
            this.pictureBox1.Location = new System.Drawing.Point(13, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblIsOnline
            // 
            this.lblIsOnline.AutoSize = true;
            this.lblIsOnline.Font = new System.Drawing.Font("Century Gothic", 15.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsOnline.Image = ((System.Drawing.Image)(resources.GetObject("lblIsOnline.Image")));
            this.lblIsOnline.Location = new System.Drawing.Point(246, 3);
            this.lblIsOnline.Name = "lblIsOnline";
            this.lblIsOnline.Size = new System.Drawing.Size(35, 32);
            this.lblIsOnline.TabIndex = 2;
            this.lblIsOnline.Text = "   ";
            // 
            // SelectFriendControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.pnlFriend);
            this.Name = "SelectFriendControl";
            this.Size = new System.Drawing.Size(297, 61);
            this.pnlFriend.ResumeLayout(false);
            this.pnlFriend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFriend;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblIsOnline;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
