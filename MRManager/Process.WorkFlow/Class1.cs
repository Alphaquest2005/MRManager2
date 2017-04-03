using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Actor.Interfaces;
using DomainMessages;
using EventMessages.Events;
using Interfaces;
using RevolutionEntities;
using RevolutionEntities.Process;

namespace Process.WorkFlow
{
    public class SignIn
    {
        public static IProcessAction IntializeSigninProcessState => new ProcessAction(
            action: async cp =>
            {
                var ps = new ProcessState<IUserSignIn>(
                    process: cp.Actor.Process,
                    entity: NullEntity<IUserSignIn>.Instance,
                    info: new StateInfo(cp.Actor.Process.Id,
                        new State(name: "AwaitUserName", status: "Waiting for User Name",
                            notes:
                                "Please Enter your User Name. If this is your First Time Login In please Contact the Receptionist for your user info.")));
                return await Task.Run(() => new UpdateProcessState<IUserSignIn>(ps,
                    new StateCommandInfo(cp.Actor.Process.Id, RevolutionData.Context.Process.Commands.UpdateState),
                    cp.Actor.Process, cp.Actor.Source));

            },
            processInfo: cp => new StateCommandInfo(cp.Actor.Process.Id, RevolutionData.Context.Process.Commands.CreateState),
            // take shortcut cud be IntialState
            expectedSourceType: new SourceType(typeof(IComplexEventService)));

        public static IProcessAction UserNameFound => new ProcessAction(
            action: async cp =>
            {
                var ps = new ProcessState<IUserSignIn>(cp.Actor.Process, cp.Messages["UserNameFound"].Entity,
                    new StateInfo(cp.Actor.Process.Id, "WelcomeUser",
                        $"Welcome {cp.Messages["UserNameFound"].Entity.Usersignin}", "Please Enter your Password"));
                return await Task.Run(() => new UpdateProcessState<IUserSignIn>(ps,
                    new StateCommandInfo(cp.Actor.Process.Id, RevolutionData.Context.Process.Commands.UpdateState),
                    cp.Actor.Process, cp.Actor.Source));
            },
            processInfo: cp => new StateCommandInfo(cp.Actor.Process.Id, RevolutionData.Context.Process.Commands.UpdateState),
            expectedSourceType: new SourceType(typeof(IComplexEventService))
            );

        public static IProcessAction SetProcessStatetoValidatedUser => new ProcessAction(
            action: async cp =>
            {
                var ps = new ProcessState<IUserSignIn>(cp.Actor.Process, cp.Messages["ValidatedUser"].Entity,
                    new StateInfo(cp.Actor.Process.Id, "UserValidated",
                        $"User: {cp.Messages["ValidatedUser"].Entity.Usersignin} Validated", "User Validated"));
                return await Task.Run(() => new UpdateProcessState<IUserSignIn>(ps,
                    new StateCommandInfo(cp.Actor.Process.Id, RevolutionData.Context.Process.Commands.UpdateState),
                    cp.Actor.Process, cp.Actor.Source));
            },
            processInfo: cp => new StateCommandInfo(cp.Actor.Process.Id, RevolutionData.Context.Process.Commands.UpdateState),
            expectedSourceType: new SourceType(typeof(IComplexEventService)));


        public static IProcessAction UserValidated => new ProcessAction(
            action: async cp =>
                     await Task.Run(() => new UserValidated(cp.Messages["ValidatedUser"].Entity,
                        new StateEventInfo(cp.Actor.Process.Id, RevolutionData.Context.Domain.Events.DomainEventPublished),
                        cp.Actor.Process, cp.Actor.Source)),
            processInfo: cp => new StateCommandInfo(cp.Actor.Process.Id, RevolutionData.Context.Domain.Commands.PublishDomainEvent),
            expectedSourceType: new SourceType(typeof(IComplexEventService))
            );


    }
}
