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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCancelar = new ReaLTaiizor.Controls.CyberTextBox();
            btnExcluir = new ReaLTaiizor.Controls.CyberTextBox();
            btnNovo = new ReaLTaiizor.Controls.CyberTextBox();
            btnEditar = new ReaLTaiizor.Controls.CyberTextBox();
            btnSalvar = new ReaLTaiizor.Controls.CyberTextBox();
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
            cyberGroupBox2.Controls.Add(label3);
            cyberGroupBox2.Controls.Add(label2);
            cyberGroupBox2.Controls.Add(label1);
            cyberGroupBox2.Controls.Add(btnCancelar);
            cyberGroupBox2.Controls.Add(btnExcluir);
            cyberGroupBox2.Controls.Add(btnNovo);
            cyberGroupBox2.Controls.Add(btnEditar);
            cyberGroupBox2.Controls.Add(btnSalvar);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(81, 135);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 10;
            label3.Text = "Senha:";
            label3.Click += label3_Click;
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
            // btnCancelar
            // 
            btnCancelar.Alpha = 20;
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.Background_WidthPen = 3F;
            btnCancelar.BackgroundPen = true;
            btnCancelar.ColorBackground = Color.FromArgb(37, 52, 68);
            btnCancelar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnCancelar.ColorLighting = Color.FromArgb(29, 200, 238);
            btnCancelar.ColorPen_1 = Color.FromArgb(29, 200, 238);
            btnCancelar.ColorPen_2 = Color.FromArgb(37, 52, 68);
            btnCancelar.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnCancelar.Font = new Font("Arial", 11F);
            btnCancelar.ForeColor = Color.FromArgb(245, 245, 245);
            btnCancelar.Lighting = false;
            btnCancelar.LinearGradientPen = false;
            btnCancelar.Location = new Point(645, 205);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.PenWidth = 15;
            btnCancelar.RGB = false;
            btnCancelar.Rounding = true;
            btnCancelar.RoundingInt = 60;
            btnCancelar.Size = new Size(135, 44);
            btnCancelar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCancelar.TabIndex = 7;
            btnCancelar.Tag = "Cyber";
            btnCancelar.TextButton = "Cancelar";
            btnCancelar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCancelar.Timer_RGB = 300;
            // 
            // btnExcluir
            // 
            btnExcluir.Alpha = 20;
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.Background_WidthPen = 3F;
            btnExcluir.BackgroundPen = true;
            btnExcluir.ColorBackground = Color.FromArgb(37, 52, 68);
            btnExcluir.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnExcluir.ColorLighting = Color.FromArgb(29, 200, 238);
            btnExcluir.ColorPen_1 = Color.FromArgb(29, 200, 238);
            btnExcluir.ColorPen_2 = Color.FromArgb(37, 52, 68);
            btnExcluir.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnExcluir.Font = new Font("Arial", 11F);
            btnExcluir.ForeColor = Color.FromArgb(245, 245, 245);
            btnExcluir.Lighting = false;
            btnExcluir.LinearGradientPen = false;
            btnExcluir.Location = new Point(504, 205);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.PenWidth = 15;
            btnExcluir.RGB = false;
            btnExcluir.Rounding = true;
            btnExcluir.RoundingInt = 60;
            btnExcluir.Size = new Size(135, 44);
            btnExcluir.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnExcluir.TabIndex = 6;
            btnExcluir.Tag = "Cyber";
            btnExcluir.TextButton = "Excluir";
            btnExcluir.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnExcluir.Timer_RGB = 300;
            // 
            // btnNovo
            // 
            btnNovo.Alpha = 20;
            btnNovo.BackColor = Color.Transparent;
            btnNovo.Background_WidthPen = 3F;
            btnNovo.BackgroundPen = true;
            btnNovo.ColorBackground = Color.FromArgb(37, 52, 68);
            btnNovo.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnNovo.ColorLighting = Color.FromArgb(29, 200, 238);
            btnNovo.ColorPen_1 = Color.FromArgb(29, 200, 238);
            btnNovo.ColorPen_2 = Color.FromArgb(37, 52, 68);
            btnNovo.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnNovo.Font = new Font("Arial", 11F);
            btnNovo.ForeColor = Color.FromArgb(245, 245, 245);
            btnNovo.Lighting = false;
            btnNovo.LinearGradientPen = false;
            btnNovo.Location = new Point(81, 205);
            btnNovo.Name = "btnNovo";
            btnNovo.PenWidth = 15;
            btnNovo.RGB = false;
            btnNovo.Rounding = true;
            btnNovo.RoundingInt = 60;
            btnNovo.Size = new Size(135, 44);
            btnNovo.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnNovo.TabIndex = 5;
            btnNovo.Tag = "Cyber";
            btnNovo.TextButton = "Novo";
            btnNovo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnNovo.Timer_RGB = 300;
            btnNovo.Load += cyberTextBox6_Load;
            // 
            // btnEditar
            // 
            btnEditar.Alpha = 20;
            btnEditar.BackColor = Color.Transparent;
            btnEditar.Background_WidthPen = 3F;
            btnEditar.BackgroundPen = true;
            btnEditar.ColorBackground = Color.FromArgb(37, 52, 68);
            btnEditar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnEditar.ColorLighting = Color.FromArgb(29, 200, 238);
            btnEditar.ColorPen_1 = Color.FromArgb(29, 200, 238);
            btnEditar.ColorPen_2 = Color.FromArgb(37, 52, 68);
            btnEditar.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnEditar.Font = new Font("Arial", 11F);
            btnEditar.ForeColor = Color.FromArgb(245, 245, 245);
            btnEditar.Lighting = false;
            btnEditar.LinearGradientPen = false;
            btnEditar.Location = new Point(222, 205);
            btnEditar.Name = "btnEditar";
            btnEditar.PenWidth = 15;
            btnEditar.RGB = false;
            btnEditar.Rounding = true;
            btnEditar.RoundingInt = 60;
            btnEditar.Size = new Size(135, 44);
            btnEditar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnEditar.TabIndex = 4;
            btnEditar.Tag = "Cyber";
            btnEditar.TextButton = "Editar";
            btnEditar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnEditar.Timer_RGB = 300;
            // 
            // btnSalvar
            // 
            btnSalvar.Alpha = 20;
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.Background_WidthPen = 3F;
            btnSalvar.BackgroundPen = true;
            btnSalvar.ColorBackground = Color.FromArgb(37, 52, 68);
            btnSalvar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnSalvar.ColorLighting = Color.FromArgb(29, 200, 238);
            btnSalvar.ColorPen_1 = Color.FromArgb(29, 200, 238);
            btnSalvar.ColorPen_2 = Color.FromArgb(37, 52, 68);
            btnSalvar.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnSalvar.Font = new Font("Arial", 11F);
            btnSalvar.ForeColor = Color.FromArgb(245, 245, 245);
            btnSalvar.Lighting = false;
            btnSalvar.LinearGradientPen = false;
            btnSalvar.Location = new Point(363, 205);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.PenWidth = 15;
            btnSalvar.RGB = false;
            btnSalvar.Rounding = true;
            btnSalvar.RoundingInt = 60;
            btnSalvar.Size = new Size(135, 44);
            btnSalvar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSalvar.TabIndex = 3;
            btnSalvar.Tag = "Cyber";
            btnSalvar.TextButton = "Salvar";
            btnSalvar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSalvar.Timer_RGB = 300;
            btnSalvar.Load += btnSalvar_Load;
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
        private ReaLTaiizor.Controls.CyberTextBox btnNovo;
        private ReaLTaiizor.Controls.CyberTextBox btnEditar;
        private ReaLTaiizor.Controls.CyberTextBox btnSalvar;
        private ReaLTaiizor.Controls.CyberTextBox btnExcluir;
        private ReaLTaiizor.Controls.CyberTextBox btnCancelar;
        private Label label3;
        private Label label2;
        private Label label1;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvUsuario;
    }
}