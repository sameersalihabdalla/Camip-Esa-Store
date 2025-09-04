Option Strict On
Option Explicit On

Namespace Global.Utils
    Public Module modUtils
        ''' <summary>
        ''' Returns the IPv4 address of the calling user. When under a web 
        ''' environment, returns the <see cref="System.Web.HttpRequest"/> 
        ''' IP address, otherwise returns the IP address of the local machine
        ''' </summary>
        ''' <returns>The IPv4 address of the calling user</returns>
        Public Function GetIPv4Address() As String
            Dim ipAddress = String.Empty

            ' Get client ip address
            If System.Web.HttpContext.Current IsNot Nothing _
                AndAlso System.Web.HttpContext.Current.Request IsNot Nothing Then

                ' Get client ip address using ServerVariables
                Dim request = System.Web.HttpContext.Current.Request
                ipAddress = request.ServerVariables("HTTP_X_FORWARDED_FOR")
                If Not String.IsNullOrEmpty(ipAddress) Then
                    Dim addresses = ipAddress.Split(",".ToCharArray, StringSplitOptions.RemoveEmptyEntries)
                    If addresses.Length > 0 Then
                        ipAddress = addresses(0)
                    End If
                End If
                If String.IsNullOrEmpty(ipAddress) Then
                    ipAddress = request.ServerVariables("REMOTE_ADDR")
                End If

                ' Get client ip address using UserHostAddress
                If String.IsNullOrEmpty(ipAddress) Then
                    Dim clientIPA = GetNetworkAddress(request.UserHostAddress)
                    If clientIPA IsNot Nothing Then
                        ipAddress = clientIPA.ToString
                    End If
                End If
            End If

            ' Get local machine ip address
            If String.IsNullOrEmpty(ipAddress) Then
                Dim loacalIPA = GetNetworkAddress(System.Net.Dns.GetHostName)
                If loacalIPA IsNot Nothing Then
                    ipAddress = loacalIPA.ToString
                End If
            End If
            Return ipAddress
        End Function

        Private Function GetNetworkAddress(addresses As String) As System.Net.IPAddress
            Return System.Net.Dns.GetHostAddresses(addresses) _
                .FirstOrDefault(Function(x) x.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork)
        End Function
    End Module
End Namespace ' http://programmingnotes.org/

