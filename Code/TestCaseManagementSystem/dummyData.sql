INSERT INTO TestCases (DomainId, ShortDescription, LongDescription, AuthorDescription, CreateDate, Priority,
                       ReferenceLink)
VALUES ('TestCase_1', 'Short Description 1', 'Long Description 1', 'Author Description 1', '2023-04-29 10:00:00.000000',
        'High', 'http://example.com/testcase1'),
       ('TestCase_2', 'Short Description 2', 'Long Description 2', 'Author Description 2', '2023-04-29 11:00:00.000000',
        'Medium', 'http://example.com/testcase2'),
       ('TestCase_3', 'Short Description 3', 'Long Description 3', 'Author Description 3', '2023-04-29 12:00:00.000000',
        'Low', 'http://example.com/testcase3'),
       ('TestCase_4', 'Short Description 4', 'Long Description 4', 'Author Description 4', '2023-04-29 13:00:00.000000',
        'High', 'http://example.com/testcase4'),
       ('TestCase_5', 'Short Description 5', 'Long Description 5', 'Author Description 5', '2023-04-29 14:00:00.000000',
        'Medium', 'http://example.com/testcase5'),
       ('TestCase_6', 'Short Description 6', 'Long Description 6', 'Author Description 6', '2023-04-29 15:00:00.000000',
        'Low', 'http://example.com/testcase6'),
       ('TestCase_7', 'Short Description 7', 'Long Description 7', 'Author Description 7', '2023-04-29 16:00:00.000000',
        'High', 'http://example.com/testcase7'),
       ('TestCase_8', 'Short Description 8', 'Long Description 8', 'Author Description 8', '2023-04-29 17:00:00.000000',
        'Medium', 'http://example.com/testcase8'),
       ('TestCase_9', 'Short Description 9', 'Long Description 9', 'Author Description 9', '2023-04-29 18:00:00.000000',
        'Low', 'http://example.com/testcase9'),
       ('TestCase_10', 'Short Description 10', 'Long Description 10', 'Author Description 10',
        '2023-04-29 18:00:00.000000', 'Low', 'http://example.com/testcase10');


INSERT INTO TestEnvironments (DomainId, ShortDescription, LongDescription)
VALUES ('TestEnvironment_1', 'Short Description 1', 'Long Description 1'),
       ('TestEnvironment_2', 'Short Description 2', 'Long Description 2'),
       ('TestEnvironment_3', 'Short Description 3', 'Long Description 3'),
       ('TestEnvironment_4', 'Short Description 4', 'Long Description 4'),
       ('TestEnvironment_5', 'Short Description 5', 'Long Description 5'),
       ('TestEnvironment_6', 'Short Description 6', 'Long Description 6'),
       ('TestEnvironment_7', 'Short Description 7', 'Long Description 7'),
       ('TestEnvironment_8', 'Short Description 8', 'Long Description 8'),
       ('TestEnvironment_9', 'Short Description 9', 'Long Description 9'),
       ('TestEnvironment_10', 'Short Description 10', 'Long Description 10');


INSERT INTO TestImplementations (DomainId, ShortDescription, LongDescription, AuthorDescription, CreateDate,
                                 ReferenceLink)
VALUES ('TestImplementation_1', 'Short Description 1', 'Long Description 1', 'Author Description 1',
        '2023-04-29 14:30:00.000000', 'https://example.com'),
       ('TestImplementation_2', 'Short Description 2', 'Long Description 2', 'Author Description 2',
        '2023-04-29 14:31:00.000000', 'https://example.com'),
       ('TestImplementation_3', 'Short Description 3', 'Long Description 3', 'Author Description 3',
        '2023-04-29 14:32:00.000000', 'https://example.com'),
       ('TestImplementation_4', 'Short Description 4', 'Long Description 4', 'Author Description 4',
        '2023-04-29 14:33:00.000000', 'https://example.com'),
       ('TestImplementation_5', 'Short Description 5', 'Long Description 5', 'Author Description 5',
        '2023-04-29 14:34:00.000000', 'https://example.com'),
       ('TestImplementation_6', 'Short Description 6', 'Long Description 6', 'Author Description 6',
        '2023-04-29 14:35:00.000000', 'https://example.com'),
       ('TestImplementation_7', 'Short Description 7', 'Long Description 7', 'Author Description 7',
        '2023-04-29 14:36:00.000000', 'https://example.com'),
       ('TestImplementation_8', 'Short Description 8', 'Long Description 8', 'Author Description 8',
        '2023-04-29 14:37:00.000000', 'https://example.com'),
       ('TestImplementation_9', 'Short Description 9', 'Long Description 9', 'Author Description 9',
        '2023-04-29 14:38:00.000000', 'https://example.com'),
       ('TestImplementation_10', 'Short Description 10', 'Long Description 10', 'Author Description 10',
        '2023-04-29 14:39:00.000000', 'https://example.com');


INSERT INTO `TestPlans` (`DomainId`, `ShortDescription`, `LongDescription`, `CreateDate`, `ReferenceLink`)
VALUES ('TestPlan_1', 'Plan 1', 'This is the first test plan', '2022-01-01 10:00:00',
        'https://www.gantner-instruments.com/'),
       ('TestPlan_2', 'Plan 2', 'This is the second test plan', '2022-01-02 11:00:00',
        'https://www.gantner-instruments.com/'),
       ('TestPlan_3', 'Plan 3', 'This is the third test plan', '2022-01-03 12:00:00',
        'https://www.gantner-instruments.com/'),
       ('TestPlan_4', 'Plan 4', 'This is the fourth test plan', '2022-01-04 13:00:00',
        'https://www.gantner-instruments.com/'),
       ('TestPlan_5', 'Plan 5', 'This is the fifth test plan', '2022-01-05 14:00:00',
        'https://www.gantner-instruments.com/'),
       ('TestPlan_6', 'Plan 6', 'This is the sixth test plan', '2022-01-06 15:00:00',
        'https://www.gantner-instruments.com/'),
       ('TestPlan_7', 'Plan 7', 'This is the seventh test plan', '2022-01-07 16:00:00',
        'https://www.gantner-instruments.com/'),
       ('TestPlan_8', 'Plan 8', 'This is the eighth test plan', '2022-01-08 17:00:00',
        'https://www.gantner-instruments.com/'),
       ('TestPlan_9', 'Plan 9', 'This is the ninth test plan', '2022-01-09 18:00:00',
        'https://www.gantner-instruments.com/'),
       ('TestPlan_10', 'Plan 10', 'This is the tenth test plan', '2022-01-10 19:00:00',
        'https://www.gantner-instruments.com/');


INSERT INTO `TestRuns` (`DomainId`, `StartDate`, `EndDate`, `State`, `TestSystemId`, `ResultDetailsMap`)
VALUES ('abc123', '2022-01-01 10:00:00.000000', '2022-01-01 11:30:00.000000', 'Success', 'testsys1',
        '{"additionalProp1": {"value": 0,"timestamp": 0,"description": "string","result": true},"additionalProp2": {"value": 0,"timestamp": 0,"description": "string","result": true},"additionalProp3": {"value": 0,"timestamp": 0,"description": "string","result": true}}'),
       ('def456', '2022-02-15 14:30:00.000000', '2022-02-15 16:00:00.000000', 'Failed', 'testsys2',
        '{"additionalProp1": {"value": 0,"timestamp": 0,"description": "string","result": true},"additionalProp2": {"value": 0,"timestamp": 0,"description": "string","result": true},"additionalProp3": {"value": 0,"timestamp": 0,"description": "string","result": true}}'),
       ('ghi789', '2022-03-20 08:00:00.000000', '2022-03-20 10:00:00.000000', 'Success', 'testsys3',
        '{"additionalProp1": {"value": 0,"timestamp": 0,"description": "string","result": true},"additionalProp2": {"value": 0,"timestamp": 0,"description": "string","result": true},"additionalProp3": {"value": 0,"timestamp": 0,"description": "string","result": true}}'),
       ('jkl012', '2022-04-05 13:15:00.000000', '2022-04-05 14:45:00.000000', 'Failed', 'testsys1',
        '{"additionalProp1": {"value": 0,"timestamp": 0,"description": "string","result": true},"additionalProp2": {"value": 0,"timestamp": 0,"description": "string","result": true},"additionalProp3": {"value": 0,"timestamp": 0,"description": "string","result": true}}'),
       ('mno345', '2022-05-10 09:00:00.000000', '2022-05-10 11:00:00.000000', 'Success', 'testsys2',
        '{"additionalProp1": {"value": 0,"timestamp": 0,"description": "string","result": true},"additionalProp2": {"value": 0,"timestamp": 0,"description": "string","result": true},"additionalProp3": {"value": 0,"timestamp": 0,"description": "string","result": true}}'),
       ('pqr678', '2022-06-25 12:30:00.000000', '2022-06-25 13:30:00.000000', 'Success', 'testsys3',
        '{"additionalProp1": {"value": 0,"timestamp": 0,"description": "string","result": true},"additionalProp2": {"value": 0,"timestamp": 0,"description": "string","result": true},"additionalProp3": {"value": 0,"timestamp": 0,"description": "string","result": true}}'),
       ('stu901', '2022-07-08 08:45:00.000000', '2022-07-08 10:00:00.000000', 'Failed', 'testsys1',
        '{"additionalProp1": {"value": 0,"timestamp": 0,"description": "string","result": true},"additionalProp2": {"value": 0,"timestamp": 0,"description": "string","result": true},"additionalProp3": {"value": 0,"timestamp": 0,"description": "string","result": true}}'),
       ('vwx234', '2022-08-15 11:00:00.000000', '2022-08-15 12:00:00.000000', 'Success', 'testsys2',
        '{"additionalProp1": {"value": 0,"timestamp": 0,"description": "string","result": true},"additionalProp2": {"value": 0,"timestamp": 0,"description": "string","result": true},"additionalProp3": {"value": 0,"timestamp": 0,"description": "string","result": true}}'),
       ('yza567', '2022-09-20 13:30:00.000000', '2022-09-20 14:45:00.000000', 'Success', 'testsys3',
        '{"additionalProp1": {"value": 0,"timestamp": 0,"description": "string","result": true},"additionalProp2": {"value": 0,"timestamp": 0,"description": "string","result": true},"additionalProp3": {"value": 0,"timestamp": 0,"description": "string","result": true}}'),
       ('bcd890', '2022-10-05 10:15:00.000000', '2022-10-05 11:30:00.000000', 'Failed', 'testsys1',
        '{"additionalProp1": {"value": 0,"timestamp": 0,"description": "string","result": true},"additionalProp2": {"value": 0,"timestamp": 0,"description": "string","result": true},"additionalProp3": {"value": 0,"timestamp": 0,"description": "string","result": true}}');


INSERT INTO `TestSystems` (`Name`, `Description`, `TestEnvironmentDomainId`)
VALUES ('System1', 'This is the first test system', 'TestEnvironment_1'),
       ('System2', 'This is the second test system', 'TestEnvironment_4'),
       ('System3', 'This is the third test system', 'TestEnvironment_1'),
       ('System4', 'This is the fourth test system', 'TestEnvironment_3'),
       ('System5', 'This is the fifth test system', 'TestEnvironment_8'),
       ('System6', 'This is the sixth test system', 'TestEnvironment_10'),
       ('System7', 'This is the seventh test system', 'TestEnvironment_4'),
       ('System8', 'This is the eighth test system', 'TestEnvironment_5'),
       ('System9', 'This is the ninth test system', 'TestEnvironment_6'),
       ('System10', 'This is the tenth test system', 'TestEnvironment_1');


INSERT INTO `TestEnvironmentPlans` (`TestEnvironmentDomainId`, `TestPlanDomainId`)
VALUES ('TestEnvironment_1', 'TestPlan_1'),
       ('TestEnvironment_1', 'TestPlan_3'),
       ('TestEnvironment_1', 'TestPlan_5'),
       ('TestEnvironment_2', 'TestPlan_1'),
       ('TestEnvironment_3', 'TestPlan_1'),
       ('TestEnvironment_2', 'TestPlan_2'),
       ('TestEnvironment_2', 'TestPlan_7'),
       ('TestEnvironment_5', 'TestPlan_8'),
       ('TestEnvironment_8', 'TestPlan_10'),
       ('TestEnvironment_10', 'TestPlan_9');

# INSERT INTO `DeviceDetails` (`TestRunId`, `Id`, `Name`, `Firmware`, `MkCode`, `Serial`)
# VALUES
#     (1, 1, 'Device1', 'v1.0', 'MK-001', 'SER-001'),
#     (1, 2, 'Device2', 'v2.1', 'MK-002', 'SER-002'),
#     (1, 3, 'Device3', 'v3.3', 'MK-003', 'SER-003'),
#     (2, 4, 'Device4', 'v4.2', 'MK-004', 'SER-004'),
#     (2, 5, 'Device5', 'v5.1', 'MK-005', 'SER-005'),
#     (2, 6, 'Device6', 'v6.3', 'MK-006', 'SER-006'),
#     (3, 7, 'Device7', 'v7.0', 'MK-007', 'SER-007'),
#     (3, 8, 'Device8', 'v8.2', 'MK-008', 'SER-008'),
#     (3, 9, 'Device9', 'v9.1', 'MK-009', 'SER-009'),
#     (4, 10, 'Device10', 'v10.0', 'MK-010', 'SER-010');
