//Copyright (c) 2024 Smallize Pty Ltd. All Rights Reserved
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Slidize.Cloud.Sdk.Api;

namespace Slidize.Cloud.Sdk.Tests.UseCases;

[TestClass]
public class RemoveAnnotationsTests
{
    [TestMethod]
    public void RemoveAnnotations()
    {
        var api = new SlidizeApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        var stream = api.RemoveAnnotations(fileStream);
        Assert.IsTrue(stream.Length > 0);
    }
    
    [TestMethod]
    public void RemoveAnnotationsWithHttpInfo()
    {
        var api = new SlidizeApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        var apiResponse = api.RemoveAnnotationsWithHttpInfo(fileStream);
        Assert.AreEqual(apiResponse.StatusCode, HttpStatusCode.OK);
        Assert.AreEqual(apiResponse.ResponseType, typeof(Stream));
    }
    
    [TestMethod]
    public async Task RemoveAnnotationsAsync()
    {
        var api = new SlidizeApi();
        await using var fileStream = File.Open(c_testFile, FileMode.Open);
        var stream = await api.RemoveAnnotationsAsync(fileStream);
        Assert.IsTrue(stream.Length > 0);
    }
    
    [TestMethod]
    public async Task RemoveAnnotationsWithHttpInfoAsync()
    {
        var api = new SlidizeApi();
        await using var fileStream = File.Open(c_testFile, FileMode.Open);
        var apiResponse = await api.RemoveAnnotationsWithHttpInfoAsync(fileStream);
        Assert.AreEqual(apiResponse.StatusCode, HttpStatusCode.OK);
        Assert.AreEqual(apiResponse.ResponseType, typeof(Stream));
    }

    private const string c_testFile = "../../../../TestData/test.pptx";
}