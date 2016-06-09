using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace JobCodeCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 在窗口的标题显示出版本号
            FileVersionInfo myFileVersion = FileVersionInfo.GetVersionInfo(System.Windows.Forms.Application.ExecutablePath);
            this.Text = this.Text + " v." + myFileVersion.FileVersion;

        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if (txtCode.Text.Trim() == "")
                return;

            if (txtCode.Text.Trim().Length != 10)
                return;

            string Job_Code_Text = txtCode.Text.Trim();
            if (Job_Code_Text.Substring(0, 2).ToLower() == "0x")
                Job_Code_Text = Job_Code_Text.Substring(2);

            Int64 Job_Code = 0x00000000;
            // 将用户输入的职业代码文本，转换成数值并存放到 Job_Code 变量中
            if (!Int64.TryParse(Job_Code_Text, System.Globalization.NumberStyles.AllowHexSpecifier, null, out Job_Code))
                return;

            // 循环遍历窗口中的所有控件
            foreach (Control Ctrl in this.Controls)
            {
                // 如果是一个 GroupBox 控件的话
                if (Ctrl is System.Windows.Forms.GroupBox)
                {
                    // 那么继续遍历这个 GroupBox 控件中的控件
                    foreach (Control TCtrl in Ctrl.Controls)
                    {
                        // 如果 GroupBox 控件中的控件，是一个 复选框 的话
                        if (TCtrl is System.Windows.Forms.CheckBox)
                        {
                            System.Windows.Forms.CheckBox cb_Asgrad = (TCtrl as System.Windows.Forms.CheckBox);

                            if (cb_Asgrad.Tag == null)
                                continue;

                            // 取得复选框 Tag 属性中的文本，转成数值
                            string szTag = Convert.ToString(cb_Asgrad.Tag).Substring(2);
                            Int64 cbTag = 0x00000000;

                            if (!Int64.TryParse(szTag, System.Globalization.NumberStyles.AllowHexSpecifier, null, out cbTag))
                                continue;

                            if ((Job_Code & cbTag) == cbTag)
                                cb_Asgrad.Checked = true;
                            else
                                cb_Asgrad.Checked = false;
                        }
                    }
                }
            }
        }

        private void lbReset_Click(object sender, EventArgs e)
        {
            txtCode.Text = "";
            foreach (Control Ctrl in this.Controls)
            {
                if (Ctrl is System.Windows.Forms.GroupBox)
                {
                    foreach (Control TCtrl in Ctrl.Controls)
                    {
                        if (TCtrl is System.Windows.Forms.CheckBox)
                        {
                            System.Windows.Forms.CheckBox cb_Asgrad = (TCtrl as System.Windows.Forms.CheckBox);

                            if (cb_Asgrad.Tag == null)
                                continue;

                            cb_Asgrad.Checked = false;
                        }
                    }
                }
            }
        }

        private void lbCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txtCode.Text);
            tipstimer.Enabled = true;
            lbTips.Text = "职业代码已复制到剪切板！";
        }

        private void tipstimer_Tick(object sender, EventArgs e)
        {
            lbTips.Text = "请勾选职业来获得职业代码，或填写职业代码来反查职业。";
            tipstimer.Enabled = false;
        }

        private void lbSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Control Ctrl in this.Controls)
            {
                if (Ctrl is System.Windows.Forms.GroupBox)
                {
                    foreach (Control TCtrl in Ctrl.Controls)
                    {
                        if (TCtrl is System.Windows.Forms.CheckBox)
                        {
                            System.Windows.Forms.CheckBox cb_Asgrad = (TCtrl as System.Windows.Forms.CheckBox);

                            if (cb_Asgrad.Tag == null)
                                continue;

                            cb_Asgrad.Checked = true;
                        }
                    }
                }
            }
        }

        private void cbAsgard_CheckedChanged(object sender, EventArgs e)
        {
            Int64 Job_Code = 0x00000000;

            foreach (Control Ctrl in this.Controls)
            {
                if (Ctrl is System.Windows.Forms.GroupBox)
                {
                    foreach (Control TCtrl in Ctrl.Controls)
                    {
                        if (TCtrl is System.Windows.Forms.CheckBox)
                        {
                            System.Windows.Forms.CheckBox cb_Asgrad = (TCtrl as System.Windows.Forms.CheckBox);

                            if (cb_Asgrad.Tag == null)
                                continue;

                            // 取得复选框 Tag 属性中的文本，转成数值
                            string szTag = Convert.ToString(cb_Asgrad.Tag).Substring(2);
                            Int64 cbTag = 0x00000000;

                            if (!Int64.TryParse(szTag, System.Globalization.NumberStyles.AllowHexSpecifier, null, out cbTag))
                                continue;

                            if (cb_Asgrad.Checked)
                                Job_Code += cbTag;
                        }
                    }
                }
            }

            // 若已经全部勾选，那么变成0xFFFFFFFF
            if (Job_Code == 0xE3EFDFFF)
                Job_Code = 0xFFFFFFFF;

            if (Job_Code == 0)
            {
                txtCode.Text = "";
            }
            else
            {
                txtCode.Text = "0x" + string.Format("{0:x8}", Job_Code).ToUpper();
            }
        }

        private void btnWhyNoHaveExtendJob_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "在 rAthena 中，职业代码只是用来控制职业系，如果你想限制一个物品只有进阶二转（比如超魔导师）才能使用的话，您应该配合 Class 字段来做限制。", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
