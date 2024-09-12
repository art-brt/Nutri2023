

Public Class Form1
        Private Sub PACIENTESBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PACIENTESBindingNavigatorSaveItem.Click
            Me.Validate()
            Me.PACIENTESBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.NUTRI2023DataSet)

        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            'TODO: esta linha de código carrega dados na tabela 'NUTRI2023DataSet.PACIENTES'. Você pode movê-la ou removê-la conforme necessário.
            Me.PACIENTESTableAdapter.Fill(Me.NUTRI2023DataSet.PACIENTES)

        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Dim ofd As New OpenFileDialog
            If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
                FOTOPictureBox.ImageLocation = ofd.FileName
            End If

        End Sub

        Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
            If MessageBox.Show("Deseja deletar o registro?", "deletar?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then
                PACIENTESBindingNavigator.BindingSource.RemoveCurrent()
            End If
        End Sub

        Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
            NOMETextBox.Focus()
        End Sub

    Private Sub ALTURATextBox_Leave(sender As Object, e As EventArgs) Handles ALTURATextBox.Leave
        If SEXOComboBox.Text = "" Or PESOTextBox.Text = "" Or ALTURATextBox.Text = "" Then
            MsgBox("selecione o sexo e digite peso e altura para calcular IMC ")
            SEXOComboBox.Focus()
        Else
            IMCTextBox.Text = PESOTextBox.Text / (ALTURATextBox.Text ^ 2)
            If SEXOComboBox.Text = "masculino" Then
                If IMCTextBox.Text < 20 Then
                    CONDICAOTextBox.Text = "abaixo do peso"
                Else
                    If IMCTextBox.Text > 25 Then
                        CONDICAOTextBox.Text = "acima do peso"
                    Else
                        CONDICAOTextBox.Text = "no peso ideal"

                    End If
                End If
            Else
                If IMCTextBox.Text < 19 Then
                    CONDICAOTextBox.Text = "abaixo do peso"
                Else
                    If IMCTextBox.Text > 24 Then
                        CONDICAOTextBox.Text = "acima do peso"
                    Else
                        CONDICAOTextBox.Text = "no peso ideal"
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        userform1.
    End Sub
End Class
