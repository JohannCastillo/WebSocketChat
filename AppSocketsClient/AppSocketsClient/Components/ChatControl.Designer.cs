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
            this.label1 = new System.Windows.Forms.Label();
            this.lblFriend = new System.Windows.Forms.Label();
            this.pnlChat = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.TextBox();
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
            this.pnlChatLayout.Location = new System.Drawing.Point(4, 0);
            this.pnlChatLayout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.pnlChatLayout.Name = "pnlChatLayout";
            this.pnlChatLayout.Size = new System.Drawing.Size(734, 604);
            this.pnlChatLayout.TabIndex = 5;
            this.pnlChatLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChatLayout_Paint);
            // 
            // pnlFriend
            // 
            this.pnlFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.pnlFriend.Controls.Add(this.label1);
            this.pnlFriend.Controls.Add(this.lblFriend);
            this.pnlFriend.Location = new System.Drawing.Point(4, 0);
            this.pnlFriend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.pnlFriend.Name = "pnlFriend";
            this.pnlFriend.Size = new System.Drawing.Size(726, 52);
            this.pnlFriend.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conversando con ";
            // 
            // lblFriend
            // 
            this.lblFriend.AutoSize = true;
            this.lblFriend.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFriend.ForeColor = System.Drawing.Color.White;
            this.lblFriend.Location = new System.Drawing.Point(194, 14);
            this.lblFriend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFriend.Name = "lblFriend";
            this.lblFriend.Size = new System.Drawing.Size(60, 19);
            this.lblFriend.TabIndex = 0;
            this.lblFriend.Text = "label1";
            // 
            // pnlChat
            // 
            this.pnlChat.AutoScroll = true;
            this.pnlChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.pnlChat.Location = new System.Drawing.Point(4, 60);
            this.pnlChat.Margin = new System.Windows.Forms.Padding(4);
            this.pnlChat.Name = "pnlChat";
            this.pnlChat.Size = new System.Drawing.Size(722, 464);
            this.pnlChat.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEnviar);
            this.panel3.Controls.Add(this.txtMensaje);
            this.panel3.Location = new System.Drawing.Point(4, 532);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(722, 60);
            this.panel3.TabIndex = 4;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(252)))), ((int)(((byte)(138)))));
            this.btnEnviar.BackgroundImage = global::AppSocketsClient.Properties.Resources.send;
            this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Location = new System.Drawing.Point(664, 3);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(55, 53);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMensaje.ForeColor = System.Drawing.SystemColors.Window;
            this.txtMensaje.Location = new System.Drawing.Point(4, 4);
            this.txtMensaje.Margin = new System.Windows.Forms.Padding(4);
            this.txtMensaje.MaxLength = 32000;
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMensaje.Size = new System.Drawing.Size(653, 53);
            this.txtMensaje.TabIndex = 3;
            this.txtMensaje.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMensaje_KeyDown);
            // 
            // ChatControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.pnlChatLayout);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChatControl";
            this.Size = new System.Drawing.Size(734, 604);
            this.Enter += new System.EventHandler(this.ChatControl_Enter);
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
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label lblFriend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnviar;
    }
}
