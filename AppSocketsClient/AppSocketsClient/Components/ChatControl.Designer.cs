namespace AppSocketsClient.Components
{
    partial class ChatControl
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
            this.pnlChatLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlFriend = new System.Windows.Forms.Panel();
            this.pnlChat = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.lblFriend = new System.Windows.Forms.Label();
            this.pnlChatLayout.SuspendLayout();
            this.pnlFriend.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChatLayout
            // 
            this.pnlChatLayout.Controls.Add(this.pnlFriend);
            this.pnlChatLayout.Controls.Add(this.pnlChat);
            this.pnlChatLayout.Controls.Add(this.panel3);
            this.pnlChatLayout.Location = new System.Drawing.Point(3, 0);
            this.pnlChatLayout.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pnlChatLayout.Name = "pnlChatLayout";
            this.pnlChatLayout.Size = new System.Drawing.Size(728, 607);
            this.pnlChatLayout.TabIndex = 5;
            // 
            // pnlFriend
            // 
            this.pnlFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.pnlFriend.Controls.Add(this.lblFriend);
            this.pnlFriend.Location = new System.Drawing.Point(3, 0);
            this.pnlFriend.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pnlFriend.Name = "pnlFriend";
            this.pnlFriend.Size = new System.Drawing.Size(725, 56);
            this.pnlFriend.TabIndex = 2;
            // 
            // pnlChat
            // 
            this.pnlChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.pnlChat.Location = new System.Drawing.Point(3, 62);
            this.pnlChat.Name = "pnlChat";
            this.pnlChat.Size = new System.Drawing.Size(725, 482);
            this.pnlChat.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEnviar);
            this.panel3.Controls.Add(this.txtMensaje);
            this.panel3.Location = new System.Drawing.Point(3, 550);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(725, 46);
            this.panel3.TabIndex = 4;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(669, 3);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(53, 40);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "S";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // txtMensaje
            // 
            this.txtMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMensaje.ForeColor = System.Drawing.SystemColors.Window;
            this.txtMensaje.Location = new System.Drawing.Point(3, 3);
            this.txtMensaje.MaxLength = 32000;
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMensaje.Size = new System.Drawing.Size(660, 41);
            this.txtMensaje.TabIndex = 3;
            // 
            // lblFriend
            // 
            this.lblFriend.AutoSize = true;
            this.lblFriend.ForeColor = System.Drawing.Color.White;
            this.lblFriend.Location = new System.Drawing.Point(23, 17);
            this.lblFriend.Name = "lblFriend";
            this.lblFriend.Size = new System.Drawing.Size(44, 16);
            this.lblFriend.TabIndex = 0;
            this.lblFriend.Text = "label1";
            // 
            // ChatControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.pnlChatLayout);
            this.Name = "ChatControl";
            this.Size = new System.Drawing.Size(734, 610);
            this.pnlChatLayout.ResumeLayout(false);
            this.pnlFriend.ResumeLayout(false);
            this.pnlFriend.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlChatLayout;
        private System.Windows.Forms.Panel pnlFriend;
        private System.Windows.Forms.FlowLayoutPanel pnlChat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label lblFriend;
    }
}
