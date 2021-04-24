Public Class TOS_ABOUT
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Process.Start(Me.Label4.Text)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process.Start("https://www.facebook.com/Revenge-RAT-1819959184942959/?fref=ts&ref=br_tf")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Process.Start("https://twitter.com/H3x_0R")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Process.Start("http://revengerateg.wixsite.com/revenge-rat")
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.TableLayoutPanel2.Visible = True
        Me.TableLayoutPanel3.Visible = False
        Me.TableLayoutPanel3.Dock = DockStyle.Top
        Me.Text = "Terms of Service"
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.TableLayoutPanel2.Visible = False
        Me.TableLayoutPanel3.Visible = True
        Me.TableLayoutPanel3.Dock = DockStyle.Fill
        Me.Text = "About"
    End Sub

    Private Sub TOS_ABOUT_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "Terms of Service"
    End Sub
End Class