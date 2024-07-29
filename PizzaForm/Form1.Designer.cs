namespace PizzaForm
{
    partial class Form1
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
            this.lblWayToPay = new System.Windows.Forms.Label();
            this.lblSandwiches = new System.Windows.Forms.Label();
            this.rbcash = new System.Windows.Forms.RadioButton();
            this.rbCard = new System.Windows.Forms.RadioButton();
            this.comboBoxSandwiches = new System.Windows.Forms.ComboBox();
            this.labelSupplements = new System.Windows.Forms.Label();
            this.checkBoxTomatoSos = new System.Windows.Forms.CheckBox();
            this.checkBoxMustaard = new System.Windows.Forms.CheckBox();
            this.checkBoxMayones = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelFinalSum = new System.Windows.Forms.Label();
            this.buttonPay = new System.Windows.Forms.Button();
            this.textBoxClientPayment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWayToPay
            // 
            this.lblWayToPay.AutoSize = true;
            this.lblWayToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWayToPay.Location = new System.Drawing.Point(36, 323);
            this.lblWayToPay.Name = "lblWayToPay";
            this.lblWayToPay.Size = new System.Drawing.Size(188, 20);
            this.lblWayToPay.TabIndex = 0;
            this.lblWayToPay.Text = "Начин на плащане:";
            // 
            // lblSandwiches
            // 
            this.lblSandwiches.AutoSize = true;
            this.lblSandwiches.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSandwiches.Location = new System.Drawing.Point(37, 54);
            this.lblSandwiches.Name = "lblSandwiches";
            this.lblSandwiches.Size = new System.Drawing.Size(107, 20);
            this.lblSandwiches.TabIndex = 1;
            this.lblSandwiches.Text = "Сандвичи:";
            this.lblSandwiches.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSandwiches.Click += new System.EventHandler(this.label2_Click);
            // 
            // rbcash
            // 
            this.rbcash.AutoSize = true;
            this.rbcash.Location = new System.Drawing.Point(39, 357);
            this.rbcash.Name = "rbcash";
            this.rbcash.Size = new System.Drawing.Size(63, 20);
            this.rbcash.TabIndex = 2;
            this.rbcash.TabStop = true;
            this.rbcash.Text = "в кеш";
            this.rbcash.UseVisualStyleBackColor = true;
            this.rbcash.CheckedChanged += new System.EventHandler(this.rbcash_CheckedChanged);
            // 
            // rbCard
            // 
            this.rbCard.AutoSize = true;
            this.rbCard.Location = new System.Drawing.Point(39, 383);
            this.rbCard.Name = "rbCard";
            this.rbCard.Size = new System.Drawing.Size(76, 20);
            this.rbCard.TabIndex = 3;
            this.rbCard.TabStop = true;
            this.rbCard.Text = "с карта";
            this.rbCard.UseVisualStyleBackColor = true;
            this.rbCard.CheckedChanged += new System.EventHandler(this.rbCard_CheckedChanged);
            // 
            // comboBoxSandwiches
            // 
            this.comboBoxSandwiches.FormattingEnabled = true;
            this.comboBoxSandwiches.Items.AddRange(new object[] {
            "Сандвич с домат",
            "Сандвич с шунка",
            "Сандвич с пушено",
            "Сандвич с телешко"});
            this.comboBoxSandwiches.Location = new System.Drawing.Point(171, 50);
            this.comboBoxSandwiches.Name = "comboBoxSandwiches";
            this.comboBoxSandwiches.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSandwiches.TabIndex = 4;
            this.comboBoxSandwiches.SelectedIndexChanged += new System.EventHandler(this.comboBoxSandwiches_SelectedIndexChanged);
            // 
            // labelSupplements
            // 
            this.labelSupplements.AutoSize = true;
            this.labelSupplements.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSupplements.Location = new System.Drawing.Point(37, 111);
            this.labelSupplements.Name = "labelSupplements";
            this.labelSupplements.Size = new System.Drawing.Size(94, 20);
            this.labelSupplements.TabIndex = 5;
            this.labelSupplements.Text = "Добавки:";
            // 
            // checkBoxTomatoSos
            // 
            this.checkBoxTomatoSos.AutoSize = true;
            this.checkBoxTomatoSos.Location = new System.Drawing.Point(39, 151);
            this.checkBoxTomatoSos.Name = "checkBoxTomatoSos";
            this.checkBoxTomatoSos.Size = new System.Drawing.Size(76, 20);
            this.checkBoxTomatoSos.TabIndex = 6;
            this.checkBoxTomatoSos.Text = "Кетчуп";
            this.checkBoxTomatoSos.UseVisualStyleBackColor = true;
            this.checkBoxTomatoSos.CheckedChanged += new System.EventHandler(this.checkBoxTomatoSos_CheckedChanged);
            // 
            // checkBoxMustaard
            // 
            this.checkBoxMustaard.AutoSize = true;
            this.checkBoxMustaard.Location = new System.Drawing.Point(39, 177);
            this.checkBoxMustaard.Name = "checkBoxMustaard";
            this.checkBoxMustaard.Size = new System.Drawing.Size(84, 20);
            this.checkBoxMustaard.TabIndex = 7;
            this.checkBoxMustaard.Text = "Горчица";
            this.checkBoxMustaard.UseVisualStyleBackColor = true;
            // 
            // checkBoxMayones
            // 
            this.checkBoxMayones.AutoSize = true;
            this.checkBoxMayones.Location = new System.Drawing.Point(40, 203);
            this.checkBoxMayones.Name = "checkBoxMayones";
            this.checkBoxMayones.Size = new System.Drawing.Size(96, 20);
            this.checkBoxMayones.TabIndex = 8;
            this.checkBoxMayones.Text = "Майонеза";
            this.checkBoxMayones.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PizzaForm.Properties.Resources.shunka;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(556, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(603, 327);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(0, 16);
            this.labelSum.TabIndex = 10;
            // 
            // labelFinalSum
            // 
            this.labelFinalSum.AutoSize = true;
            this.labelFinalSum.Location = new System.Drawing.Point(494, 327);
            this.labelFinalSum.Name = "labelFinalSum";
            this.labelFinalSum.Size = new System.Drawing.Size(93, 16);
            this.labelFinalSum.TabIndex = 11;
            this.labelFinalSum.Text = "Крайна сума:";
            // 
            // buttonPay
            // 
            this.buttonPay.Location = new System.Drawing.Point(528, 295);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(75, 23);
            this.buttonPay.TabIndex = 12;
            this.buttonPay.Text = "Плати";
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // textBoxClientPayment
            // 
            this.textBoxClientPayment.Location = new System.Drawing.Point(650, 296);
            this.textBoxClientPayment.Name = "textBoxClientPayment";
            this.textBoxClientPayment.Size = new System.Drawing.Size(100, 22);
            this.textBoxClientPayment.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 512);
            this.Controls.Add(this.textBoxClientPayment);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.labelFinalSum);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBoxMayones);
            this.Controls.Add(this.checkBoxMustaard);
            this.Controls.Add(this.checkBoxTomatoSos);
            this.Controls.Add(this.labelSupplements);
            this.Controls.Add(this.comboBoxSandwiches);
            this.Controls.Add(this.rbCard);
            this.Controls.Add(this.rbcash);
            this.Controls.Add(this.lblSandwiches);
            this.Controls.Add(this.lblWayToPay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWayToPay;
        private System.Windows.Forms.Label lblSandwiches;
        private System.Windows.Forms.RadioButton rbcash;
        private System.Windows.Forms.RadioButton rbCard;
        private System.Windows.Forms.ComboBox comboBoxSandwiches;
        private System.Windows.Forms.Label labelSupplements;
        private System.Windows.Forms.CheckBox checkBoxTomatoSos;
        private System.Windows.Forms.CheckBox checkBoxMustaard;
        private System.Windows.Forms.CheckBox checkBoxMayones;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelFinalSum;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.TextBox textBoxClientPayment;
    }
}

