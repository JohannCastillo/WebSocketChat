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
            this.pnlFriend = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pnlFriend.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFriend
            // 
            this.pnlFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.pnlFriend.Controls.Add(this.lblUserName);
            this.pnlFriend.Location = new System.Drawing.Point(13, 3);
            this.pnlFriend.Name = "pnlFriend";
            this.pnlFriend.Size = new System.Drawing.Size(281, 92);
            this.pnlFriend.TabIndex = 0;
            this.pnlFriend.Click += new System.EventHandler(this.pnlFriend_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(31, 10);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(37, 16);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "label";
            // 
            // SelectFriendControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.pnlFriend);
            this.Name = "SelectFriendControl";
            this.Size = new System.Drawing.Size(297, 98);
            this.pnlFriend.ResumeLayout(false);
            this.pnlFriend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFriend;
        private System.Windows.Forms.Label lblUserName;
    }
}
