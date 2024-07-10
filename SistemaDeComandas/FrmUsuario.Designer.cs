namespace SistemaDeComandas
{
    partial class FrmUsuario
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            cyberGroupBox1 = new ReaLTaiizor.Controls.CyberGroupBox();
            dgvUsuario = new ReaLTaiizor.Controls.PoisonDataGridView();
            cyberGroupBox2 = new ReaLTaiizor.Controls.CyberGroupBox();
            btnExcluir2 = new ReaLTaiizor.Controls.CyberButton();
            btnCancelar = new ReaLTaiizor.Controls.CyberButton();
            btnSalvar = new ReaLTaiizor.Controls.CyberButton();
            btnEditar = new ReaLTaiizor.Controls.CyberButton();
            btnNovo = new ReaLTaiizor.Controls.CyberButton();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNome = new ReaLTaiizor.Controls.CyberTextBox();
            txtEmail = new ReaLTaiizor.Controls.CyberTextBox();
            txtSenha = new ReaLTaiizor.Controls.CyberTextBox();
            cyberGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            cyberGroupBox2.SuspendLayout();
            SuspendLayout();
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
            cyberGroupBox1.Controls.Add(dgvUsuario);
            cyberGroupBox1.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox1.Lighting = false;
            cyberGroupBox1.LinearGradient_Background = false;
            cyberGroupBox1.LinearGradientPen = false;
            cyberGroupBox1.Location = new Point(12, 283);
            cyberGroupBox1.Name = "cyberGroupBox1";
            cyberGroupBox1.PenWidth = 15;
            cyberGroupBox1.RGB = false;
            cyberGroupBox1.Rounding = true;
            cyberGroupBox1.RoundingInt = 60;
            cyberGroupBox1.Size = new Size(861, 237);
            cyberGroupBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox1.TabIndex = 0;
            cyberGroupBox1.Tag = "Cyber";
            cyberGroupBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox1.Timer_RGB = 300;
            // 
            // dgvUsuario
            // 
            dgvUsuario.AllowUserToResizeRows = false;
            dgvUsuario.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvUsuario.BorderStyle = BorderStyle.None;
            dgvUsuario.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvUsuario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUsuario.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuario.EnableHeadersVisualStyles = false;
            dgvUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvUsuario.GridColor = Color.FromArgb(255, 255, 255);
            dgvUsuario.Location = new Point(45, 30);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvUsuario.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuario.Size = new Size(778, 187);
            dgvUsuario.TabIndex = 0;
            // 
            // cyberGroupBox2
            // 
            cyberGroupBox2.Alpha = 20;
            cyberGroupBox2.BackColor = Color.Transparent;
            cyberGroupBox2.Background = true;
            cyberGroupBox2.Background_WidthPen = 3F;
            cyberGroupBox2.BackgroundPen = true;
            cyberGroupBox2.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberGroupBox2.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox2.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox2.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberGroupBox2.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberGroupBox2.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox2.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox2.Controls.Add(btnExcluir2);
            cyberGroupBox2.Controls.Add(btnCancelar);
            cyberGroupBox2.Controls.Add(btnSalvar);
            cyberGroupBox2.Controls.Add(btnEditar);
            cyberGroupBox2.Controls.Add(btnNovo);
            cyberGroupBox2.Controls.Add(label3);
            cyberGroupBox2.Controls.Add(label2);
            cyberGroupBox2.Controls.Add(label1);
            cyberGroupBox2.Controls.Add(txtNome);
            cyberGroupBox2.Controls.Add(txtEmail);
            cyberGroupBox2.Controls.Add(txtSenha);
            cyberGroupBox2.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox2.Font = new Font("Segoe UI", 12F);
            cyberGroupBox2.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox2.Lighting = false;
            cyberGroupBox2.LinearGradient_Background = false;
            cyberGroupBox2.LinearGradientPen = false;
            cyberGroupBox2.Location = new Point(12, 12);
            cyberGroupBox2.Name = "cyberGroupBox2";
            cyberGroupBox2.PenWidth = 15;
            cyberGroupBox2.RGB = false;
            cyberGroupBox2.Rounding = true;
            cyberGroupBox2.RoundingInt = 60;
            cyberGroupBox2.Size = new Size(861, 265);
            cyberGroupBox2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox2.TabIndex = 1;
            cyberGroupBox2.Tag = "Cyber";
            cyberGroupBox2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox2.Timer_RGB = 300;
            // 
            // btnExcluir2
            // 
            btnExcluir2.Alpha = 20;
            btnExcluir2.BackColor = Color.Transparent;
            btnExcluir2.Background = true;
            btnExcluir2.Background_WidthPen = 4F;
            btnExcluir2.BackgroundPen = true;
            btnExcluir2.ColorBackground = Color.FromArgb(37, 52, 68);
            btnExcluir2.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnExcluir2.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnExcluir2.ColorBackground_Pen = Color.FromArgb(0, 192, 192);
            btnExcluir2.ColorLighting = Color.FromArgb(29, 200, 238);
            btnExcluir2.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnExcluir2.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnExcluir2.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnExcluir2.Effect_1 = true;
            btnExcluir2.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnExcluir2.Effect_1_Transparency = 25;
            btnExcluir2.Effect_2 = true;
            btnExcluir2.Effect_2_ColorBackground = Color.White;
            btnExcluir2.Effect_2_Transparency = 20;
            btnExcluir2.Font = new Font("Arial", 11F);
            btnExcluir2.ForeColor = Color.FromArgb(245, 245, 245);
            btnExcluir2.Lighting = false;
            btnExcluir2.LinearGradient_Background = false;
            btnExcluir2.LinearGradientPen = false;
            btnExcluir2.Location = new Point(494, 204);
            btnExcluir2.Name = "btnExcluir2";
            btnExcluir2.PenWidth = 15;
            btnExcluir2.Rounding = true;
            btnExcluir2.RoundingInt = 70;
            btnExcluir2.Size = new Size(130, 44);
            btnExcluir2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnExcluir2.TabIndex = 17;
            btnExcluir2.Tag = "Cyber";
            btnExcluir2.TextButton = "Excluir";
            btnExcluir2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnExcluir2.Timer_Effect_1 = 5;
            btnExcluir2.Timer_RGB = 300;
            // 
            // btnCancelar
            // 
            btnCancelar.Alpha = 20;
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.Background = true;
            btnCancelar.Background_WidthPen = 4F;
            btnCancelar.BackgroundPen = true;
            btnCancelar.ColorBackground = Color.FromArgb(37, 52, 68);
            btnCancelar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnCancelar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnCancelar.ColorBackground_Pen = Color.FromArgb(0, 192, 192);
            btnCancelar.ColorLighting = Color.FromArgb(29, 200, 238);
            btnCancelar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnCancelar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnCancelar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnCancelar.Effect_1 = true;
            btnCancelar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnCancelar.Effect_1_Transparency = 25;
            btnCancelar.Effect_2 = true;
            btnCancelar.Effect_2_ColorBackground = Color.White;
            btnCancelar.Effect_2_Transparency = 20;
            btnCancelar.Font = new Font("Arial", 11F);
            btnCancelar.ForeColor = Color.FromArgb(245, 245, 245);
            btnCancelar.Lighting = false;
            btnCancelar.LinearGradient_Background = false;
            btnCancelar.LinearGradientPen = false;
            btnCancelar.Location = new Point(630, 204);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.PenWidth = 15;
            btnCancelar.Rounding = true;
            btnCancelar.RoundingInt = 70;
            btnCancelar.Size = new Size(130, 44);
            btnCancelar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCancelar.TabIndex = 16;
            btnCancelar.Tag = "Cyber";
            btnCancelar.TextButton = "Cancelar";
            btnCancelar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCancelar.Timer_Effect_1 = 5;
            btnCancelar.Timer_RGB = 300;
            // 
            // btnSalvar
            // 
            btnSalvar.Alpha = 20;
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.Background = true;
            btnSalvar.Background_WidthPen = 4F;
            btnSalvar.BackgroundPen = true;
            btnSalvar.ColorBackground = Color.FromArgb(37, 52, 68);
            btnSalvar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnSalvar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnSalvar.ColorBackground_Pen = Color.FromArgb(0, 192, 192);
            btnSalvar.ColorLighting = Color.FromArgb(29, 200, 238);
            btnSalvar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnSalvar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnSalvar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnSalvar.Effect_1 = true;
            btnSalvar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnSalvar.Effect_1_Transparency = 25;
            btnSalvar.Effect_2 = true;
            btnSalvar.Effect_2_ColorBackground = Color.White;
            btnSalvar.Effect_2_Transparency = 20;
            btnSalvar.Font = new Font("Arial", 11F);
            btnSalvar.ForeColor = Color.FromArgb(245, 245, 245);
            btnSalvar.Lighting = false;
            btnSalvar.LinearGradient_Background = false;
            btnSalvar.LinearGradientPen = false;
            btnSalvar.Location = new Point(358, 204);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.PenWidth = 15;
            btnSalvar.Rounding = true;
            btnSalvar.RoundingInt = 70;
            btnSalvar.Size = new Size(130, 44);
            btnSalvar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSalvar.TabIndex = 14;
            btnSalvar.Tag = "Cyber";
            btnSalvar.TextButton = "Salvar";
            btnSalvar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSalvar.Timer_Effect_1 = 5;
            btnSalvar.Timer_RGB = 300;
            btnSalvar.Click += btnSalvar_Click;
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
            btnEditar.ColorBackground_Pen = Color.FromArgb(0, 192, 192);
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
            btnEditar.Location = new Point(222, 204);
            btnEditar.Name = "btnEditar";
            btnEditar.PenWidth = 15;
            btnEditar.Rounding = true;
            btnEditar.RoundingInt = 70;
            btnEditar.Size = new Size(130, 44);
            btnEditar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnEditar.TabIndex = 12;
            btnEditar.Tag = "Cyber";
            btnEditar.TextButton = "Editar";
            btnEditar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnEditar.Timer_Effect_1 = 5;
            btnEditar.Timer_RGB = 300;
            // 
            // btnNovo
            // 
            btnNovo.Alpha = 20;
            btnNovo.BackColor = Color.Transparent;
            btnNovo.Background = true;
            btnNovo.Background_WidthPen = 4F;
            btnNovo.BackgroundPen = true;
            btnNovo.ColorBackground = Color.FromArgb(37, 52, 68);
            btnNovo.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnNovo.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnNovo.ColorBackground_Pen = Color.FromArgb(0, 192, 192);
            btnNovo.ColorLighting = Color.FromArgb(29, 200, 238);
            btnNovo.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnNovo.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnNovo.Cursor = Cursors.No;
            btnNovo.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnNovo.Effect_1 = true;
            btnNovo.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnNovo.Effect_1_Transparency = 25;
            btnNovo.Effect_2 = true;
            btnNovo.Effect_2_ColorBackground = Color.White;
            btnNovo.Effect_2_Transparency = 20;
            btnNovo.Font = new Font("Arial", 11F);
            btnNovo.ForeColor = Color.FromArgb(245, 245, 245);
            btnNovo.Lighting = false;
            btnNovo.LinearGradient_Background = false;
            btnNovo.LinearGradientPen = false;
            btnNovo.Location = new Point(86, 204);
            btnNovo.Name = "btnNovo";
            btnNovo.PenWidth = 15;
            btnNovo.RGB = true;
            btnNovo.Rounding = true;
            btnNovo.RoundingInt = 70;
            btnNovo.Size = new Size(130, 44);
            btnNovo.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnNovo.TabIndex = 11;
            btnNovo.Tag = "Cyber";
            btnNovo.TextButton = "Novo";
            btnNovo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnNovo.Timer_Effect_1 = 5;
            btnNovo.Timer_RGB = 300;
            btnNovo.Click += btnNovo_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(81, 135);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 10;
            label3.Text = "Senha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 89);
            label2.Name = "label2";
            label2.Size = new Size(51, 21);
            label2.TabIndex = 9;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 43);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 8;
            label1.Text = "Nome:";
            label1.Click += label1_Click;
            // 
            // txtNome
            // 
            txtNome.Alpha = 20;
            txtNome.BackColor = Color.Transparent;
            txtNome.Background_WidthPen = 3F;
            txtNome.BackgroundPen = true;
            txtNome.ColorBackground = Color.FromArgb(37, 52, 68);
            txtNome.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            txtNome.ColorLighting = Color.FromArgb(29, 200, 238);
            txtNome.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtNome.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtNome.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtNome.Font = new Font("Arial", 10F);
            txtNome.ForeColor = Color.FromArgb(245, 245, 245);
            txtNome.Lighting = false;
            txtNome.LinearGradientPen = false;
            txtNome.Location = new Point(222, 24);
            txtNome.Name = "txtNome";
            txtNome.PenWidth = 15;
            txtNome.RGB = false;
            txtNome.Rounding = true;
            txtNome.RoundingInt = 60;
            txtNome.Size = new Size(582, 40);
            txtNome.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtNome.TabIndex = 2;
            txtNome.Tag = "Cyber";
            txtNome.TextButton = "";
            txtNome.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtNome.Timer_RGB = 300;
            // 
            // txtEmail
            // 
            txtEmail.Alpha = 20;
            txtEmail.BackColor = Color.Transparent;
            txtEmail.Background_WidthPen = 3F;
            txtEmail.BackgroundPen = true;
            txtEmail.ColorBackground = Color.FromArgb(37, 52, 68);
            txtEmail.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            txtEmail.ColorLighting = Color.FromArgb(29, 200, 238);
            txtEmail.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtEmail.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtEmail.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtEmail.Font = new Font("Arial", 10F);
            txtEmail.ForeColor = Color.FromArgb(245, 245, 245);
            txtEmail.Lighting = false;
            txtEmail.LinearGradientPen = false;
            txtEmail.Location = new Point(222, 70);
            txtEmail.Name = "txtEmail";
            txtEmail.PenWidth = 15;
            txtEmail.RGB = false;
            txtEmail.Rounding = true;
            txtEmail.RoundingInt = 60;
            txtEmail.Size = new Size(582, 40);
            txtEmail.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtEmail.TabIndex = 1;
            txtEmail.Tag = "Cyber";
            txtEmail.TextButton = "";
            txtEmail.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtEmail.Timer_RGB = 300;
            // 
            // txtSenha
            // 
            txtSenha.Alpha = 20;
            txtSenha.BackColor = Color.Transparent;
            txtSenha.Background_WidthPen = 3F;
            txtSenha.BackgroundPen = true;
            txtSenha.ColorBackground = Color.FromArgb(37, 52, 68);
            txtSenha.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            txtSenha.ColorLighting = Color.FromArgb(29, 200, 238);
            txtSenha.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtSenha.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtSenha.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtSenha.Font = new Font("Arial", 10F);
            txtSenha.ForeColor = Color.FromArgb(245, 245, 245);
            txtSenha.Lighting = false;
            txtSenha.LinearGradientPen = false;
            txtSenha.Location = new Point(222, 116);
            txtSenha.Name = "txtSenha";
            txtSenha.Password = true;
            txtSenha.PenWidth = 15;
            txtSenha.RGB = false;
            txtSenha.Rounding = true;
            txtSenha.RoundingInt = 60;
            txtSenha.Size = new Size(417, 40);
            txtSenha.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtSenha.TabIndex = 0;
            txtSenha.Tag = "Cyber";
            txtSenha.TextButton = "";
            txtSenha.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtSenha.Timer_RGB = 300;
            txtSenha.Load += txtSenha_Load;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 532);
            Controls.Add(cyberGroupBox2);
            Controls.Add(cyberGroupBox1);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            cyberGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            cyberGroupBox2.ResumeLayout(false);
            cyberGroupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox1;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox2;
        private ReaLTaiizor.Controls.CyberTextBox txtNome;
        private ReaLTaiizor.Controls.CyberTextBox txtEmail;
        private ReaLTaiizor.Controls.CyberTextBox txtSenha;
        private ReaLTaiizor.Controls.CyberTextBox btnExcluir;
        private Label label3;
        private Label label2;
        private Label label1;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvUsuario;
        private ReaLTaiizor.Controls.CyberButton cyberButton4;
        private ReaLTaiizor.Controls.CyberButton btnSalvar;

        private ReaLTaiizor.Controls.CyberButton btnEditar;
        private ReaLTaiizor.Controls.CyberButton btnNovo;
        private ReaLTaiizor.Controls.CyberButton btnCancelar;
        private ReaLTaiizor.Controls.CyberButton btnExcluir2;
    }
}