
namespace ProjetoAula02
{
    partial class FormPokemon
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
            this.lblDescricao = new System.Windows.Forms.Label();
            this.rbtCharmander = new System.Windows.Forms.RadioButton();
            this.rbtSquirtle = new System.Windows.Forms.RadioButton();
            this.rbtBulbasaur = new System.Windows.Forms.RadioButton();
            this.pictureBoxPokemon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(12, 19);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(246, 31);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Escolha seu Pokemon:";
            // 
            // rbtCharmander
            // 
            this.rbtCharmander.AutoSize = true;
            this.rbtCharmander.Checked = true;
            this.rbtCharmander.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCharmander.Location = new System.Drawing.Point(18, 64);
            this.rbtCharmander.Name = "rbtCharmander";
            this.rbtCharmander.Size = new System.Drawing.Size(119, 27);
            this.rbtCharmander.TabIndex = 1;
            this.rbtCharmander.TabStop = true;
            this.rbtCharmander.Text = "Charmander";
            this.rbtCharmander.UseVisualStyleBackColor = true;
            this.rbtCharmander.CheckedChanged += new System.EventHandler(this.rbtCharmander_CheckedChanged);
            // 
            // rbtSquirtle
            // 
            this.rbtSquirtle.AutoSize = true;
            this.rbtSquirtle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtSquirtle.Location = new System.Drawing.Point(18, 97);
            this.rbtSquirtle.Name = "rbtSquirtle";
            this.rbtSquirtle.Size = new System.Drawing.Size(88, 27);
            this.rbtSquirtle.TabIndex = 2;
            this.rbtSquirtle.Text = "Squirtle";
            this.rbtSquirtle.UseVisualStyleBackColor = true;
            this.rbtSquirtle.CheckedChanged += new System.EventHandler(this.rbtSquirtle_CheckedChanged);
            // 
            // rbtBulbasaur
            // 
            this.rbtBulbasaur.AutoSize = true;
            this.rbtBulbasaur.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtBulbasaur.Location = new System.Drawing.Point(18, 130);
            this.rbtBulbasaur.Name = "rbtBulbasaur";
            this.rbtBulbasaur.Size = new System.Drawing.Size(102, 27);
            this.rbtBulbasaur.TabIndex = 3;
            this.rbtBulbasaur.Text = "Bulbasaur";
            this.rbtBulbasaur.UseVisualStyleBackColor = true;
            this.rbtBulbasaur.CheckedChanged += new System.EventHandler(this.rbtBulbasaur_CheckedChanged);
            // 
            // pictureBoxPokemon
            // 
            this.pictureBoxPokemon.Image = global::ProjetoAula02.Properties.Resources.charmander;
            this.pictureBoxPokemon.Location = new System.Drawing.Point(195, 64);
            this.pictureBoxPokemon.Name = "pictureBoxPokemon";
            this.pictureBoxPokemon.Size = new System.Drawing.Size(475, 475);
            this.pictureBoxPokemon.TabIndex = 4;
            this.pictureBoxPokemon.TabStop = false;
            // 
            // FormPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 541);
            this.Controls.Add(this.pictureBoxPokemon);
            this.Controls.Add(this.rbtBulbasaur);
            this.Controls.Add(this.rbtSquirtle);
            this.Controls.Add(this.rbtCharmander);
            this.Controls.Add(this.lblDescricao);
            this.Name = "FormPokemon";
            this.Text = "O Programa Pokemon";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.RadioButton rbtCharmander;
        private System.Windows.Forms.RadioButton rbtSquirtle;
        private System.Windows.Forms.RadioButton rbtBulbasaur;
        private System.Windows.Forms.PictureBox pictureBoxPokemon;
    }
}

