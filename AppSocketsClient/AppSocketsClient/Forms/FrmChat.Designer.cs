namespace AppSocketsClient.Forms
{
    partial class FrmChat
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
            this.pnlContacts = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExample = new System.Windows.Forms.Button();
            this.pnlChat = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlFriend = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBack = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlChatLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.pnlContacts.SuspendLayout();
            this.pnlBack.SuspendLayout();
            this.pnlChatLayout.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContacts
            // 
            this.pnlContacts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.pnlContacts.Controls.Add(this.btnExample);
            this.pnlContacts.Location = new System.Drawing.Point(-5, 56);
            this.pnlContacts.Name = "pnlContacts";
            this.pnlContacts.Size = new System.Drawing.Size(306, 604);
            this.pnlContacts.TabIndex = 0;
            // 
            // btnExample
            // 
            this.btnExample.Location = new System.Drawing.Point(3, 3);
            this.btnExample.Name = "btnExample";
            this.btnExample.Size = new System.Drawing.Size(303, 56);
            this.btnExample.TabIndex = 0;
            this.btnExample.Text = "Un chat";
            this.btnExample.UseVisualStyleBackColor = true;
            this.btnExample.Click += new System.EventHandler(this.btnExample_Click);
            // 
            // pnlChat
            // 
            this.pnlChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.pnlChat.Location = new System.Drawing.Point(3, 62);
            this.pnlChat.Name = "pnlChat";
            this.pnlChat.Size = new System.Drawing.Size(707, 482);
            this.pnlChat.TabIndex = 1;
            // 
            // pnlFriend
            // 
            this.pnlFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.pnlFriend.Location = new System.Drawing.Point(3, 0);
            this.pnlFriend.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pnlFriend.Name = "pnlFriend";
            this.pnlFriend.Size = new System.Drawing.Size(707, 56);
            this.pnlFriend.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.panel1.Location = new System.Drawing.Point(-5, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 56);
            this.panel1.TabIndex = 3;
            // 
            // pnlBack
            // 
            this.pnlBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.pnlBack.Controls.Add(this.pnlChatLayout);
            this.pnlBack.Controls.Add(this.label1);
            this.pnlBack.Location = new System.Drawing.Point(301, 56);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(713, 604);
            this.pnlBack.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(248, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione un chat";
            // 
            // pnlChatLayout
            // 
            this.pnlChatLayout.Controls.Add(this.pnlFriend);
            this.pnlChatLayout.Controls.Add(this.pnlChat);
            this.pnlChatLayout.Controls.Add(this.panel3);
            this.pnlChatLayout.Location = new System.Drawing.Point(0, 4);
            this.pnlChatLayout.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pnlChatLayout.Name = "pnlChatLayout";
            this.pnlChatLayout.Size = new System.Drawing.Size(704, 600);
            this.pnlChatLayout.TabIndex = 4;
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
            this.txtMensaje.Size = new System.Drawing.Size(639, 41);
            this.txtMensaje.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEnviar);
            this.panel3.Controls.Add(this.txtMensaje);
            this.panel3.Location = new System.Drawing.Point(3, 550);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(701, 46);
            this.panel3.TabIndex = 4;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(648, 3);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(50, 40);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "S";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // FrmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1013, 662);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlContacts);
            this.Controls.Add(this.pnlBack);
            this.Name = "FrmChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmChat";
            this.pnlContacts.ResumeLayout(false);
            this.pnlBack.ResumeLayout(false);
            this.pnlBack.PerformLayout();
            this.pnlChatLayout.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlContacts;
        private System.Windows.Forms.FlowLayoutPanel pnlChat;
        private System.Windows.Forms.Panel pnlFriend;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExample;
        private System.Windows.Forms.FlowLayoutPanel pnlChatLayout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtMensaje;
    }
}