namespace EcrOneClick.Infrastructure.Abstract;

public interface IDockerService
{
    Task<List<DockerImage>> GetImages();
}