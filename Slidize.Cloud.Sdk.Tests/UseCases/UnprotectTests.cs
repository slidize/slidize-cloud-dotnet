//Copyright (c) 2024 Smallize Pty Ltd. All Rights Reserved
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Slidize.Cloud.Sdk.Api;

namespace Slidize.Cloud.Sdk.Tests.UseCases;

[TestClass]
public class UnprotectTests
{
    [TestMethod]
    public void Unprotect()
    {
        var api = new SlidizeApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        var stream = api.Unprotect(c_password,fileStream);
        Assert.IsTrue(stream.Length > 0);
    }
    
    [TestMethod]
    public void UnprotectWithHttpInfo()
    {
        var api = new SlidizeApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        var apiResponse = api.UnprotectWithHttpInfo(c_password, fileStream);
        Assert.AreEqual(apiResponse.StatusCode, HttpStatusCode.OK);
        Assert.AreEqual(apiResponse.ResponseType, typeof(Stream));
    }
    
    [TestMethod]
    public async Task UnprotectAsync()
    {
        var api = new SlidizeApi();
        await using var fileStream = File.Open(c_testFile, FileMode.Open);
        var stream = await api.UnprotectAsync(c_password, fileStream);
        Assert.IsTrue(stream.Length > 0);
    }
    
    [TestMethod]
    public async Task UnprotectWithHttpInfoAsync()
    {
        var api = new SlidizeApi();
        await using var fileStream = File.Open(c_testFile, FileMode.Open);
        var apiResponse = await api.UnprotectWithHttpInfoAsync(c_password, fileStream);
        Assert.AreEqual(apiResponse.StatusCode, HttpStatusCode.OK);
        Assert.AreEqual(apiResponse.ResponseType, typeof(Stream));
    }

    private const string c_testFile = "../../../../TestData/protected.pptx";
    private const string c_password = "password";
}