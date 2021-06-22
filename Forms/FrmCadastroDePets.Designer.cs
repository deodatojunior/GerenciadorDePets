
namespace CadastroPet.Forms
{
    partial class FrmCadastroDePets
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCadastrarPet = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRacaPet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtDataNascimentoPet = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTutorPet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdadePet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomePet = new System.Windows.Forms.TextBox();
            this.txtSexoPet = new System.Windows.Forms.TextBox();
            this.txtEspeciePet = new System.Windows.Forms.TextBox();
            this.txtPortePet = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPortePet);
            this.groupBox1.Controls.Add(this.txtEspeciePet);
            this.groupBox1.Controls.Add(this.txtSexoPet);
            this.groupBox1.Controls.Add(this.btnCadastrarPet);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtRacaPet);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtDataNascimentoPet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTutorPet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIdadePet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNomePet);
            this.groupBox1.Location = new System.Drawing.Point(23, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 279);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do pet";
            // 
            // btnCadastrarPet
            // 
            this.btnCadastrarPet.BackColor = System.Drawing.Color.Lime;
            this.btnCadastrarPet.Location = new System.Drawing.Point(249, 214);
            this.btnCadastrarPet.Name = "btnCadastrarPet";
            this.btnCadastrarPet.Size = new System.Drawing.Size(127, 44);
            this.btnCadastrarPet.TabIndex = 17;
            this.btnCadastrarPet.Text = "Cadastrar pet";
            this.btnCadastrarPet.UseVisualStyleBackColor = false;
            this.btnCadastrarPet.Click += new System.EventHandler(this.btnCadastrarPet_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(424, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Porte do pet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Raça do pet";
            // 
            // txtRacaPet
            // 
            this.txtRacaPet.Location = new System.Drawing.Point(249, 167);
            this.txtRacaPet.Name = "txtRacaPet";
            this.txtRacaPet.Size = new System.Drawing.Size(124, 20);
            this.txtRacaPet.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Espécie do pet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data de nascimento do pet";
            // 
            // dtDataNascimentoPet
            // 
            this.dtDataNascimentoPet.Location = new System.Drawing.Point(309, 104);
            this.dtDataNascimentoPet.Name = "dtDataNascimentoPet";
            this.dtDataNascimentoPet.Size = new System.Drawing.Size(236, 20);
            this.dtDataNascimentoPet.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nome do tutor";
            // 
            // txtTutorPet
            // 
            this.txtTutorPet.Location = new System.Drawing.Point(50, 104);
            this.txtTutorPet.Name = "txtTutorPet";
            this.txtTutorPet.Size = new System.Drawing.Size(192, 20);
            this.txtTutorPet.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sexo do pet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Idade do pet";
            // 
            // txtIdadePet
            // 
            this.txtIdadePet.Location = new System.Drawing.Point(309, 54);
            this.txtIdadePet.Name = "txtIdadePet";
            this.txtIdadePet.Size = new System.Drawing.Size(67, 20);
            this.txtIdadePet.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do pet";
            // 
            // txtNomePet
            // 
            this.txtNomePet.Location = new System.Drawing.Point(50, 54);
            this.txtNomePet.Name = "txtNomePet";
            this.txtNomePet.Size = new System.Drawing.Size(192, 20);
            this.txtNomePet.TabIndex = 0;
            // 
            // txtSexoPet
            // 
            this.txtSexoPet.Location = new System.Drawing.Point(427, 54);
            this.txtSexoPet.Name = "txtSexoPet";
            this.txtSexoPet.Size = new System.Drawing.Size(100, 20);
            this.txtSexoPet.TabIndex = 18;
            // 
            // txtEspeciePet
            // 
            this.txtEspeciePet.Location = new System.Drawing.Point(50, 166);
            this.txtEspeciePet.Name = "txtEspeciePet";
            this.txtEspeciePet.Size = new System.Drawing.Size(137, 20);
            this.txtEspeciePet.TabIndex = 19;
            // 
            // txtPortePet
            // 
            this.txtPortePet.Location = new System.Drawing.Point(427, 166);
            this.txtPortePet.Name = "txtPortePet";
            this.txtPortePet.Size = new System.Drawing.Size(100, 20);
            this.txtPortePet.TabIndex = 20;
            // 
            // FrmCadastroDePets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 377);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCadastroDePets";
            this.Text = "Cadastrar Pet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomePet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdadePet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTutorPet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtDataNascimentoPet;
        private System.Windows.Forms.Button btnCadastrarPet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRacaPet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEspeciePet;
        private System.Windows.Forms.TextBox txtSexoPet;
        private System.Windows.Forms.TextBox txtPortePet;
    }
}