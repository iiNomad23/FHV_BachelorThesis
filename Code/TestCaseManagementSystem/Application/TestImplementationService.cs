﻿using Application.Api;
using Application.Dto;
using Domain;
using Domain.Repositories;

namespace Application;

public class TestImplementationService : ITestImplementationService
{
    private readonly ITestImplementationRepository _testImplementationRepository;

    public TestImplementationService(ITestImplementationRepository testImplementationRepository)
    {
        _testImplementationRepository = testImplementationRepository;
    }

    public async Task<TestImplementationDTO> FindById(string id)
    {
        var testImplementation = await _testImplementationRepository.FindById(id);

        return new TestImplementationDTO
        {
            Id = testImplementation.DomainId,
            ShortDescription = testImplementation.ShortDescription,
            LongDescription = testImplementation.LongDescription,
            AuthorDescription = testImplementation.AuthorDescription,
            ReferenceLink = testImplementation.ReferenceLink
        };
    }

    public async Task<List<TestImplementationDTO>> FindByShortDescription(string shortDescription)
    {
        var testImplementations = await _testImplementationRepository.FindByShortDescription(shortDescription);

        return testImplementations
            .Select(testImplementation => new TestImplementationDTO
            {
                Id = testImplementation.DomainId,
                ShortDescription = testImplementation.ShortDescription,
                LongDescription = testImplementation.LongDescription,
                AuthorDescription = testImplementation.AuthorDescription,
                ReferenceLink = testImplementation.ReferenceLink
            })
            .ToList();
    }

    public async Task<List<TestImplementationDTO>> GetAll()
    {
        var testImplementations = await _testImplementationRepository.GetAll();

        return testImplementations
            .Select(testImplementation => new TestImplementationDTO
            {
                Id = testImplementation.DomainId,
                ShortDescription = testImplementation.ShortDescription,
                LongDescription = testImplementation.LongDescription,
                AuthorDescription = testImplementation.AuthorDescription,
                ReferenceLink = testImplementation.ReferenceLink
            })
            .ToList();
    }

    public async Task Create(TestImplementationDTO testImplementationDTO)
    {
        await _testImplementationRepository.Add(
            new TestImplementation(
                _testImplementationRepository.NextIdentity(),
                testImplementationDTO.ShortDescription,
                testImplementationDTO.LongDescription,
                testImplementationDTO.AuthorDescription,
                DateTime.Now.ToUniversalTime(),
                testImplementationDTO.ReferenceLink
            )
        );
    }

    public async Task Remove(TestImplementationDTO testImplementationDTO)
    {
        await _testImplementationRepository.Remove(testImplementationDTO.Id);
    }
}