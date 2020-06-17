Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Windows.Forms.VisualStyles

Namespace CustomControl
    Class CheckComboBox
        Inherits ComboBox

        Public Class ComboboxData
            Private TotalData As String
            Private _checked As Boolean

            Public Property Checked As Boolean
                Set(ByVal value As Boolean)
                    _checked = value
                End Set
                Get
                    Return _checked
                End Get
            End Property

            Private _data As String

            Public Property Data As String
                Set(ByVal value As String)
                    _data = value
                End Set
                Get
                    Return _data
                End Get
            End Property

            Public Sub New(ByVal value As String, ByVal ischeck As Boolean)
                Data = value
                Checked = ischeck
            End Sub

            Public Overrides Function ToString() As String
                Return Data
            End Function
        End Class

        Public Event Checkchanged As EventHandler

        Public Sub New()
            Me.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        End Sub

        Public ReadOnly Property CheckItems As List(Of ComboboxData)
            Get
                Dim newitems As List(Of ComboboxData) = New List(Of ComboboxData)()

                For Each item In Items

                    If TypeOf item Is ComboboxData Then
                        newitems.Add(TryCast(item, ComboboxData))
                    End If
                Next

                Return newitems
            End Get
        End Property

        Protected Overrides Sub OnSelectedIndexChanged(ByVal e As EventArgs)
            MyBase.OnSelectedIndexChanged(e)
            Dim data As ComboboxData = CType(SelectedItem, ComboboxData)
            data.Checked = Not data.Checked
            RaiseEvent Checkchanged(data, e)
        End Sub

        Protected Overrides Sub OnDrawItem(ByVal e As DrawItemEventArgs)
            If e.Index = -1 Then
                Return
            End If

            If TypeOf Items(e.Index) Is ComboboxData Then
                Dim data As ComboboxData = TryCast(Items(e.Index), ComboboxData)
                CheckBoxRenderer.RenderMatchingApplicationState = True
                CheckBoxRenderer.DrawCheckBox(e.Graphics, New Point(e.Bounds.X, e.Bounds.Y), e.Bounds, data.Data, Me.Font, (e.State And DrawItemState.Focus) = 0, If(data.Checked, CheckBoxState.CheckedNormal, CheckBoxState.UncheckedNormal))
            Else
                e.Graphics.DrawString(Items(e.Index).ToString(), Me.Font, Brushes.Black, New Point(e.Bounds.X, e.Bounds.Y))
                Return
            End If

            MyBase.OnDrawItem(e)
        End Sub
    End Class
End Namespace
