﻿Imports System.Web
Imports System.Web.Services

Public Class GetUserName
    Implements System.Web.IHttpHandler

    Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest

        'Dim servercontext = ServerApplicationContext.CreateContext()
        'context.Response.ContentType = "text/plain"
        'context.Response.Write(servercontext.Application.User.Name)
        Using ctx As ServerApplicationContext = ServerApplicationContext.CreateContext()
            context.Response.ContentType = "text/plain"
            context.Response.Write(ctx.Application.User.Name)
        End Using
    End Sub

    ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class