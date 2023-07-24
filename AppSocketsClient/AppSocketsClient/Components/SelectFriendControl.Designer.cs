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
            this.lblLastMessage = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblNewMessage = new System.Windows.Forms.Label();
            this.lblIsOnline = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.pnlFriend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFriend
            // 
            this.pnlFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.pnlFriend.Controls.Add(this.lblTime);
            this.pnlFriend.Controls.Add(this.lblIsOnline);
            this.pnlFriend.Controls.Add(this.pictureBox1);
            this.pnlFriend.Controls.Add(this.lblNewMessage);
            this.pnlFriend.Controls.Add(this.lblLastMessage);
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
            // lblLastMessage
            // 
            this.lblLastMessage.AutoEllipsis = true;
            this.lblLastMessage.AutoSize = true;
            this.lblLastMessage.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblLastMessage.Location = new System.Drawing.Point(70, 30);
            this.lblLastMessage.MaximumSize = new System.Drawing.Size(185, 20);
            this.lblLastMessage.Name = "lblLastMessage";
            this.lblLastMessage.Size = new System.Drawing.Size(0, 20);
            this.lblLastMessage.TabIndex = 4;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(74, 4);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(87, 19);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "John Doe";
            // 
            // lblNewMessage
            // 
            this.lblNewMessage.AutoSize = true;
            this.lblNewMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblNewMessage.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblNewMessage.Image = global::AppSocketsClient.Properties.Resources.lightblue;
            this.lblNewMessage.Location = new System.Drawing.Point(251, 25);
            this.lblNewMessage.Margin = new System.Windows.Forms.Padding(0);
            this.lblNewMessage.Name = "lblNewMessage";
            this.lblNewMessage.Size = new System.Drawing.Size(30, 25);
            this.lblNewMessage.TabIndex = 5;
            this.lblNewMessage.Text = "   ";
            this.lblNewMessage.Visible = false;
            // 
            // lblIsOnline
            // 
            this.lblIsOnline.AutoSize = true;
            this.lblIsOnline.BackColor = System.Drawing.Color.Transparent;
            this.lblIsOnline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIsOnline.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.lblIsOnline.ForeColor = System.Drawing.Color.Transparent;
            this.lblIsOnline.Image = ((System.Drawing.Image)(resources.GetObject("lblIsOnline.Image")));
            this.lblIsOnline.Location = new System.Drawing.Point(54, 6);
            this.lblIsOnline.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.lblIsOnline.Name = "lblIsOnline";
            this.lblIsOnline.Size = new System.Drawing.Size(17, 17);
            this.lblIsOnline.TabIndex = 2;
            this.lblIsOnline.Text = "   ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AppSocketsClient.Properties.Resources.man;
            this.pictureBox1.Location = new System.Drawing.Point(13, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoEllipsis = true;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblTime.Location = new System.Drawing.Point(233, 0);
            this.lblTime.MaximumSize = new System.Drawing.Size(185, 20);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 20);
            this.lblTime.TabIndex = 6;
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
        private System.Windows.Forms.Label lblLastMessage;
        private System.Windows.Forms.Label lblNewMessage;
        private System.Windows.Forms.Label lblTime;
    }
}
