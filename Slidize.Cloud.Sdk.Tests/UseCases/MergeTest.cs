//Copyright (c) 2024 Smallize Pty Ltd. All Rights Reserved
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Slidize.Cloud.Sdk.Api;
using Slidize.Cloud.Sdk.Model;

namespace Slidize.Cloud.Sdk.Tests.UseCases;

[TestClass]
public class MergeTest
{
    [TestMethod]
    public void Merge()
    {
        var api = new SlidizeApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        using var masterFileStream = File.Open(c_masterFile, FileMode.Open);
        var mergeOptions = new MergeOptions()
        {
            MasterFileName = Path.GetFileName(c_masterFile),
            ExcludeMasterFile = false
        };
        
        var stream = api.Merge(ExportFormat.Pdf, new List<Stream>() {fileStream, masterFileStream}, mergeOptions);
        Assert.IsTrue(stream.Length > 0);
    }
    
    [TestMethod]
    public async Task MergeAsync()
    {
        var api = new SlidizeApi();
        await using var fileStream = File.Open(c_testFile, FileMode.Open);
        await using var masterFileStream = File.Open(c_masterFile, FileMode.Open);
        var mergeOptions = new MergeOptions()
        {
            MasterFileName = Path.GetFileName(c_masterFile),
            ExcludeMasterFile = false
        };
        
        var stream = await api.MergeAsync(ExportFormat.Pdf, new List<Stream>() {fileStream, masterFileStream}, mergeOptions);
        Assert.IsTrue(stream.Length > 0);
    }
    
    [TestMethod]
    public void MergeHttpInfo()
    {
        var api = new SlidizeApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        using var masterFileStream = File.Open(c_masterFile, FileMode.Open);
        var mergeOptions = new MergeOptions()
        {
            MasterFileName = Path.GetFileName(c_masterFile),
            ExcludeMasterFile = false
        };
        var apiResponse = api.MergeWithHttpInfo(ExportFormat.Pdf, new List<Stream>() { fileStream, masterFileStream },
            mergeOptions);
        
        Assert.AreEqual(apiResponse.StatusCode, HttpStatusCode.OK);
        Assert.AreEqual(apiResponse.ResponseType, typeof(Stream));
    }
    
    [TestMethod]
    public async Task MergeHttpInfoAsync()
    {
        var api = new SlidizeApi();
        await using var fileStream = File.Open(c_testFile, FileMode.Open);
        await using var masterFileStream = File.Open(c_masterFile, FileMode.Open);
        var mergeOptions = new MergeOptions()
        {
            MasterFileName = Path.GetFileName(c_masterFile),
            ExcludeMasterFile = false
        };
        var apiResponse = await api.MergeWithHttpInfoAsync(ExportFormat.Pdf,
            new List<Stream>() { fileStream, masterFileStream }, mergeOptions);
        
        Assert.AreEqual(apiResponse.StatusCode, HttpStatusCode.OK);
        Assert.AreEqual(apiResponse.ResponseType, typeof(Stream));
    }
    
    private const string c_testFile = "../../../../TestData/test.pptx";
    private const string c_masterFile = "../../../../TestData/master.pptx";
}