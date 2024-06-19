namespace SistemaDeComandas
{
    partial class FrmCardapio
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
            spaceForm1 = new ReaLTaiizor.Forms.SpaceForm();
            cyberGroupBox1 = new ReaLTaiizor.Controls.CyberGroupBox();
            txtPesquisa = new ReaLTaiizor.Controls.CyberTextBox();
            btnAdicionarItem = new ReaLTaiizor.Controls.CyberButton();
            dgvCardapio = new DataGridView();
            btnExcluir = new ReaLTaiizor.Controls.CyberButton();
            btnEditar = new ReaLTaiizor.Controls.CyberButton();
            btnVoltar = new ReaLTaiizor.Controls.CyberButton();
            spaceForm1.SuspendLayout();
            cyberGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCardapio).BeginInit();
            SuspendLayout();
            // 
            // spaceForm1
            // 
            spaceForm1.BackColor = Color.FromArgb(42, 42, 42);
            spaceForm1.BorderStyle = FormBorderStyle.None;
            spaceForm1.Controls.Add(cyberGroupBox1);
            spaceForm1.Customization = "Kioq/yAgIP8qKir/Kioq/xwcHP/+/v7/Kysr/xkZGf8=";
            spaceForm1.Dock = DockStyle.Fill;
            spaceForm1.Font = new Font("Verdana", 8F);
            spaceForm1.Image = null;
            spaceForm1.Location = new Point(0, 0);
            spaceForm1.MinimumSize = new Size(200, 25);
            spaceForm1.Movable = true;
            spaceForm1.Name = "spaceForm1";
            spaceForm1.NoRounding = false;
            spaceForm1.Padding = new Padding(5, 25, 5, 5);
            spaceForm1.Sizable = true;
            spaceForm1.Size = new Size(847, 613);
            spaceForm1.SmartBounds = true;
            spaceForm1.StartPosition = FormStartPosition.WindowsDefaultLocation;
            spaceForm1.TabIndex = 0;
            spaceForm1.Text = "spaceForm1";
            spaceForm1.TransparencyKey = Color.Purple;
            spaceForm1.Transparent = false;
            spaceForm1.Click += spaceForm1_Click;
            // 
            // cyberGroupBox1
            // 
            cyberGroupBox1.Alpha = 20;
            cyberGroupBox1.BackColor = Color.Transparent;
            cyberGroupBox1.Background = true;
            cyberGroupBox1.Background_WidthPen = 3F;
            cyberGroupBox1.BackgroundPen = true;
            cyberGroupBox1.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberGroupBox1.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox1.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberGroupBox1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberGroupBox1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox1.Controls.Add(btnVoltar);
            cyberGroupBox1.Controls.Add(btnEditar);
            cyberGroupBox1.Controls.Add(btnExcluir);
            cyberGroupBox1.Controls.Add(dgvCardapio);
            cyberGroupBox1.Controls.Add(btnAdicionarItem);
            cyberGroupBox1.Controls.Add(txtPesquisa);
            cyberGroupBox1.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox1.Lighting = false;
            cyberGroupBox1.LinearGradient_Background = false;
            cyberGroupBox1.LinearGradientPen = false;
            cyberGroupBox1.Location = new Point(12, 40);
            cyberGroupBox1.Name = "cyberGroupBox1";
            cyberGroupBox1.PenWidth = 15;
            cyberGroupBox1.RGB = false;
            cyberGroupBox1.Rounding = true;
            cyberGroupBox1.RoundingInt = 60;
            cyberGroupBox1.Size = new Size(823, 561);
            cyberGroupBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox1.TabIndex = 0;
            cyberGroupBox1.Tag = "Cyber";
            cyberGroupBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox1.Timer_RGB = 300;
            cyberGroupBox1.Load += cyberGroupBox1_Load;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Alpha = 20;
            txtPesquisa.BackColor = Color.Transparent;
            txtPesquisa.Background_WidthPen = 3F;
            txtPesquisa.BackgroundPen = true;
            txtPesquisa.ColorBackground = Color.FromArgb(37, 52, 68);
            txtPesquisa.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            txtPesquisa.ColorLighting = Color.FromArgb(29, 200, 238);
            txtPesquisa.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtPesquisa.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtPesquisa.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtPesquisa.Font = new Font("Arial", 12F);
            txtPesquisa.ForeColor = Color.FromArgb(245, 245, 245);
            txtPesquisa.Lighting = false;
            txtPesquisa.LinearGradientPen = false;
            txtPesquisa.Location = new Point(62, 65);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PenWidth = 15;
            txtPesquisa.RGB = false;
            txtPesquisa.Rounding = true;
            txtPesquisa.RoundingInt = 60;
            txtPesquisa.Size = new Size(691, 50);
            txtPesquisa.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtPesquisa.TabIndex = 0;
            txtPesquisa.Tag = "Cyber";
            txtPesquisa.TextButton = "";
            txtPesquisa.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtPesquisa.Timer_RGB = 300;
            // 
            // btnAdicionarItem
            // 
            btnAdicionarItem.Alpha = 20;
            btnAdicionarItem.BackColor = Color.Transparent;
            btnAdicionarItem.Background = true;
            btnAdicionarItem.Background_WidthPen = 4F;
            btnAdicionarItem.BackgroundPen = true;
            btnAdicionarItem.ColorBackground = Color.FromArgb(37, 52, 68);
            btnAdicionarItem.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnAdicionarItem.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnAdicionarItem.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnAdicionarItem.ColorLighting = Color.FromArgb(29, 200, 238);
            btnAdicionarItem.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnAdicionarItem.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnAdicionarItem.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnAdicionarItem.Effect_1 = true;
            btnAdicionarItem.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnAdicionarItem.Effect_1_Transparency = 25;
            btnAdicionarItem.Effect_2 = true;
            btnAdicionarItem.Effect_2_ColorBackground = Color.White;
            btnAdicionarItem.Effect_2_Transparency = 20;
            btnAdicionarItem.Font = new Font("Arial", 11F);
            btnAdicionarItem.ForeColor = Color.FromArgb(245, 245, 245);
            btnAdicionarItem.Lighting = false;
            btnAdicionarItem.LinearGradient_Background = false;
            btnAdicionarItem.LinearGradientPen = false;
            btnAdicionarItem.Location = new Point(62, 121);
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.PenWidth = 15;
            btnAdicionarItem.Rounding = true;
            btnAdicionarItem.RoundingInt = 70;
            btnAdicionarItem.Size = new Size(130, 50);
            btnAdicionarItem.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnAdicionarItem.TabIndex = 1;
            btnAdicionarItem.Tag = "Cyber";
            btnAdicionarItem.TextButton = "+ Item Cardápio";
            btnAdicionarItem.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnAdicionarItem.Timer_Effect_1 = 5;
            btnAdicionarItem.Timer_RGB = 300;
            // 
            // dgvCardapio
            // 
            dgvCardapio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCardapio.Location = new Point(62, 177);
            dgvCardapio.Name = "dgvCardapio";
            dgvCardapio.Size = new Size(691, 296);
            dgvCardapio.TabIndex = 2;
            dgvCardapio.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnExcluir
            // 
            btnExcluir.Alpha = 20;
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.Background = true;
            btnExcluir.Background_WidthPen = 4F;
            btnExcluir.BackgroundPen = true;
            btnExcluir.ColorBackground = Color.FromArgb(37, 52, 68);
            btnExcluir.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnExcluir.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnExcluir.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnExcluir.ColorLighting = Color.FromArgb(29, 200, 238);
            btnExcluir.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnExcluir.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnExcluir.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnExcluir.Effect_1 = true;
            btnExcluir.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnExcluir.Effect_1_Transparency = 25;
            btnExcluir.Effect_2 = true;
            btnExcluir.Effect_2_ColorBackground = Color.White;
            btnExcluir.Effect_2_Transparency = 20;
            btnExcluir.Font = new Font("Arial", 11F);
            btnExcluir.ForeColor = Color.FromArgb(245, 245, 245);
            btnExcluir.Lighting = false;
            btnExcluir.LinearGradient_Background = false;
            btnExcluir.LinearGradientPen = false;
            btnExcluir.Location = new Point(435, 479);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.PenWidth = 15;
            btnExcluir.Rounding = true;
            btnExcluir.RoundingInt = 70;
            btnExcluir.Size = new Size(156, 43);
            btnExcluir.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnExcluir.TabIndex = 3;
            btnExcluir.Tag = "Cyber";
            btnExcluir.TextButton = "X  Excluir  ";
            btnExcluir.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnExcluir.Timer_Effect_1 = 5;
            btnExcluir.Timer_RGB = 300;
            // 
            // btnEditar
            // 
            btnEditar.Alpha = 20;
            btnEditar.BackColor = Color.Transparent;
            btnEditar.Background = true;
            btnEditar.Background_WidthPen = 4F;
            btnEditar.BackgroundPen = true;
            btnEditar.ColorBackground = Color.FromArgb(37, 52, 68);
            btnEditar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnEditar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnEditar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnEditar.ColorLighting = Color.FromArgb(29, 200, 238);
            btnEditar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnEditar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnEditar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnEditar.Effect_1 = true;
            btnEditar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnEditar.Effect_1_Transparency = 25;
            btnEditar.Effect_2 = true;
            btnEditar.Effect_2_ColorBackground = Color.White;
            btnEditar.Effect_2_Transparency = 20;
            btnEditar.Font = new Font("Arial", 11F);
            btnEditar.ForeColor = Color.FromArgb(245, 245, 245);
            btnEditar.Lighting = false;
            btnEditar.LinearGradient_Background = false;
            btnEditar.LinearGradientPen = false;
            btnEditar.Location = new Point(597, 479);
            btnEditar.Name = "btnEditar";
            btnEditar.PenWidth = 15;
            btnEditar.Rounding = true;
            btnEditar.RoundingInt = 70;
            btnEditar.Size = new Size(156, 43);
            btnEditar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnEditar.TabIndex = 4;
            btnEditar.Tag = "Cyber";
            btnEditar.TextButton = "# Editar";
            btnEditar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnEditar.Timer_Effect_1 = 5;
            btnEditar.Timer_RGB = 300;
            // 
            // btnVoltar
            // 
            btnVoltar.Alpha = 20;
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.Background = true;
            btnVoltar.Background_WidthPen = 4F;
            btnVoltar.BackgroundPen = true;
            btnVoltar.ColorBackground = Color.FromArgb(37, 52, 68);
            btnVoltar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnVoltar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnVoltar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnVoltar.ColorLighting = Color.FromArgb(29, 200, 238);
            btnVoltar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnVoltar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnVoltar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnVoltar.Effect_1 = true;
            btnVoltar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnVoltar.Effect_1_Transparency = 25;
            btnVoltar.Effect_2 = true;
            btnVoltar.Effect_2_ColorBackground = Color.White;
            btnVoltar.Effect_2_Transparency = 20;
            btnVoltar.Font = new Font("Arial", 11F);
            btnVoltar.ForeColor = Color.FromArgb(245, 245, 245);
            btnVoltar.Lighting = false;
            btnVoltar.LinearGradient_Background = false;
            btnVoltar.LinearGradientPen = false;
            btnVoltar.Location = new Point(62, 479);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.PenWidth = 15;
            btnVoltar.Rounding = true;
            btnVoltar.RoundingInt = 70;
            btnVoltar.Size = new Size(156, 43);
            btnVoltar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnVoltar.TabIndex = 5;
            btnVoltar.Tag = "Cyber";
            btnVoltar.TextButton = "<- Voltar";
            btnVoltar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnVoltar.Timer_Effect_1 = 5;
            btnVoltar.Timer_RGB = 300;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FrmCardapio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 613);
            Controls.Add(spaceForm1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapio";
            Text = "FrmCardapio";
            TransparencyKey = Color.Purple;
            spaceForm1.ResumeLayout(false);
            cyberGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCardapio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.SpaceForm spaceForm1;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox1;
        private ReaLTaiizor.Controls.CyberTextBox txtPesquisa;
        private ReaLTaiizor.Controls.CyberButton btnAdicionarItem;
        private ReaLTaiizor.Controls.CyberButton btnEditar;
        private ReaLTaiizor.Controls.CyberButton btnExcluir;
        private DataGridView dgvCardapio;
        private ReaLTaiizor.Controls.CyberButton btnVoltar;
    }
}