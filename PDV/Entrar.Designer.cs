namespace PDV
{
    partial class Entrar
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrar));
            this.user = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Fechar = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).BeginInit();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.user.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.user.BorderThickness = 3;
            this.user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user.isPassword = false;
            this.user.Location = new System.Drawing.Point(13, 161);
            this.user.Margin = new System.Windows.Forms.Padding(4);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(189, 44);
            this.user.TabIndex = 1;
            this.user.Text = "Usuário";
            this.user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pass
            // 
            this.pass.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.pass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pass.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.pass.BorderThickness = 3;
            this.pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pass.isPassword = false;
            this.pass.Location = new System.Drawing.Point(13, 213);
            this.pass.Margin = new System.Windows.Forms.Padding(4);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(189, 44);
            this.pass.TabIndex = 2;
            this.pass.Text = "Senha";
            this.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PDV.Properties.Resources.Loja;
            this.pictureBox1.Location = new System.Drawing.Point(32, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.login.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login.BorderRadius = 0;
            this.login.ButtonText = "Entrar";
            this.login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login.DisabledColor = System.Drawing.Color.Gray;
            this.login.Iconcolor = System.Drawing.Color.Transparent;
            this.login.Iconimage = ((System.Drawing.Image)(resources.GetObject("login.Iconimage")));
            this.login.Iconimage_right = null;
            this.login.Iconimage_right_Selected = null;
            this.login.Iconimage_Selected = null;
            this.login.IconMarginLeft = 0;
            this.login.IconMarginRight = 0;
            this.login.IconRightVisible = true;
            this.login.IconRightZoom = 0D;
            this.login.IconVisible = true;
            this.login.IconZoom = 90D;
            this.login.IsTab = false;
            this.login.Location = new System.Drawing.Point(12, 264);
            this.login.Name = "login";
            this.login.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.login.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.login.OnHoverTextColor = System.Drawing.Color.White;
            this.login.selected = false;
            this.login.Size = new System.Drawing.Size(189, 48);
            this.login.TabIndex = 0;
            this.login.Text = "Entrar";
            this.login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.login.Textcolor = System.Drawing.Color.White;
            this.login.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Fechar
            // 
            this.Fechar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Fechar.Image = ((System.Drawing.Image)(resources.GetObject("Fechar.Image")));
            this.Fechar.ImageActive = null;
            this.Fechar.Location = new System.Drawing.Point(177, 8);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(24, 24);
            this.Fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Fechar.TabIndex = 4;
            this.Fechar.TabStop = false;
            this.Fechar.Zoom = 10;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // Entrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 327);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Entrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton login;
        private Bunifu.Framework.UI.BunifuMetroTextbox user;
        private Bunifu.Framework.UI.BunifuMetroTextbox pass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton Fechar;
    }
}

