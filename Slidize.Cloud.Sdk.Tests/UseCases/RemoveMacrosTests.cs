//Copyright (c) 2024 Smallize Pty Ltd. All Rights Reserved
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Slidize.Cloud.Sdk.Api;

namespace Slidize.Cloud.Sdk.Tests.UseCases;

[TestClass]
public class RemoveMacrosTests
{
    [TestMethod]
    public void RemoveMacros()
    {
        var api = new SlidizeApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        var stream = api.RemoveMacros(fileStream);
        Assert.IsTrue(stream.Length > 0);
    }
    
    [TestMethod]
    public void RemoveMacrosWithHttpInfo()
    {
        var api = new SlidizeApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        var apiResponse = api.RemoveMacrosWithHttpInfo(fileStream);
        Assert.AreEqual(apiResponse.StatusCode, HttpStatusCode.OK);
        Assert.AreEqual(apiResponse.ResponseType, typeof(Stream));
    }
    
    [TestMethod]
    public async Task RemoveMacrosAsync()
    {
        var api = new SlidizeApi();
        await using var fileStream = File.Open(c_testFile, FileMode.Open);
        var stream = await api.RemoveMacrosAsync(fileStream);
        Assert.IsTrue(stream.Length > 0);
    }
    
    [TestMethod]
    public async Task RemoveMacrosWithHttpInfoAsync()
    {
        var api = new SlidizeApi();
        await using var fileStream = File.Open(c_testFile, FileMode.Open);
        var apiResponse = await api.RemoveMacrosWithHttpInfoAsync(fileStream);
        Assert.AreEqual(apiResponse.StatusCode, HttpStatusCode.OK);
        Assert.AreEqual(apiResponse.ResponseType, typeof(Stream));
    }

    private const string c_testFile = "../../../../TestData/macros.pptm";
}