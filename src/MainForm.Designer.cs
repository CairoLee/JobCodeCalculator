namespace JobCodeCalculator
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbNovice = new System.Windows.Forms.GroupBox();
            this.cbNovice = new System.Windows.Forms.CheckBox();
            this.gbMerchant = new System.Windows.Forms.GroupBox();
            this.cbAlchemist = new System.Windows.Forms.CheckBox();
            this.cbBlacksmith = new System.Windows.Forms.CheckBox();
            this.cbMerchant = new System.Windows.Forms.CheckBox();
            this.gbThief = new System.Windows.Forms.GroupBox();
            this.cbRogue = new System.Windows.Forms.CheckBox();
            this.cbAssassin = new System.Windows.Forms.CheckBox();
            this.cbThief = new System.Windows.Forms.CheckBox();
            this.gbTaekwon = new System.Windows.Forms.GroupBox();
            this.cbSoulLinker = new System.Windows.Forms.CheckBox();
            this.cbStarGladiator = new System.Windows.Forms.CheckBox();
            this.cbTaekwon = new System.Windows.Forms.CheckBox();
            this.gbNinja = new System.Windows.Forms.GroupBox();
            this.cbKagerouOboro = new System.Windows.Forms.CheckBox();
            this.cbNinja = new System.Windows.Forms.CheckBox();
            this.gbGunslinger = new System.Windows.Forms.GroupBox();
            this.cbRebellion = new System.Windows.Forms.CheckBox();
            this.cbGunslinger = new System.Windows.Forms.CheckBox();
            this.gbSwordman = new System.Windows.Forms.GroupBox();
            this.cbCrusader = new System.Windows.Forms.CheckBox();
            this.cbKnight = new System.Windows.Forms.CheckBox();
            this.cbSwordman = new System.Windows.Forms.CheckBox();
            this.gbMagician = new System.Windows.Forms.GroupBox();
            this.cbSage = new System.Windows.Forms.CheckBox();
            this.cbWizard = new System.Windows.Forms.CheckBox();
            this.cbMagician = new System.Windows.Forms.CheckBox();
            this.gbArcher = new System.Windows.Forms.GroupBox();
            this.cbBardDancer = new System.Windows.Forms.CheckBox();
            this.cbHunter = new System.Windows.Forms.CheckBox();
            this.cbArcher = new System.Windows.Forms.CheckBox();
            this.gbAcolyte = new System.Windows.Forms.GroupBox();
            this.cbMonk = new System.Windows.Forms.CheckBox();
            this.cbPriest = new System.Windows.Forms.CheckBox();
            this.cbAcolyte = new System.Windows.Forms.CheckBox();
            this.gbCodeEditer = new System.Windows.Forms.GroupBox();
            this.btnWhyNoHaveExtendJob = new System.Windows.Forms.Button();
            this.lbReset = new System.Windows.Forms.LinkLabel();
            this.lbSelectAll = new System.Windows.Forms.LinkLabel();
            this.lbCopy = new System.Windows.Forms.LinkLabel();
            this.lbTips = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDoram = new System.Windows.Forms.GroupBox();
            this.cbSummoner = new System.Windows.Forms.CheckBox();
            this.tipstimer = new System.Windows.Forms.Timer(this.components);
            this.gbNovice.SuspendLayout();
            this.gbMerchant.SuspendLayout();
            this.gbThief.SuspendLayout();
            this.gbTaekwon.SuspendLayout();
            this.gbNinja.SuspendLayout();
            this.gbGunslinger.SuspendLayout();
            this.gbSwordman.SuspendLayout();
            this.gbMagician.SuspendLayout();
            this.gbArcher.SuspendLayout();
            this.gbAcolyte.SuspendLayout();
            this.gbCodeEditer.SuspendLayout();
            this.gbDoram.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNovice
            // 
            this.gbNovice.Controls.Add(this.cbNovice);
            this.gbNovice.Location = new System.Drawing.Point(13, 78);
            this.gbNovice.Name = "gbNovice";
            this.gbNovice.Size = new System.Drawing.Size(240, 52);
            this.gbNovice.TabIndex = 1;
            this.gbNovice.TabStop = false;
            this.gbNovice.Text = "初学者系列";
            // 
            // cbNovice
            // 
            this.cbNovice.AutoSize = true;
            this.cbNovice.Location = new System.Drawing.Point(16, 21);
            this.cbNovice.Name = "cbNovice";
            this.cbNovice.Size = new System.Drawing.Size(126, 16);
            this.cbNovice.TabIndex = 0;
            this.cbNovice.Tag = "0x00000001";
            this.cbNovice.Text = "初学者/超级初学者";
            this.cbNovice.UseVisualStyleBackColor = true;
            this.cbNovice.CheckedChanged += new System.EventHandler(this.cbAsgard_CheckedChanged);
            // 
            // gbMerchant
            // 
            this.gbMerchant.Controls.Add(this.cbAlchemist);
            this.gbMerchant.Controls.Add(this.cbBlacksmith);
            this.gbMerchant.Controls.Add(this.cbMerchant);
            this.gbMerchant.Location = new System.Drawing.Point(260, 78);
            this.gbMerchant.Name = "gbMerchant";
            this.gbMerchant.Size = new System.Drawing.Size(240, 52);
            this.gbMerchant.TabIndex = 2;
            this.gbMerchant.TabStop = false;
            this.gbMerchant.Text = "商人系列";
            // 
            // cbAlchemist
            // 
            this.cbAlchemist.AutoSize = true;
            this.cbAlchemist.Location = new System.Drawing.Point(156, 21);
            this.cbAlchemist.Name = "cbAlchemist";
            this.cbAlchemist.Size = new System.Drawing.Size(72, 16);
            this.cbAlchemist.TabIndex = 2;
            this.cbAlchemist.Tag = "0x00040000";
            this.cbAlchemist.Text = "炼金术师";
            this.cbAlchemist.UseVisualStyleBackColor = true;
            this.cbAlchemist.CheckedChanged += new System.EventHandler(this.cbAsgard_CheckedChanged);
            // 
            // cbBlacksmith
            // 
            this.cbBlacksmith.AutoSize = true;
            this.cbBlacksmith.Location = new System.Drawing.Point(87, 21);
            this.cbBlacksmith.Name = "cbBlacksmith";
            this.cbBlacksmith.Size = new System.Drawing.Size(48, 16);
            this.cbBlacksmith.TabIndex = 1;
            this.cbBlacksmith.Tag = "0x00000400";
            this.cbBlacksmith.Text = "铁匠";
            this.cbBlacksmith.UseVisualStyleBackColor = true;
            this.cbBlacksmith.CheckedChanged += new System.EventHandler(this.cbAsgard_CheckedChanged);
            // 
            // cbMerchant
            // 
            this.cbMerchant.AutoSize = true;
            this.cbMerchant.Location = new System.Drawing.Point(16, 21);
            this.cbMerchant.Name = "cbMerchant";
            this.cbMerchant.Size = new System.Drawing.Size(48, 16);
            this.cbMerchant.TabIndex = 0;
            this.cbMerchant.Tag = "0x00000020";
            this.cbMerchant.Text = "商人";
            this.cbMerchant.UseVisualStyleBackColor = true;
            this.cbMerchant.CheckedChanged += new System.EventHandler(this.cbAsgard_CheckedChanged);
            // 
            // gbThief
            // 
            this.gbThief.Controls.Add(this.cbRogue);
            this.gbThief.Controls.Add(this.cbAssassin);
            this.gbThief.Controls.Add(this.cbThief);
            this.gbThief.Location = new System.Drawing.Point(260, 136);
            this.gbThief.Name = "gbThief";
            this.gbThief.Size = new System.Drawing.Size(240, 52);
            this.gbThief.TabIndex = 4;
            this.gbThief.TabStop = false;
            this.gbThief.Text = "盗贼系列";
            // 
            // cbRogue
            // 
            this.cbRogue.AutoSize = true;
            this.cbRogue.Location = new System.Drawing.Point(156, 21);
            this.cbRogue.Name = "cbRogue";
            this.cbRogue.Size = new System.Drawing.Size(48, 16);
            this.cbRogue.TabIndex = 2;
            this.cbRogue.Tag = "0x00020000";
            this.cbRogue.Text = "流氓";
            this.cbRogue.UseVisualStyleBackColor = true;
            this.cbRogue.CheckedChanged += new System.EventHandler(this.cbAsgard_CheckedChanged);
            // 
            // cbAssassin
            // 
            this.cbAssassin.AutoSize = true;
            this.cbAssassin.Location = new System.Drawing.Point(87, 21);
            this.cbAssassin.Name = "cbAssassin";
            this.cbAssassin.Size = new System.Drawing.Size(48, 16);
            this.cbAssassin.TabIndex = 1;
            this.cbAssassin.Tag = "0x00001000";
            this.cbAssassin.Text = "刺客";
            this.cbAssassin.UseVisualStyleBackColor = true;
            this.cbAssassin.CheckedChanged += new System.EventHandler(this.cbAsgard_CheckedChanged);
            // 
            // cbThief
            // 
            this.cbThief.AutoSize = true;
            this.cbThief.Location = new System.Drawing.Point(16, 21);
            this.cbThief.Name = "cbThief";
            this.cbThief.Size = new System.Drawing.Size(48, 16);
            this.cbThief.TabIndex = 0;
            this.cbThief.Tag = "0x00000040";
            this.cbThief.Text = "盗贼";
            this.cbThief.UseVisualStyleBackColor = true;
            this.cbThief.CheckedChanged += new System.EventHandler(this.cbAsgard_CheckedChanged);
            // 
            // gbTaekwon
            // 
            this.gbTaekwon.Controls.Add(this.cbSoulLinker);
            this.gbTaekwon.Controls.Add(this.cbStarGladiator);
            this.gbTaekwon.Controls.Add(this.cbTaekwon);
            this.gbTaekwon.Location = new System.Drawing.Point(260, 193);
            this.gbTaekwon.Name = "gbTaekwon";
            this.gbTaekwon.Size = new System.Drawing.Size(240, 52);
            this.gbTaekwon.TabIndex = 6;
            this.gbTaekwon.TabStop = false;
            this.gbTaekwon.Text = "跆拳系列";
            // 
            // cbSoulLinker
            // 
            this.cbSoulLinker.AutoSize = true;
            this.cbSoulLinker.Location = new System.Drawing.Point(156, 21);
            this.cbSoulLinker.Name = "cbSoulLinker";
            this.cbSoulLinker.Size = new System.Drawing.Size(60, 16);
            this.cbSoulLinker.TabIndex = 2;
            this.cbSoulLinker.Tag = "0x00800000";
            this.cbSoulLinker.Text = "悟灵士";
            this.cbSoulLinker.UseVisualStyleBackColor = true;
            this.cbSoulLinker.CheckedChanged += new System.EventHandler(this.cbAsgard_CheckedChanged);
            // 
            // cbStarGladiator
            // 
            this.cbStarGladiator.AutoSize = true;
            this.cbStarGladiator.Location = new System.Drawing.Point(87, 21);
            this.cbStarGladiator.Name = "cbStarGladiator";
            this.cbStarGladiator.Size = new System.Drawing.Size(48, 16);
            this.cbStarGladiator.TabIndex = 1;
            this.cbStarGladiator.Tag = "0x00400000";
            this.cbStarGladiator.Text = "拳圣";
            this.cbStarGladiator.UseVisualStyleBackColor = true;
            this.cbStarGladiator.CheckedChanged += new System.EventHandler(this.cbAsgard_CheckedChanged);
            // 
            // cbTaekwon
            // 
            this.cbTaekwon.AutoSize = true;
            this.cbTaekwon.Location = new System.Drawing.Point(16, 21);
            this.cbTaekwon.Name = "cbTaekwon";
            this.cbTaekwon.Size = new System.Drawing.Size(60, 16);
            this.cbTaekwon.TabIndex = 0;
            this.cbTaekwon.Tag = "0x00200000";
            this.cbTaekwon.Text = "跆拳道";
            this.cbTaekwon.UseVisualStyleBackColor = true;
            this.cbTaekwon.CheckedChanged += new System.EventHandler(this.cbAsgard_CheckedChanged);
            // 
            // gbNinja
            // 
            this.gbNinja.Controls.Add(this.cbKagerouOboro);
            this.gbNinja.Controls.Add(this.cbNinja);
            this.gbNinja.Location = new System.Drawing.Point(260, 250);
            this.gbNinja.Name = "gbNinja";
            this.gbNinja.Size = new System.Drawing.Size(240, 52);
            this.gbNinja.TabIndex = 8;
            this.gbNinja.TabStop = false;
            this.gbNinja.Text = "忍者系列";
            // 
            // cbKagerouOboro
            // 
            this.cbKagerouOboro.AutoSize = true;
            this.cbKagerouOboro.Location = new System.Drawing.Point(87, 21);
            this.cbKagerouOboro.Name = "cbKagerouOboro";
            this.cbKagerouOboro.Size = new System.Drawing.Size(126, 16);
            this.cbKagerouOboro.TabIndex = 1;
            this.cbKagerouOboro.Tag = "0x20000000";
            this.cbKagerouOboro.Text = "日影忍者/月影忍者";
            this.cbKagerouOboro.UseVisualStyleBackColor = true;
            this.cbKagerouOboro.CheckedChanged += new System.EventHandler(this.cbAsgard_CheckedChanged);
            // 
            // cbNinja
            // 
            this.cbNinja.AutoSize = true;
            this.cbNinja.Location = new System.Drawing.Point(16, 21);
            this.cbNinja.Name = "cbNinja";
            this.cbNinja.Size = new System.Drawing.Size(48, 16);
            this.cbNinja.TabIndex = 0;
            this.cbNinja.Tag = "0x02000000";
            this.cbNinja.Text = "忍者";
            this.cbNinja.UseVisualStyleBackColor = true;
            this.cbNinja.CheckedChanged += new System.EventHandler(this.cbAsgard_CheckedChanged);
            // 
            // gbGunslinger
            // 
            this.gbGunslinger.Controls.Add(this.cbRebellion);
            this.gbGunslinger.Controls.Add(this.cbGunslinger);
            this.gbGunslinger.Location = new System.Drawing.Point(260, 307);
            this.gbGunslinger.Name = "gbGunslinger";
            this.gbGunslinger.Size = new System.Drawing.Size(240, 52);
            this.gbGunslinger.TabIndex = 10;
            this.gbGunslinger.TabStop = false;
            this.gbGunslinger.Text = "枪手系列";
            // 
            // cbRebellion
            // 
            this.cbRebellion.AutoSize = true;
            this.cbRebellion.Location = new System.Drawing.Point(87, 21);
            this.cbRebellion.Name = "cbRebellion";
            this.cbRebellion.Size = new System.Drawing.Size(102, 16);
            this.cbRebellion.TabIndex = 1;
            this.cbRebellion.Tag = "0x40000000";
            this.cbRebellion.Text = "变革者/反叛者";
            this.cbRebellion.UseVisualStyleBackColor = true;
            this.cbRebellion.CheckedChanged += new System.EventHandler(this.cbAsgard_CheckedChanged);
            // 
            // cbGunslinger
            // 
            this.cbGunslinger.AutoSize = true;
            this.cbGunslinger.Location = new System.Drawing.Point(16, 21);
            this.cbGunslinger.Name = "cbGunslinger";
            this.cbGunslinger.Size = new System.Drawing.Size(60, 16);
            this.cbGunslinger.TabIndex = 0;
            this.cbGunslinger.Tag = "0x01000000";
            this.cbGunslinger.Text = "神枪手";
            this.cbGunslinger.UseVisualStyleBackColor = true;
            this.cbGunslinger.CheckedChanged += new System.EventHandler(this.cbAsgard_CheckedChanged);
            // 
            // gbSwordman
            // 
            this.gbSwordman.Controls.Add(this.cbCrusader);
            this.gbSwordman.Controls.Add(this.cbKnight);
            this.gbSwordman.Controls.Add(this.cbSwordman);
            this.gbSwordman.Location = new System.Drawing.Point(13, 136);
            this.gbSwordman.Name = "gbSwordman";
            this.gbSwordman.Size = new System.Drawing.Size(240, 52);
            this.gbSwordman.TabIndex = 3;
            this.gbSwordman.TabStop = false;
            this.gbSwordman.Text = "剑士系列";
            // 
            // cbCrusader
            // 
            this.cbCrusader.AutoSize = true;
            this.cbCrusader.Location = new System.Drawing.Point(156, 21);
            this.cbCrusader.Name = "cbCrusader";
            this.cbCrusader.Size = new System.Drawing.Size(60, 16);
            this.cbCrusader.TabIndex = 2;
            this.cbCrusader.Tag = "0x00004000";
            this.cbCrusader.Text = "十字军";
            this.cbCrusader.UseVisualStyleBackColor = true;
            this.cbCrusader.CheckedChanged += new System.EventHandler(this.cbAsgard_CheckedChanged);
            // 
            // cbKnight
            // 
            this.cbKnight.AutoSize = true;
            this.cbKnight.Location = new System.Drawing.Point(87, 21);
            this.cbKnight.Name = "cbKnight";
            this.cbKnight.Size = new System.Drawing.Size(48, 16);
            this.cbKnight.TabIndex = 1;
            this.cbKnight.Tag = "0x00000080";
            this.cbKnight.Text = "骑士";
            this.cbKnight.UseVisualStyleBackColor = true;
            this.cbKnight.CheckedChanged += new System.EventHandler(this.cbAsgard_CheckedChanged);
            // 
            // cbSwordman
            // 
            this.cbSwordman.AutoSize = true;
            this.cbSwordman.Location = new System.Drawing.Point(16, 21);
            this.cbSwordman.Name = "cbSwordman";
            this.cbSwordman.Size = new System.Drawing.Size(48, 16);
            this.cbSwordman.TabIndex = 0;
            this.cbSwordman.Tag = "0x00000002";
            this.cbSwordman.Text = "剑士";
            this.cbSwordman.UseVisualStyleBackColor = true;
            this.cbSwordman.CheckedChanged += new System.EventHandler(this.cbAsgard_CheckedChanged);
            // 
            // gbMagician
            // 
            this.gbMagician.Controls.Add(this.cbSage);
            this.gbMagician.Controls.Add(this.cbWizard);
            this.gbMagician.Controls.Add(this.cbMagician);
            this.gbMagician.Location = new System.Drawing.Point(14, 193);
            this.gbMagician.Name = "gbMagician";
            this.gbMagician.Size = new System.Drawing.Size(240, 52);
            this.gbMagician.TabIndex = 5;
            this.gbMagician.TabStop = false;
            this.gbMagician.Text = "魔法师系列";
            // 
            // cbSage
            // 
            this.cbSage.AutoSize = true;
            this.cbSage.Location = new System.Drawing.Point(156, 21);
            this.cbSage.Name = "cbSage";
            this.cbSage.Size = new System.Drawing.Size(48, 16);
            this.cbSage.TabIndex = 2;
            this.cbSage.Tag = "0x00010000";
            this.cbSage.Text = "贤者";
            this.cbSage.UseVisualStyleBackColor = true;
            this.cbSage.CheckedChanged += new System.EventHandler(this.cbAsgard_CheckedChanged);
            // 
            // cbWizard
            // 
            this.cbWizard.AutoSize = true;
            this.cbWizard.Location = new System.Drawing.Point(87, 21);
            this.cbWizard.Name = "cbWizard";
            this.cbWizard.Size = new System.Drawing.Size(48, 16);
            this.cbWizard.TabIndex = 1;
            this.cbWizard.Tag = "0x00000200";
            this.cbWizard.Text = "巫师";
            this.cbWizard.UseVisualStyleBackColor = true;
            this.cbWizard.CheckedChanged += new System.EventHandler(this.cbAsgard_CheckedChanged);
            // 
            // cbMagician
            // 
            this.cbMagician.AutoSize = true;
            this.cbMagician.Location = new System.Drawing.Point(16, 21);
            this.cbMagician.Name = "cbMagician";
            this.cbMagician.Size = new System.Drawing.Size(60, 16);
            this.cbMagician.TabIndex = 0;
            this.cbMagician.Tag = "0x00000004";
            this.cbMagician.Text = "魔法师";
            this.cbMagician.UseVisualStyleBackColor = true;
            this.cbMagician.CheckedChanged += new System.EventHandler(this.cbAsgard_CheckedChanged);
            // 
            // gbArcher
            // 
            this.gbArcher.Controls.Add(this.cbBardDancer);
            this.gbArcher.Controls.Add(this.cbHunter);
            this.gbArcher.Controls.Add(this.cbArcher);
            this.gbArcher.Location = new System.Drawing.Point(14, 250);
            this.gbArcher.Name = "gbArcher";
            this.gbArcher.Size = new System.Drawing.Size(240, 52);
            this.gbArcher.TabIndex = 7;
            this.gbArcher.TabStop = false;
            this.gbArcher.Text = "弓箭手系列";
            // 
            // cbBardDancer
            // 
            this.cbBardDancer.AutoSize = true;
            this.cbBardDancer.Location = new System.Drawing.Point(156, 21);
            this.cbBardDancer.Name = "cbBardDancer";
            this.cbBardDancer.Size = new System.Drawing.Size(78, 16);
            this.cbBardDancer.TabIndex = 2;
            this.cbBardDancer.Tag = "0x00080000";
            this.cbBardDancer.Text = "诗人/舞娘";
            this.cbBardDancer.UseVisualStyleBackColor = true;
            this.cbBardDancer.CheckedChanged += new System.EventHandler(this.cbAsgard_CheckedChanged);
            // 
            // cbHunter
            // 
            this.cbHunter.AutoSize = true;
            this.cbHunter.Location = new System.Drawing.Point(87, 21);
            this.cbHunter.Name = "cbHunter";
            this.cbHunter.Size = new System.Drawing.Size(48, 16);
            this.cbHunter.TabIndex = 1;
            this.cbHunter.Tag = "0x00000800";
            this.cbHunter.Text = "猎人";
            this.cbHunter.UseVisualStyleBackColor = true;
            this.cbHunter.CheckedChanged += new System.EventHandler(this.cbAsgard_CheckedChanged);
            // 
            // cbArcher
            // 
            this.cbArcher.AutoSize = true;
            this.cbArcher.Location = new System.Drawing.Point(16, 21);
            this.cbArcher.Name = "cbArcher";
            this.cbArcher.Size = new System.Drawing.Size(60, 16);
            this.cbArcher.TabIndex = 0;
            this.cbArcher.Tag = "0x00000008";
            this.cbArcher.Text = "弓箭手";
            this.cbArcher.UseVisualStyleBackColor = true;
            this.cbArcher.CheckedChanged += new System.EventHandler(this.cbAsgard_CheckedChanged);
            // 
            // gbAcolyte
            // 
            this.gbAcolyte.Controls.Add(this.cbMonk);
            this.gbAcolyte.Controls.Add(this.cbPriest);
            this.gbAcolyte.Controls.Add(this.cbAcolyte);
            this.gbAcolyte.Location = new System.Drawing.Point(14, 307);
            this.gbAcolyte.Name = "gbAcolyte";
            this.gbAcolyte.Size = new System.Drawing.Size(240, 52);
            this.gbAcolyte.TabIndex = 9;
            this.gbAcolyte.TabStop = false;
            this.gbAcolyte.Text = "服事系列";
            // 
            // cbMonk
            // 
            this.cbMonk.AutoSize = true;
            this.cbMonk.Location = new System.Drawing.Point(156, 21);
            this.cbMonk.Name = "cbMonk";
            this.cbMonk.Size = new System.Drawing.Size(48, 16);
            this.cbMonk.TabIndex = 2;
            this.cbMonk.Tag = "0x00008000";
            this.cbMonk.Text = "武僧";
            this.cbMonk.UseVisualStyleBackColor = true;
            this.cbMonk.CheckedChanged += new System.EventHandler(this.cbAsgard_CheckedChanged);
            // 
            // cbPriest
            // 
            this.cbPriest.AutoSize = true;
            this.cbPriest.Location = new System.Drawing.Point(87, 21);
            this.cbPriest.Name = "cbPriest";
            this.cbPriest.Size = new System.Drawing.Size(48, 16);
            this.cbPriest.TabIndex = 1;
            this.cbPriest.Tag = "0x00000100";
            this.cbPriest.Text = "牧师";
            this.cbPriest.UseVisualStyleBackColor = true;
            this.cbPriest.CheckedChanged += new System.EventHandler(this.cbAsgard_CheckedChanged);
            // 
            // cbAcolyte
            // 
            this.cbAcolyte.AutoSize = true;
            this.cbAcolyte.Location = new System.Drawing.Point(16, 21);
            this.cbAcolyte.Name = "cbAcolyte";
            this.cbAcolyte.Size = new System.Drawing.Size(48, 16);
            this.cbAcolyte.TabIndex = 0;
            this.cbAcolyte.Tag = "0x00000010";
            this.cbAcolyte.Text = "服事";
            this.cbAcolyte.UseVisualStyleBackColor = true;
            this.cbAcolyte.CheckedChanged += new System.EventHandler(this.cbAsgard_CheckedChanged);
            // 
            // gbCodeEditer
            // 
            this.gbCodeEditer.Controls.Add(this.btnWhyNoHaveExtendJob);
            this.gbCodeEditer.Controls.Add(this.lbReset);
            this.gbCodeEditer.Controls.Add(this.lbSelectAll);
            this.gbCodeEditer.Controls.Add(this.lbCopy);
            this.gbCodeEditer.Controls.Add(this.lbTips);
            this.gbCodeEditer.Controls.Add(this.txtCode);
            this.gbCodeEditer.Controls.Add(this.label1);
            this.gbCodeEditer.Location = new System.Drawing.Point(14, 7);
            this.gbCodeEditer.Name = "gbCodeEditer";
            this.gbCodeEditer.Size = new System.Drawing.Size(486, 66);
            this.gbCodeEditer.TabIndex = 0;
            this.gbCodeEditer.TabStop = false;
            // 
            // btnWhyNoHaveExtendJob
            // 
            this.btnWhyNoHaveExtendJob.Location = new System.Drawing.Point(351, 16);
            this.btnWhyNoHaveExtendJob.Name = "btnWhyNoHaveExtendJob";
            this.btnWhyNoHaveExtendJob.Size = new System.Drawing.Size(126, 39);
            this.btnWhyNoHaveExtendJob.TabIndex = 12;
            this.btnWhyNoHaveExtendJob.Text = "为何没有进阶职业";
            this.btnWhyNoHaveExtendJob.UseVisualStyleBackColor = true;
            this.btnWhyNoHaveExtendJob.Click += new System.EventHandler(this.btnWhyNoHaveExtendJob_Click);
            // 
            // lbReset
            // 
            this.lbReset.AutoSize = true;
            this.lbReset.Location = new System.Drawing.Point(290, 18);
            this.lbReset.Name = "lbReset";
            this.lbReset.Size = new System.Drawing.Size(29, 12);
            this.lbReset.TabIndex = 5;
            this.lbReset.TabStop = true;
            this.lbReset.Text = "重置";
            this.lbReset.Click += new System.EventHandler(this.lbReset_Click);
            // 
            // lbSelectAll
            // 
            this.lbSelectAll.AutoSize = true;
            this.lbSelectAll.Location = new System.Drawing.Point(253, 18);
            this.lbSelectAll.Name = "lbSelectAll";
            this.lbSelectAll.Size = new System.Drawing.Size(29, 12);
            this.lbSelectAll.TabIndex = 4;
            this.lbSelectAll.TabStop = true;
            this.lbSelectAll.Text = "全选";
            this.lbSelectAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbSelectAll_LinkClicked);
            // 
            // lbCopy
            // 
            this.lbCopy.AutoSize = true;
            this.lbCopy.Location = new System.Drawing.Point(192, 18);
            this.lbCopy.Name = "lbCopy";
            this.lbCopy.Size = new System.Drawing.Size(53, 12);
            this.lbCopy.TabIndex = 3;
            this.lbCopy.TabStop = true;
            this.lbCopy.Text = "复制代码";
            this.lbCopy.Click += new System.EventHandler(this.lbCopy_Click);
            // 
            // lbTips
            // 
            this.lbTips.AutoSize = true;
            this.lbTips.Location = new System.Drawing.Point(12, 40);
            this.lbTips.Name = "lbTips";
            this.lbTips.Size = new System.Drawing.Size(317, 12);
            this.lbTips.TabIndex = 2;
            this.lbTips.Text = "请勾选职业来获得职业代码，或填写职业代码来反查职业。";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(86, 16);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 21);
            this.txtCode.TabIndex = 1;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "职业代码：";
            // 
            // gbDoram
            // 
            this.gbDoram.Controls.Add(this.cbSummoner);
            this.gbDoram.Location = new System.Drawing.Point(14, 365);
            this.gbDoram.Name = "gbDoram";
            this.gbDoram.Size = new System.Drawing.Size(240, 52);
            this.gbDoram.TabIndex = 11;
            this.gbDoram.TabStop = false;
            this.gbDoram.Text = "杜兰族";
            // 
            // cbSummoner
            // 
            this.cbSummoner.AutoSize = true;
            this.cbSummoner.Location = new System.Drawing.Point(16, 21);
            this.cbSummoner.Name = "cbSummoner";
            this.cbSummoner.Size = new System.Drawing.Size(132, 16);
            this.cbSummoner.TabIndex = 0;
            this.cbSummoner.Tag = "0x80000000";
            this.cbSummoner.Text = "召唤师（Summoner）";
            this.cbSummoner.UseVisualStyleBackColor = true;
            this.cbSummoner.CheckedChanged += new System.EventHandler(this.cbAsgard_CheckedChanged);
            // 
            // tipstimer
            // 
            this.tipstimer.Interval = 1000;
            this.tipstimer.Tick += new System.EventHandler(this.tipstimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 430);
            this.Controls.Add(this.gbDoram);
            this.Controls.Add(this.gbCodeEditer);
            this.Controls.Add(this.gbAcolyte);
            this.Controls.Add(this.gbArcher);
            this.Controls.Add(this.gbMagician);
            this.Controls.Add(this.gbSwordman);
            this.Controls.Add(this.gbGunslinger);
            this.Controls.Add(this.gbNinja);
            this.Controls.Add(this.gbTaekwon);
            this.Controls.Add(this.gbThief);
            this.Controls.Add(this.gbMerchant);
            this.Controls.Add(this.gbNovice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job-Code Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbNovice.ResumeLayout(false);
            this.gbNovice.PerformLayout();
            this.gbMerchant.ResumeLayout(false);
            this.gbMerchant.PerformLayout();
            this.gbThief.ResumeLayout(false);
            this.gbThief.PerformLayout();
            this.gbTaekwon.ResumeLayout(false);
            this.gbTaekwon.PerformLayout();
            this.gbNinja.ResumeLayout(false);
            this.gbNinja.PerformLayout();
            this.gbGunslinger.ResumeLayout(false);
            this.gbGunslinger.PerformLayout();
            this.gbSwordman.ResumeLayout(false);
            this.gbSwordman.PerformLayout();
            this.gbMagician.ResumeLayout(false);
            this.gbMagician.PerformLayout();
            this.gbArcher.ResumeLayout(false);
            this.gbArcher.PerformLayout();
            this.gbAcolyte.ResumeLayout(false);
            this.gbAcolyte.PerformLayout();
            this.gbCodeEditer.ResumeLayout(false);
            this.gbCodeEditer.PerformLayout();
            this.gbDoram.ResumeLayout(false);
            this.gbDoram.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNovice;
        private System.Windows.Forms.GroupBox gbMerchant;
        private System.Windows.Forms.CheckBox cbNovice;
        private System.Windows.Forms.CheckBox cbAlchemist;
        private System.Windows.Forms.CheckBox cbBlacksmith;
        private System.Windows.Forms.CheckBox cbMerchant;
        private System.Windows.Forms.GroupBox gbThief;
        private System.Windows.Forms.CheckBox cbRogue;
        private System.Windows.Forms.CheckBox cbAssassin;
        private System.Windows.Forms.CheckBox cbThief;
        private System.Windows.Forms.GroupBox gbTaekwon;
        private System.Windows.Forms.CheckBox cbSoulLinker;
        private System.Windows.Forms.CheckBox cbStarGladiator;
        private System.Windows.Forms.CheckBox cbTaekwon;
        private System.Windows.Forms.GroupBox gbNinja;
        private System.Windows.Forms.CheckBox cbKagerouOboro;
        private System.Windows.Forms.CheckBox cbNinja;
        private System.Windows.Forms.GroupBox gbGunslinger;
        private System.Windows.Forms.CheckBox cbRebellion;
        private System.Windows.Forms.CheckBox cbGunslinger;
        private System.Windows.Forms.GroupBox gbSwordman;
        private System.Windows.Forms.CheckBox cbCrusader;
        private System.Windows.Forms.CheckBox cbKnight;
        private System.Windows.Forms.CheckBox cbSwordman;
        private System.Windows.Forms.GroupBox gbMagician;
        private System.Windows.Forms.CheckBox cbSage;
        private System.Windows.Forms.CheckBox cbWizard;
        private System.Windows.Forms.CheckBox cbMagician;
        private System.Windows.Forms.GroupBox gbArcher;
        private System.Windows.Forms.CheckBox cbBardDancer;
        private System.Windows.Forms.CheckBox cbHunter;
        private System.Windows.Forms.CheckBox cbArcher;
        private System.Windows.Forms.GroupBox gbAcolyte;
        private System.Windows.Forms.CheckBox cbMonk;
        private System.Windows.Forms.CheckBox cbPriest;
        private System.Windows.Forms.CheckBox cbAcolyte;
        private System.Windows.Forms.GroupBox gbCodeEditer;
        private System.Windows.Forms.LinkLabel lbReset;
        private System.Windows.Forms.LinkLabel lbSelectAll;
        private System.Windows.Forms.LinkLabel lbCopy;
        private System.Windows.Forms.Label lbTips;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWhyNoHaveExtendJob;
        private System.Windows.Forms.GroupBox gbDoram;
        private System.Windows.Forms.CheckBox cbSummoner;
        private System.Windows.Forms.Timer tipstimer;
    }
}

