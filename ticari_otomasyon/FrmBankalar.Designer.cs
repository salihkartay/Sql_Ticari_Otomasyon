
using System;

namespace ticari_otomasyon
{
    partial class FrmBankalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBankalar));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.comboBoxIlce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.maskedTelefon = new System.Windows.Forms.MaskedTextBox();
            this.CmbFirma = new DevExpress.XtraEditors.LabelControl();
            this.MskTarih = new DevExpress.XtraEditors.LabelControl();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.CmbIlce = new DevExpress.XtraEditors.LabelControl();
            this.CmbIl = new DevExpress.XtraEditors.LabelControl();
            this.textSube = new DevExpress.XtraEditors.TextEdit();
            this.TxtSube = new DevExpress.XtraEditors.LabelControl();
            this.TxtIBAN = new DevExpress.XtraEditors.LabelControl();
            this.MskTelefon = new DevExpress.XtraEditors.LabelControl();
            this.txtBankaAdi = new DevExpress.XtraEditors.TextEdit();
            this.TxtBankaAd = new DevExpress.XtraEditors.LabelControl();
            this.textIBAN = new System.Windows.Forms.MaskedTextBox();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.ComboBoxIl = new DevExpress.XtraEditors.ComboBoxEdit();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.maskedTarih = new System.Windows.Forms.MaskedTextBox();
            this.textHesapTürü = new DevExpress.XtraEditors.TextEdit();
            this.TxtHesapTürü = new DevExpress.XtraEditors.LabelControl();
            this.TxtYetkili = new DevExpress.XtraEditors.LabelControl();
            this.textYetkili = new System.Windows.Forms.MaskedTextBox();
            this.TxtHesapNo = new DevExpress.XtraEditors.LabelControl();
            this.textHesapNo = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSube.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxIl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textHesapTürü.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-4, -2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1670, 1062);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // comboBoxIlce
            // 
            this.comboBoxIlce.Location = new System.Drawing.Point(89, 123);
            this.comboBoxIlce.Name = "comboBoxIlce";
            this.comboBoxIlce.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxIlce.Properties.Appearance.Options.UseFont = true;
            this.comboBoxIlce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxIlce.Size = new System.Drawing.Size(112, 20);
            this.comboBoxIlce.TabIndex = 3;
            // 
            // maskedTelefon
            // 
            this.maskedTelefon.Location = new System.Drawing.Point(87, 265);
            this.maskedTelefon.Mask = "(999) 000-0000";
            this.maskedTelefon.Name = "maskedTelefon";
            this.maskedTelefon.Size = new System.Drawing.Size(112, 21);
            this.maskedTelefon.TabIndex = 8;
            this.maskedTelefon.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTelefon2_MaskInputRejected);
            // 
            // CmbFirma
            // 
            this.CmbFirma.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.CmbFirma.Appearance.Options.UseFont = true;
            this.CmbFirma.Location = new System.Drawing.Point(39, 346);
            this.CmbFirma.Name = "CmbFirma";
            this.CmbFirma.Size = new System.Drawing.Size(41, 18);
            this.CmbFirma.TabIndex = 24;
            this.CmbFirma.Text = "Firma:";
            // 
            // MskTarih
            // 
            this.MskTarih.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.MskTarih.Appearance.Options.UseFont = true;
            this.MskTarih.Location = new System.Drawing.Point(49, 292);
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(38, 18);
            this.MskTarih.TabIndex = 23;
            this.MskTarih.Text = "Tarih:";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(87, 475);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(112, 38);
            this.btnGuncelle.TabIndex = 21;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(87, 431);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(112, 38);
            this.btnSil.TabIndex = 20;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(87, 387);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(112, 38);
            this.btnKaydet.TabIndex = 19;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // CmbIlce
            // 
            this.CmbIlce.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.CmbIlce.Appearance.Options.UseFont = true;
            this.CmbIlce.Location = new System.Drawing.Point(56, 123);
            this.CmbIlce.Name = "CmbIlce";
            this.CmbIlce.Size = new System.Drawing.Size(28, 18);
            this.CmbIlce.TabIndex = 18;
            this.CmbIlce.Text = "İlçe:";
            // 
            // CmbIl
            // 
            this.CmbIl.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.CmbIl.Appearance.Options.UseFont = true;
            this.CmbIl.Location = new System.Drawing.Point(70, 99);
            this.CmbIl.Name = "CmbIl";
            this.CmbIl.Size = new System.Drawing.Size(13, 18);
            this.CmbIl.TabIndex = 15;
            this.CmbIl.Text = "İl:";
            // 
            // textSube
            // 
            this.textSube.Location = new System.Drawing.Point(89, 153);
            this.textSube.Name = "textSube";
            this.textSube.Size = new System.Drawing.Size(112, 20);
            this.textSube.TabIndex = 4;
            this.textSube.EditValueChanged += new System.EventHandler(this.textSube_EditValueChanged);
            // 
            // TxtSube
            // 
            this.TxtSube.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtSube.Appearance.Options.UseFont = true;
            this.TxtSube.Location = new System.Drawing.Point(46, 155);
            this.TxtSube.Name = "TxtSube";
            this.TxtSube.Size = new System.Drawing.Size(42, 18);
            this.TxtSube.TabIndex = 13;
            this.TxtSube.Text = "Sube: ";
            // 
            // TxtIBAN
            // 
            this.TxtIBAN.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtIBAN.Appearance.Options.UseFont = true;
            this.TxtIBAN.Location = new System.Drawing.Point(46, 186);
            this.TxtIBAN.Name = "TxtIBAN";
            this.TxtIBAN.Size = new System.Drawing.Size(39, 18);
            this.TxtIBAN.TabIndex = 11;
            this.TxtIBAN.Text = "IBAN:";
            // 
            // MskTelefon
            // 
            this.MskTelefon.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.MskTelefon.Appearance.Options.UseFont = true;
            this.MskTelefon.Location = new System.Drawing.Point(27, 268);
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(54, 18);
            this.MskTelefon.TabIndex = 8;
            this.MskTelefon.Text = "Telefon:";
            // 
            // txtBankaAdi
            // 
            this.txtBankaAdi.Location = new System.Drawing.Point(89, 67);
            this.txtBankaAdi.Name = "txtBankaAdi";
            this.txtBankaAdi.Size = new System.Drawing.Size(112, 20);
            this.txtBankaAdi.TabIndex = 1;
            // 
            // TxtBankaAd
            // 
            this.TxtBankaAd.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtBankaAd.Appearance.Options.UseFont = true;
            this.TxtBankaAd.Location = new System.Drawing.Point(19, 66);
            this.TxtBankaAd.Name = "TxtBankaAd";
            this.TxtBankaAd.Size = new System.Drawing.Size(64, 18);
            this.TxtBankaAd.TabIndex = 3;
            this.TxtBankaAd.Text = "BankaAdı:";
            // 
            // textIBAN
            // 
            this.textIBAN.Location = new System.Drawing.Point(87, 183);
            this.textIBAN.Name = "textIBAN";
            this.textIBAN.Size = new System.Drawing.Size(112, 21);
            this.textIBAN.TabIndex = 5;
            this.textIBAN.ValidatingType = typeof(int);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(89, 41);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(112, 20);
            this.txtId.TabIndex = 100;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(62, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lookUpEdit2);
            this.groupControl1.Controls.Add(this.lookUpEdit1);
            this.groupControl1.Controls.Add(this.ComboBoxIl);
            this.groupControl1.Controls.Add(this.BtnTemizle);
            this.groupControl1.Controls.Add(this.maskedTarih);
            this.groupControl1.Controls.Add(this.textHesapTürü);
            this.groupControl1.Controls.Add(this.TxtHesapTürü);
            this.groupControl1.Controls.Add(this.TxtYetkili);
            this.groupControl1.Controls.Add(this.textYetkili);
            this.groupControl1.Controls.Add(this.TxtHesapNo);
            this.groupControl1.Controls.Add(this.textHesapNo);
            this.groupControl1.Controls.Add(this.comboBoxIlce);
            this.groupControl1.Controls.Add(this.maskedTelefon);
            this.groupControl1.Controls.Add(this.CmbFirma);
            this.groupControl1.Controls.Add(this.MskTarih);
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.CmbIlce);
            this.groupControl1.Controls.Add(this.CmbIl);
            this.groupControl1.Controls.Add(this.textSube);
            this.groupControl1.Controls.Add(this.TxtSube);
            this.groupControl1.Controls.Add(this.TxtIBAN);
            this.groupControl1.Controls.Add(this.MskTelefon);
            this.groupControl1.Controls.Add(this.txtBankaAdi);
            this.groupControl1.Controls.Add(this.TxtBankaAd);
            this.groupControl1.Controls.Add(this.textIBAN);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1659, -2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(247, 747);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.Location = new System.Drawing.Point(87, 347);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.NullText = "Firma seçiniz";
            this.lookUpEdit2.Size = new System.Drawing.Size(112, 20);
            this.lookUpEdit2.TabIndex = 11;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(0, 0);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Size = new System.Drawing.Size(100, 20);
            this.lookUpEdit1.TabIndex = 40;
            // 
            // ComboBoxIl
            // 
            this.ComboBoxIl.Location = new System.Drawing.Point(89, 93);
            this.ComboBoxIl.Name = "ComboBoxIl";
            this.ComboBoxIl.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ComboBoxIl.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxIl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxIl.Size = new System.Drawing.Size(112, 20);
            this.ComboBoxIl.TabIndex = 2;
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnTemizle.Appearance.Options.UseFont = true;
            this.BtnTemizle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(87, 519);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(112, 38);
            this.BtnTemizle.TabIndex = 38;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // maskedTarih
            // 
            this.maskedTarih.Location = new System.Drawing.Point(87, 293);
            this.maskedTarih.Mask = "00/00/0000";
            this.maskedTarih.Name = "maskedTarih";
            this.maskedTarih.Size = new System.Drawing.Size(112, 21);
            this.maskedTarih.TabIndex = 9;
            this.maskedTarih.ValidatingType = typeof(System.DateTime);
            // 
            // textHesapTürü
            // 
            this.textHesapTürü.Location = new System.Drawing.Point(87, 320);
            this.textHesapTürü.Name = "textHesapTürü";
            this.textHesapTürü.Size = new System.Drawing.Size(112, 20);
            this.textHesapTürü.TabIndex = 10;
            // 
            // TxtHesapTürü
            // 
            this.TxtHesapTürü.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtHesapTürü.Appearance.Options.UseFont = true;
            this.TxtHesapTürü.Location = new System.Drawing.Point(2, 320);
            this.TxtHesapTürü.Name = "TxtHesapTürü";
            this.TxtHesapTürü.Size = new System.Drawing.Size(82, 18);
            this.TxtHesapTürü.TabIndex = 35;
            this.TxtHesapTürü.Text = "Hesap Türü:";
            // 
            // TxtYetkili
            // 
            this.TxtYetkili.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtYetkili.Appearance.Options.UseFont = true;
            this.TxtYetkili.Location = new System.Drawing.Point(42, 240);
            this.TxtYetkili.Name = "TxtYetkili";
            this.TxtYetkili.Size = new System.Drawing.Size(41, 18);
            this.TxtYetkili.TabIndex = 32;
            this.TxtYetkili.Text = "Yetkili:";
            // 
            // textYetkili
            // 
            this.textYetkili.Location = new System.Drawing.Point(89, 237);
            this.textYetkili.Name = "textYetkili";
            this.textYetkili.Size = new System.Drawing.Size(112, 21);
            this.textYetkili.TabIndex = 7;
            this.textYetkili.ValidatingType = typeof(int);
            // 
            // TxtHesapNo
            // 
            this.TxtHesapNo.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtHesapNo.Appearance.Options.UseFont = true;
            this.TxtHesapNo.Location = new System.Drawing.Point(15, 209);
            this.TxtHesapNo.Name = "TxtHesapNo";
            this.TxtHesapNo.Size = new System.Drawing.Size(69, 18);
            this.TxtHesapNo.TabIndex = 30;
            this.TxtHesapNo.Text = "Hesap No:";
            // 
            // textHesapNo
            // 
            this.textHesapNo.Location = new System.Drawing.Point(87, 210);
            this.textHesapNo.Name = "textHesapNo";
            this.textHesapNo.Size = new System.Drawing.Size(112, 21);
            this.textHesapNo.TabIndex = 6;
            this.textHesapNo.ValidatingType = typeof(int);
            // 
            // FrmBankalar
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnTemizle;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmBankalar";
            this.Text = "Bankalar";
            this.Load += new System.EventHandler(this.FrmBankalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSube.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxIl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textHesapTürü.Properties)).EndInit();
            this.ResumeLayout(false);

        }


        private void textSube_EditValueChanged(object sender, EventArgs e)
        {
            
        }
        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxIlce;
        private System.Windows.Forms.MaskedTextBox maskedTelefon;
        private DevExpress.XtraEditors.LabelControl CmbFirma;
        private DevExpress.XtraEditors.LabelControl MskTarih;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl CmbIlce;
        private DevExpress.XtraEditors.LabelControl CmbIl;
        private DevExpress.XtraEditors.TextEdit textSube;
        private DevExpress.XtraEditors.LabelControl TxtSube;
        private DevExpress.XtraEditors.LabelControl TxtIBAN;
        private DevExpress.XtraEditors.LabelControl MskTelefon;
        private DevExpress.XtraEditors.TextEdit txtBankaAdi;
        private DevExpress.XtraEditors.LabelControl TxtBankaAd;
        private System.Windows.Forms.MaskedTextBox textIBAN;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl TxtHesapNo;
        private System.Windows.Forms.MaskedTextBox textHesapNo;
        private DevExpress.XtraEditors.TextEdit textHesapTürü;
        private DevExpress.XtraEditors.LabelControl TxtHesapTürü;
        private DevExpress.XtraEditors.LabelControl TxtYetkili;
        private System.Windows.Forms.MaskedTextBox textYetkili;
        private System.Windows.Forms.MaskedTextBox maskedTarih;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
        private DevExpress.XtraEditors.ComboBoxEdit ComboBoxIl;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
    }
}