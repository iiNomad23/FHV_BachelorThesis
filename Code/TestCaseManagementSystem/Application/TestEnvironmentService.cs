﻿using Application.Api;
using Application.Dto;
using Application.Dto.Child;
using Domain;
using Domain.Repositories;

namespace Application;

public class TestEnvironmentService : ITestEnvironmentService
{
    private readonly ITestEnvironmentRepository _testEnvironmentRepository;

    public TestEnvironmentService(ITestEnvironmentRepository testEnvironmentRepository)
    {
        _testEnvironmentRepository = testEnvironmentRepository;
    }

    public async Task<TestEnvironmentDTO> FindById(string id)
    {
        var testEnvironment = await _testEnvironmentRepository.FindById(id);

        return new TestEnvironmentDTO
        {
            Id = testEnvironment.DomainId,
            ShortDescription = testEnvironment.ShortDescription,
            LongDescription = testEnvironment.LongDescription,
            TestSystems = testEnvironment.TestSystems
                .Select(ts => new TestSystemDTO
                {
                    Name = ts.Name,
                    Description = ts.Description,
                })
                .ToList()
        };
    }

    public async Task<List<TestEnvironmentDTO>> FindByShortDescription(string shortDescription)
    {
        var testEnvironments = await _testEnvironmentRepository.FindByShortDescription(shortDescription);

        return testEnvironments
            .Select(testEnvironment => new TestEnvironmentDTO
            {
                Id = testEnvironment.DomainId,
                ShortDescription = testEnvironment.ShortDescription,
                LongDescription = testEnvironment.LongDescription,
                TestSystems = testEnvironment.TestSystems
                    .Select(ts => new TestSystemDTO
                    {
                        Name = ts.Name,
                        Description = ts.Description,
                    })
                    .ToList()
            })
            .ToList();
    }

    public async Task<List<TestEnvironmentDTO>> GetAll()
    {
        var testEnvironments = await _testEnvironmentRepository.GetAll();

        return testEnvironments
            .Select(testEnvironment => new TestEnvironmentDTO
            {
                Id = testEnvironment.DomainId,
                ShortDescription = testEnvironment.ShortDescription,
                LongDescription = testEnvironment.LongDescription,
                TestSystems = testEnvironment.TestSystems
                    .Select(ts => new TestSystemDTO
                    {
                        Name = ts.Name,
                        Description = ts.Description,
                    })
                    .ToList()
            })
            .ToList();
    }

    public async Task Create(TestEnvironmentDTO testEnvironmentDTO)
    {
        var nextDomainId = _testEnvironmentRepository.NextIdentity();

        await _testEnvironmentRepository.Add(
            new TestEnvironment(
                nextDomainId,
                testEnvironmentDTO.ShortDescription,
                testEnvironmentDTO.LongDescription,
                testEnvironmentDTO.TestSystems
                    .Select(ts => new TestSystem(
                        ts.Name,
                        ts.Description,
                        nextDomainId
                    ))
                    .ToList()
            )
        );
    }

    public async Task Remove(TestEnvironmentDTO testEnvironmentDTO)
    {
        await _testEnvironmentRepository.Remove(testEnvironmentDTO.Id);
    }

    public async Task AddTestPlans(TestEnvironmentUpdateTestPlanIdsDTO testEnvironmentUpdateTestPlanIdsDTO)
    {
        var testEnvironment = await _testEnvironmentRepository
            .FindById(testEnvironmentUpdateTestPlanIdsDTO.Id);

        foreach (var testPlansId in testEnvironmentUpdateTestPlanIdsDTO.TestPlansIds)
        {
            testEnvironment.AddTestPlan(testPlansId);
        }

        await _testEnvironmentRepository.Update(testEnvironment);
    }

    public async Task RemoveTestPlans(TestEnvironmentUpdateTestPlanIdsDTO testEnvironmentUpdateTestPlanIdsDTO)
    {
        var testEnvironment = await _testEnvironmentRepository
            .FindById(testEnvironmentUpdateTestPlanIdsDTO.Id);

        foreach (var testPlansId in testEnvironmentUpdateTestPlanIdsDTO.TestPlansIds)
        {
            testEnvironment.RemoveTestPlan(testPlansId);
        }

        await _testEnvironmentRepository.Update(testEnvironment);
    }
}