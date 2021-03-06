﻿using Ardalis.GuardClauses;
using EventFlow.Aggregates;
using EventFlow.EventStores;
using System;
using System.Collections.Generic;
using System.Text;

namespace Szlem.Recruitment.Impl.Enrollments.Events
{
    [EventVersion("Szlem.Recruitment.CandidateResignedPermanently", 1)]
    internal class CandidateResignedPermanently : AggregateEvent<EnrollmentAggregate, EnrollmentAggregate.EnrollmentId>
    {
        public Guid RecordingCoordinatorID { get; }
        public Recruitment.Enrollments.CommunicationChannel CommunicationChannel { get; }
        public string ResignationReason { get; }
        public string AdditionalNotes { get; }

        public CandidateResignedPermanently(
            Guid recordingCoordinatorID,
            Recruitment.Enrollments.CommunicationChannel communicationChannel,
            string resignationReason,
            string additionalNotes)
        {
            Guard.Against.Default(recordingCoordinatorID, nameof(recordingCoordinatorID));
            Guard.Against.Default(communicationChannel, nameof(communicationChannel));
            Guard.Against.Null(resignationReason, nameof(resignationReason));
            Guard.Against.Null(additionalNotes, nameof(additionalNotes));

            RecordingCoordinatorID = recordingCoordinatorID;
            CommunicationChannel = communicationChannel;
            ResignationReason = resignationReason;
            AdditionalNotes = additionalNotes;
        }
    }
}
