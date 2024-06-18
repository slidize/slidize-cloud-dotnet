//Copyright (c) 2024 Smallize Pty Ltd. All Rights Reserved
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Slidize.Cloud.Sdk.Api;
using Slidize.Cloud.Sdk.Model;

namespace Slidize.Cloud.Sdk.Tests.UseCases;

[TestClass]
public class ConvertToVideoTests
{
    [TestMethod]
    public void ConvertToVideo()
    {
        var api = new SlidizeApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        var videoOptions = new VideoOptions()
        {
            Duration = 3,
            Transition = 1,
            ResolutionType = VideoResolutionType.SD,
            TransitionType = VideoTransitionType.Dissolve
        };
        var stream = api.ConvertToVideo(fileStream, videoOptions);
        Assert.IsTrue(stream.Length > 0);
    }
    
    [TestMethod]
    public void ConvertToVideoWithHttpInfo()
    {
        var api = new SlidizeApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        var videoOptions = new VideoOptions()
        {
            Duration = 3,
            Transition = 1,
            ResolutionType = VideoResolutionType.SD,
            TransitionType = VideoTransitionType.None
        };
        var apiResponse = api.ConvertToVideoWithHttpInfo(fileStream, videoOptions);
        Assert.AreEqual(apiResponse.StatusCode, HttpStatusCode.OK);
        Assert.AreEqual(apiResponse.ResponseType, typeof(Stream));
    }
    
    [TestMethod]
    public async Task ConvertToVideoAsync()
    {
        var api = new SlidizeApi();
        await using var fileStream = File.Open(c_testFile, FileMode.Open);
        var videoOptions = new VideoOptions()
        {
            Duration = 3,
            Transition = 1,
            ResolutionType = VideoResolutionType.SD,
            TransitionType = VideoTransitionType.Dissolve
        };
        var stream = await api.ConvertToVideoAsync(fileStream, videoOptions);
        Assert.IsTrue(stream.Length > 0);
    }
    
    [TestMethod]
    public async Task ConvertToVideoWithHttpInfoAsync()
    {
        var api = new SlidizeApi();
        await using var fileStream = File.Open(c_testFile, FileMode.Open);
        var videoOptions = new VideoOptions()
        {
            Duration = 3,
            Transition = 1,
            ResolutionType = VideoResolutionType.SD,
            TransitionType = VideoTransitionType.None
        };
        var apiResponse = await api.ConvertToVideoWithHttpInfoAsync(fileStream, videoOptions);
        Assert.AreEqual(apiResponse.StatusCode, HttpStatusCode.OK);
        Assert.AreEqual(apiResponse.ResponseType, typeof(Stream));
    }

    private const string c_testFile = "../../../../TestData/test.pptx";
    
}