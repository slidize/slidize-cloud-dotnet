//Copyright (c) 2024 Smallize Pty Ltd. All Rights Reserved
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Slidize.Cloud.Sdk.Api;
using Slidize.Cloud.Sdk.Model;

namespace Slidize.Cloud.Sdk.Tests.UseCases;

[TestClass]
public class ConvertTests
{
    [TestMethod]
    public void Convert()
    {
        var api = new SlidizeApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        var stream = api.Convert(ExportFormat.Pdf, new List<Stream>() {fileStream});
        Assert.IsTrue(stream.Length > 0);
    }
    
    [TestMethod]
    public void ConvertWithHttpInfo()
    {
        var api = new SlidizeApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        var apiResponse = api.ConvertWithHttpInfo(ExportFormat.Pdf, new List<Stream>() {fileStream});
        Assert.AreEqual(apiResponse.StatusCode, HttpStatusCode.OK);
        Assert.AreEqual(apiResponse.ResponseType, typeof(Stream));
    }
    
    [TestMethod]
    public async Task ConvertAsync()
    {
        var api = new SlidizeApi();
        await using var fileStream = File.Open(c_testFile, FileMode.Open);
        var stream = await api.ConvertAsync(ExportFormat.Pdf, new List<Stream>() {fileStream});
        Assert.IsTrue(stream.Length > 0);
    }
    
    [TestMethod]
    public async Task ConvertWithHttpInfoAsync()
    {
        var api = new SlidizeApi();
        await using var fileStream = File.Open(c_testFile, FileMode.Open);
        var apiResponse = await api.ConvertWithHttpInfoAsync(ExportFormat.Pdf, new List<Stream>() {fileStream});
        Assert.AreEqual(apiResponse.StatusCode, HttpStatusCode.OK);
        Assert.AreEqual(apiResponse.ResponseType, typeof(Stream));
    }

    private const string c_testFile = "../../../../TestData/test.pptx";
}