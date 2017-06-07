
Partial Class UserControl_ucDatePicker
    Inherits System.Web.UI.UserControl
    Public Property dateValue() As DateTime
        Get
            Dim _dateValue As DateTime
            Try

                _dateValue = DateTime.ParseExact(txtDateValue.Text.Trim(), "dd-MMM-yyyy", Nothing)
                Return _dateValue
            Catch ex As Exception
                Return DateTime.MinValue
            End Try
        End Get
        Set(ByVal value As DateTime)
            txtDateValue.Text = value.ToString("dd-MMM-yyyy")
        End Set
    End Property

    Public Property ValidationGroup() As String
        Get
            Return rfvDateValue.ValidationGroup.ToString

        End Get
        Set(ByVal value As String)
            rfvDateValue.ValidationGroup = value
        End Set
    End Property

    Public Property ErrorMessage() As String
        Get
            Return rfvDateValue.ErrorMessage.ToString

        End Get
        Set(ByVal value As String)
            rfvDateValue.ErrorMessage = value
        End Set
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtDateValue.Attributes.Add("onfocus", "showCalender (calender,this)")
    End Sub
End Class
