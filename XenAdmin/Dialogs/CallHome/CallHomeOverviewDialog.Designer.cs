﻿using XenAdmin.Commands;

namespace XenAdmin.Dialogs.CallHome
{
    partial class CallHomeOverviewDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CallHomeOverviewDialog));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rubricLabel = new System.Windows.Forms.Label();
            this.poolsDataGridView = new XenAdmin.Controls.DataGridViewEx.DataGridViewEx();
            this.PoolNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.poolNameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.healthCheckStatusPanel = new System.Windows.Forms.TableLayoutPanel();
            this.scheduleLabel = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.issuesLabel = new System.Windows.Forms.Label();
            this.lastUploadDateLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReportAnalysisLinkLabel = new System.Windows.Forms.LinkLabel();
            this.previousUploadPanel = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.previousUploadDateLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.notEnrolledPanel = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poolsDataGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.healthCheckStatusPanel.SuspendLayout();
            this.previousUploadPanel.SuspendLayout();
            this.notEnrolledPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.rubricLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.poolsDataGridView, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // rubricLabel
            // 
            resources.ApplyResources(this.rubricLabel, "rubricLabel");
            this.tableLayoutPanel1.SetColumnSpan(this.rubricLabel, 2);
            this.rubricLabel.Name = "rubricLabel";
            // 
            // poolsDataGridView
            // 
            this.poolsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.poolsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.poolsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.poolsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.poolsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PoolNameColumn,
            this.StatusColumn});
            resources.ApplyResources(this.poolsDataGridView, "poolsDataGridView");
            this.poolsDataGridView.Name = "poolsDataGridView";
            this.poolsDataGridView.ReadOnly = true;
            this.poolsDataGridView.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // PoolNameColumn
            // 
            this.PoolNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            resources.ApplyResources(this.PoolNameColumn, "PoolNameColumn");
            this.PoolNameColumn.Name = "PoolNameColumn";
            this.PoolNameColumn.ReadOnly = true;
            // 
            // StatusColumn
            // 
            this.StatusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.StatusColumn, "StatusColumn");
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            this.StatusColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.poolNameLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // poolNameLabel
            // 
            this.poolNameLabel.AutoEllipsis = true;
            resources.ApplyResources(this.poolNameLabel, "poolNameLabel");
            this.poolNameLabel.Name = "poolNameLabel";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.Controls.Add(this.healthCheckStatusPanel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.notEnrolledPanel, 0, 1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // healthCheckStatusPanel
            // 
            resources.ApplyResources(this.healthCheckStatusPanel, "healthCheckStatusPanel");
            this.healthCheckStatusPanel.Controls.Add(this.scheduleLabel, 0, 6);
            this.healthCheckStatusPanel.Controls.Add(this.linkLabel2, 0, 7);
            this.healthCheckStatusPanel.Controls.Add(this.issuesLabel, 0, 2);
            this.healthCheckStatusPanel.Controls.Add(this.lastUploadDateLabel, 1, 1);
            this.healthCheckStatusPanel.Controls.Add(this.label4, 0, 5);
            this.healthCheckStatusPanel.Controls.Add(this.label1, 0, 0);
            this.healthCheckStatusPanel.Controls.Add(this.label2, 0, 1);
            this.healthCheckStatusPanel.Controls.Add(this.ReportAnalysisLinkLabel, 0, 3);
            this.healthCheckStatusPanel.Controls.Add(this.previousUploadPanel, 0, 4);
            this.healthCheckStatusPanel.Name = "healthCheckStatusPanel";
            // 
            // scheduleLabel
            // 
            resources.ApplyResources(this.scheduleLabel, "scheduleLabel");
            this.healthCheckStatusPanel.SetColumnSpan(this.scheduleLabel, 2);
            this.scheduleLabel.Name = "scheduleLabel";
            // 
            // linkLabel2
            // 
            resources.ApplyResources(this.linkLabel2, "linkLabel2");
            this.healthCheckStatusPanel.SetColumnSpan(this.linkLabel2, 2);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.TabStop = true;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // issuesLabel
            // 
            resources.ApplyResources(this.issuesLabel, "issuesLabel");
            this.healthCheckStatusPanel.SetColumnSpan(this.issuesLabel, 2);
            this.issuesLabel.Name = "issuesLabel";
            // 
            // lastUploadDateLabel
            // 
            resources.ApplyResources(this.lastUploadDateLabel, "lastUploadDateLabel");
            this.lastUploadDateLabel.Name = "lastUploadDateLabel";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.healthCheckStatusPanel.SetColumnSpan(this.label4, 2);
            this.label4.Name = "label4";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.healthCheckStatusPanel.SetColumnSpan(this.label1, 2);
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // ReportAnalysisLinkLabel
            // 
            resources.ApplyResources(this.ReportAnalysisLinkLabel, "ReportAnalysisLinkLabel");
            this.healthCheckStatusPanel.SetColumnSpan(this.ReportAnalysisLinkLabel, 2);
            this.ReportAnalysisLinkLabel.Name = "ReportAnalysisLinkLabel";
            this.ReportAnalysisLinkLabel.TabStop = true;
            // 
            // previousUploadPanel
            // 
            resources.ApplyResources(this.previousUploadPanel, "previousUploadPanel");
            this.healthCheckStatusPanel.SetColumnSpan(this.previousUploadPanel, 2);
            this.previousUploadPanel.Controls.Add(this.linkLabel1, 0, 1);
            this.previousUploadPanel.Controls.Add(this.previousUploadDateLabel, 1, 0);
            this.previousUploadPanel.Controls.Add(this.label3, 0, 0);
            this.previousUploadPanel.Name = "previousUploadPanel";
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.previousUploadPanel.SetColumnSpan(this.linkLabel1, 2);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            // 
            // previousUploadDateLabel
            // 
            resources.ApplyResources(this.previousUploadDateLabel, "previousUploadDateLabel");
            this.previousUploadDateLabel.Name = "previousUploadDateLabel";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // notEnrolledPanel
            // 
            resources.ApplyResources(this.notEnrolledPanel, "notEnrolledPanel");
            this.tableLayoutPanel3.SetColumnSpan(this.notEnrolledPanel, 2);
            this.notEnrolledPanel.Controls.Add(this.linkLabel3, 0, 1);
            this.notEnrolledPanel.Controls.Add(this.label6, 0, 0);
            this.notEnrolledPanel.Name = "notEnrolledPanel";
            // 
            // linkLabel3
            // 
            resources.ApplyResources(this.linkLabel3, "linkLabel3");
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.TabStop = true;
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // CallHomeOverviewDialog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.buttonCancel;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "CallHomeOverviewDialog";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CallHomeOverviewDialog_FormClosed);
            this.Load += new System.EventHandler(this.CallHomeOverview_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poolsDataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.healthCheckStatusPanel.ResumeLayout(false);
            this.healthCheckStatusPanel.PerformLayout();
            this.previousUploadPanel.ResumeLayout(false);
            this.previousUploadPanel.PerformLayout();
            this.notEnrolledPanel.ResumeLayout(false);
            this.notEnrolledPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private XenAdmin.Controls.DataGridViewEx.DataGridViewEx poolsDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label poolNameLabel;
        private System.Windows.Forms.Label rubricLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoolNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.TableLayoutPanel healthCheckStatusPanel;
        private System.Windows.Forms.Label issuesLabel;
        private System.Windows.Forms.Label lastUploadDateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel ReportAnalysisLinkLabel;
        private System.Windows.Forms.TableLayoutPanel previousUploadPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label previousUploadDateLabel;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label scheduleLabel;
        private System.Windows.Forms.TableLayoutPanel notEnrolledPanel;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}

