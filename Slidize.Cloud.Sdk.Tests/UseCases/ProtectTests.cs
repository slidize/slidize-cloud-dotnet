//Copyright (c) 2024 Smallize Pty Ltd. All Rights Reserved
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Slidize.Cloud.Sdk.Api;
using Slidize.Cloud.Sdk.Model;

namespace Slidize.Cloud.Sdk.Tests.UseCases;

[TestClass]
public class ProtectTests
{
    [TestMethod]
    public void Protect()
    {
        var api = new SlidizeApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        var protectionOptions = new ProtectionOptions()
        {
            ViewPassword = c_password,
            EditPassword = c_password,
            MarkAsFinal = true
        };
        var stream = api.Protect(fileStream, protectionOptions);
        Assert.IsTrue(stream.Length > 0);
    }
    
    [TestMethod]
    public void ProtectWithHttpInfo()
    {
        var api = new SlidizeApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        var protectionOptions = new ProtectionOptions()
        {
            ViewPassword = c_password,
            EditPassword = c_password,
            MarkAsFinal = true
        };
        var apiResponse = api.ProtectWithHttpInfo(fileStream, protectionOptions);
        Assert.AreEqual(apiResponse.StatusCode, HttpStatusCode.OK);
        Assert.AreEqual(apiResponse.ResponseType, typeof(Stream));
    }
    
    [TestMethod]
    public async Task ProtectAsync()
    {
        var api = new SlidizeApi();
        await using var fileStream = File.Open(c_testFile, FileMode.Open);
        var protectionOptions = new ProtectionOptions()
        {
            ViewPassword = c_password,
            EditPassword = c_password,
            MarkAsFinal = true
        };
        var stream = await api.ProtectAsync(fileStream, protectionOptions);
        Assert.IsTrue(stream.Length > 0);
    }
    
    [TestMethod]
    public async Task ProtectWithHttpInfoAsync()
    {
        var api = new SlidizeApi();
        await using var fileStream = File.Open(c_testFile, FileMode.Open);
        var protectionOptions = new ProtectionOptions()
        {
            ViewPassword = c_password,
            EditPassword = c_password,
            MarkAsFinal = true
        };
        var apiResponse = await api.ProtectWithHttpInfoAsync(fileStream, protectionOptions);
        Assert.AreEqual(apiResponse.StatusCode, HttpStatusCode.OK);
        Assert.AreEqual(apiResponse.ResponseType, typeof(Stream));
    }

    private const string c_testFile = "../../../../TestData/test.pptx";
    private const string c_password = "password";
}