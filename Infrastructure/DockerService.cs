using Docker.DotNet;
using Docker.DotNet.Models;
using EcrOneClick.Infrastructure.Abstract;

namespace EcrOneClick.Infrastructure;

public class DockerService : IDockerService
{
    private readonly DockerClient _dockerClient;
    
    public DockerService()
    {
        _dockerClient = new DockerClientConfiguration().CreateClient();
    }   
    
    public async Task<List<DockerImage>> GetImages()
    {
        try
        {
            var images = await _dockerClient.Images.ListImagesAsync(new ImagesListParameters()
            {
                All = true
            });

            if (images is null) return [];

            List<DockerImage> imageList = [];

            foreach (var image in images)
            {
                imageList.Add(new DockerImage()
                {
                    Name = string.Join(",", image.RepoTags)
                });
            }

            return imageList;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return [];
        }
    }
}