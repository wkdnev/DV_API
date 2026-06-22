### CP-1 — Policy and Procedures (Control)

This requirement is about making sure the organisation has a clear, written plan for what to do when things go wrong, so services can be restored quickly and responsibilities are understood before an emergency happens. Without an up-to-date contingency planning policy and practical procedures, confusion during a disruption could slow recovery, increase downtime, and result in failing to meet legal and regulatory obligations.

The organisation must create and document a contingency planning policy and the procedures needed to carry it out. This must explain why the plan exists, what it covers, who is responsible for what, the commitment from senior leadership, how different teams work together, and how the organisation will meet compliance requirements. The policy and procedures must also align with all relevant laws, directives, regulations, and internal standards.

The Chief Information Security Officer (CISO), or a delegated contingency planning lead, must be formally responsible for developing, documenting, and sharing the policy with the CISO, Chief Information Officer, security and privacy programme leads, and system owners. They must also ensure the procedures are shared with IT operations managers, the incident response lead, business continuity coordinators, and system administrators.

The policy must be reviewed and updated every year and after any significant change, including after security incidents, audit findings, major system or operational technology changes, changes in laws, and changes in risk assessments. The procedures must also be reviewed and updated every year and after test results show deficiencies, after changes to roles or contacts, after changes to recovery capabilities, or after significant changes to network or operational technology architecture.

##### CISO-owned contingency planning policy & role-based procedures suite

- Category: Manual
- Priority: Critical

###### WHAT
Create an organisation-wide **contingency planning policy** and supporting **procedures**. These should clearly set out the purpose and scope, who does what, how security and privacy teams work together, who receives the documents, and how the documents are governed so they stay up to date.

###### WHY (control requirement)
CP-1 requires contingency planning **policy and procedures** that are more than just a repeat of other requirements. They must match the organisation’s risk management approach and be developed together by the security and privacy programmes. The policy must be owned by an authorised official (Chief Information Security Officer (CISO) or a delegated lead), shared with the defined roles, and reviewed and updated at least every year and after defined events. The procedures must also be reviewed and updated at least every year and after defined events.

###### HOW (specific approach)
1. **Create a controlled set of documents**:
   - One official **Contingency Planning Policy** (either organisation-wide or for a specific mission/business process). It must include clear sections for: purpose, scope, management commitment, the coordination approach (security and privacy working together), roles and responsibilities, alignment with relevant laws/directives/regulations/standards, and references to the procedure documents.
   - A set of **role-based procedure documents**, for example: Recovery Roles and Escalation; Communications and Contact Management; Disaster Recovery (DR) Test Management; Post-incident Update Process; and, where applicable, an Operational Technology (OT)/network architecture change impact checklist.
2. **Assign and document ownership**:
   - Name the **CISO (or delegated Contingency Planning Lead)** as the official responsible for managing the policy and procedures.
   - Set up a **Contingency Planning Working Group** (CISO, Security, Privacy, IT Operations, Risk Management) with documented decision rights and an approval (sign-off) process.
3. **Define who receives what**:
   - Share the **policy** with: CISO, Chief Information Officer, Security and Privacy programme leads, and system owners.
   - Share the **procedures** with: IT operations managers, the incident response lead, business continuity coordinators, and system administrators.
4. **Set review/update triggers and keep proof**:
   - Review and update the **policy** at least annually and after any material change, including: security incidents or breaches, audit findings, major system/OT changes, changes to laws/directives/regulations, and changes to risk assessment outcomes.
   - Review and update the **procedures** at least annually and after: test results that show gaps, changes to roles and responsibilities, changes to contact lists, changes to recovery capabilities, and major network/OT architecture changes.
   - For every update decision, record why (update or no update) and keep evidence that the review was completed.
5. **Use one trusted source of documents with version control**:
   - Store the documents in an enterprise policy/governance, risk and compliance (GRC) repository (or an equivalent controlled document system) with version control, access controls, and publication dates/times.
   - Make sure each procedure document states the exact policy version it follows.

###### WHO (roles responsible)
- **CISO (or delegated Contingency Planning Lead)**: owns, manages, and shares the policy and procedures.
- **Contingency Planning Working Group**: drafts, reviews, and provides agreement (Security, Privacy, IT Operations, Risk).
- **Security and Privacy programme leads**: work together to develop the policy and procedures and provide sign-off.
- **System owners and IT operations/incident response/business continuity coordinators**: receive and put the procedures into practice.

###### Acceptance criteria
- A controlled **Contingency Planning Policy** exists, is approved by the CISO (or delegate), and clearly includes purpose/scope/roles/responsibilities/coordination/compliance alignment.
- Role-based **contingency planning procedures** exist and link to the specific policy version they implement.
- Sharing can be demonstrated: named recipients for the policy and procedures are recorded, and evidence of publication and acknowledgement is kept.
- Review and update timing is in place: the policy is reviewed at least annually and after defined events; the procedures are reviewed at least annually and after defined events.
- Evidence that security and privacy programmes worked together is kept (for example: sign-offs, meeting minutes, or tracked approvals).

###### Actions Required for Compliance

- [ ] Draft and get approval for an organisation-wide business continuity and contingency planning policy. The policy must be owned by the Chief Information Security Officer (CISO) (or a delegated Contingency Planning Lead) and must clearly state its purpose, coverage, responsibilities, how it is coordinated, and how it aligns with required compliance obligations.
- [ ] Create role-based contingency planning procedures, including: a policy-to-procedure implementation guide; recovery roles and escalation steps; communications and contact management; disaster recovery (DR) testing management; and a process for updating information after incidents.
- [ ] Define and document the distribution lists for policy recipients and procedure recipients, and publish documents through a controlled, version-managed repository.
- [ ] Create a contingency planning working group charter, with an approval process that includes sign-off from the Security and Privacy programme leads and agreement from Risk Management.
- [ ] Set review and update schedules: review the policy every year and whenever there is a major change. Review the procedures every year and whenever there are test failures, changes to roles, contacts, or recovery capability, or significant changes to the network or operational technology (OT) architecture.
- [ ] Keep auditable records showing collaboration, approvals, distribution, and the decision made at each review or update (including why an update was made or why no update was needed).


---

### CP-2 — Contingency Plan (Control)

This requirement is about having a clear, ready-to-use plan for what to do if a key service stops working, is suspected to be compromised, or simply fails. Without it, essential work could stop, the wrong people might be contacted too late, recovery could happen in the wrong order, and the organisation might return to normal in a way that weakens the protections it originally put in place.

The organisation must create a contingency plan that:
- identifies the essential mission and business functions
- sets recovery goals
- defines the order for restoring services
- includes simple ways to track progress
- names specific people for each role, including their contact details
- explains how essential functions will continue during disruption
- explains how full restoration will happen later, without reducing the protections that were planned

The plan must also cover:
- how contingency information will be shared
- review by the Chief Information Security Officer and the System Security Officer
- approval by the Authorising Official

Copies must be provided to the security operations centre (SOC), network operations centre (NOC), IT Operations, and the continuity of operations (COOP) team. Updates must be communicated to the SOC Manager, NOC Manager, System Owner, COOP Lead, and relevant teams.

The plan must be reviewed at least annually, updated when changes or issues arise, include lessons learned from testing and training, coordinate with incident handling, and be protected from unauthorised viewing or alteration.

##### Single approved COOP contingency plan with named contacts & metrics

- Category: Manual
- Priority: Critical

###### WHAT
Create and maintain one single, authoritative contingency plan for the application/system. It must set out: (1) the essential mission/business functions, (2) recovery goals and the order for restoring services, (3) measurable recovery measures, (4) named contingency roles with contact details, (5) how essential functions will keep working during disruption, compromise, or failure (including backup/manual ways of working and alternative ways to share information), and (6) how the system will be fully restored without weakening security protections.

###### WHY (control requirement)
CP-2 requires contingency planning that supports continued operations by covering how the system will be restored and how alternative mission/business processes will operate when systems are compromised or breached. The plan must be considered throughout the system development life cycle. It must include actions such as orderly degradation/shutdown, fallback/manual mode, and alternative information flows, and it must coordinate with incident handling activities. It must also reflect how much restoration is needed, based on recovery goals taken from laws, directives, regulations, policies, standards, and guidelines, and on the organisation’s acceptable level of risk.

###### HOW (specific approach)
1. **Build the plan around essential functions**: create an inventory of essential functions for the application (for example, services that depend on authentication, core business workflows, data services, and administrative functions) and link each function to the required information technology/operational technology (IT/OT) capabilities and dependencies.
2. **Define the restoration order and degraded/fallback modes**: for each essential function, document the acceptable degraded mode(s), the fallback/manual mode(s), and the alternative information flows (for example, alternative application programming interfaces (APIs), cached read-only operations, a reduced feature set, and manual approvals). Include clear start and stop criteria.
3. **Set recovery goals and measurable measures**: define recovery time objective (RTO) and recovery point objective (RPO) targets for each essential function. Include objective recovery checks (for example, identity/authentication is restored, integrity verification is completed, monitoring/security information and event management (SIEM) alerts are restored, backup restoration is validated, and access control enforcement is verified).
4. **Assign named contingency roles and contacts**: implement the organisation-defined roles (Chief Information Security Officer (CISO), single sign-on (SSO), Authorising Official (AO); security operations centre (SOC) manager, network operations centre (NOC) manager, system owner, continuity of operations (COOP) lead; SOC/NOC/IT operations/COOP team) with named individuals, phone/email contacts, and out-of-hours escalation routes. Ensure the plan states who activates the plan and who carries out each restoration workstream.
5. **Coordinate with incident handling**: add clear activation triggers and handovers to incident response (for example, suspected breach versus service availability failure). Also state how contingency actions will not conflict with incident response decisions, including whether any actions must be carried out only in modes reserved for when systems are under attack.
6. **Govern, protect, distribute, and review**: restrict document access (most users read-only; authorised owners use change control), distribute copies to SOC, NOC, IT operations, and the COOP team, and ensure the plan is reviewed at least annually by the CISO and the SSO and approved by the AO. Keep a record of changes and communicate updates to the named key personnel.

###### WHO
- **Chief Information Security Officer (CISO)** and **System Security Officer (SSO)**: review the contingency plan content and confirm it is secure enough.
- **Authorising Official (AO)**: approve the contingency plan.
- **System Owner / COOP Lead**: maintain the plan and ensure the essential-function mapping and restoration steps are up to date.
- **SOC Manager / NOC Manager / IT Operations**: confirm the degraded/fallback modes and restoration measures are practical to operate.

###### Acceptance criteria
- The contingency plan clearly lists the essential mission/business functions, restoration priorities, and RTO/RPO targets for each function.
- The plan includes fallback/manual modes and alternative information flows, with clear activation criteria.
- Named contacts are in place for each contingency role (including SOC/NOC/IT operations/COOP), with contact details and escalation routes.
- The plan includes measurable recovery measures/checks that can be used during an event.
- The plan shows coordination with incident handling through documented activation triggers and handovers.
- Evidence exists that: (a) the CISO and SSO reviewed the plan, (b) the AO approved it, (c) there is an annual review schedule, and (d) it is distributed in a controlled way to SOC/NOC/IT operations/COOP with controlled change management.

###### Actions Required for Compliance

- [ ] Create a list of the application’s essential functions, and link each function to the required dependencies and capabilities.
- [ ] For each essential function, define what “degraded”, “fallback”, and “manual” modes mean, how information will flow in each case, and the conditions that trigger switching into those modes.
- [ ] Set recovery time objective (RTO) and recovery point objective (RPO) targets, and define restoration priorities for each essential function. Add measurable recovery checks and performance metrics.
- [ ] Create a contingency roles document that lists named contacts for each role (security operations centre (SOC) manager, network operations centre (NOC) manager, system owner, and business continuity and disaster recovery (COOP) lead) and the escalation routes to follow.
- [ ] Set up incident-handling coordination, including what triggers activation, how responsibilities are handed over, and how contingency actions differ between a suspected security breach and an availability failure.
- [ ] Put controlled access in place for the contingency plan and manage who can receive and use it, including the security operations centre (SOC), network operations centre (NOC), IT Operations, and the continuity of operations plan (COOP) team.
- [ ] Arrange and record an annual review by the Chief Information Security Officer (CISO) and the Senior Security Officer (SSO), and obtain approval from the Authorising Officer (AO), with an auditable record of all changes.


---

#### CP-2.1 — Coordinate with Related Plans (Enhancement)

This requirement is about making sure your disruption and recovery plans are developed together, not separately. If your business continuity, disaster recovery, continuity of operations, crisis communications, critical infrastructure plans, incident and breach response, insider-threat actions, data-breach response, and building emergency plans are not coordinated, teams may act at the wrong time, contact the wrong people first, give conflicting instructions, or leave responsibilities uncovered—turning a manageable disruption into a longer, more expensive problem.

To meet this expectation, the organisation must:
- identify who is responsible for each related plan
- name specific people to coordinate the work
- include people who handle information in the planning discussions

When the contingency plan is created, these responsible owners must provide input so that the triggers for action, escalation routes, roles, handovers, and procedures match across all documents. The organisation must also keep evidence that this joint work has been done, and maintain a repeatable process to review and update the plans together whenever changes occur.

##### Plan-of-plans coordination for contingency planning (CP-2(1))

- Category: Manual
- Priority: Critical

###### WHAT must be done
Coordinate the development of the system contingency plan with the organisation teams responsible for all related plans (for example: business continuity, disaster recovery, continuity of operations, crisis communications, critical infrastructure, cyber incident response, insider threat, data breach response, breach response, and occupant emergency). Make sure these plans use the same triggers, escalation routes, roles, handovers, and procedures, so they work together consistently.

###### WHY (control requirement)
CP-2(1) requires that the development of the contingency plan is coordinated with the organisation teams responsible for related plans. This is to ensure disruption and recovery actions do not conflict with each other or leave any gaps.

###### HOW (specific steps/approach)
1. Set up a standing cross-functional “Contingency Plan Coordination” working group (the plan-of-plans forum), chaired by the system contingency planning lead (typically the business continuity management and disaster recovery lead).
2. Create and maintain a RACI (or similar responsibility matrix) that links contingency plan roles (for example: contingency coordinator, system operations lead, incident commander, communications lead) to the named owners of each related plan listed in the CP-2(1) guidance.
3. While drafting (not after publication), hold structured joint walkthroughs and tabletop exercises for agreed disruption scenarios (for example: a major outage, ransomware and containment, suspected data breach, building emergency). For each scenario, record:
   - what triggers it and when action starts
   - the escalation order and who has decision authority
   - roles and responsibilities
   - handover points between the system contingency plan and each related plan
   - required communications actions, including who approves and who releases messages
4. Add a consistency checklist into the contingency plan template or workflow, so the contingency plan must reference the related plans and include checks for triggers, escalation routes, roles, handovers, and procedures.
5. Keep evidence that coordination took place: meeting minutes, sign-offs from related-plan owners, tracked changes, and an issues log showing any mismatches found and how they were resolved (or what actions were scheduled, with dates and accountable owners).
6. Agree a joint review schedule (for example, aligned to change or release cycles and at least annually) so that any update to a related plan triggers a coordinated review of the system contingency plan.

###### WHO (role responsible)
- **Contingency planning lead / BCM-DR lead**: chairs the working group and ensures the coordination process is followed.
- **Related-plan owners** (business continuity plan, disaster recovery, continuity of operations, crisis communications, critical infrastructure, cyber incident response, insider threat, data breach response, breach response, occupant emergency): provide input and sign off.
- **Information security representative** (for example, a delegate for the chief information security officer (CISO) / information security governance lead): ensures information-handling responsibilities are included.
- **System or application owner and operations lead**: ensures system-specific procedures, escalation, and handovers are accurate.
- **Communications lead**: ensures crisis communications triggers and approval steps align.

###### Acceptance criteria
- The system contingency plan references each relevant related plan and shows alignment of triggers, escalation routes, roles, handovers, and procedures.
- A completed RACI exists and is approved by the contingency planning lead and the related-plan owners.
- Evidence exists of joint walkthroughs or tabletop exercises for the defined disruption scenarios, including documented handover points.
- Evidence of coordination during drafting is retained (minutes, sign-offs, tracked changes, and an issues log showing resolution or scheduled actions).
- A documented joint review and update schedule exists, and the process is used when related plans change.

###### Actions Required for Compliance

- [ ] Set up a Contingency Plan Coordination working group and appoint named representatives from each related plan owner.
- [ ] Create and approve a contingency plan that uses a RACI matrix (Responsible, Accountable, Consulted, Informed). This should assign an owner to each role for every related plan listed in the CP-2(1) guidance.
- [ ] Define standard disruption scenarios and hold joint tabletop walkthroughs while drafting the contingency plan, with clear handover points.
- [ ] Update the system contingency plan template and workflow so that each plan must (1) link to any related plans and (2) include a completed consistency checklist covering triggers, escalation, responsibilities, handovers, and procedures.
- [ ] Collect and keep proof that people coordinated work (for example, meeting minutes, approvals, tracked changes, and an issues log showing how each issue was resolved or the dated actions taken).
- [ ] Agree and document a joint review schedule, so that any changes to related plans trigger coordinated updates to the system contingency plan.


---

#### CP-2.2 — Capacity Planning (Enhancement)

This expectation is about making sure the organisation has enough “spare capacity” to keep essential services running during an emergency, even if performance is worse than normal. Without careful planning, the organisation could end up lacking the computing power needed to process critical information, the communications capacity needed to keep people and customers connected, or the environmental support needed to keep key facilities operating (such as power, cooling, or other essential site services). This could lead to delays or failure when it matters most.

To meet this expectation, the organisation must plan in advance for emergency conditions by:
- defining what “necessary capacity” means,
- identifying the likely reduced-performance conditions, and
- using its risk assessment, the system’s importance level, and its tolerance for risk to set capacity targets for information processing, telecommunications, and environmental support.

It must record the results in the relevant planning documents, link them to the contingency procedures, assign named responsibilities, involve those with information security responsibilities, and keep evidence that the plans were reviewed and approved.

##### Risk-based contingency capacity targets for IT processing, comms, and facilities

- Category: Manual
- Priority: Critical

###### WHAT
Create and maintain a documented, risk-based capacity plan to ensure **enough capacity is available during contingency operations when systems are operating in a degraded way** for:
1) **Information processing** (computing, storage, and data processing speed),
2) **Telecommunications** (network bandwidth, number of sessions, name resolution, and remote access), and
3) **Environmental support** (building power, cooling, uninterruptible power supply (UPS) and generator runtime, and other environmental limits).

###### WHY (control requirement)
CP-2(2) enhancement requires the organisation to **carry out capacity planning** so that **enough capacity for information processing, telecommunications, and environmental support is available during contingency operations**, with **degraded operations explicitly included** in the capacity planning. Capacity targets must be based on **risk assessment**, the system’s **impact level**, and the organisation’s **risk tolerance**.

###### HOW (specific steps/approach)
1. **Create contingency degradation scenarios** from the contingency plan and risk assessment (for example: reduced computing headroom, limited wide area network (WAN) bandwidth, increased delay, reduced backup data transfer, degraded facility power and cooling).
2. **Define “necessary capacity”** as measurable targets for each essential function and for each degraded scenario, aligned to the system’s **impact level** and the organisation’s **risk tolerance** (for example: the maximum acceptable performance reduction, the minimum acceptable service availability and duration, and data transfer and job completion thresholds aligned to recovery time objective (RTO) and recovery point objective (RPO)).
3. **Link essential functions to capacity resources** across the three required areas:
   - Information processing: CPU and memory headroom, storage input/output operations per second (IOPS) and throughput, queue depth, limits on concurrent jobs, and database connection/session capacity.
   - Telecommunications: bandwidth per link, number of concurrent sessions (web/application programming interface (API)/virtual private network (VPN)), name resolution capacity (domain name system (DNS)), and message queue throughput.
   - Environmental support: UPS and generator runtime, cooling capacity, rack and power limits, and data hall constraints.
4. **Calculate and document contingency capacity targets** for each degraded scenario and contingency duration, ensuring the targets represent the minimum capacity needed to meet resilience objectives while operating in a degraded mode.
5. **Create auditable records**: a capacity planning record (including assumptions, calculations, and targets) that is **linked** to the contingency procedures/contingency plan and the system security plan, and includes named ownership.
6. **Assign named responsibilities** for capacity planning and for using the targets during contingency execution, including information security responsibilities in the review and approval.
7. **Set a review and approval schedule** (for example, at least for major changes and periodically) and keep evidence of review and sign-off.

###### WHO
- **Accountable owner**: Application Owner / Business Continuity Manager (ensures linkage to the contingency plan and duration objectives).
- **Technical lead**: Infrastructure/Platform Engineering Lead (produces resource mappings and capacity calculations).
- **Information security**: Information Security Officer/Architect (reviews risk-based assumptions, alignment to impact level, and risk tolerance thresholds).
- **Approvers**: System Owner and Information Security (sign off capacity targets and records).

###### Acceptance criteria
- The organisation has a **documented capacity planning record** that includes, for each contingency scenario:
  - explicit **degraded-state assumptions**,
  - **capacity targets** for **information processing**, **telecommunications**, and **environmental support**, and
  - evidence that targets are based on **risk assessment**, **system impact level**, and **organisational risk tolerance**.
- The capacity planning record is **linked** to the **contingency plan/procedures** and the **system security plan**.
- Named roles and responsibilities for capacity planning and contingency execution are recorded.
- Evidence exists of **review and approval** by information security responsibilities and the system owner.

###### Actions Required for Compliance

- [ ] Identify the key mission and business activities, and the backup scenarios that would reduce performance of processing, communications, and environmental support.
- [ ] Set clear, measurable targets for reduced (“degraded”) operating capacity for information processing, telecommunications, and environmental support, based on the impact level and the organisation’s acceptable level of risk.
- [ ] Match each essential function to the specific capacity resources it needs (processing power, storage, and input/output performance; sessions, bandwidth, and domain name system (DNS) capacity; and limits for uninterruptible power supply (UPS), generator, cooling, and power).
- [ ] For each degraded scenario, calculate the minimum contingency capacity needed for the full contingency period, and record the assumptions and results.
- [ ] Link the capacity planning record to the contingency plan and procedures, and to the system security plan. Record who is responsible by name.
- [ ] Carry out and record an information security review, and obtain formal approval (sign-off) for the capacity targets and supporting materials.
- [ ] Carry out regular reviews of capacity targets, including reviews triggered by changes, to ensure they stay up to date as the systems and infrastructure change.


---

#### CP-2.3 — Resume Mission and Business Functions (Enhancement)

This requirement is about making sure the organisation can quickly restart its most important work after a serious disruption. If the contingency plan is put into action but there is no clear, ready-to-use way to restart the essential mission and business functions within 24 hours, customers may not receive services, critical work could be delayed, and the organisation could face legal, financial, or reputational harm.

To meet this expectation, the organisation must first identify and document which mission and business functions are essential. It must then set a target to restore them within 24 hours of activating the contingency plan. The organisation must also have a documented restart plan that begins immediately when the contingency plan is triggered, clearly names the people responsible for carrying out the work, and includes the people responsible for information protection and privacy.

The plan must be based on the organisation’s impact assessment, align with its security and privacy requirements, refer to any related plans or records, and set out the steps for restarting operations. This should allow the organisation to show that it is planned to meet the 24-hour target.

##### 24-hour resumption plan for essential functions on contingency activation

- Category: Manual
- Priority: Critical

###### WHAT
Create and maintain a **documented plan for resuming operations**. Once the contingency plan is **activated**, this plan must restart the organisation’s **essential mission and business functions** within **{{cp-02.03_odp.02}} (within 24 hours)**. The plan must be **started only when the contingency plan is activated**, include **named responsibilities** (including information security and privacy), and set out the **steps (processes)** needed to restore services.

###### WHY (control requirement)
CP-2(3) enhancement requires: **“Plan for the resumption of {{cp-02.03_odp.01}} mission and business functions within {{cp-02.03_odp.02}} of contingency plan activation.”** This means the organisation must:
- prioritise essential functions,
- set a clear **24-hour** resumption target, and
- have an **auditable, ready-to-use** approach that begins immediately when the contingency plan is activated.

###### HOW (specific steps/approach)
1. **Define “essential”**: Use the organisation’s business impact analysis (BIA) outputs to create an authoritative list of essential mission/business functions (for example: order processing, billing, regulated reporting, customer access). For each one, identify the minimum services needed and the supporting system components.
2. **Create a resumption plan for each essential function**: For each essential function, document:
   - the **start point** (the time/event when the contingency plan is activated)
   - the **24-hour target** and intermediate milestones (for example: T+0–2 hours triage, T+2–8 hours restoring identity and network access, T+8–24 hours restoring the service)
   - required dependencies (identity, network, databases, messaging, third-party services)
   - the **step-by-step process** to reach an operational level
   - rollback/containment steps to protect confidentiality and integrity during recovery.
3. **Assign named responsibilities**: Identify the accountable individuals/roles for restoring each essential function, including clear decision-making responsibility for **information security** and **privacy** during recovery (for example: approving emergency access, confirming logging/monitoring is in place, and setting data-handling limits).
4. **Align with security and privacy requirements**: Ensure each resumption procedure refers to the relevant security and privacy constraints (for example: least privilege, logging/monitoring expectations, encryption requirements, and how data minimisation/retention will be handled during recovery).
5. **Set up an activation-to-execution mechanism**: Configure the contingency plan activation process so that, when the contingency plan is declared, the correct resumption instructions are automatically selected/issued (for example: creating an incident or ticket, assigning the right runbook, and recording time-stamped proof). Ensure the plan can be carried out by the application, infrastructure, and security teams without needing ad-hoc interpretation.
6. **Produce audit-ready evidence**: Record execution times, actions taken, and time-to-first-service measures for each essential function during exercises and real incidents. Store the results as contingency plan records to show the **24-hour** objective is achievable.

###### WHO (role responsible)
- **Business Continuity Manager (BCM) / BCM Lead**: owns the resumption plan structure, BIA mapping, and the overall **24-hour** objective.
- **Application Owner / Service Owner**: owns the recovery steps and dependencies for each function.
- **Information Security Lead**: checks that security and privacy requirements are met, including emergency access and logging/monitoring needs.
- **Privacy Officer / Data Protection Lead**: checks that privacy requirements are met during recovery.
- **Incident Response Lead / IT Operations Lead**: ensures the activation process triggers execution and evidence capture.

###### Acceptance criteria
- The organisation has an **authoritative list** of essential mission/business functions derived from the BIA.
- For each essential function, there is a **documented resumption procedure** that starts on **contingency plan activation** and targets **within 24 hours**.
- Named individuals/roles are in place to carry out recovery, including **information security** and **privacy** responsibilities.
- Resumption procedures clearly reference the required **security/privacy alignment** (for example: least privilege, logging/monitoring posture, data-handling constraints).
- The activation process produces **time-stamped evidence** showing the plan can be executed and measured against the **24-hour** target (for example, from tabletop/exercise results or documented rehearsal outcomes).

###### Actions Required for Compliance

- [ ] Confirm the official list of essential mission and business functions using business impact analysis (BIA) outputs.
- [ ] Create a recovery plan for each essential function. Start the plan when the contingency is activated, and set milestones to be achieved within 24 hours.
- [ ] Assign named accountable roles for each essential function, including clear information security and privacy responsibilities.
- [ ] Review and update each resumption procedure to match the system security plan and privacy requirements, including least-privilege access, logging and monitoring, and limits on how data can be handled.
- [ ] Set up a process that moves from activation to execution, so the correct “resume” steps are followed and time-stamped proof is recorded.
- [ ] Run at least one tabletop exercise to test the restart procedures, and record evidence showing they meet the 24-hour target.


---

#### CP-2.5 — Continue Mission and Business Functions (Enhancement)

This requirement is about making sure the organisation can keep its most important work running even if key systems or storage locations fail. It also requires the organisation not to stop its emergency arrangements until everything is fully back to normal at the organisation’s main sites.

Without this, a disruption could cause essential services to stop, delay critical decisions or payments, or force staff to improvise without a clear plan—leading to avoidable losses and damage to the organisation’s reputation.

The organisation must:
- identify which mission and business functions are essential
- create and keep up to date a contingency plan and supporting procedures showing how those essential functions will continue with minimal or no day-to-day disruption
- define the main processing and storage sites to use for contingency purposes, and allow these to change if circumstances require it
- document agreements for the primary and backup sites
- assign clear responsibilities to named individuals, including people who understand the essential functions and people responsible for information security
- test the plan and record the results

Business continuity must continue until full restoration is confirmed at the defined primary processing and/or storage sites.

##### Essential-function continuity plan with primary-site restoration gates

- Category: Manual
- Priority: Critical

###### WHAT
Create and maintain a contingency planning programme that ensures **essential mission and business activities** can continue with **little or no disruption**, and that this continuity is **kept in place until the full recovery of systems** at the organisation’s defined **main processing and/or main storage sites**.

###### WHY (control requirement)
CP-2(5) requires the organisation to **plan how essential mission/business activities will continue**, with **little or no disruption**, and to **keep continuity in place until full system recovery** at the defined **main processing and/or storage sites**. The plan must be supported by procedures and governance so that starting, running, and standing down the arrangements are controlled and can be checked through audit evidence.

###### HOW (specific steps/approach)
1. **Identify the scope of essential activities** from the organisation’s BIA (business impact assessment) and similar outputs: keep an up-to-date register of essential mission/business activities (parameter: `cp-02.05_odp = essential`) and link each one to the application parts and supporting services needed to keep it running (for example: identity, access authorisation, messaging, databases, storage, and monitoring/logging).
2. **Set the main processing and main storage sites** for contingency purposes, and document which workloads and data areas are tied to each site. Use a controlled method to **change contingency sites** when needed (for example: decision criteria, approval steps, and updated site mapping).
3. **Write continuity procedures and runbooks** that cover: how disruptions are detected and escalated, how to activate the arrangements, how people will communicate, roles and responsibilities (including information security involvement), and step-by-step instructions for running essential activities at alternate sites.
4. **Define clear “full system recovery” stop/return points** that are explicit and testable at the named main processing and/or main storage sites. The return criteria must include, at minimum, that agreed service health for essential activities has been restored and that data is confirmed to be accurate and consistent (for example: acceptable replication delay levels and data integrity checks) before stopping alternate operations.
5. **Document and keep up to date site agreements** for main/alternate processing and main/alternate storage. Each agreement must include activation triggers, responsibilities, security expectations, capacity assumptions, and review/refresh dates.
6. **Test and keep evidence of continuity execution** using exercises that move from discussion-based testing to live testing. These should confirm: how quickly activation can happen, that essential activities can be sustained, and that operations are only stopped after the return points at the main sites are met. Record results, any differences from expectations, and corrective actions until they are completed.
7. **Link contingency planning to security planning** by ensuring the system security plan (and related security documentation) refers to how essential activities will be protected during disruption and return, including how security controls (for example: access management, logging/monitoring, and handling privileged access) remain effective.

###### WHO
- **Business Continuity Manager / BCM Lead**: owns the contingency planning programme and keeps the evidence.
- **Application Owner / Service Owner**: maintains the mapping from essential activities to application components and the runbooks.
- **Information Security Officer / Security Architect**: ensures security controls continue to work and checks that return points are met.
- **Infrastructure/Cloud Operations Lead**: maintains site agreements, failover/restore mechanisms, and supports testing.
- **DR/Incident Response Lead**: coordinates activation and exercise delivery.

###### Acceptance criteria
- An up-to-date register exists showing **essential** mission/business activities and their supporting application/services mapping.
- Documented **main processing and main storage sites** exist for contingency purposes, with an approved process to update them when circumstances change.
- Continuity runbooks/procedures exist for essential activities, with **named responsibilities** that include information security.
- **Return/termination is controlled** by documented, testable “full system recovery” criteria at the defined main sites; alternate operations do not end until the criteria are met.
- Site agreements for main/alternate processing and storage are current, reviewed, and include activation triggers and responsibilities.
- At least one continuity test/exercise produces auditable evidence: results, identified gaps, and corrective actions completed.
- The system security plan references contingency arrangements sufficient to show security control continuity during disruption and return.

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date register of the organisation’s essential mission and business functions, and map each one to the required applications and supporting services.
- [ ] Identify the primary processing site and the primary storage site for contingency purposes, and set an approved process for updating them when circumstances change.
- [ ] Create continuity procedures (runbooks) for each essential function, covering how to activate and operate it, how communications will work, and who is responsible for each task (with input from information security).
- [ ] Set clear, testable “full system restoration” stop-and-go checkpoints (“return gates”) at the main processing and/or main storage sites, and do not shut down the backup or alternate operations until those checkpoints are met.
- [ ] Create and keep up to date site agreements for primary and alternate processing and storage. Include when each option should be activated, who is responsible for each task, and the dates for regular reviews.
- [ ] Run at least one tabletop-to-live business continuity test, record the results and any deviations, and complete corrective actions to show readiness.


---

#### CP-2.6 — Alternate Processing and Storage Sites (Enhancement)

This requirement ensures the organisation can continue its most important work at other locations if its main sites become unavailable, and then return to the original sites only after they are fully ready again. Without this, a disruption could stop key services for customers, employees, or regulators, leading to serious financial loss, reputational damage, and operational chaos.

The organisation is expected to:
- identify which mission and business functions are essential;
- create and document a clear plan to move those functions to specific alternate processing and/or storage sites with little or no interruption;
- keep those essential functions running at the alternate sites until the original sites are completely restored.

The organisation must also:
- assign named responsibilities;
- involve people with information security responsibilities;
- carry out a business impact analysis to support what is considered essential;
- put practical agreements in place with the alternate sites;
- test the plan and keep recorded evidence of the results.

Finally, the organisation must keep the relevant planning and security information up to date, including how the move back to the primary sites will be handled.

##### Alternate-site transfer plan with secure IT failover and switch-back gates

- Category: Software
- Priority: Critical

###### WHAT
Create and keep a documented plan to move the organisation’s **essential** mission and business activities (as the organisation defines them) to **alternative processing and/or storage locations**. Carry out the move with **minimal or no disruption to day-to-day operations**, keep running the service from the alternative locations, and then **bring operations back to the main locations in a controlled way** only after the main locations are fully restored.

###### WHY (control requirement)
CP-2(6) enhancement requires the organisation to: (1) plan how to move the **{{ insert: param, cp-02.06_odp }} essential** activities to alternative locations, (2) ensure **minimal or no disruption to day-to-day operations**, (3) **continue operations** through restoring systems back to the main locations, and (4) keep the plan effective through practical use and the return to the main locations.

###### HOW (specific approach)
Put in place an auditable, information technology (IT)-focused capability to move the enterprise application to an alternative site using a “warm standby” approach (already prepared computing/storage capacity and network connections), supported by automated failover procedures that include identity checks.

1. **Work out what is essential**: Use the organisation’s business impact analysis (BIA) outputs to identify the **essential** activities (cp-02.06_odp = essential) and map them to the application parts they depend on, including the user-facing layer, application services, databases, storage, messaging, integrations, administration functions, and required enterprise services such as identity, monitoring, logging, and backup.
2. **Choose alternative sites and define what moves**: Select named alternative processing and/or storage locations for each essential activity. Prepare the required connectivity in advance (for example, zero trust network access (ZTNA), virtual private network (VPN), software-defined wide area network (SD-WAN)), domain name system (DNS) and service addresses, and the required security services (for example, sending logs to security information and event management (SIEM), monitoring, and observability tools).
3. **Create the alternative-site transfer plan (runbook + decision points)**:
   - Document **activation triggers** (for example, loss of the main site, loss of critical dependencies, or a formally declared incident).
   - Set out **roles and responsibilities** (business owner, application owner, infrastructure lead, security lead/authorised security personnel, and incident commander).
   - Provide **step-by-step instructions** for the failover sequence (protect data first, then move services, then restore user access) and for **keeping operations running** from the alternative sites.
   - Define clear **return-to-main criteria**: continue running from the alternative sites until the main sites are fully restored and verified (for example, data integrity checks, service health checks, confirmation of dependencies, and verification of security settings).
4. **Protect the move and the return**:
   - Use enterprise identity integration to control access during the contingency period (conditional access, phishing-resistant multi-factor authentication (MFA) for privileged access, least privilege, and service accounts/workload identities for automation).
   - Ensure encryption during data transfer and while stored remains in place at the alternative sites (reuse approved certificates/keys and agreed configuration baselines).
   - Ensure administrative actions taken during failover are recorded and kept in line with the organisation’s logging requirements.
5. **Make it operational using automation**:
   - Use infrastructure and configuration as code so the process can be repeated reliably (network rules, routing/DNS changes, application deployment settings, and database/storage failover steps).
   - Use orchestration runbooks to carry out the transfer steps in the documented order and to capture proof of what happened (timestamps, actions taken, validation results, and approvals).
6. **Test and keep evidence**:
   - Run tabletop exercises and carry out at least periodic technical failover and return-to-main tests (including checking that the “stay on the alternative site until the main site is fully restored” decision point works as intended).
   - Record results, any differences from the plan, and corrective actions; then update the plan.

###### WHO
- **Application Owner**: owns the mapping of essential activities and the plan content for the application.
- **Business Continuity/Disaster Recovery (DR) Lead**: ensures the plan matches the BIA and continuity objectives.
- **Infrastructure/Platform Lead**: builds and maintains the alternative-site environments and the automation.
- **Information Security Lead (authorised security personnel)**: reviews and approves security controls, access routes, logging, and the checks needed before returning to the main sites.
- **Incident Commander / Security Operations Centre (SOC) Lead**: activates the plan and coordinates keeping operations running and returning to the main sites during real events.

###### Acceptance criteria
- A documented alternative-site transfer plan exists for all activities identified as **essential** (cp-02.06_odp) and includes activation triggers, roles, procedures, continuity steps, and clear return-to-main criteria.
- Failover can be carried out to the alternative processing/storage locations with **minimal or no disruption to day-to-day operations**, supported by test evidence (recorded runbook execution and validation results).
- Operations remain running from the alternative sites until the main sites are **fully restored and verified**, supported by return-to-main test evidence.
- Identity and access controls, and security logging, remain effective during failover and return, supported by test evidence and review by information security.
- The plan is kept up to date based on test outcomes and corrective actions.

###### Actions Required for Compliance

- [ ] Map **cp-02.06** essential mission and business functions to specific application parts and their dependencies, using the outputs from the business impact assessment (BIA).
- [ ] For each essential function, choose and record the named backup processing and/or storage sites, including the required network connections and the security service addresses (endpoints).
- [ ] Create an alternate-site transfer plan (runbook) that includes: the conditions that start the transfer, named responsibilities, the step-by-step failover order, procedures to keep services running after the switch, and clear, pre-defined checkpoints that must be met before switching back.
- [ ] Set up automated failover handling that uses “infrastructure and configuration as code” and runs the required procedures, while recording evidence of what was done and the checks used to confirm it worked.
- [ ] Set up identity-based access controls for contingency plans, including conditional access, least-privilege access, phishing-resistant multi-factor authentication (MFA) for privileged accounts, and automated workload identities. Then test and confirm the controls work correctly at alternate sites.
- [ ] Carry out regular failover and return-to-normal (switch-back) tests, record the results, and update the plan with corrective actions until the switch-back requirements are consistently met.


---

#### CP-2.7 — Coordinate with External Service Providers (Enhancement)

This requirement is about making sure your plans for coping with disruption still work when key services are provided by outside suppliers. If you depend on another organisation for services such as hosting, managed information technology, payments, or customer support, that supplier’s ability to recover and keep operating will directly affect whether your own essential services can continue. Without coordination, you may only find out too late that the supplier’s recovery times, responsibilities, or communication steps do not meet your needs.

To meet this expectation, the organisation must:
- identify every external supplier it relies on during disruption;
- share the specific parts of its disruption plans that relate to those suppliers; and
- work with each supplier to align the timing, responsibilities, and readiness needed to meet your recovery objectives.

The organisation should keep clear, dated records showing these agreements and reviews, involve the correct internal roles (including those responsible for protecting information), and check that what suppliers are contractually required to do supports the disruption expectations.

##### Provider contingency annexes aligned to organisational recovery needs

- Category: Manual
- Priority: Critical

###### WHAT
For each external service provider whose services are needed to keep the organisation’s mission and business functions running during disruption, create and maintain a **Provider Contingency Annex** (or an equivalent contract schedule). This annex should bring together the provider’s contingency, business continuity, and disaster recovery commitments with the organisation’s own contingency plan requirements.

###### WHY (control requirement)
NIST SP 800-53 **CP-2(7)** enhancement requires the organisation to **coordinate its contingency plan with the contingency plans of external service providers**. The goal is to ensure **contingency requirements can be met**. This means the provider’s recovery timing, responsibilities, escalation and communication approach, and expectations for restoring services must match the organisation’s needs.

###### HOW (specific steps/approach)
1. **Identify critical external providers** that the application relies on for essential functions during disruption (for example: cloud hosting, managed identity, software-as-a-service dependencies, managed monitoring and security information and event management (SIEM), backup services, payment processing, and ticketing/support).
2. **Match the organisation’s contingency requirements** to the provider’s service parts (for example: identity and authentication availability, expectations for restoring data, how application programming interfaces (APIs) and services will be restored, support response times, and escalation routes).
3. **Create a Provider Contingency Annex template** that, at minimum, requires:
   - The provider’s service scope and the disruption scenarios covered
   - **Availability and recovery time targets** (recovery time objective (RTO) and recovery point objective (RPO), where applicable)
   - **Responsibilities** for each recovery step (who restores what, and by when)
   - Escalation contacts and roles, and communication timeframes (including incident notification windows)
   - Assumptions and constraints (for example: what the provider will not do, and dependencies on third parties)
   - Evidence and assurance the provider will provide (for example: how often they test their business continuity and disaster recovery (BCP/DR) and the summary results)
4. **Negotiate and obtain formal sign-off** confirming the provider’s contingency commitments **match** the organisation’s contingency plan requirements. If full alignment is not possible, document **agreed workarounds or alternatives**.
5. **Maintain an auditable coordination register** that links each annex to the relevant parts of the contingency plan, contract versions, sign-off dates, and named people involved in coordination (including security input).
6. **Test the combined capability in practice** by running at least one **table-top coordination exercise** for each critical provider (or after a major service change). This confirms that the agreed notification/escalation process and recovery timing can meet the organisation’s contingency objectives.

###### WHO (role responsible)
- **Business Continuity/Disaster Recovery (BC/DR) Lead**: owns mapping of contingency requirements and coordination outcomes.
- **Third-Party Risk Manager / Procurement Contract Owner**: owns adding the annex to contracts, negotiating, and contract governance.
- **Information Security / Security Architect**: checks the annex content for security-relevant recovery expectations (for example: identity availability, restoring access to data, and incident notification requirements).
- **Application/Infrastructure Owner**: confirms technical service dependencies and who is responsible for restoring services.

###### Acceptance criteria
- For every critical external provider, there is a **signed Provider Contingency Annex** (or equivalent) that clearly states recovery/availability targets, responsibilities, and escalation/communication timeframes aligned to the organisation’s contingency plan.
- The organisation can provide **audit-ready evidence**, including the annexes, sign-off records, provider business continuity and disaster recovery (BCP/DR) assurance summaries (for example: test frequency and results), and the coordination register.
- For each critical provider, there is a documented coordination outcome showing either (a) alignment with the organisation’s contingency requirements or (b) documented, approved workarounds or alternatives.
- At least one table-top coordination exercise has been completed for each critical provider (or after material service changes). Results are recorded, and any gaps are either fixed or formally accepted as a risk.

###### Actions Required for Compliance

- [ ] Identify and record all external service providers whose services are needed to keep essential business functions running during a disruption.
- [ ] Map each provider’s service components to your organisational contingency requirements, including recovery time objectives (RTO) and recovery point objectives (RPO) where applicable, notification time windows, and expectations for restoring services.
- [ ] Create a provider contingency annex template that sets out recovery targets, who is responsible, escalation contact details, and communication timeframes.
- [ ] Negotiate with each critical provider, get formal approval, and securely store the signed annexes for each one
- [ ] Collect proof from each provider showing how often their business continuity and disaster recovery (BCP/DR) tests are carried out, along with the test summary results (or an equivalent assurance), and record this information in an auditable coordination log.
- [ ] For each critical service provider (or after any major service changes), run a scenario-based coordination exercise and record the results, any gaps found, and either the fixes planned or the decision to accept the remaining risk.


---

#### CP-2.8 — Identify Critical Assets (Enhancement)

This requirement is about making sure the organisation clearly understands which systems and day-to-day activities are truly vital for keeping essential services running when something goes wrong. Without this, the organisation may spend time and money protecting the wrong things, or only realise too late that a key computer service, supporting tool, manual process, or the people who carry it out is not included in the emergency plans. That can cause avoidable disruption to the mission and business activities.

To meet this expectation, the organisation must first define which mission and business functions are considered essential. It then needs to identify the critical assets that support those functions, covering both:
- the technical parts (for example, key system components, services, products, and the mechanisms that make them work), and
- the operational parts (for example, manual procedures and the people responsible for carrying them out).

The organisation must base this work on business impact and business continuity planning inputs, record it in organisational documents, and use it to guide contingency planning. This includes setting named responsibilities, relevant policies and procedures, and plans that clearly reference and handle these critical assets during contingency operations, so resources are prioritised appropriately.

##### Critical assets register linking essential functions to IT/OT assets

- Category: Manual
- Priority: Critical

###### WHAT
Create and maintain an auditable **Critical System Assets Register** that lists the organisation’s **critical technical and operational assets** that support its **essential mission and business functions** (parameter: `cp-02.08_odp = essential`). The register must include both:
- **Technical assets** (for example, system components, information technology (IT) services/products, and the mechanisms that make them work), and
- **Operational assets** (for example, manually performed procedures and the people/roles who carry them out).

###### WHY (control requirement)
CP-2(8) enhancement requires the organisation to **identify critical system assets that support essential mission and business functions**, so that **additional contingency operation controls** can be applied to help ensure mission/business continuity during contingency operations. This also helps **prioritise organisational resources** and ensures contingency planning refers to the correct assets.

###### HOW (specific steps/approach)
1. **Define what “essential” means** for the application by using existing **criticality analysis / business impact analysis (BIA) / business continuity planning** inputs. Record the list of essential functions and the reason each function is considered “essential”.
2. **Link each essential function to what it needs to work**, then map those needs to **critical technical assets** (for example, multi-tier application components, identity services, data stores, backup and restore mechanisms, monitoring and alerting mechanisms, network services, and any other mechanisms needed to operate during contingency).
3. **Identify the operational assets** that support each essential function, including:
   - manually performed procedures/runbooks needed during contingency,
   - escalation and approval steps,
   - named roles/teams (for example, application owner, infrastructure operator, security incident responder) and any required supplier contacts.
4. **Document the register** with traceability fields that link each critical asset to the relevant contingency planning documents and records, including at minimum:
   - essential function(s) supported,
   - asset identifier and type (technical/operational),
   - contingency operation(s) where it is used (for example, disaster recovery (DR) failover, degraded-mode operation, manual workaround),
   - owner role and responsible team,
   - evidence/source used for the criticality decision (for example, BIA section, architecture diagram, system security plan section).
5. **Set governance and update triggers** so the register stays current: require review when there are significant changes (architecture changes, retirement of systems, major integrations, backup/DR changes, role changes) through change and configuration management.
6. **Use the register to prioritise contingency planning**: ensure contingency plans/procedures reference the critical assets, and that recovery actions are prioritised based on the register (for example, the order of restoration, fallback options, and which manual procedures/roles must be available).
7. **If any critical assets are provided by external service providers**, ensure the identification process includes external dependencies and matches the approach expected for external providers (consider CP-2(7) where applicable).

###### WHO (role responsible)
- **Application Owner / Business Owner**: confirms which business functions are “essential” and validates the mapping to contingency operations.
- **Information Security (or Security Governance Lead)**: reviews criticality decisions for completeness and ensures the register supports contingency planning and prioritisation.
- **Information technology/operational technology (IT/OT) Architecture & DR/BCP Lead**: maintains the asset categories, ensures technical mechanisms are captured, and links register entries to disaster recovery (DR) and business continuity planning (BCP) artefacts.
- **Configuration/Change Management Lead**: enforces update triggers and evidence requirements.

###### Acceptance criteria
- An auditable Critical System Assets Register exists for the application and includes **both technical and operational** critical assets supporting the defined **essential** functions.
- Each register entry has traceability to **BIA/criticality analysis inputs** and to the **contingency planning/procedures** where the asset is used.
- Owners/roles are assigned for operational procedures and for technical components/mechanisms.
- The register is reviewed and updated through defined governance (documented review timing and change triggers), and evidence of at least one review cycle is available.
- Contingency plans/procedures reference the critical assets from the register, and recovery actions are prioritised accordingly.

###### Actions Required for Compliance

- [ ] Define and document the application’s key purpose and business functions, using inputs from the business impact analysis (BIA) and criticality assessment.
- [ ] Create a clear list (taxonomy) of critical assets, covering both the technical controls and the operational procedures and responsibilities (roles).
- [ ] Update the Critical System Assets Register so each asset can be traced back to the business impact analysis (BIA) and to the relevant contingency plan or procedure sections.
- [ ] Assign a responsible owner (a named team or person) for every operational procedure and for every critical technical mechanism.
- [ ] Set up governance with a regular review schedule and clear triggers for when changes or configuration updates happen, so the register stays up to date.
- [ ] Update the contingency plans and recovery procedures to point to the register and prioritise recovery actions based on it.
- [ ] Identify any outside service providers that are relied on for critical assets, and where relevant, make sure this matches control CP-2(7).


---

### CP-3 — Contingency Training (Control)

This requirement is about making sure people know exactly what to do when the organisation has to switch to emergency or backup ways of working. Without regular, role-specific contingency training, staff may not know where to report, which duties to prioritise, or how to carry out critical tasks when working away from the usual site. This could slow recovery and increase the impact of an incident, outage, or other disruption.

The organisation must provide the right contingency training to each person within 30 days of them taking on a contingency role. It must repeat this training at least once every year, and re-train staff when systems or working arrangements change. The organisation must also review the training materials every quarter, and update them after contingency tests or exercises (including lessons learned), after audit or assessment findings, after security incidents or breaches, and after changes to relevant laws, directives, regulations, policies, standards, or guidance.

The organisation should keep records showing who was trained, when they were trained, and what was updated.

##### Automate role-based contingency training with trigger-driven updates

- Category: Software
- Priority: Critical

###### WHAT
Set up a role-based contingency training programme that (1) assigns the right training content to each person based on their contingency role and responsibilities, (2) ensures initial training is completed within the agreed time period, (3) refreshes training at the agreed frequency, and (4) reviews and updates training content on an agreed schedule and after agreed events.

###### WHY (control requirement)
CP-3 requires contingency training to be linked to assigned roles and responsibilities, so people receive the right content and level of detail. The guidance also requires that training content is reviewed and updated on an agreed schedule and after events such as contingency plan tests and exercises (including lessons learned), assessment and audit findings, security incidents and breaches, and changes to laws, directives, regulations, policies, standards, and guidelines. The organisation-defined requirements specify: initial training within **30 days**, **annual** training refreshes, **quarterly** content review and update, and defined trigger events.

###### HOW (specific steps/approach)
1. **Create a contingency role catalogue** based on the contingency plan, describing each role and responsibility in plain language (for example: alternate site administrator, mission-essential operator, off-site communications coordinator) and linking each role to the mission-essential functions it must perform.
2. **Create a role-to-training mapping** that links each contingency role to one or more training modules, ensuring the module detail matches the guidance (for example: “report for duty” for some roles; “set up systems at alternate processing/storage sites” for system administrators; “carry out mission-essential functions off-site” for organisational officials).
3. **Set up automated enrolment and completion tracking** in the enterprise learning platform:
   - When a person is assigned or activated for a contingency role, the platform automatically enrols them and starts a **30-day completion timer**.
   - Set **annual** refresh training assignments with expiry and re-confirmation dates.
4. **Set up a quarterly content review process** linked to document control and versioning:
   - Module owners review module content every quarter.
   - If changes are needed, update the module version and record what changed.
   - The platform identifies which roles are affected and re-enrols people only where required.
5. **Updates triggered by events**: build the defined trigger events into the training process so that after any of the following, module owners review and update the affected modules, and the platform reassigns the updated training to affected roles:
   - contingency plan tests and exercises (including lessons learned sessions)
   - audit and assessment findings
   - security incidents and breaches
   - changes to laws, directives, regulations, policies, standards, and guidelines
6. **Keep audit-ready records**:
   - Store training completion records (who completed what module and version, and the completion date).
   - Store content review and update records (quarterly review outcomes, version history, and which trigger/event led to the update).

###### WHO (role responsible)
- **Business Continuity Manager / Continuity Lead**: owns the contingency role catalogue and ensures it matches the contingency plan.
- **Training/HR Learning Operations Lead**: configures the learning platform enrolment, timers, and annual refresh rules.
- **System/Application Owners and Security Subject Matter Experts**: own module content and carry out quarterly reviews and event-triggered updates.
- **Change Manager / Release Manager**: ensures system changes and their contingency impacts are flagged to the training process.

###### Acceptance criteria
- For every person assigned a contingency role, training is completed **within 30 days** of taking on the role (based on learning platform records).
- All relevant system users receive **annual** contingency training (based on expiry/re-confirmation dates and completion evidence).
- Training content is **reviewed at least quarterly**, and module versions reflect updates when required (based on quarterly review logs and version history).
- After each defined trigger event (exercise/lessons learned, audit/assessment finding, security incident/breach, or policy/standards/legal change), affected roles are re-enrolled with updated module versions (based on event-to-update traceability and re-assignment records).
- Evidence can be retrieved for audit: training completion (who/what/version/when) and content review and update history (what/when/why).

###### Actions Required for Compliance

- [ ] Create a contingency role catalogue and define what each role is responsible for, aligned to the contingency plan.
- [ ] Create a table that links each contingency role to the specific training modules it must complete, including the required level of detail for each module.
- [ ] Set up the enterprise learning platform to automatically enrol people assigned to the contingency role and require that they complete the training within 30 days.
- [ ] Set up annual refresh tasks and expiry checks for re-certification for all users who have contingency roles.
- [ ] Set up a quarterly process to review content, track changes by module version, and identify which roles are affected.
- [ ] Use trigger events (training exercises and lessons learned, audit findings, security incidents, and changes to laws or policies) to start a review and update of the training module, and to re-enrol participants.
- [ ] Set up audit-ready records for: (1) training completion details (who completed it, what was completed, the version, and when) and (2) content review and update history (what changed, when it changed, and why).


---

#### CP-3.1 — Simulated Events (Enhancement)

This requirement is about making sure staff practise real crisis situations, not just discuss them. By running realistic simulated events during contingency training, staff can learn how to respond quickly and correctly when something goes wrong, such as a website going offline, data being locked up in a ransomware-style incident, severe weather damaging or destroying facilities, or critical equipment and software failing.  

To meet this expectation, the organisation must define a set of realistic simulated crisis scenarios and include them in its contingency training curriculum and materials. The training must match what is set out in its contingency planning policy, contingency plan, and system security plan.  

Staff responsible for planning and carrying out the response, as well as staff with information security responsibilities, must take part in these scenario-based exercises. The organisation must also keep records showing which scenarios were used and what happened, including the outcomes from debriefs and the improvements fed back into future training and relevant plans.

##### Simulated crisis injects for contingency training (cyber, ransomware, outage)

- Category: Software
- Priority: Critical

###### WHAT
Add realistic, controlled simulated events to contingency training by using scripted “exercise injects” that mimic (at minimum) cyber disruption, ransomware-style impact on data, major hardware or software failure, and (where feasible) disruption to access to facilities.

###### WHY (control requirement)
CP-3(1) enhancement requires that simulated events are included in contingency training so staff can practise effective responses during crises. The guidance specifically highlights realistic threat types, including cyber-attacks that disable websites, ransomware that locks organisational data, hurricanes that damage or destroy facilities, and hardware or software failures.

###### HOW (specific approach)
Set up an “exercise inject orchestrator” that starts timed scenario events against **training-safe** targets in separate, segregated environments (for example: non-production, disaster recovery rehearsal, or dedicated training systems). Each scenario must be scripted with start and stop conditions, what participants should do, when to escalate, and how to roll back and clean up afterwards.

1. **Create scenario packs** that align with the organisation’s contingency planning policy, contingency plan, training curriculum and materials, and system security plan. At minimum include:
   - **Cyber disruption**: mimic public-facing service unavailability (for example, edge/domain name system routing to a maintenance page for a defined period) within a training environment.
   - **Ransomware-style impact**: mimic encryption or loss of access without encrypting real business data (for example, remove access and place a dedicated training dataset into a controlled “locked” state; optionally simulate file renaming or permission changes on training storage).
   - **Major hardware/software failure**: mimic a core application outage (for example, a controlled service stop or failover in a non-production or training environment) with visible monitoring gaps and clear recovery decision points.
   - **Facility-access disruption (where feasible)**: mimic denial of site access using badge/access denial simulation and communication prompts (so teams practise continuity decisions rather than physical damage).

2. **Run injects through a controlled exercise control process** that is separate from production incident tools, to avoid affecting real incident reporting. The orchestrator should:
   - Trigger communication prompts (for example, “website down” alerts), prompts for using ticket or incident channels, and timed escalation cues.
   - Coordinate with monitoring and security information and event management (SIEM) so exercise activity is clearly marked as “training”, while still testing detection and triage processes.
   - Keep strict safety boundaries: only affect training datasets and training hosts; include automatic rollback and checks after the exercise.

3. **Exercise participation and roles**: ensure the people responsible for planning and running the response, including information security responsibilities, take part in scenario-based exercises (for example: contingency lead, incident commander, application and infrastructure responders, and security monitoring and incident response roles).

4. **Evidence and improvement loop**: after each exercise run, capture exercise records (inject timeline, participant actions, escalation decisions, system behaviour, and results), hold a debrief, and update training materials and any relevant plans with corrective actions.

###### WHO (responsible roles)
- **Contingency planning lead / business continuity manager**: owns scenario selection and alignment to the contingency policy and plan, and the training curriculum.
- **Information security lead / incident response manager**: checks that ransomware-style and cyber disruption scenarios are realistic, and ensures exercise injects support safe security decision-making.
- **Application and infrastructure engineering lead**: builds the training-safe inject methods (for example, edge/domain name system routing, controlled service failure, and training dataset access-lock simulation).
- **Security information and event management (SIEM) and monitoring owner**: ensures exercise events are visible and correctly labelled as training.

###### Acceptance criteria
- At least one exercise run includes: (a) cyber disruption (service unavailable), (b) ransomware-style data impact (training dataset becomes inaccessible/locked), and (c) major hardware or software failure (core outage) with clear, observable recovery decision points.
- Scenario execution is clearly aligned to the organisation’s contingency planning policy, contingency plan, training curriculum and materials, and system security plan (with documented mapping).
- Exercise injects affect only training-safe environments and datasets, with documented rollback/cleanup and checks after the exercise.
- Records are kept for each exercise, including: the scenario used, inject timeline, participant actions, debrief outcomes, and documented improvements fed into future training and relevant plans.
- The required people (those responsible for contingency/implementation and information security) participate, with evidence in attendance and role records.

###### Actions Required for Compliance

- [ ] Define and document a set of simulated crisis scenarios that are safe for training. Link each scenario to the contingency planning policy, the contingency plan, the training curriculum and materials, and the system security plan.
- [ ] Build an exercise “inject” system that, in separate training and disaster recovery (DR) environments, triggers scheduled cyber disruption, ransomware-style damage to data, and hardware and software failure events.
- [ ] Implement cyber disruption by using controlled edge and domain name system (DNS) routing to temporarily put services into a maintenance or unavailable state, with automatic rollback if needed.
- [ ] Use ransomware-style “data injection” in a controlled training environment, using a dedicated training dataset and temporarily removing access permissions, to mimic the same kind of inaccessibility that ransomware causes—without encrypting any real business data.
- [ ] In non-production and training environments, test major outage scenarios by deliberately stopping or switching services in a controlled way, with monitoring in place and clear decision points for recovery.
- [ ] Run at least one full scenario-based contingency exercise, with contingency planning, implementation, and information security roles taking part. Record who attended and keep evidence showing each role participated.
- [ ] Record exercise logs, document the debrief results and corrective actions, then update the training materials and any relevant plans as part of the improvement cycle.


---

#### CP-3.2 — Mechanisms Used in Training Environments (Enhancement)

This expectation is about making emergency practice feel like the real situation, by using the same day-to-day ways of working the organisation already relies on. Without this, training can become a “paper exercise”, leaving staff unsure what to do when a real disruption happens. That increases the risk of slow or incorrect decisions, missed actions, and poor coordination during incidents that affect customers, services, or critical operations.

To meet this expectation, the organisation should set out in its contingency planning policy how it will use real operational processes, systems, and facilities to create realistic simulated events. It should then reflect this approach in its contingency plan, training programme, and training materials. The organisation should also clearly name the people responsible for planning, running, and delivering the training, make sure the training follows the planned approach, and keep records showing which real operational methods were actually used and how they improved realism, including any justified reasons where something could not be reused.

##### Training-mode execution using real workflows, systems and facilities

- Category: Software
- Priority: Critical

###### WHAT
Deliver contingency training by running realistic scenarios through the organisation’s real day-to-day operating methods—meaning the same mission or business processes, working steps, communication routes, and (where appropriate and safe) the same operational systems and facilities—using a controlled “training mode” so that live production services are not affected.

###### WHY (control requirement)
CP-3(2) enhancement requires that contingency training uses the same types of mechanisms as live operations, so the training is more complete and realistic. These operational mechanisms include established processes and/or the supporting systems and facilities used to achieve organisational goals. Using the real mechanisms (where appropriate) improves realism and reduces the risk of “paper exercise” training.

###### HOW (specific approach)
1. **Define and set up a training mode for operational systems**: create separate training access routes (for example, separate queues or work areas, environment indicators, URL prefixes, tenant or namespace separation, or dedicated non-production instances) that reuse the same workflow engine, user screens, application programming interfaces (APIs), and operational control consoles as production. Ensure there are no changes or updates to live production customer, financial, or regulated records.
2. **Link each scenario step to a real operational mechanism**: for every step in the exercise instructions (runbook), clearly state the real mechanism being tested (for example, the workflow step, escalation route, communication channel, reporting template, or approval process). Include this mapping in the contingency plan, training materials, and facilitator guides.
3. **Use real operational processes and documents to create simulated events**: use the same operational forms or templates, ticketing and escalation procedures, communication templates, and operational reporting tools, but fill them with synthetic data or data created in a safe sandbox environment using automation.
4. **Control access and keep security boundaries intact**: give training participants time-limited, least-privilege access roles through the organisation’s identity provider. Require strong authentication, and ensure training-mode accounts are approved and recorded in logs. Where applicable, make sure training-mode controls match the system security plan.
5. **Collect evidence that shows the real mechanisms were used**: automatically gather workflow audit trails, application logs, communication delivery confirmations, and exercise run logs showing which operational mechanisms were used at each step. Require after-action reporting to include a “realism delta” section stating what was carried out using real mechanisms, what differed, and why.

###### WHO (roles responsible)
- **Business continuity / contingency planning lead**: owns the contingency plan and ensures the approach is reflected in policy, plan, training curriculum, and materials.
- **Exercise facilitator / training coordinator**: ensures scenario instructions follow the planned mechanism mapping during delivery.
- **Application owner / operations lead**: sets up and maintains the training-mode configuration and ensures safe reuse of operational workflows and systems.
- **Information security lead (and identity and access management (IAM) / security engineering as needed)**: checks that training-mode access controls and logging are correct and that they align with the system security plan.

###### Acceptance criteria
- Each contingency exercise scenario runbook step includes a clear reference to the operational mechanism used (process/workflow/communications/system/facility), and that mechanism is actually used during the exercise.
- Training-mode execution demonstrably prevents impact to production records (for example, no production writes; only synthetic or sandboxed data).
- For each exercise run, evidence is produced showing which mechanisms were used (workflow audit trails or logs and communication confirmations), and the after-action report includes a documented realism delta.
- Training access is time-limited, least-privilege, strongly authenticated, and fully logged for all participants using the enterprise identity system.

###### Actions Required for Compliance

- [ ] Create a training-mode setup that uses the same workflows and screens as the live (production) system, but blocks any changes to live customer, financial, and other regulated records.
- [ ] Create scenario runbooks that spell out every step and link it to the exact operational mechanism to be tested, including the workflow step, escalation route, communication channel, and reporting template.
- [ ] Create synthetic (sandbox) test data and make sure simulated events are entered into the same operational forms and reporting tools used during real operations.
- [ ] Set up time-limited, least-privilege training access through the organisation’s identity provider, using strong authentication and ensuring all access is fully logged.
- [ ] For each exercise run, collect and record audit evidence, including workflow audit trails, application logs, and communications delivery receipts.
- [ ] Require that after-action reports include a “realism delta” section. This section must document the mechanisms used, any intentional differences, and the reasons for those differences.


---

### CP-4 — Contingency Plan Testing (Control)

This requirement is about making sure your organisation’s emergency back-up plans are not only written down, but also work when something goes badly wrong. Without regular testing, a plan may look fine on paper yet fail in real life, which can stop day-to-day operations, put important assets at risk, and prevent people from doing their jobs during a disruption.

To meet this expectation, the organisation must test its contingency plan at least once every quarter. Testing must use a mix of:
- checklist reviews,
- walk-throughs, and
- parallel tests,

to check how effective the plan is. It must also include:
- tabletop exercises, and
- full interrupt simulations (a complete disruption test),

to confirm the organisation is ready to carry out the plan.

After each quarterly test, the organisation must review the results, record what was tested and what happened, decide whether any weaknesses or failures were found, and start corrective actions when needed. The organisation must assign clear responsibilities for running the tests and reviewing the outcomes, including people with information security responsibilities.

##### Quarterly contingency plan testing with evidence-led remediation

- Category: Manual
- Priority: Critical

###### WHAT
Set up a repeatable quarterly testing programme for the system contingency plan. Each quarter must include:
- **Effectiveness tests** (review the checklist, run a walk-through, and carry out a parallel test), and
- **Readiness tests** (run a tabletop exercise and perform a full interruption simulation).

After each test cycle, review the results in writing and record corrective actions.

###### WHY (control requirement)
CP-4 requires the organisation to **test contingency plans** to confirm **effectiveness** and to spot potential weaknesses. Testing must also determine the **impact on organisational operations, assets, and individuals** from carrying out contingency activities. Tests must follow the requirements in the contingency plan, and the results must lead to corrective actions.

###### HOW (specific approach)
1. **Define a quarterly test plan for each system**: set a quarterly schedule and map each quarter to the required test types:
   - Effectiveness testing: **checklist review**, **walk-through**, **parallel test**.
   - Readiness testing: **tabletop exercise**, **full interruption simulation**.
2. **Use standard exercise materials** that match the contingency plan requirements:
   - Checklist review: confirm the runbook is complete, dependencies are covered, escalation routes are clear, and decision criteria are defined.
   - Walk-through: step through key decisions and communications with the relevant roles.
   - Parallel test: carry out restore, failover, and contingency activities alongside normal production where possible, to confirm service recovery and access routes.
   - Tabletop: use a scenario to test decision-making and check how quickly decisions are made and how communications are handled.
   - Full interruption simulation: run a controlled disruption with clear start/stop points, and include safety and rollback considerations.
3. **Record evidence that is suitable for audit during each test**:
   - Record what was tested, the test type, dates and times, who took part, what happened, and any deviations.
   - Record evidence of operational impact (effects on operations, assets, and individuals), such as service disruption periods, data access impacts, and impacts on users or roles.
4. **Complete a fixed results review and remediation process after each quarterly test**:
   - Review effectiveness and readiness results, identify weaknesses, and assign severity.
   - Raise corrective actions with named owners, due dates, and requirements for re-testing.
   - Make sure information security responsibilities are included in the review and prioritisation of remediation.
5. **Close the loop with re-testing**: only close corrective actions when evidence shows the weakness has been addressed (for example, re-run the relevant test type or a targeted scenario).

###### WHO
- **Business/Application Owner**: accountable for the contingency plan scope and agreement of the operational impact determinations.
- **DR/BCP Lead (or Resilience Manager)**: responsible for the quarterly testing programme, exercise materials, and scheduling.
- **Information Security (Security Engineering/IR/BCP Security)**: participates in the results review and confirms security-relevant outcomes.
- **Infrastructure/Platform Leads**: carry out parallel tests and full interruption simulations and provide technical evidence.
- **Service Desk/Comms Lead (where applicable)**: supports communications and user-impact evidence during exercises.

###### Acceptance criteria
- Quarterly testing is clearly carried out for the system, with **all required test types** completed within the quarter.
- For each quarter, there is an **evidence pack** showing what was tested, how it was carried out, the outcomes, and the **effects on operations/assets/individuals**.
- Results are reviewed after each quarterly test, with **documented weaknesses** and initiated corrective actions where applicable.
- Corrective actions are tracked to completion, with **re-test evidence**.
- Information security responsibilities are evidenced through participation in the review/prioritisation and in remediation decisions.

###### Actions Required for Compliance

- [ ] Publish a quarterly schedule for testing the system’s contingency plan, covering: checklist review, walkthrough, parallel testing, tabletop exercise, and a full interruption simulation.
- [ ] Create exercise packs that match the requirements of the contingency plan. Each pack should include the scenario objectives, the people involved (roles), the key decisions to be made (decision points), and the rules for when to pause or stop and when to restart the exercise for full interruption simulations.
- [ ] Run the quarterly effectiveness and readiness tests, and record what was tested, the results, and any deviations in an evidence pack.
- [ ] Record and review how the contingency operations seen during the tests affected day-to-day organisational activities, assets, and individuals.
- [ ] Hold a meeting to review the results after testing, including responsibilities for information security, identify weaknesses, and assign a severity level.
- [ ] Create tracked corrective actions with a named responsible person and a due date, and require proof that the issue has been retested before the action can be marked as complete.


---

#### CP-4.1 — Coordinate with Related Plans (Enhancement)

This requirement is about making sure your organisation’s plans for major disruption are prepared and carried out with the teams responsible for other plans that could be affected. If you test your contingency plans on their own, you may miss important handovers, give staff and the public conflicting information, or only find out too late that the people responsible for business continuity, recovery, day-to-day operations, crisis communications, critical infrastructure, emergency response, or related incident handling are not working to the same assumptions as your tests.

To meet this expectation, the organisation must identify who is responsible for each relevant related plan, and then coordinate the testing of your contingency plans with those responsible people. This includes involving them in both the planning and the running of the test. This applies even if you do not have a dedicated team for related plans—coordination is still needed wherever those responsibilities sit.

##### Coordinate contingency plan testing with related-plan owners

- Category: Manual
- Priority: High

###### WHAT
Coordinate each contingency plan test with the parts of the organisation responsible for related plans (for example: business continuity, disaster recovery, continuity of operations, crisis communications, critical infrastructure, cyber incident response, and occupant emergency). Make sure those plan owners are involved in both planning and delivery.

###### WHY (control requirement)
CP-4(1) requires contingency plan testing to be coordinated with the organisational parts responsible for related plans. The guidance explains that organisations do not need to create new organisational parts or align them to specific plans, but **must coordinate** where those parts are responsible for related plans.

###### HOW (specific steps/approach)
1. **Create and keep a register of related-plan ownership** that lists each related plan type and the named organisational owner(s) (role, team, or person) responsible for it.
2. **Update the contingency plan testing procedure** so every test includes a required coordination step: confirm which related plan types apply to the scenario and invite the corresponding owners.
3. **Hold a coordination meeting before the test** with the related-plan owners that apply to the scenario, to agree objectives, assumptions, roles, escalation/handovers, and when communications should be triggered.
4. **Require owner approval or documented input** in the test pack (during planning), and record proof of participation during delivery (for example: who attended, invitations sent, and decisions made).
5. **Use a coordination checklist** as a required document for each test, and add a **“coordination outcomes”** section to the after-action report describing any changes to roles, communications, or procedures resulting from owner input.
6. **If an owner is not involved**, record a reason in the test record (for example: the owner is not applicable to the scenario) to show that coordination was considered and applied where responsibilities exist.

###### WHO
- **Contingency Planning Lead / Business Continuity Manager**: maintains the ownership register and ensures the testing procedure and checklists are used.
- **Related-plan owners** (for example: disaster recovery lead, crisis communications lead, cyber incident response lead, occupant emergency lead): take part in the pre-test coordination and provide approval or documented input.
- **Exercise/Testing Coordinator**: sends invitations, arranges meetings, and records evidence.

###### Acceptance criteria
- For each contingency plan test, the test record includes: (a) the related plan types that apply, (b) the named owners from the ownership register, (c) evidence that owners took part (invitations/attendees) and documented input/approval, and (d) a completed coordination checklist.
- After-action reports include a **“coordination outcomes”** section showing how owner coordination affected roles, handovers, communications, or procedures.
- Where an owner is not involved, the test record includes an auditable justification linked to whether the scenario applies.

###### Actions Required for Compliance

- [ ] Create and keep up to date a register of ownership for each related plan type listed in the CP-4(1) guidance.
- [ ] Update the contingency plan testing procedure so it requires identifying the plan types that are in scope and sending invitations to the plan owners as a mandatory step.
- [ ] Create a coordination checklist and include it as a required item in the test pack, and as a required section in the after-action report.
- [ ] Hold a pre-test coordination meeting with all responsible owners of the relevant plans to agree on responsibilities, how issues will be escalated and handed over, and what communication triggers will be used.
- [ ] Collect and keep proof that the owner took part in each test (for example, invitation records, attendee lists, and either signed approval or documented input).
- [ ] In the test record, record a clear, auditable reason whenever the person responsible for the related plan is not involved because the scenario does not apply.


---

#### CP-4.2 — Alternate Processing Site (Enhancement)

This requirement is about making sure your backup location is truly ready to take over if your main site is unavailable. Without a real visit and hands-on checks, you may only find out too late that the backup site does not have the key facilities, support, access arrangements, or ability to carry out essential work. This can lead to avoidable delays and disruption to important business services.

To meet this expectation, the organisation must plan and schedule a test of its contingency plan at the backup processing site. The people who would use the plan must be involved. The organisation must also carry out an on-site familiarisation walkthrough to show the specific resources that would be used during an emergency. It must then run a practical test to confirm the site can support contingency operations, record what was done and the results (including any major differences from the primary site), and use what it learns to update the contingency plan where needed.

The organisation must keep the relevant site agreements and service commitments available as evidence, and ensure the test outcomes are reflected in the organisation’s security planning documents where applicable.

##### Alternate site visit and practical contingency capability test

- Category: Manual
- Priority: Critical

###### WHAT
Plan, schedule, and carry out a test of the contingency plan at the alternate processing site. This includes: (1) an on-site familiarisation visit to see the real resources and capabilities available there, and (2) a practical test to confirm that essential contingency activities can be carried out from that site.

###### WHY (control requirement)
CP-4(2) requires the organisation to **test the contingency plan at the alternate processing site**. The guidance also explains that conditions at the alternate site may be very different from the primary site. An on-site visit and practical testing help identify weaknesses that could affect essential mission or business activities, and allow the contingency plan to be improved.

###### HOW (specific steps/approach)
1. **Set the test boundaries and what “success” means** for the alternate-site contingency activities (for example: identity and access capability, communications, ability to run the essential application process, and ability to access the required data and services). Record what “pass” means for each item.
2. **Arrange the test** at the named alternate processing site. Make sure the **contingency team** who will use the plan (business, application, infrastructure, and operations leads, plus relevant security representatives) are included in the test schedule.
3. **Carry out an on-site familiarisation walkthrough** using a structured checklist. This should show the specific resources used during contingency operations, such as entry and security processes, work areas, secure storage, network connection points, required third-party access routes, and the tools and workstations used for contingency processing.
4. **Run practical capability exercises** that reflect real contingency operations and confirm the constraints at the alternate site. For example: set up the required communications channels, complete authentication and access to the required systems using the organisation’s identity integration, and run a controlled end-to-end contingency process (such as restoring or using a defined dataset, or running a representative transaction).
5. **Record evidence and results**: document what was done, which resources were used, the outcome against each success item, and clearly note **any significant differences compared with the primary site** (including any security-related limitations or differences in access or support observed during the test).
6. **Update the contingency plan** based on what you find. Assign named owners for actions and set target dates. Where relevant, ensure the results are reflected in the appropriate security planning documents.
7. **Keep supporting agreements and commitments** (for example: site access arrangements, commitments for vendor or third-party support, and any relevant service expectations) as part of the test evidence. Confirm that they worked as agreed during the test.

###### WHO
- **Business Continuity/Disaster Recovery (DR) Manager** (test owner; ensures scope, scheduling, and evidence is captured)
- **Application and Infrastructure Operations Lead** (runs the contingency process exercises)
- **Information Security Representative** (supports access and security checks, and reviews evidence)
- **Alternate Site Facility/Service Owner** (supports the walkthrough and access validation)

###### Acceptance criteria
- A dated test plan exists for the alternate processing site, including scope and measurable success criteria.
- The on-site familiarisation walkthrough has been completed, and evidence shows the specific resources and capabilities used for contingency operations.
- Practical exercises were carried out at the alternate site, and results show whether each success item was met.
- Evidence includes documented significant differences compared with the primary site.
- The contingency plan was updated (or there is a formal justification for why no update is needed), including named action owners and dates for any gaps identified.
- Relevant access, support, and service commitments and agreements are retained as evidence and were validated during the test.

###### Actions Required for Compliance

- [ ] Create a contingency test plan for an alternative site, including the test scope, clear measurable success criteria, and the evidence required to prove it was completed.
- [ ] Arrange a visit to the alternate processing site and run practical drills. Confirm that the contingency team members and the information security representatives will attend.
- [ ] Carry out a structured on-site walkthrough to show, in detail, the exact resources and facilities used during contingency operations.
- [ ] Run practical readiness exercises at the alternate site to test identity and access controls, communications, and a complete, end-to-end example of the contingency process.
- [ ] Record the test results and evidence, confirm whether they meet the success criteria, and document any significant differences compared with the primary site.
- [ ] Update the business continuity plan with the results of the review, the named people responsible for each action, and the target dates. If no update is needed, document why.
- [ ] Keep and refer to the relevant site access and support agreements, and the agreed service commitments, as part of the test evidence.


---

#### CP-4.3 — Automated Testing (Enhancement)

This requirement is about running your disaster recovery plan rehearsals in a repeatable, automated way, so you can confidently switch to backup systems when it really matters. Without these rehearsals, a contingency plan may look good on paper but fail in practice, leaving your business unable to keep operating during outages, data loss events, or other disruptions.

The organisation must define an automated way to test the contingency plan, then set up automated rehearsal tests that are triggered through its normal software build and release process. The rehearsals must automatically create and configure the test environments using repeatable setup scripts, and run planned failover drills that switch to backup systems and then switch back safely where applicable.

For every rehearsal run, the organisation must keep clear records showing what was tested, who was responsible and/or who approved it, what happened, and the results. It must also ensure that only authorised people can start the automated rehearsals.

##### Automated contingency test orchestration via CI/CD and IaC

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated, repeatable way to test the contingency plan for the defined scope ({{ insert: param, cp-04.03_odp }}). This will use continuous integration and continuous delivery (CI/CD) pipeline automation, infrastructure-as-code (IaC) to create realistic test environments, and scripted failover practice runs (including checks and a safe return to normal operation where applicable). Every automated test run must produce evidence that can be audited and that is linked to the specific orchestration run identifier.

###### WHY (control requirement)
CP-4(3) enhancement requires: **“Test the contingency plan using {{ insert: param, cp-04.03_odp }}.”** The control guidance explains that automated testing improves coverage and realism, and makes it easier to put systems and the mission or business functions they support under stress.

###### HOW (specific approach)
1. **Define the automated contingency test approach** for the contingency plan scope, including: test objectives, the systems and functions being tested, the verification checks required (system health checks, synthetic transactions, and log checks), the expected failover behaviour, and the steps for safe return/switch-back.
2. **Create a dedicated CI/CD “Contingency Test” pipeline** that can only be started through authorised methods (for example, scheduled runs and/or an approval-controlled manual trigger). The pipeline must run the full test lifecycle:
   - provision (IaC apply)
   - deploy and validate the baseline
   - pre-failover checks
   - scripted failover drill
   - post-failover verification
   - switch-back (if applicable)
   - teardown (IaC destroy)
   - package evidence
3. **Provision temporary, realistic test environments using IaC** (for example, Terraform, Pulumi, or CloudFormation) so each run uses the same repeatable configuration and matches the production/disaster recovery (DR) layout (including networking, identity integration, logging and monitoring hooks, and data stores where appropriate).
4. **Run scripted failover drills using automation tools that match the technology** (for example, Ansible, PowerShell, or Bash, Kubernetes operators, or platform-native DR failover commands). The scripts must:
   - carry out the failover in a consistent, repeatable way
   - run verification checks after failover
   - switch back safely to the original state (where applicable)
   - stop the pipeline as failed if verification does not meet the agreed success criteria
5. **Automatically generate and store evidence for each run**, including:
   - pipeline run ID/build ID, timestamps, and the identity of the operator or approver
   - IaC outputs/digests (what was provisioned)
   - failover and verification results (including logs and test reports)
   - configuration and version identifiers (for example, commit hash and pipeline version)
   Store evidence in an auditable, access-controlled repository, with retention aligned to organisational policy.

###### WHO (roles responsible)
- **Application Owner / Business Continuity Owner**: sets test objectives, scope, and success criteria.
- **Platform/Infrastructure Engineer**: builds the IaC and provisions the environments.
- **DevOps/Release Engineer**: builds the CI/CD pipeline automation and evidence packaging.
- **Information Security / DR Governance Lead**: ensures the approval process, access restrictions, and evidence integrity.

###### Acceptance criteria
- A CI/CD pipeline exists that can run contingency plan tests end-to-end using automated mechanisms.
- Each run creates a realistic test environment using IaC (with no manual environment build steps).
- Each run performs a scripted failover drill and completes the defined post-failover verification checks.
- Each run produces auditable evidence linked to the CI/CD run ID (including who/what approved or started the run, IaC outputs, and verification results).
- Unauthorised users cannot start the automated rehearsal runs (the pipeline trigger is controlled by an approval/authorisation mechanism).
- The pipeline run fails (and the evidence reflects the failure) when verification criteria are not met.

###### Actions Required for Compliance

- [ ] Define what the automated contingency test will cover, what counts as a successful outcome, and how you will verify the results for the contingency plan.
- [ ] Set up an infrastructure-as-code (IaC) temporary test environment that matches the disaster recovery (DR) setup and connects to the organisation’s identity system, logging, and monitoring.
- [ ] Create a “contingency test” pipeline for continuous integration and continuous delivery (CI/CD) with stages to: set up the environment, deploy and run baseline checks, run an automated failover, verify the system is working, switch back if applicable, and then remove the environment (teardown).
- [ ] Run planned, repeatable failover tests using scripts, and then check the system after the failover. If the required conditions are not met, make the pipeline stop and report failure.
- [ ] Set up pipeline triggers so only authorised users can start them, using an approval step and running the pipeline with the minimum necessary permissions.
- [ ] For each pipeline run, automatically create the evidence record (including the pipeline run ID, infrastructure-as-code outputs and checksums, failover and verification results, timestamps, and the person who initiated and approved it) and store it in an auditable repository with defined retention periods.


---

#### CP-4.4 — Full Recovery and Reconstitution (Enhancement)

This requirement is about making sure your systems can be fully restored after a serious disruption, and then returned to normal working order in a controlled and repeatable way. If this is not done properly, a major outage, corrupted information, or a failed application could leave your business unable to operate, with teams having to guess what to fix—risking further mistakes or long delays.

To meet this expectation, the organisation must include two steps in contingency plan testing:
- a complete recovery to a pre-agreed, known condition; and
- a full reconstitution back to fully operational service, as required.

The organisation must have clear, written procedures for both recovery and reconstitution. It must also define what the “known state” means for the system’s hardware, software, and data, and use that definition during the test. The organisation must record what was done, keep the test evidence and results, and obtain documented sign-off confirming that recovery and then normal service were successfully restored with minimal disruption to business activities.

##### Evidence-backed recovery and reconstitution using known-state restore packs

- Category: Software
- Priority: Critical

###### WHAT
Carry out contingency plan testing that includes (1) **full recovery** of the system back to an **agreed, known starting point** and (2) **full reconstitution** to return the system to **fully working service**. This must use **saved information about the system’s state** for **hardware, software programmes, and data**.

###### WHY (control requirement)
The United States National Institute of Standards and Technology (NIST) Special Publication 800-53 **Contingency Planning (CP-4(4))** enhancement requires that contingency plan testing **includes full recovery and full reconstitution of the system back to a known starting point**. It also requires setting that known starting point to include **information about the system’s state for hardware, software programmes, and data**, and saving it so the system can restart and return to normal operation with less disruption.

###### HOW (specific approach)
1. **Define the known starting point for each system** in the contingency plan test package (or referenced runbook):
   - Hardware/compute profile identifiers (for example, instance type/cluster profile, network segment, storage class).
   - Software programme identifiers (for example, operating system build ID, application release version, container image digests, dependency versions).
   - Configuration baseline version (for example, configuration management/infrastructure as code (IaC) commit ID or manifest version).
   - Data state reference (for example, database snapshot ID/time window, schema version, seed/reference data set).
2. **Save the system state information** as a version-controlled, access-controlled set of “restore pack” files:
   - The restore pack contents must match the known starting point above (hardware profile reference, software files, configuration baseline, and data snapshot reference).
   - Ensure restore packs are protected against tampering (for example, signed files where feasible) and stored in an auditable repository.
3. **Run contingency testing in two clear phases, with evidence captured for each**:
   - **Recovery phase (full recovery):** redeploy/restore from the restore pack to reach the known starting point; confirm the system has reached the known starting point using automated checks (build/version checks, configuration drift checks, database/schema version checks, service health checks).
   - **Reconstitution phase (full reconstitution):** move from the recovered state to **fully working service** (for example, re-enable production work in a controlled order, restore normal routing/feature settings, re-activate monitoring/alerts as described in the runbook); run the agreed business/mission transaction tests.
4. **Record and keep test evidence and obtain sign-off**:
   - Capture timestamps, restore pack identifiers, validation outputs, any deviations, and results for both phases.
   - Obtain documented sign-off confirming that **recovery is complete** and **reconstitution is complete**, with minimal disruption to business/mission activities (as defined in the test acceptance criteria).
5. **Use separate environments and controlled test time windows** in line with the organisation’s operating model (production/test/disaster recovery (DR) separation) to minimise disruption.

###### WHO (roles responsible)
- **Application Owner / Service Owner:** owns the known starting point definition and the test acceptance criteria.
- **Infrastructure/Platform Engineer:** prepares and runs the restore from the restore pack (hardware/software/configuration/data mapping).
- **Database Administrator (or Data Platform Engineer):** validates data snapshot/schema restoration and data integrity.
- **Information Security (or Security Engineering):** checks that the known starting point and evidence capture meet CP-4(4) expectations, and that handling of sensitive data during tests is controlled.
- **Change Manager / CAB (Change Advisory Board) (as applicable):** ensures testing is authorised and tracked under change/release governance.

###### Acceptance criteria
- For each contingency plan test, the organisation can show:
  1. A **documented known starting point** exists for the system, including **state information for hardware, software programmes, and data**.
  2. A **version-controlled restore pack** was used that points to the known starting point files.
  3. **Full recovery** was carried out and confirmed using objective checks showing the system matches the known starting point.
  4. **Full reconstitution** was carried out and confirmed using agreed operational/business transaction tests.
  5. **Evidence** (restore pack IDs, validation outputs, timestamps, deviations) is kept and **documented sign-off** exists for both the recovery and reconstitution phases.

###### Actions Required for Compliance

- [ ] Define and document the system’s known starting point for this environment, including the hardware profile, software versions, the configuration baseline version, and the reference for the data snapshot and schema.
- [ ] Create a restore package that is versioned and protected by access controls, and that matches the exact known system state while keeping all required system information.
- [ ] Set up automated checks during the recovery phase to confirm the correct files and versions are used, to detect any configuration changes (configuration drift), and to verify that the data and its structure (schema) are complete and correct.
- [ ] Set up automated and controlled steps for the reconstitution phase, including enabling the approved workflow, turning on monitoring and alerts, and running business transaction tests.
- [ ] Run contingency plan tests using the restore pack in separate, isolated environments, and record evidence for both phases, including the date and time, restore pack identifiers, validation results, and any deviations.
- [ ] Get documented approval that recovery is complete and reconstitution is complete, and keep the test pack and results for audit purposes.


---

#### CP-4.5 — Self-challenge (Enhancement)

This requirement is about deliberately testing your live systems in a safe, planned way, so you understand how they behave when something goes wrong. Without this, a real cyber incident or service outage could spread more than expected, leaving important services slow, unusable, or unable to recover quickly. You may also miss hidden links between systems until it is too late.

The organisation is expected to use automated, simulated attacks and controlled service disruptions on its on-premises production network services and critical application servers. Examples include temporarily reducing network bandwidth and temporarily limiting user or system permissions. The purpose is to deliberately create harmful conditions, then check whether services can still work as intended and recover within the planned timeframe.

The organisation must:
- define the test scope and process
- ensure tests are authorised and can be repeated
- record what was disrupted and what happened
- analyse the results to identify unexpected dependencies and weaknesses
- document how findings will be used in recovery and re-establishment planning

The organisation must also keep up to date and retain: the relevant contingency planning policy, recovery procedures, contingency plan, updates to the system security plan, and evidence of test documentation, results, and named responsibilities.

##### Automated resilience self-challenge with scoped disruption and evidence

- Category: Software
- Priority: Critical

###### WHAT
Carry out automated, authorised, simulated cyber-attacks and controlled service disruptions against the defined on-premises production network services and critical application servers. Use methods that (1) reduce available network bandwidth and (2) temporarily limit privileges. These actions must disrupt and negatively affect the intended components, while staying controlled and able to be reversed.

###### WHY (control requirement)
NIST SP 800-53 CP-4(5) enhancement requires the organisation to “employ {{ cp-04.05_odp.01 mechanisms }} to {{ cp-04.05_odp.02 system or system component }} to disrupt and adversely affect the system or system component.” The guidance also expects automated, ongoing simulated cyber-attacks and service disruptions to uncover unexpected dependencies and resilience weaknesses.

###### HOW (specific approach)
###### 1) Define and manage the resilience self-challenge scope
- Create a resilience test catalogue that lists the exact “system or system component” targets (on-premises production network services and critical application servers). Include the service owner, recovery owner, and the specific negative-impact hypotheses (for example: bandwidth reduction, throttling, temporary privilege limits).
- Set test time windows, maximum impact limits, and clear stop/recovery conditions (kill-switch triggers) to prevent uncontrolled outages.

###### 2) Implement automated disruption mechanisms (IT/operational technology (OT)-safe where applicable)
- **Bandwidth reduction mechanism:** implement controlled traffic shaping and quality of service (QoS) changes on approved network routes (for example, per subnet/virtual local area network (VLAN) and per application flow where possible). Use pre-approved maximum reduction levels and fixed durations.
- **Privilege restriction mechanism:** implement time-limited, reversible privilege reduction using the organisation’s identity and access platform (for example, temporary removal of roles, reduced application programming interface (API) permissions, or disabling specific administrative capabilities for selected service accounts/users). Ensure only the minimum needed for the test is affected.
- **Service disruption mechanism:** where needed to meet the “adversely affect” intent, use controlled throttling or restart of non-safety-critical components, or rate limiting of specific application functions. Never use broad “stop all” actions.

###### 3) Ensure repeatability, authorisation, and limited impact (blast-radius) controls
- Use an orchestration workflow (runbooks) that requires prior approval and enforces:
  - target allow-lists (only catalogue items can be disrupted),
  - blast-radius limits (only the specified subnets/VLANs/instances/accounts),
  - time limits and documented recovery steps,
  - automated pre-checks (service health baseline) and post-checks (confirmation that services are restored).

###### 4) Capture evidence and analyse resilience outcomes
- Collect performance and health information throughout each run, including network performance, application availability/latency/error rates, identity and authorisation events, and overall system health.
- Record exactly what was disrupted (mechanism type, settings, affected targets, start/stop times) and what happened as a result (degree of degradation, recovery time, and any unexpected dependencies).
- Analyse dependencies based on observed impact patterns to identify hidden functional dependencies and update recovery/reconstitution steps accordingly.

###### 5) Use results to update contingency planning materials
- Update the contingency plan and recovery/reconstitution procedures based on the findings.
- Ensure the system security plan and relevant contingency planning documentation are updated to reflect lessons learned and any new resilience controls.

###### WHO
- **Resilience Test Lead / Service Owner:** maintains the test catalogue and negative-impact hypotheses.
- **Security Engineering (or Cyber Resilience Team):** designs disruption mechanisms, safeguards, and evidence requirements.
- **Identity and Access Management (IAM) Owner:** implements time-limited privilege restriction workflows.
- **Network/Infrastructure Engineering:** implements bandwidth reduction mechanisms and recovery.
- **Change Management / Authorising Official:** approves each test execution within the defined time windows.

###### Acceptance criteria
The organisation can demonstrate at least one executed self-challenge test where:
1) the defined “mechanisms” were used to disrupt and negatively affect the defined “system or system component” targets,
2) bandwidth reduction and temporary privilege restriction were applied in a controlled, reversible way, with enforced blast-radius limits,
3) the test was authorised, repeatable, and followed documented runbooks with automated stop/recovery conditions,
4) test evidence exists showing what was disrupted, what impact was observed, and how quickly services recovered/reconstituted,
5) the results were analysed to identify unexpected dependencies/weaknesses and were used to update contingency/recovery materials.

###### Actions Required for Compliance

- [ ] Create a resilience self-assessment test catalogue for the on-premises production network services and critical application servers, with named owners and clear recovery responsibilities.
- [ ] Define the approved ways to disrupt service, including the settings for reducing bandwidth and temporarily restricting privileges for a limited time. Include the maximum allowed impact levels and the steps to undo the changes (rollback).
- [ ] Set up automated procedures (“runbooks”) that enforce approved target lists, limit how widely changes can affect systems (“blast-radius” limits), apply changes only during defined testing time windows, and include an emergency stop (“kill switch”) condition to halt activity immediately if needed.
- [ ] Set up identity-based processes to temporarily and reversibly limit access rights for selected users and service accounts during each test.
- [ ] Set up telemetry collection and evidence capture to record which components were disrupted, the key operating settings used, the start and stop times, the impact that was observed, and how well recovery performed.
- [ ] Carry out an analysis of dependencies after testing and update the contingency plan, the recovery and re-establishment procedures, and the system security plan sections based on the results.


---

### CP-6 — Alternate Storage Site (Control)

This requirement is about making sure your organisation can still restore important backup information even if your main site is unavailable, by keeping backup copies somewhere else. Without a properly set-up alternate storage location, a major disruption—such as a site outage, equipment failure, or wider incident—could mean you cannot restore systems or continue essential work.

To meet this expectation, the organisation must:
- choose a backup storage site in a different geographic location from the primary site
- put formal agreements in place that clearly allow backups to be securely stored and later retrieved
- ensure the alternate site provides protection and access safeguards equivalent to those at the primary site, including suitable environmental conditions and secure handling of backup media

The organisation must also:
- document who is responsible
- create clear, step-by-step procedures for storing and retrieving backups at the alternate site
- keep the relevant plans and records up to date, so the arrangements are understood and can be used during an incident.

##### Geographically separate backup vault with auditable chain-of-custody

- Category: Manual
- Priority: Critical

###### WHAT
Set up and run a separate off-site location for storing the application’s system backup information (for example, backup media and/or backup data). Make sure backups can be stored securely and can be retrieved reliably if the main site is unavailable.

###### WHY (control requirement)
Control CP-6 requires that the alternate storage site is in a different geographic location from the main (primary) storage site, and that it holds duplicate copies of the information/data. This is so essential services can continue even if there is a disruption. The arrangement must reflect business continuity planning needs and include environmental conditions, access rules, physical and environmental protection, and coordination for sending and collecting backup media.

###### HOW (specific steps/approach)
1. **Select and document the alternate site**: Choose a storage facility or data storage service that is clearly separated geographically from the primary site. Record the alternate site address/region, what backups it will hold, and the storage areas in the contingency plan and system documentation.
2. **Put agreements in place**: Set up contractual or operational agreements that clearly allow secure backup storage and later retrieval. Include: approved delivery methods, the process for requesting retrieval, expected turnaround times, incident notification and availability expectations, and environmental limits (for example, temperature, humidity, fire and water protection) and access rules.
3. **Use an auditable chain of custody for backup media** (where backups are stored on physical media): Use tamper-evident packaging/seals, unique batch or container identifiers, and clear labelling rules. Use a handover form/log that records batch identifiers, dates and times, and the named roles responsible. Make sure retrieval requests are raised through the agreed process, and that collection and return are logged in the same way.
4. **Ensure equivalent security and protection at the alternate site**: Check that the alternate site’s physical and environmental protections and access controls are equivalent to the primary site (for example, controlled entry, visitor management, secure storage areas, and protection from environmental hazards). Keep evidence such as facility security documentation and inspection or audit reports.
5. **Create and test backup and retrieval procedures for the alternate site**: Produce step-by-step runbooks showing who sends backups, how backup batch references are created, how backups are received and stored at the alternate site, and how retrieval is requested and confirmed. Carry out at least one controlled retrieval test per cycle (for example, quarterly or twice yearly) and run tabletop exercises to confirm the procedures match real life.
6. **Align with contingency planning and keep records**: Ensure the alternate storage arrangement is included in the contingency plan and system security documentation. Keep evidence of the agreements, chain-of-custody logs, retrieval confirmations, and test results so the approach can be audited.

###### WHO (role responsible)
- **Business Continuity and Disaster Recovery (DR) Manager**: owns alignment with contingency planning and the testing schedule.
- **Information Security and Compliance Lead**: checks that protections and agreement terms are equivalent.
- **Infrastructure and Storage Operations Lead**: carries out backup dispatch and receiving procedures and maintains the chain-of-custody tools and logs.
- **Service Provider / Vault Facility Security Contact**: provides facility security evidence and supports retrieval processes.

###### Acceptance criteria
- A geographically distinct alternate storage site is formally documented and approved for the application’s backup scope.
- The agreements in place explicitly cover secure storage and retrieval, including delivery and retrieval coordination details and environmental and access requirements.
- Documented procedures exist for storing and retrieving backups at the alternate site, including named roles and step-by-step workflows.
- Evidence is available showing equivalent physical and environmental protection and access rules at the alternate site.
- At least one successful, auditable retrieval test has been completed within the defined cycle, and the results have been retained (including chain-of-custody and retrieval confirmation records).

###### Actions Required for Compliance

- [ ] Choose and document a separate backup storage location in a different geographic area for the application’s backup coverage.
- [ ] Carry out in-force agreements covering secure backup storage, authorised delivery, the retrieval process, turnaround times, and incident notification
- [ ] Define and put in place chain-of-custody procedures for handing over backup media, including how seals are used, how batch numbers are recorded, what handover records are kept, and which named roles are responsible.
- [ ] Check and document that the alternate site’s physical and environmental protections, and its access rules, are the same as those at the primary site.
- [ ] Publish runbooks for alternate-site backup dispatch and ingestion, and for retrieval requests and confirmations, including escalation paths.
- [ ] Carry out and record at least one successful “alternate site” data retrieval test, and one tabletop exercise, in each defined cycle.


---

#### CP-6.1 — Separation from Primary Site (Enhancement)

This requirement is about keeping your backup storage in a location that is different enough from your main storage, so that the same disaster or mistake is less likely to damage both at the same time. Without this, a single event—such as a flood or fire, a building or structural failure, a deliberate break-in, or even human error—could leave you unable to recover your data because both locations are affected together.

To meet this expectation, the organisation must:
- identify at least one alternate storage site;
- use its risk assessment to decide how much separation is needed to reduce the risk that both sites could be affected by the same threats, including natural disasters, structural failures, hostile attacks, and human mistakes;
- clearly record the chosen alternate site in its key planning documents;
- include the alternate site in the recovery plan and day-to-day recovery procedures;
- put formal agreements in place covering both the main and alternate sites;
- assign named people to be responsible for using the alternate site during recovery and for related information protection activities; and
- keep records that show the separation decision and the reasons for it.

##### Document and implement a threat-based separated alternate backup site

- Category: Manual
- Priority: Critical

###### WHAT
Choose and use an additional storage location for backup and recovery copies that is far enough away from the main storage location to lower the risk of the same problems affecting both.

###### WHY (control requirement)
CP-6(1) requires the organisation to **identify an additional storage location** and confirm it is **sufficiently separated** from the main site. This decision must be based on the **threats identified in the organisation’s risk assessment**, including **natural disasters, structural failures, hostile attacks, and mistakes of omission or commission**. The guidance also says that for **hostile attacks**, the **distance between sites matters less**, so the reason for separation must clearly reflect this.

###### HOW (specific steps/approach)
1. **Select the additional site**: Choose at least one additional storage location (for example, a different data centre or region, a different physical site, or an independently managed storage service). It must be demonstrably separated from the main site for the threat types used in the risk assessment (for example, different flood, landslide, earthquake, or utility-dependency areas).
2. **Write the separation reason based on the risk assessment**: For each threat type in the risk assessment (natural disasters, structural failures, hostile attacks, mistakes of omission or commission), record why the chosen separation reduces the chance that both sites are affected in the same way. Clearly state that **hostile attacks are treated as less dependent on distance**, so you must rely on other safeguards (for example, write-protected or unchangeable backups, access controls, and monitoring) rather than separation alone.
3. **Make backups independent at the additional site**: Set up backups so that a compromise or human error at the main site does not automatically cause loss of backups at the additional site (for example, use write-protected or “immutable” backup settings at the additional site, use separate credentials or roles for restoring, and use encryption and key management that prevents the main site from deleting or changing backups at the additional site).
4. **Update contingency planning records**: Update the system’s contingency planning documents and day-to-day recovery procedures to include the additional site. This must include the exact restore steps (which backup sets to use, how to access the additional site, and who is authorised to approve restores).
5. **Put formal agreements and named responsibilities in place**: Create agreements covering service availability, access during recovery, and independence from main-site outages. Assign named roles or individuals responsible for using the additional site during recovery and for related information-protection activities.
6. **Test that recovery can actually reach the site**: Run recovery “table-top” exercises and at least one practical restore test to confirm the additional site can be used within the organisation’s recovery expectations.

###### WHO (role responsible)
- **Information System Owner / Business Continuity Manager**: accountable for the separation decision and the contingency planning updates.
- **Security Architect / Risk Owner**: ensures the separation reason is based on the threats identified in the organisation’s risk assessment.
- **Infrastructure/Cloud Backup Engineer**: sets up write-protected or independent backup configuration and ensures restore connectivity.
- **IT Operations / Incident Response Lead**: maintains recovery procedures, runs restore tests, and confirms named responsibilities.

###### Acceptance criteria
- The organisation can provide evidence of a documented **additional storage location** for backups and recovery copies.
- The organisation can provide a **separation rationale based on the risk assessment**, covering: natural disasters, structural failures, hostile attacks (including an explicit statement that “separation is less relevant”), and mistakes of omission or commission.
- The system’s **contingency plan and recovery procedures** clearly name the additional site and explain how to restore from it.
- There are **formal agreements** with the main and additional site providers/owners (or internal site owners) and **named individuals/roles** responsible for additional-site recovery activities.
- Evidence exists of at least one **restore validation** (a test or table-top exercise with documented results) showing the additional site is reachable and usable for recovery.

###### Actions Required for Compliance

- [ ] Choose a different storage location for your backup and recovery copies, and record where it is and the service details.
- [ ] Document the reasons for separating responsibilities, and link them to the threats identified in the organisation’s risk assessment: natural disasters, structural failures, hostile attacks, and mistakes made by not doing something or doing something incorrectly.
- [ ] Update the system contingency plan and the day-to-day recovery procedures to clearly state the alternate site and the exact restore steps.
- [ ] Put in place and sign agreements that cover: responsibilities for the main and backup sites, access arrangements during recovery, and how the backup site can operate independently if the main site is unavailable.
- [ ] Assign specific named people (or roles) who are responsible for alternate-site recovery and for related information protection activities.
- [ ] Run a recovery tabletop exercise and carry out at least one test restore to confirm the alternate site is operationally usable.


---

#### CP-6.2 — Recovery Time and Recovery Point Objectives (Enhancement)

This requirement is about making sure your backup location is genuinely ready to get you back to normal quickly, with the right amount of data loss. If it is not set up properly, a major disruption could mean you cannot reach the backup site when you need it, recovery actions fail because of incorrect setup, and you restore services too slowly or lose more data than you can tolerate.  

To meet this expectation, the organisation must configure its alternate storage site—including the physical premises and the supporting systems—so that recovery can restore the required services within the agreed recovery time objective (how quickly you must be back) and restore data to the agreed recovery point objective (the latest time you can afford to lose). The site must also be set up so recovery can be carried out correctly, without avoidable misconfiguration, in line with the organisation’s contingency planning.

##### Configure alternate site for RTO/RPO with restore rehearsals

- Category: Software
- Priority: Critical

###### WHAT
Set up the alternate storage site (the physical facilities and the systems that support recovery work) so recovery can be carried out correctly and meets the organisation-defined **Recovery Time Objective (RTO)** and **Recovery Point Objective (RPO)**.

###### WHY (control requirement)
CP-6(2) enhancement requires that the alternate storage site is set up to support recovery work **in line with RTO and RPO**, and that this setup includes the **physical facilities and supporting systems** needed for **access and correct execution** of recovery work.

###### HOW (specific steps/approach)
1. **Link RTO/RPO to what can be recovered**: For each critical application service and data store (for example, web services, application programming interfaces (APIs), databases, messaging, and identity integrations), record the required RTO and RPO and the recovery method (restore from backup, failover using replication, point-in-time recovery, or configuration rebuild where relevant).
2. **Set up the alternate storage site and recovery-supporting systems**: Make sure the alternate site has:
   - Network connections and routing to required dependencies (identity, logging and monitoring, messaging, databases).
   - Storage and backup/recovery tools that can meet the RPO (for example, controls for replication delay and the ability to restore to a specific point in time).
   - Computing and environment readiness to meet the RTO (for example, pre-prepared templates/virtual machine images/containers, or an automated way to build the environment).
   - Security-appropriate access to recovery data (access to encryption keys, recovery roles with the minimum necessary permissions, and checks that recovery media/objects are intact).
3. **Put recovery instructions into controlled, repeatable procedures**: Create recovery runbooks that are version-controlled and repeatable, and (where possible) use infrastructure-as-code to automate them. These should state the exact steps to restore each component and how to confirm recovery worked (service health checks and checks at application level).
4. **Run automated restore practice tests that provide RTO/RPO proof**: Carry out planned, documented restore tests that measure:
   - **RTO evidence**: the time from starting recovery to restoring the required services.
   - **RPO evidence**: the most recent recoverable data time achieved (for example, the point-in-time marker) and confirmation it meets the RPO.
   - **Correct execution evidence**: confirmation the runbooks run without avoidable setup errors (for example, missing credentials, incorrect mappings, or unavailable dependencies).
5. **Review results and fix gaps**: If any practice test does not meet the RTO/RPO targets or suggests a risk of incorrect setup, raise corrective actions to update the alternate site setup, the runbooks, or the backup/recovery approach. Re-test until the acceptance requirements are met.

###### WHO (role responsible)
- **Disaster Recovery (DR) / Business Continuity Plan (BCP) Lead (Application Continuity Owner)**: owns the RTO/RPO mapping, the practice test schedule, and tracking of fixes.
- **Infrastructure/Cloud Engineer**: sets up the alternate site compute, network, storage, and recovery tools.
- **Database/Platform Engineer**: ensures databases and data stores can be restored to the correct point in time and consistently.
- **Security/Identity Lead**: ensures recovery access controls, encryption key access, and recovery roles have the minimum necessary permissions.
- **Application Owner/Technical Lead**: defines application-level checks to confirm recovery is correct.

###### Acceptance criteria
- For each in-scope critical service/data store, restore practice tests show recovery is achieved within the defined **RTO** and data is restored within the defined **RPO**.
- Restore practice tests include documented checks that the recovery steps run correctly (with no avoidable setup issues causing failed or only partial recovery).
- The alternate site setup (physical facilities and supporting systems) is clearly accessible and usable for recovery work, evidenced by practice test outputs and records of remediation actions.

###### Actions Required for Compliance

- [ ] Document the recovery time objective (RTO) and recovery point objective (RPO) targets for each application component, and specify the required recovery method (restore, replication, or point-in-time recovery).
- [ ] Set up the alternate site’s storage, computing, and network resources so they can support the chosen recovery methods and make the recovery time objective (RTO) and recovery point objective (RPO) achievable.
- [ ] Create recovery runbooks that are version-controlled (and automate steps where possible) to clearly set out the exact order for restoring services and the checks to confirm everything is working correctly.
- [ ] Set up protection and controlled access for recovery data used during restores at an alternate site, including encryption key access, recovery roles with the minimum necessary permissions (least privilege), and checks to ensure data integrity.
- [ ] Run scheduled automated restore practice tests and measure and record:

- **RTO (recovery time objective)**: how long it takes to restore service  
- **RPO (recovery point objective)**: the latest point in time you can recover to
- [ ] Fix any rehearsal gaps against the recovery time objective (RTO) and recovery point objective (RPO), or any failures to execute correctly, then re-test until the agreed acceptance criteria are met.


---

#### CP-6.3 — Accessibility (Enhancement)

This requirement is about making sure your organisation can still access backup information somewhere else if a wide-area disaster prevents normal access. Without this, authorised staff may not be able to reach the planned alternate storage location because roads are blocked, the site is physically inaccessible, or electronic connections fail—meaning you may not be able to restore critical systems and records when you need them most.

To meet this expectation, the organisation must first define what it means by an area-wide disruption. It must then identify and document realistic access problems that could affect getting to the alternate storage site for that scenario. For each problem, it must record clear, practical steps to overcome it. This includes copying backup information to other alternate locations if the original location cannot be reached, and planning how staff will gain physical access to retrieve backups if electronic access is not available.

These actions must be included in the contingency planning documents and supported by the organisation’s risk assessment and assigned responsibilities.

##### Accessibility failure-modes register for alternate backup sites

- Category: Manual
- Priority: Critical

###### WHAT
Create an organisation-owned, risk-based list of accessibility failure scenarios for each designated alternate storage site, and include it in the contingency/disaster recovery playbook with clear actions that can be tested.

###### WHY (control requirement)
CP-6(3) enhancement requires the organisation to **identify possible accessibility issues** affecting the **alternate storage site** during an **area-wide disruption/disaster**, and to **set out clear mitigation actions**, including:
- duplicating backup information at **other alternate storage sites** if access problems occur at the originally designated alternate site; and
- planning for **physical access** to retrieve backup information if **electronic access** to the alternate site is disrupted.

###### HOW (specific steps/approach)
1. **Define the scope of “area-wide disruption/disaster”** in the contingency planning documents, using the organisation’s risk assessment (for example: regional power loss, internet service provider/cloud impairment, road/airport closures, site security lockdown).
2. For **each designated alternate storage site**, create an “accessibility failure modes” table with at least these fields: *problem*, *impact on authorised access*, *detection trigger*, *mitigation action*, *restoration method*, *owner*, and *evidence location*.
3. Identify and document accessibility problems in two categories:
   - **Electronic/communications** (for example: DNS failure, virtual private network (VPN)/zero-trust broker not reachable, identity provider not reachable, object storage application programming interface (API) blocked, encryption/key service not reachable).
   - **Physical/travel** (for example: building inaccessible, security lockdown preventing entry, courier blocked, staff unable to travel due to road closures).
4. For every documented problem, specify a clear **“if/then” mitigation** that includes one or both of the control outcomes:
   - **Backup duplication/restoration from another alternate site** (name the secondary alternate site(s), the restore order, and the expected restoration method).
   - **Physical retrieval plan** for electronic-access failure (name the offline media/backup retrieval location(s), the pre-authorised roles, the physical access procedure, and how access credentials/authorisations are obtained).
5. **Embed** the register into the contingency playbook so responders follow a problem-to-mitigation mapping during an incident (not as a separate risk document). Make sure the playbook points to the register entries and the escalation/decision points.
6. **Test and confirm** the playbook using tabletop exercises that include both information technology (IT) and, where relevant, operational technology (OT) stakeholders. Cover at least one electronic-access failure and one physical-access failure scenario. Record the results and update the register.

###### WHO (role responsible)
- **Business Continuity/Disaster Recovery (DR) Manager** (owns the register and its integration into contingency planning)
- **Application Owner / Infrastructure Owner** (owns restoration methods and alternate-site mapping)
- **Security/Identity Lead** (owns assumptions for electronic-access failure modes and constraints for accessing credentials)
- **IT Operations / OT Operations Lead** (owns whether physical retrieval is feasible and the on-call/authorised people needed)

###### Acceptance criteria
- The organisation has a documented, risk-based **accessibility failure modes register** for each designated alternate storage site covering both electronic and physical/travel categories.
- For each failure mode, the register includes **explicit mitigation actions** that, where applicable, cover restoring from other alternate sites and/or **physical retrieval** when electronic access is disrupted.
- The contingency/disaster recovery playbook includes a **clear link** from identified accessibility problems to the corresponding mitigation steps.
- At least one tabletop exercise has been completed covering both an electronic-access disruption and a physical-access disruption, with evidence that the register/playbook was updated based on the exercise outcomes.

###### Actions Required for Compliance

- [ ] Define and document what counts as an organisation-wide disruption for the purposes of your risk assessment scope.
- [ ] Create an accessibility failure-modes register for each designated alternate backup storage site, split into electronic and physical (including travel) categories.
- [ ] For each type of failure, write clear “if this happens, then do that” actions, including the names of the secondary alternate sites that will be used to duplicate the backup and restore services.
- [ ] Document a step-by-step process for retrieving physical access when electronic access fails. Include which pre-authorised roles can perform the process and where to find offline backup media.
- [ ] Add the register to the contingency and disaster recovery plan as a “problem to mitigation” guide, including the escalation steps.
- [ ] Run practice “tabletop” exercises that cover at least one electronic access failure and one physical access failure, and update the risk register and playbook based on what you learn.


---

### CP-7 — Alternate Processing Site (Control)

This expectation is about having a pre-arranged, ready-to-use backup location. If your main site becomes unavailable, you must be able to quickly move and restart the essential work that supports handling classified Secret information and time-critical command-and-control services. Without this, an interruption could prevent you from operating when it matters most, which could lead to mission failure, loss of critical services, or unsafe handling of sensitive information.

To meet this expectation, the organisation must:

- choose an alternate site in a different geographic location  
- identify exactly which essential functions must be moved and restarted  
- ensure the move and restart can be completed within 4 hours  
- put in place the legal and contractual arrangements needed for the transfer and restart  
- ensure the required equipment and supplies are already at the alternate site, or can be delivered there within 4 hours  
- provide security and operational safeguards at the alternate site that are equivalent to those at the primary site  
- document the arrangements and procedures  
- assign named responsibilities  
- be able to demonstrate readiness to meet the 4-hour target

##### Geographically distinct alternate site with ≤4-hour Secret failover

- Category: Manual
- Priority: Critical

###### WHAT
Set up and keep a separate alternate processing site in a different location that can be brought into use to restart the organisation’s defined **essential mission and business functions** (including **processing classified Secret information** and **time-critical command-and-control services**) within the required **4-hour** timeframe, with **security and operational protections that are the same as** those at the primary site.

###### WHY (control requirement)
CP-7 requires an alternate processing capability that is **in a different location** from the primary processing site and can be used if the primary site is not available. This alternate capability must be supported by documented contingency planning, including **environmental conditions**, **access rules**, **physical and environmental protection**, and **coordination for moving and assigning staff**. It must also match the organisation’s defined **system operations scope** and the required **time period** (≤4 hours).

###### HOW (specific approach)
1. **Define what will move and restart**: create an “alternate processing service catalogue” that lists the exact essential functions/workloads to be transferred and restarted (Secret processing and time-critical command-and-control services). Include the required supporting capabilities (identity, key management/cryptographic services, logging/security information and event management (SIEM) intake, network services, and administration tools).
2. **Choose and check a truly separate location**: select a site that is clearly geographically separated from the primary site (for example, a different city area/region). Document the environmental and physical protection baseline needed to handle Secret information.
3. **Prepare a ready-to-use capability in advance**: use a hot/warm standby approach so the alternate site is already set up to a secure baseline, allowing staff to arrive and the essential functions to restart quickly. Pre-stage the required equipment and supplies, and ensure any missing items can be delivered or activated within the 4-hour target.
4. **Use the same security and operational protections**: for each essential function, match the security and operational controls used at the primary site to those at the alternate site (for example, access controls, monitoring for privileged access, encryption/key handling, matching logging/monitoring, and network separation). Make sure access rules and operating procedures are consistent and can be checked during audits.
5. **Put enforceable agreements in place**: agree and document contractual/legal arrangements (for example, service level agreement (SLA) terms) that clearly authorise activation, set response/availability commitments that fit the 4-hour window, and cover staff movement/coordination and any required environmental/physical access.
6. **Define activation triggers, responsibilities, and step-by-step instructions**: document the contingency activation sequence, who has decision authority, how staff will be coordinated, and who is responsible for transfer and restart. Ensure the step-by-step instructions (runbooks) include how to restore secure communications and how to confirm the essential functions are working.
7. **Test and keep proof that it is ready**: carry out at least periodic failover/restart exercises (both discussion-based and technical) to show the organisation can reach operational status for the defined essential functions within 4 hours. Keep evidence for audit (times achieved, completed checklists, confirmation of system health, and checks that security controls are equivalent).

###### WHO
- **Business/mission owner**: confirms the scope of the essential mission and business functions.
- **System owner / application owner**: owns what will be transferred and the technical restart requirements.
- **IT/operational technology (OT) infrastructure lead**: sets up and maintains the alternate site baseline and connectivity.
- **Information security lead**: checks that security controls are equivalent and that Secret-handling requirements are met.
- **Service management / disaster recovery (DR) coordinator**: maintains runbooks, the activation process, and the exercise schedule.
- **Legal/procurement**: negotiates and maintains enforceable agreements/SLAs.

###### Acceptance criteria
- A documented alternate processing site exists that is **in a different location** from the primary site.
- The organisation has a documented **alternate processing service catalogue** that identifies the exact **essential mission and business functions** to transfer/restart.
- Documented and evidenced activation/restart procedures show the organisation can resume the defined essential functions within **4 hours** of the primary site becoming unavailable (using agreed triggers and measured timings).
- Enforceable agreements/SLAs exist that clearly support activation, staff coordination, and response times aligned to the 4-hour target.
- Security and operational equivalence is demonstrated for the essential functions (access rules, environmental/physical protections, matching logging/monitoring, and cryptographic/key handling where applicable).
- Evidence of readiness is kept (exercise reports, timing measures, and outputs showing equivalence mapping).

###### Actions Required for Compliance

- [ ] Document the alternate processing service catalogue for the defined essential mission and business functions—specifically, secret processing and time-critical command-and-control services—and list their dependencies.
- [ ] Choose an alternate processing site in a different geographic location, and document the environmental and physical security requirements for handling Secret information.
- [ ] Set up an activation process that includes start triggers, who has decision authority, assigned roles, and a handover/resumption procedure (runbook) designed to meet a target of completing within 4 hours or less.
- [ ] Put in place enforceable agreements and service level agreements (SLAs) that clearly authorise activating the alternate site, coordinating the required personnel, and meeting the required response times.
- [ ] Create a mapping that shows how the primary and alternate site controls match for the essential functions, including access rules, monitoring and logging, and cryptographic key handling where applicable.
- [ ] Run and record regular failover and recovery tests. Measure how long it takes for the defined essential functions to be fully operational again, and keep the results in a format suitable for audit.


---

#### CP-7.1 — Separation from Primary Site (Enhancement)

This requirement is about making sure your business has a genuinely different backup location so you can keep operating if your main site becomes unusable. It addresses the real-world risk that the same disruption could affect both locations at the same time—for example flooding or fire, building or infrastructure failures, deliberate break-ins or sabotage, or mistakes made when switching over.  

To meet this expectation, the organisation must choose at least one alternate processing site that is far enough away from the primary site to reduce the likelihood that the same problems would affect both. This decision must be based on the organisation’s own assessment of the threats that could realistically happen.  

The organisation must then clearly document which alternate site has been chosen and explain why the distance is considered sufficient in its contingency planning policy, contingency plan, system recovery documentation, and the agreements with both the primary and alternate sites, so everyone involved knows where to go and what to do during an emergency.

##### Document and implement risk-based alternate processing site separation

- Category: Manual
- Priority: Critical

###### WHAT
Identify at least one backup processing site for the application that is sufficiently different from the main processing site to reduce the chance that the same problems affect both sites at the same time, and record the reasons for the separation.

###### WHY (control requirement)
CP-7(1) requires the organisation to **identify a backup processing site sufficiently different from the main site** so that shared threats are less likely to impact both sites at once. The level of separation must be decided using the organisation’s **risk assessment threats** (for example: natural disasters, building or structural failures, deliberate hostile attacks, and mistakes or omissions). For **deliberate hostile attacks**, the level of separation is considered less important.

###### HOW (specific steps/approach)
1. **Carry out or update a site separation risk assessment** for the application. This should link the organisation’s risk assessment threats to the ways those threats could cause failures at both sites (for example: flood risk, building fire and fire-suppression dependencies, power and other utility dependencies, shared telecommunications or internet service routes, shared identity and administration pathways, and human error during failover).
2. **Choose a backup processing site** that meets measurable separation requirements for the relevant non-hostile threats (for example: a different geographic area outside the identified hazard zones; independent power supplies; different ways to connect to and from the network; different building or structural characteristics; different physical access routes).
3. **Explain what “sufficient separation” means in the documentation**. For each separation requirement, state clearly which threat(s) it reduces. Also state explicitly how the risk from deliberate hostile attacks is addressed (that is, do not rely on separation alone; use security measures such as least privilege, monitoring of privileged access, and incident response).
4. **Keep contingency documentation up to date** and consistent, recording the backup site and the reasons for separation in the **contingency planning policy**, **contingency procedures**, the **contingency plan**, and the **system recovery documentation/system security plan**.
5. **Put formal agreements in place** between the owners of the main and backup sites (or their service providers). These agreements must reference the backup site’s contingency responsibilities and when it is expected to be activated.
6. **Ensure the backup site is operationally ready for failover** (for example, warm or cold standby as appropriate). The backup site must be able to be activated using documented runbooks, with evidence that the separation reasons still hold after changes (for example, controls to prevent configuration drift and periodic review of site dependencies).

###### WHO
- **Business Continuity/Disaster Recovery (DR) Manager**: owns the site separation risk assessment and updates to the contingency plan.
- **Application Owner / Service Owner**: confirms the application’s specific dependencies and the scope of failover.
- **Infrastructure/Cloud Platform Lead**: selects and sets up the backup site and documents independence of dependencies (power, network, telecommunications).
- **Information Security Lead**: approves the separation reasons, how deliberate hostile attacks are handled, and ensures alignment with the organisation’s risk assessment.
- **Legal/Procurement (if needed)**: ensures agreements with backup site providers include contingency responsibilities.

###### Acceptance criteria
- The organisation has **identified at least one backup processing site** for the application.
- The documentation clearly explains **why the separation is sufficient**, referencing the organisation’s **risk assessment threats** and showing how each separation requirement addresses those threats.
- The backup site and separation reasons are recorded in the **contingency planning policy**, **contingency procedures**, **contingency plan**, and **system recovery/system security documentation**.
- Agreements with the owners/providers of the main and backup sites **explicitly reference** the backup site and its contingency responsibilities.
- For deliberate hostile attacks, the documentation clearly states that **separation is not relied upon on its own**, and describes the additional security controls used to reduce the impact of shared hostile-attack threats.
- There is evidence that can be audited and traced to the application’s contingency arrangements (for example: the risk assessment record, site selection record, approved documentation set, and signed/approved agreements).

###### Actions Required for Compliance

- [ ] Carry out a site separation risk assessment for the application, mapping potential threats to shared failure modes across the primary site and the alternate site(s).
- [ ] Choose an alternative processing site that meets the documented separation requirements for the relevant non-hostile threats.
- [ ] Define and get approval for what “sufficient separation” means by linking each separation requirement to the specific threats identified in the risk assessment.
- [ ] Update the contingency planning policy, contingency procedures, contingency plan, and system recovery and system security documentation to record the alternate site and the reason for choosing it.
- [ ] Put in place and document agreements with the owners or providers of the primary site and the alternate site(s). These agreements should clearly reference the alternate-site contingency responsibilities.
- [ ] Review and provide evidence of how hostile attacks are handled, to ensure that separation is not relied on by itself. Document the compensating security controls and the monitoring expectations.


---

#### CP-7.2 — Accessibility (Enhancement)

This requirement is about making sure your organisation’s backup locations can still be used during a wide-area emergency that disrupts normal operations. If you do not check in advance that these locations are usable, you may find that people, systems, or services cannot be reached or used properly at the alternate site during a disaster. This can lead to delays, lost work, or an inability to carry on essential activities.

To meet this expectation, the organisation must:
- Define what it means by an area-wide disruption or disaster for its own planning.
- Identify the specific alternate processing sites it would use.
- Check those sites for any accessibility problems that could prevent them from supporting operations in the relevant disaster scenarios.

For every problem found, the organisation must:
- Record the issue clearly.
- Link it to the specific scenario where it would occur.
- Document clear, practical actions to reduce the impact, including what will be done, who will do it, and when it will be done, so the plan can be followed during the event.

These details must be included in the contingency planning documents, supported by the relevant site agreements, and assigned to named staff responsible for contingency actions, system recovery, and oversight. The same information must also be reflected in the system-level planning documents and kept for audit purposes.

##### Alternate-site accessibility risk register with tabletop mitigations

- Category: Manual
- Priority: Critical

###### WHAT
Create and maintain an **alternate-site accessibility risk register** that lists potential accessibility problems at each alternate processing site for **area-wide disruption/disaster** scenarios. For each risk, define **clear, practical mitigation actions**—what will be done, who will do it, and when. Test the register using **tabletop exercises** that simulate losing the primary site and having limited access to alternate sites.

###### WHY (control requirement)
CP-7(2) (Accessibility) requires the organisation to **identify potential accessibility problems** at alternate processing sites during an **area-wide disruption or disaster**, and to **set out clear mitigation actions**. The control guidance explains that “area-wide disruptions” are broad geographic disruptions identified through the organisation’s risk assessment.

###### HOW (specific steps/approach)
1. **Define the disruption scope** in contingency planning materials: record what counts as an “area-wide disruption or disaster” (for example, a regional power or telecommunications outage affecting multiple sites; cloud service degradation affecting all primary endpoints) and the planning assumptions.
2. **Identify alternate processing sites** for each relevant scenario, including the expected workloads/services and what is assumed for switching from the primary site to the alternate.
3. **Assess accessibility for each alternate site** and record any issues, covering (where relevant to your setup):
   - Identity and access: whether the identity provider (IdP) and single sign-on (SSO) are available, any dependencies on multi-factor authentication (MFA) and conditional access, and whether “break-glass” or offline recovery is possible.
   - Network access: whether domain name system (DNS) works, whether virtual private network (VPN), software-defined wide area network (SD-WAN), or edge routing is available, whether IP allowlists are in place, and whether certificates are valid.
   - Application access: whether required application programming interfaces (APIs) and secrets are available, whether licensing is in place, and whether database and storage connections can be made.
   - Administrative access: whether jump servers and remote management tools are available, whether privileged credential storage is available, and whether patching and required tools are ready.
   - Data access: whether encryption keys are available, whether data can be replicated or restored, and any expected limits on restore time and performance.
4. **Record each accessibility problem** in a risk register in a way that supports action during the event. Include:
   - Alternate site identifier, disruption scenario(s), problem description and impact, how it will be detected, mitigation action(s), trigger condition, named owner (role), and target completion date.
5. **Write mitigation actions as runbook steps** and ensure they are included in contingency planning materials and system-level planning documents. Examples of mitigation types to document (tailor to your environment):
   - How identity recovery will work if the central IdP is unreachable.
   - Pre-positioned network configuration items (for example, allowlists and certificate bundles) and the checks used to confirm they work.
   - Procedures for accessing credentials and secrets to run operations at the alternate site (including who can access them and how).
   - Steps to restore and activate data, including expected timelines.
6. **Validate using tabletop exercises**: run structured exercises for each scenario to confirm the mitigation actions work under constrained conditions (for example, limited connectivity, delayed DNS, or central services not available). Update the register and contingency documents based on the results.
7. **Assign and keep evidence of responsibilities**: ensure named staff are responsible for contingency actions, system recovery, and oversight, and keep the assessment and exercise outputs for audit.

###### WHO (role responsible)
- **Business Continuity Manager / disaster recovery (DR) Lead**: owns the scenario scope, the tabletop exercise programme, and updates to the contingency plan.
- **Application Owner / Service Owner**: owns application-specific accessibility risks and mitigations.
- **Infrastructure/Network Lead**: owns network access and administrative access accessibility mitigations.
- **Identity and Access Management (IAM) Lead**: owns identity and access recovery mitigations.
- **Information Security / Chief Information Security Officer (CISO) Office**: provides oversight, ensures mitigations align with security requirements, and approves audit evidence.

###### Acceptance criteria
- A documented **alternate-site accessibility risk register** exists and includes: each alternate site, the linked area-wide disruption scenario(s), identified accessibility problems, and explicit mitigation actions with **trigger conditions, named owners, and timing**.
- The register and mitigations are **included in contingency planning materials** and reflected in relevant **system-level planning documents**.
- At least one **tabletop exercise** has been completed for each major set of scenarios, and the outcomes are used to update the register and runbooks.
- Evidence of assessments and tabletop results is kept and can be retrieved for audit.

###### Actions Required for Compliance

- [ ] In your business continuity planning documents, define and record what counts as an organisation-wide disruption or disaster.
- [ ] Create a list of backup processing locations and match the expected workload and services to each disruption scenario.
- [ ] Carry out an accessibility assessment for each alternate site, covering identity access, network connection availability, access to applications, access to administrative functions, and access to data. Record the findings.
- [ ] Update the alternate-site accessibility risk register with linked scenarios, the potential impact, how the risk can be detected, the conditions that trigger it, the named responsible owners, and the mitigation actions.
- [ ] Turn each mitigation into clear runbook steps (what to do, when to do it, and who should do it), and include those steps in contingency planning materials and system-level planning documents.
- [ ] Run tabletop exercises for each major scenario, then update the risk register and the operating guides based on the results.
- [ ] Keep the assessment and tabletop exercise evidence, and confirm that responsibility for contingency actions and oversight is assigned to named staff.


---

#### CP-7.3 — Priority of Service (Enhancement)

This requirement is about making sure that, if your business systems need to be moved to a different processing location, your service provider will treat you as a priority. This helps you return to normal operations within the time you have planned for. Without clear priority commitments, you could end up waiting behind other customers, leading to longer disruption, missed deadlines, and avoidable financial and reputational harm.

To meet this expectation, the organisation must first decide:
- what level of availability it needs from an alternative processing location, and
- how quickly services must be restored after a disruption.

It must then decide what type of alternative processing it will use, either:
- a logical fallback (a backup option within the same environment), and/or
- a physical alternative site.

Next, the organisation must create written agreements with the relevant providers that clearly include priority treatment, matched to the availability needs and the agreed restoration time. The organisation must also ensure that its contingency planning documents and recovery responsibilities refer to these agreements, and that named individuals are responsible for creating, reviewing, approving, and enforcing the contract terms.

##### Priority-of-service clauses aligned to RTOs in alternate site agreements

- Category: Manual
- Priority: Critical

###### WHAT
Create and keep up to date written agreements with service providers for alternate processing sites (including service level agreements), making sure they include **priority-of-service provisions** that match the organisation’s **availability needs** and recovery time targets, known as **recovery time objectives (RTOs)**, for logical alternate processing and/or physical alternate processing.

###### WHY (control requirement)
CP-7(3) enhancement requires the organisation to **develop alternate processing site agreements** that include **priority-of-service provisions** aligned to **availability requirements**, including **RTOs**. Priority-of-service must be agreed so the organisation receives **priority treatment** when restoring services at the alternate processing site.

###### HOW (specific steps/approach)
1. **Set alternate processing targets for each service**: For every critical service in scope (for example, application components, identity integration, databases, messaging, and backup/recovery services), record the required availability and the **RTO** for logical failover and/or physical alternate processing.
2. **Create a standard contracting pack**: Prepare standard contract and service level agreement (SLA) wording that requires the provider to give the organisation **priority treatment** during incidents affecting the organisation’s services. Include clear, measurable restoration commitments that refer to the agreed **RTOs**, and state how priority will be applied (for example, priority access to support staff, priority order for restoration, and how escalation is handled based on incident severity).
3. **Maintain an RTO-to-clause mapping register**: Keep an auditable record that links each service’s **RTO** to the exact agreement/SLA document reference and the specific clause or SLA line items that enforce priority-of-service and restoration timing.
4. **Control purchasing and renewals**: Use a procurement workflow check so that any new or renewed alternate processing agreement cannot be approved unless the drafter selects the correct **RTO** level and includes the required priority-of-service clauses, with the correct mapping to the register.
5. **Connect contingency planning to the agreements**: Update contingency and disaster recovery documents so they reference the agreement references and explain how the organisation will request the provider’s priority-of-service during an incident (including named escalation contacts).
6. **Keep evidence and manage versions**: Store signed agreements and SLAs in a controlled repository with effective dates, and keep the mapping register up to date for audit purposes.

###### WHO (role responsible)
- **Business Continuity/Disaster Recovery (BC/DR) Lead**: owns the **RTO** and availability targets and ensures contingency plans reference the agreements.
- **Procurement/Commercial Manager**: ensures contracts are negotiated and signed.
- **Legal/Contract Manager**: checks that the priority-of-service clauses can be enforced.
- **Service Owner / Application Owner**: provides the service scope and confirms the correct **RTO** level.
- **Governance, Risk and Compliance (GRC) / Compliance Analyst**: maintains the RTO-to-clause mapping register and keeps audit evidence.

###### Acceptance criteria
- For each critical service in scope, there is a **signed alternate processing site agreement/SLA** that includes **priority-of-service provisions**.
- Each agreement’s priority-of-service clause is **clearly linked** to the service’s documented **RTO** (using the RTO-to-clause mapping register).
- Procurement and renewal records show the priority-of-service clauses were **required and not optional** for the selected **RTO** level.
- Contingency/disaster recovery documents reference the agreement references and include escalation contacts and steps to request priority treatment.
- Evidence is kept with controlled version control (agreement effective dates and mapping register entries).

###### Actions Required for Compliance

- [ ] For each critical service, document the required service availability targets and the recovery time objectives (RTOs) for alternate processing using logical and/or physical systems.
- [ ] Create standard alternate-processing contract and service level agreement (SLA) templates that include enforceable clauses for priority of service and the order in which services are restored.
- [ ] Maintain an RTO-to-clause mapping register that links each service’s recovery time objective (RTO) to the exact agreement and service level agreement (SLA) line items.
- [ ] Set up a procurement approval step that checks the correct recovery time objective (RTO) tier is chosen and that requires priority-of-service clauses to be included in every contract.
- [ ] Update the business continuity and disaster recovery (DR) procedures to reference the agreement identifiers, and explain how to request the provider’s priority during incidents.
- [ ] Store signed agreements and service level agreements (SLAs), along with mapping evidence, in a secure, controlled repository that records the effective date and keeps a full version history.


---

#### CP-7.4 — Preparation for Use (Enhancement)

This requirement is about making sure your backup site is genuinely ready to run the business if the main site cannot. Without proper preparation, essential services could be delayed or fail during an emergency because the backup site would be only a “paper plan”, not a working location with the right settings, trained people, and support in place.

The organisation is expected to plan in advance for using the alternate site as part of its documented recovery arrangements. This includes clearly naming who is responsible for preparing the site, who will restore systems there, and who is responsible for information protection. There must be formal, signed agreements that allow the site to be used when needed.

The organisation must also set up the backup site’s systems to match the main site’s required configuration, keep the security planning for that location up to date, and ensure essential supplies and practical logistics are available. Finally, recovery steps must be tested, or otherwise proven, to work at the alternate site.

##### Alternate site configuration baseline and readiness evidence pack

- Category: Software
- Priority: Critical

###### WHAT
Set up the alternate processing site so it is operationally ready by creating (and keeping up to date) a baseline configuration for the essential systems, matching security-related settings to those used at the primary site, and producing evidence that can be audited (including recovery methods that have been tested and the essential supplies needed to operate).

###### WHY (control requirement)
CP-7(4) (Preparation for Use) requires the organisation to **prepare the alternate processing site so it can act as the operational site supporting essential mission and business functions**. The guidance says site preparation includes **putting in place configuration settings that are consistent with the primary site** and ensuring **essential supplies and logistical needs are in place**.

###### HOW (specific steps/approach)
1. **Define the scope of “essential systems”** for the alternate site (applications, databases, identity and access integration, network services, monitoring and logging, secrets and key management, and any operational technology (OT) or edge components if applicable). Also identify which settings must match the primary site and which can differ (for example, IP addresses and certificate subject alternative names (SANs)).
2. **Create an alternate-site configuration baseline** for the essential systems that matches the primary-site required configuration, including software versions/build identifiers, service endpoints, identity integration settings, security hardening profiles, logging destinations and retention, encryption and key-management settings, and controls for privileged access.
3. **Put the baseline in place using repeatable configuration records** (for example, infrastructure-as-code and configuration management). Store these as version-controlled, approval-controlled records so the alternate site can be rebuilt or updated in a consistent way.
4. **Update the system security planning records** so the security plan and contingency and recovery documentation clearly include the alternate site and refer to the same security objectives and security-related settings as the primary-site baseline.
5. **Create and maintain an “alternate-site readiness evidence pack”** containing: (a) the approval record for the configuration baseline, (b) results of drift or consistency checks (where automated), (c) recovery runbooks that clearly reference the alternate-site activation steps and health checks, and (d) evidence from at least a tabletop exercise and one non-production recovery test (or an equivalent demonstration) showing the alternate site can support essential functions.
6. **Confirm the essential supplies and logistics needed for activation** (for example, access to required accounts and keys, spare capacity/credentials, vendor or landlord access contacts, connectivity requirements, and any required physical or consumable items). Record the activation conditions and the people responsible.

###### WHO (role responsible)
- **Business Continuity and Disaster Recovery (DR) Lead**: owns the alternate-site readiness evidence pack and ensures it matches the recovery arrangements.
- **Application Owner / Service Owner**: confirms the scope of essential systems and validates functional readiness.
- **Infrastructure/Platform Engineering**: creates and maintains the alternate-site configuration baseline records.
- **Information Security (Chief Information Security Officer (CISO)/InfoSec)**: checks that security-related configuration matches and ensures security planning covers the alternate site.
- **IT/OT Operations (as applicable)**: carries out readiness checks, maintains runbooks, and coordinates logistics verification.

###### Acceptance criteria
- The alternate site has a **documented, version-controlled configuration baseline** for all essential systems that is demonstrably consistent with the primary-site required settings (with any exceptions documented).
- The **system security planning records** explicitly cover the alternate site and align security-related settings with the primary-site baseline.
- **Recovery runbooks** for essential systems include alternate-site activation and restore steps and health checks that reference the alternate-site environment.
- Readiness evidence shows the alternate site can support essential functions using **tested or proven recovery methods** (tabletop exercise plus at least one non-production test or an equivalent proof).
- **Essential supplies and logistics** needed for activation are confirmed and recorded, including named contacts and activation conditions.

###### Actions Required for Compliance

- [ ] Identify and record the key systems and configuration settings that must be the same as the primary site at the alternate processing site.
- [ ] Create a version-controlled backup configuration for the alternate site, using infrastructure-as-code and configuration management for all essential systems.
- [ ] Set up identity, privileged access, encryption and key management, and logging and monitoring to match the required configuration for the primary site (and document any permitted exceptions).
- [ ] Update the system security plan and the recovery and contingency documentation to clearly include the alternate site, and to reference the baseline.
- [ ] Create recovery runbooks that cover activating an alternate site, the steps to restore and switch over (failover), and health checks for every essential system.
- [ ] Run tabletop exercises and at least one recovery test in a non-production environment to produce evidence that the alternate site can support essential functions.
- [ ] Check and record the key items needed to activate services, including: access details (credentials and where to connect), required connectivity, spare capacity and consumables, and the named people responsible for access.


---

#### CP-7.6 — Inability to Return to Primary Site (Enhancement)

This requirement is about making sure the organisation can continue its work even if it is not possible to return to its main site—for example, after a flood or hurricane damages the building and rebuilding there is not a sensible option. Without this planning, the organisation could be forced to stop work at the worst possible time, lose critical services, and make rushed, inconsistent decisions that increase operational and safety risks.

To meet this expectation, the organisation must:
- set out a clear policy for these situations
- identify the specific circumstances that would prevent returning to the main site
- plan in advance what will happen for each situation

It must also prepare practical, documented procedures for moving work to at least one alternative processing site. This includes:
- details of the alternative site(s)
- any agreements needed with the site owner or provider
- what is required to set up secure operation there

Finally, the organisation must assign named individuals responsible for restoring services and for protecting information during the switch, including deputies or cover arrangements. It must also keep all supporting documents up to date and easy to find.

##### Predefined failover to alternate site when primary return is impossible

- Category: Manual
- Priority: Critical

###### WHAT
Plan and prepare for situations where you cannot return to the main processing site. This includes setting clear triggers, pre-authorising backup processing sites, and creating runbooks that allow the application to be securely rebuilt and that its information protection responsibilities are maintained.

###### WHY (control requirement)
NIST SP 800-53 **CP-7(6)** requires the organisation to **“Plan and prepare for circumstances that preclude returning to the primary processing site.”** Guidance examples include scenarios such as **natural disasters that damage or destroy a facility**, and a decision that **rebuilding in the same location is not sensible**. Without this preparation, the organisation risks a long service outage and making insecure, improvised recovery decisions.

###### HOW (specific steps/approach)
Set up a continuity-of-processing package for the application. Activate it when returning to the main site is impossible or not practical:
1. **Define triggers and decision rules** in the application/business continuity plan (for example: loss of access to the main site, the facility being judged unsafe, infrastructure damage that cannot be repaired, or an engineering/insurance decision that rebuilding is not prudent).
2. **Choose and document at least one alternate processing site** (hot/warm/cold options as appropriate to how critical the workload is), and keep **signed agreements** that clearly allow contingency/continuity use.
3. **Create application-specific alternate-site runbooks** covering: starting the failover, the order to bring services online (presentation/application/data/administration), validating data is correct, switching over DNS/load balancers, expected timeframes, and when to roll back or stop.
4. **Set security expectations for the alternate site in advance**, and ensure they are included in the application’s **system security plan** (for example: logging and monitoring coverage, encryption while data is in transit and at rest, identity-based access, controls for privileged access, and incident response steps during failover).
5. **Name roles and deputies** for (a) rebuilding the system/failover execution and (b) information security during the switch, including cover when main-site staff are not available.
6. **Keep readiness under continuous review** using scheduled tabletop exercises and periodic technical checks (for example: availability of certificates/secrets, backup integrity, replication health, and confirmation that required security controls are active at the alternate site).

###### WHO (role responsible)
- **Business Continuity Manager / DR Lead**: owns the triggers, plan governance, and exercises.
- **Application Owner / Service Owner**: owns the application runbooks and the order of service dependencies.
- **Infrastructure/Cloud Platform Lead**: owns readiness of the alternate-site environment and connectivity.
- **Information Security Lead**: ensures alternate-site security expectations are documented and tested.
- **IAM/Privileged Access Administrator**: ensures break-glass/continuity access is configured and that access is logged and audited.

###### Acceptance criteria
- Triggers for “precluding returning” are documented and approved, with clear decision rules.
- At least one alternate processing site is identified, with current signed contingency/continuity agreements.
- Application runbooks exist for failover to the alternate site, are version-controlled, and include cutover/rollback steps and validation checks.
- Alternate-site security expectations are documented in the application system security plan and can be tested (logging, encryption, access control, and incident response during failover).
- Named roles for system rebuilding and information security (with deputies) are recorded, and tabletop/technical readiness tests have been completed within the last defined review period.

###### Actions Required for Compliance

- [ ] Define and get approval for clear triggers and decision criteria for when it is not possible or not practical to return to the primary site.
- [ ] Choose an alternative processing site or sites and obtain signed agreements that allow contingency and business continuity use.
- [ ] Create application-specific alternate-site failover runbooks, covering the cutover steps, how to validate success, how to roll back if needed, and the expected timeframes for each stage.
- [ ] Update the application system security plan to include what security must be in place at an alternative site, including logging, encryption, access control, and incident response.
- [ ] Assign named responsibilities for failover and reconstitution, and for information security, including named deputies, and document who is covered and when.
- [ ] Run practice “tabletop” exercises and carry out regular checks to confirm that the alternate site is ready to operate and that security controls can be activated.


---

### CP-8 — Telecommunications Services (Control)

This requirement is about making sure your organisation can still communicate by phone and data even if your main communications links fail, so essential work can continue without delay. Without backup telecommunications arrangements and the right agreements in place, a failure at either your main or backup site could prevent teams from coordinating, supporting customers, or carrying out critical duties at any time, potentially causing serious disruption.

To meet this expectation, the organisation must:
- clearly identify which essential functions need continuous 24-hour, 7-days-a-week phone and data communications for command, control, and support; and
- set a target to restore these communications within 24 hours when the primary services are unavailable at either site.

It must also:
- put alternative phone and data telecommunications in place before they are needed;
- cover both outage scenarios in its contingency planning policy and procedures;
- include these arrangements in the contingency plan; and
- keep documented agreements with the relevant providers or internal teams so restoration within 24 hours is possible.

Finally, it must assign named responsibilities across planning, recovery, information protection, and contracting, and keep the supporting records up to date.

##### Alternate voice/data telecoms with 24-hour restoration SLAs

- Category: Manual
- Priority: Critical

###### WHAT
Set up and document backup telecommunications services (voice and data) that allow **system operations for essential mission and business functions** to restart within **24 hours** when the main telecommunications services are not available at either the main or backup (alternate) processing/storage site.

###### WHY (control requirement)
Control CP-8 requires the organisation to **set up backup telecommunications services** and the **necessary agreements** so that **{{ cp-08_odp.01 }}** can be restarted **within {{ cp-08_odp.02 }}** when the main telecommunications services are not available at either the main or backup (alternate) processing/storage site. This must be included in contingency planning and supported by documented agreements.

###### HOW (specific steps/approach)
1. **Define essential telecom-dependent functions**: Create a telecom service catalogue that links “command, control, and support” to the specific voice and data services needed for **24x7** operation (for example: critical call routing/telephony endpoints, virtual private network (VPN) and software-defined wide area network (SD-WAN) connectivity, domain name system (DNS) and directory access, messaging/application programming interface (API) endpoints, and monitoring/telemetry routes).
2. **Identify main and backup site telecom routes**: For each essential function, document the **main** and **backup** connectivity routes between the sites (including carrier/internet service provider (ISP) connections, network-based options, and any satellite/backup options where relevant). Make sure the backup route ends at the backup site.
3. **Arrange backup voice and data services with clear restoration targets**: Put in place **documented agreements** (carrier contracts, managed service agreements, or internal arrangements) that include:
   - availability and service-quality expectations suitable for voice and data,
   - a **restoration time of within 24 hours** for the defined essential services when main telecommunications are not available at either site,
   - escalation contacts and activation procedures.
4. **Build failover/activation into contingency procedures**: Update the contingency plan and operating instructions so that, if main telecommunications fail at either site, the organisation can activate the backup telecommunications services and restore the defined essential functions within the target time.
5. **Assign named responsibilities and evidence ownership**: Assign accountable roles for: (a) ownership of the telecom service catalogue, (b) managing carrier/contracts, (c) carrying out network/telecom failover, and (d) activating the contingency plan and capturing evidence.
6. **Test restoration and record results**: Carry out at least periodic restoration/failover exercises to show the organisation can restore the defined essential voice/data communications within **24 hours**, and keep evidence (test plans, results, confirmations from carriers, and lessons learned).

###### WHO
- **Business/Operations owner**: confirms which functions are “essential mission and business functions” (cp-08_odp.01).
- **Network/Telecom engineering lead**: designs and implements the backup voice/data connections and failover activation.
- **Service/Contract manager (procurement/vendor management)**: negotiates and maintains documented agreements with providers.
- **Business continuity/disaster recovery (BC/DR) lead**: updates the contingency plan and ensures activation steps match the 24-hour target.
- **Information security lead**: ensures telecom failover does not break security requirements (for example, maintaining access and protecting communications).

###### Acceptance criteria
- A documented telecom service catalogue exists that clearly identifies the essential **24x7 voice and data communications for command, control, and support** (cp-08_odp.01).
- Documented agreements/contracts (or internal arrangements) exist for backup voice and data services that state restoration of the defined essential services **within 24 hours** (cp-08_odp.02) when main telecommunications are not available at either site.
- The contingency plan/operating instructions include clear activation steps for backup telecommunications services for both: loss at the main site and loss at the backup site.
- Named roles are assigned for activation, execution, and evidence capture.
- Restoration/failover testing produces evidence that essential voice/data communications can be restored within **24 hours** (or there is an approved, time-limited remediation plan with documented acceptance of risk).

###### Actions Required for Compliance

- [ ] Create a telecom service catalogue that links command, control, and support activities to specific 24/7 voice and data services (cp-08_odp.01).
- [ ] Document the main and backup telecommunications routes to the processing and storage sites for each essential service.
- [ ] Negotiate and sign documented agreements with service providers for backup voice and data services, including restoration within 24 hours (cp-08_odp.02).
- [ ] Update the contingency plan and runbooks to include the steps to activate them in the event of a loss of primary telecommunications at either site.
- [ ] Assign named responsibilities for carrying out telecom failover, managing contracts, activating contingency plans, and capturing evidence
- [ ] Run recovery and failover practice exercises, and keep evidence suitable for audit showing that systems can be restored within 24 hours.


---

#### CP-8.1 — Priority of Service Provisions (Enhancement)

This requirement is about making sure that the phone and data connections your organisation uses for urgent national security emergency work are treated as a priority when problems happen. If there are no clear, agreed priority arrangements in advance, an outage could mean your organisation has to wait longer for services to be restored or for new connections to be put in place, which could delay critical response.

To meet this expectation, your organisation must agree primary and backup telecommunications service contracts in advance. These contracts must set out preferential handling during outages and during service restoration, and they must match your organisation’s own targets for how quickly services must be available again.

Your organisation must also:
- identify which emergency-preparedness telecommunications services it relies on;
- check whether each service is provided by a common carrier; and
- where a common carrier is involved, request Telecommunications Service Priority so the provider gives preferential restoration and setup.

Your organisation should document these arrangements, keep evidence that the priority requests were made, and ensure its recovery plans clearly link to the agreed contracts and responsibilities.

##### Contractual priority-of-service clauses mapped to telecom RTOs

- Category: Manual
- Priority: Critical

###### WHAT
Set up a standard set of contract clauses for **primary** and **alternate telecommunications service providers**. These clauses must require **faster restoration and provisioning during disruptions**, plus **extra line provisioning when needed**. The provider commitments must be **matched to the organisation’s defined availability targets and recovery time objectives (RTOs)**.

###### WHY (control requirement)
CP-8(1) (Enhancement) requires the organisation to make sure that, when telecommunications service providers also support other organisations with similar priority, the organisation’s mission and business impact are reflected in **priority-of-service arrangements**. The guidance notes that **Telecommunications Service Priority (TSP)** is always in place for eligible common-carrier services. However, the organisation must still ensure that its **primary and alternate telecom service arrangements** are written so they match the organisation’s recovery expectations.

###### HOW (specific steps/approach)
1. Create an authoritative **Telecom Resilience Requirements** document. It should define the service classes used for national security emergency preparedness (for example: voice/SIP trunks, leased lines, dedicated internet access, mobile connectivity/APNs) and set the organisation’s **availability targets and RTOs** for each class.
2. Create a **Priority & RTO contract clause pack** to insert into both primary and alternate telecom agreements. The pack must include:
   - A clear **priority-of-service** clause requiring preferential handling for restoration/provisioning during disruptions.
   - A **disruption/restoration trigger** (for example: service outage/restoration events) that activates priority handling.
   - A measurable **restoration/provisioning commitment** (or a direct reference to the organisation’s RTO schedule) so contractual duties can be traced to the defined RTOs.
   - A clause for **faster provisioning of additional lines** where applicable.
   - Named roles/contacts and escalation routes for telecom contingency planning and service recovery.
3. Implement a **contract lifecycle workflow** in the organisation’s contract management system. Add checks that block signing unless:
   - The priority-of-service clause pack is included in both primary and alternate agreements.
   - The RTO/availability mapping is completed and attached.
   - Named responsibilities are recorded.
4. Store signed agreements and the clause pack version used in a controlled repository, with retention and audit support (for example, an immutable audit trail / version-controlled document control).
5. Link the resulting contractual commitments into the organisation’s **telecom contingency plan** and service recovery procedures. This ensures incident responders can quickly find the priority-of-service obligations during disruptions.

###### WHO
- **Head of Procurement / Contract Manager**: owns adoption of the clause pack and enforces the contract workflow.
- **Telecom/Network Resilience Lead (IT/OT)**: owns the Telecom Resilience Requirements (service classes and RTOs) and the RTO mapping.
- **Information Security / Business Continuity Manager**: checks that the commitments are traceable into contingency planning and recovery procedures.

###### Acceptance criteria
- Primary and alternate telecom agreements for relevant emergency-preparedness services include the standardised **priority-of-service** clause pack.
- Each agreement includes an auditable mapping from contractual restoration/provisioning commitments to the organisation’s defined **availability targets and RTOs**.
- Named responsibilities and escalation contacts are recorded in the signed agreements.
- Signed agreements (including clause pack versions) are stored in a controlled, audit-ready repository.
- The telecom contingency plan / service recovery runbooks reference the priority-of-service contractual obligations and escalation routes.

###### Actions Required for Compliance

- [ ] Define service categories and measurable availability targets, including recovery time objectives (RTOs), in a Telecom Resilience Requirements document
- [ ] Create a contract clause pack for priority restoration and recovery time objective (RTO) commitments, including preferential restoration or provisioning and faster provisioning of additional lines.
- [ ] Set up a contract lifecycle workflow that prevents signatures unless the priority clauses and the recovery time objective (RTO) mapping are included for both the primary agreement and the alternate agreement.
- [ ] Sign and execute the primary and alternate telecommunications agreements using the approved clause pack, and record the named escalation responsibilities.
- [ ] Store signed agreements and clause pack versions in a controlled, audit-ready repository, with retention.
- [ ] Update the telecommunications contingency plan and the service recovery runbooks to refer to the contractual priority-of-service obligations and the escalation routes.


---

#### CP-8.2 — Single Points of Failure (Enhancement)

This expectation is about making sure your backup communications are truly separate, so that one outage does not affect both your main service and your fallback. Without this, a single physical issue—such as shared wiring or shared infrastructure—could disable your main internet or phone connections and your backup at the same time, leaving staff unable to operate or recover.

To meet this, the organisation must:
- identify every main communications service it depends on
- arrange a separate alternate service for each one
- document which backup service matches which primary service

It must also write and keep clear procedures for what to do if the primary service fails, who is authorised to switch to the alternate, and how to test and use the alternate during recovery. These details must be included in its contingency planning and system recovery records.

Finally, the organisation must put formal agreements in place and obtain enough information from providers to confirm that the primary and alternate services do not unintentionally use the same physical lines, and keep evidence of these checks.

##### Contract route-diverse alternates with provider physical separation evidence

- Category: Manual
- Priority: Critical

###### WHAT
For each main telecommunications service the application uses (for example: internet access, leased line, multi-protocol label switching / virtual private network (MPLS/VPN), session initiation protocol (SIP) trunk, managed connectivity), buy an alternative telecommunications service that is contractually and technically set up to be route-diverse. This means it must **not** use the same physical transmission lines or the same handover points as the primary service.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 control CP-8(2) enhancement requires the organisation to **obtain alternative telecommunications services** to reduce the chance that the primary and alternative share a **single point of failure**. It also requires **provider transparency** so the organisation can confirm the actual physical transmission capability and that the primary and alternative do not unintentionally use the same physical lines.

###### HOW (specific steps/approach)
1. **Create or update a telecom service inventory** for the application’s communication needs. Record: the service purpose, provider, service identifiers (circuit IDs / contract IDs), endpoints or locations, and which application components use each service.
2. **Set an alternate procurement requirement for each primary service** that ensures physical separation outcomes (for example: a different provider and/or a different underlying physical route, separate handover locations, and an explicit assurance of “no shared physical lines”).
3. **Update contracts and service orders** to include enforceable clauses requiring the provider to disclose physical transmission capability and route diversity. Include specific identifiers (circuit or service IDs, handover points, and diversity or engineering statements).
4. **Collect evidence from the provider** (engineering diagrams, diversity reports, written confirmations, and circuit mapping) showing that the alternative does not share the same physical lines as the primary. Store this in an auditable evidence register.
5. **Record the primary-to-alternate pairing** by service identifier in the application’s contingency planning documents (and any system recovery records used for the application), so staff can clearly identify the correct alternative during recovery.
6. **Carry out a verification exercise** (for example, a tabletop exercise or controlled validation) using the recorded identifiers to confirm the correct alternative can be activated, and that the provider contact route and service identifiers are correct.

###### WHO (role responsible)
- **IT / Infrastructure Service Owner / Network Engineering Lead**: maintains the telecom inventory and defines the alternate requirements.
- **Procurement / Vendor Management**: negotiates and includes enforceable physical separation and transparency clauses.
- **Telecom / Network Operations (NOC) / Service Management**: gathers and checks provider evidence and ensures it can be traced.
- **Business Continuity / Disaster Recovery (DR) Manager**: ensures the primary-to-alternate mapping is reflected in contingency planning documents.

###### Acceptance criteria
- For every identified **primary telecommunications service**, there is a corresponding **alternate** with documented, provider-supplied evidence showing **route and physical separation** (no shared physical lines or handover points).
- Contracts and service orders include enforceable requirements for **provider transparency** and disclosure of physical transmission capability, using specific identifiers.
- The application’s contingency planning documents include an auditable **primary-to-alternate mapping** that references the exact service identifiers (for example: circuit IDs and handover points).
- The evidence register contains provider engineering and diversity confirmations linked to the specific primary and alternate service agreements.
- A verification exercise confirms staff can use the correct identifiers and start using the alternative during recovery (even if automated failover is managed elsewhere).

###### Actions Required for Compliance

- [ ] List every primary telecommunications service the application and the service provider use, and record the service endpoints and the circuit or service identifiers.
- [ ] Set separate “alternate” requirements for each primary connection to ensure route diversity and to keep handover lines and physical lines separate.
- [ ] Update procurement contracts and service orders to include enforceable clauses that require physical separation and require the provider to provide evidence of transparency.
- [ ] Collect and store provider engineering and diversity reports, along with written confirmations, that name the exact circuit or service identifiers.
- [ ] Update contingency planning documents to keep a traceable link between each primary and its alternate, using the same service identifiers.
- [ ] Run a tabletop or validation exercise to confirm that the correct backup option can be identified and used during recovery.


---

#### CP-8.3 — Separation of Primary and Alternate Providers (Enhancement)

This requirement is about making sure your backup phone and internet connections come from genuinely different providers, so that one disaster or mistake does not affect both at the same time. Without this, the same event—such as a natural disaster, building or equipment failure, deliberate attack, or human error—could disrupt both your main service and your fallback service, leaving you unable to communicate when it matters most.

To meet this requirement, the organisation must first use its risk assessment to decide how much separation is enough. It must then clearly identify which telecommunications services are the primary ones and which are the alternate ones. The alternate services must be obtained from providers that are physically and organisationally separate from the primary providers, with minimal shared infrastructure and sufficient geographic separation. The organisation must also record why this separation reduces the same risks.

The organisation must keep its contingency planning documents and procedures up to date. These should include relevant provider contract details, site information, and the named people responsible for switching to the alternate service and coordinating recovery communications.

##### Risk-based dual telecom providers with documented separation

- Category: Manual
- Priority: Critical

###### WHAT
Set up backup telecommunications options (for example, internet access, dedicated circuits, multi-protocol label switching (MPLS), virtual private networks (VPNs), session initiation protocol (SIP) trunking, and mobile backup). Use providers that are separate from the main (primary) providers to reduce the risk that the same problem affects both.

###### WHY (control requirement)
Control CP-8(3) requires getting backup telecommunications services from providers that are separate from the primary providers, so you are less likely to be affected by the same threats. The guidance also expects this separation to be defined in the organisation’s risk assessment, including enough geographic separation and reduced shared infrastructure.

###### HOW (specific steps/approach)
1. **Set separation requirements using the risk assessment**: For each relevant site and type of telecommunications service, use the telecommunications risk assessment to define clear, measurable separation rules (for example, different carrier legal entities, different points of presence (POPs) or exchange locations, different physical routes where known, different disaster zones, and explicit limits on shared infrastructure).
2. **Match primary and alternate services to each workload**: For each business-critical application connection path (for example, user access, application programming interface (API) connectivity, admin access, monitoring/telemetry data leaving the network, and security information and event management (SIEM) forwarding), identify the primary telecommunications service and the alternate telecommunications service, including which circuits or links are used for failover.
3. **Choose alternate providers that meet the separation rules**: Buy alternate services from providers that are organisationally and physically separate from the primary providers. Make sure contracts and service designs reduce shared infrastructure, or clearly document and address any unavoidable shared parts.
4. **Record provider and site details, and explain the separation**: Keep an auditable record that links each primary and alternate provider agreement to the relevant site and point of presence (POP) identifiers, circuit identifiers, and the risk-assessment explanation of how the separation reduces exposure to the same threats.
5. **Build separation into contingency (backup) procedures**: Update the organisation’s telecommunications and information technology (IT) continuity procedures to include clear triggers for switching to alternate services, named responsible roles, escalation and network operations centre (NOC) contacts, and step-by-step instructions to restore communications using the alternate telecommunications path.
6. **Check operational readiness**: Run periodic failover tests (for example, table-top exercises and/or controlled switching) to confirm that alternate telecommunications services can be used without changes that would remove the separation (for example, ensure admin and identity connections and monitoring data leaving the network still work via the alternate path).

###### WHO (role responsible)
- **Telecom/Network Engineering Lead**: responsible for the technical design, input to provider selection, and failover testing.
- **Information Security / Risk Owner**: ensures separation rules come from the telecommunications risk assessment and that evidence is ready for audit.
- **Procurement/Vendor Management**: ensures contracts include clauses that support separation and independence expectations.
- **Business Continuity Manager**: ensures contingency procedures, triggers, and tests are kept up to date.

###### Acceptance criteria
- For each in-scope site and in-scope telecommunications service, there is a documented **primary** and **alternate** provider/service mapping.
- The alternate provider choice can be traced to the **telecommunications risk assessment** and meets the defined separation rules (including organisational/physical separation and sufficient geographic separation).
- Contract and service documentation, plus an auditable record, shows **minimised shared infrastructure** (or documented, risk-assessed mitigations).
- Contingency procedures include **triggers, named roles, and provider/site contact details** sufficient to switch to alternate telecommunications services.
- At least one documented failover readiness activity (table-top exercise or controlled test) shows that alternate telecommunications services can restore communications within the organisation’s continuity expectations.

###### Actions Required for Compliance

- [ ] Carry out a telecoms-specific risk assessment for each site and each type of telecoms service, and set clear, measurable rules to separate the primary provider from the alternate provider.
- [ ] Create and keep an up-to-date register of the main and backup (alternate) telecom services for each business-critical application connection path.
- [ ] Procure alternative telecommunications services from providers that meet the organisation’s separation requirements for organisational, physical, and geographic independence, and record this evidence in contracts and service orders.
- [ ] Document the provider, site, point of presence (POP), and circuit details, and include the risk-assessment reasoning showing that the service is less vulnerable to common threats.
- [ ] Update the contingency plan to include clear failover triggers, named responsible roles, and step-by-step instructions for switching over to backup telecommunications routes.
- [ ] Carry out regular failover readiness tests (for example, tabletop exercises and/or controlled switching) and keep the results as audit evidence.


---

#### CP-8.4 — Provider Contingency Plan (Enhancement)

This requirement is about making sure your phone and internet providers have a clear, tested plan for keeping services running, or restoring them quickly, when major disruptions happen. Without this, a widespread outage, natural disaster, or other serious problem could leave your organisation unable to communicate, carry out work, or recover in time—causing real operational and financial harm.

To meet this expectation, the organisation must require that both its main telecommunications provider and its backup provider have documented contingency plans, and it must review those plans to confirm they meet the organisation’s recovery needs. The organisation must also get evidence at least once every year that each provider has tested its contingency plan and trained the people responsible for carrying it out. The organisation must keep records of the plan reviews and the annual evidence, and ensure these expectations are included in the provider agreements or equivalent contracts.

##### Annual review and evidence pack for telecom provider contingency plans

- Category: Manual
- Priority: Critical

###### WHAT
Put in place a contractual and operational approach to: (1) require both the main (primary) and backup (alternate) telecommunications providers to keep documented contingency plans, (2) allow the organisation to check those plans against the organisation’s contingency requirements, and (3) collect and keep proof at least once a year that each provider has tested its contingency plan and trained the relevant staff.

###### WHY (control requirement)
The CP-8(4) enhancement guidance expects the organisation to review provider contingency plans, while recognising that providers may treat parts of their plans as proprietary. It also allows summary proof in some cases. It further expects the organisation to obtain proof at least annually that providers have **tested** their contingency plans and **trained** relevant personnel, and to use provider agreements (or other legally binding arrangements) and keep records of the reviews and proof.

###### HOW (specific steps/approach)
1. **Define the organisation’s telecommunications contingency requirements** (for example: restoration objectives, expectations for escalation and notification, restoration approach, and communication channels) in a single standard owned by the business continuity management (BCM) / disaster recovery (DR) function, so reviewers can apply it consistently.
2. **Create a provider “contingency evidence pack” template** that supports summary review (to reflect proprietary constraints) and includes minimum information: plan summary, roles/escalation matrix, overview of the restoration process, date of the last test and a short excerpt from the test summary, date of the last training and a short excerpt from the training roster or a training attestation, and a statement of material changes.
3. **Update contracts for both primary and alternate telecommunications providers** to require: keeping a documented contingency plan; providing the evidence pack **at least annually**; notifying the organisation of material changes; and allowing limited review of relevant plan sections under a non-disclosure agreement (NDA) (or providing structured summaries where full disclosure is not practical).
4. **Set up an annual review process** within the organisation’s governance, risk and compliance (GRC) / BCM process: receive provider evidence packs, carry out a structured checklist review against the organisation’s telecommunications contingency requirements, record the review result, and follow up on any gaps.
5. **Use evidence “acceptance gates”**: do not close the annual review unless both testing proof and training proof are present and dated within the required yearly timing; require corrective action plans when evidence is missing or not sufficient.
6. **Keep audit-ready records** that link each provider agreement to: the annual plan review record, the submitted evidence pack, and any follow-up correspondence. Keep these records for the period required by the organisation’s audit and legal requirements.
7. **Optionally use coordinated tests**: where feasible, ask to take part in disaster recovery exercises coordinated with the Department of Homeland Security (DHS) and relevant state/local government bodies, and record participation proof as part of the annual testing and training evidence.

###### WHO
- **BCM/DR Manager**: owns the telecommunications contingency requirements standard and the annual review process.
- **Procurement/Legal Counsel**: adds the required contractual clauses into the primary and alternate provider agreements.
- **GRC/Compliance Lead**: manages the evidence pack intake process, the review acceptance gates, and the audit trail.
- **Telecommunications/Infrastructure Owner (information technology (IT)/operational technology (OT) network team)**: supports the checklist review and confirms the restoration and escalation expectations.

###### Acceptance criteria
- Contracts for both primary and alternate telecommunications providers include obligations to provide an annual contingency evidence pack and to maintain documented contingency plans.
- At least once a year, the organisation receives evidence packs that include **dated testing proof** and **dated training proof** for each provider.
- The organisation completes and records an annual review of each provider’s contingency plan (or structured summary) against the organisation’s telecommunications contingency requirements.
- Evidence packs and review records are stored in a controlled repository, with traceable links to provider agreements and review outcomes.
- Any missing or insufficient evidence triggers documented follow-up, and the matter is closed only after remediation or an approved risk acceptance process.

###### Actions Required for Compliance

- [ ] Define the organisation’s telecommunications business continuity and disaster recovery (BCM/DR) contingency requirements, including restoration objectives, escalation and notification expectations, the restoration approach, and the communications channels.
- [ ] Create a template for a provider contingency evidence pack that supports quick summary reviews, and that includes fields for the most recent test or exercise and the most recent training evidence.
- [ ] Update the agreements with the main and backup telecommunications providers to require: documented contingency plans, and an annual submission of the evidence pack (at least once per year), with notification of any material changes.
- [ ] Set up an annual governance, risk and compliance (GRC) and business continuity management (BCM) process to collect evidence packs, carry out a structured checklist review, and record the results of each review.
- [ ] Set up “evidence acceptance” checkpoints so the annual review cannot be completed unless, for every provider, there is dated testing evidence and dated training evidence.
- [ ] Store evidence packs and annual review records in a controlled system, with clear, traceable links to the provider agreements and any follow-up actions.


---

#### CP-8.5 — Alternate Telecommunication Service Testing (Enhancement)

This requirement is about making sure your backup phone system and communication routes are genuinely ready to use, not just recorded on paper. If your main service fails, you may be unable to contact customers, staff, or emergency services, and important business activities could be disrupted. Testing only occasionally, or without the right arrangements with your service providers, increases the risk that the backup will not work when you need it most.

The organisation must test its alternative telecommunications services at least once every quarter, using the arrangements agreed in its contracts with the service providers. The tests must be carried out in a way that does not disrupt mission-critical operations. The organisation must also:

- have written procedures for how the tests are carried out  
- include the alternative services in its contingency planning  
- clearly assign responsibility for the tests  
- involve the relevant service providers and the appropriate internal security-responsible staff, where required  
- keep clear records showing the quarterly tests were completed and recording the results

##### Quarterly alternate telecom testing with provider sign-off

- Category: Manual
- Priority: Critical

###### WHAT
Set up and carry out a **quarterly** test programme for **alternative telecommunications services**, using **contractually agreed arrangements with providers**, and record the results to show that testing **does not harm mission-critical operations**.

###### WHY (control requirement)
NIST Special Publication 800-53 **Control CP-8(5)** requires: **“Test alternate telecommunications services {{ insert: param, cp-08.05_odp }}.”** The organisation-defined parameter **cp-08.05_odp (frequency)** sets the **frequency** for testing alternative telecommunications services. The guidance also requires testing to be arranged through **contractual agreements**, and allows testing to take place **at the same time as normal operations** to help ensure there is **no impact on organisational missions/functions**.

###### HOW (specific steps/approach)
1. **Make quarterly testing part of contracts**: Update or renew provider agreements to include (a) quarterly test time windows, (b) provider responsibilities and escalation contacts, (c) required proof documents (for example, a signed test report, confirmation email, and test logs), and (d) clear expectations that there will be **no service impact**, including rollback and mitigation actions.
2. **Create a standard test pack (procedure)** aligned to the organisation’s business continuity planning approach: include the test scope, pre-checks, step-by-step test execution, verification criteria, rollback/stop criteria, and an evidence checklist.
3. **Define how “no service impact” will be checked**: set measurable checks to be carried out before/during/after the test (for example, routing and service health checks, application connectivity checks, call/Session Initiation Protocol (SIP) trunk success checks, latency and packet-loss thresholds, and confirmation that critical business functions are unaffected).
4. **Run tests alongside normal operations** using pre-approved time windows: do non-disruptive checks first, then carry out the agreed alternative-path test actions only within the contract-approved window.
5. **Keep evidence in business continuity records**: store the test pack reference, quarter/date, which alternative service(s) were tested, provider sign-off, execution logs, verification results, and a clear statement that **no service impact** occurred (or record any deviations and the corrective actions taken).
6. **Assign responsibility and involve security**: appoint an owner for the quarterly programme (for example, the Business Continuity/Disaster Recovery (DR) Manager) and require information security review/attestation that test traffic and access routes follow the required security controls.

###### WHO (role responsible)
- **Business Continuity/Disaster Recovery (DR) Manager** (programme owner; ensures quarterly timing and complete evidence)
- **Service Provider/Telecom Vendor Manager** (ensures contractual testing obligations and provider participation)
- **Information Security Lead** (confirms that testing does not breach security requirements)
- **Network/Telecom Operations Lead** (carries out the test steps and rollback)

###### Acceptance criteria
- Alternative telecommunications services are tested **at least quarterly** (per **cp-08.05_odp frequency = Quarterly**).
- Each test is carried out under **contractually agreed provider arrangements** (test time windows, responsibilities, and evidence documents).
- Evidence for each quarter is kept in **business continuity records** and includes: scope, date/quarter, provider sign-off, execution results, and a clear **no service impact** confirmation (or documented corrective actions).
- Tests are carried out in a way that demonstrates **no impact on organisational missions/functions** during the test window.

###### Actions Required for Compliance

- [ ] Update service provider contracts to include quarterly alternate telecommunications test time windows, each party’s responsibilities, escalation contact details, and the required proof documents (evidence artefacts).
- [ ] Create a standard alternative telecommunications testing procedure (test pack) that includes clear start and stop conditions, rollback steps if needed, and an evidence checklist.
- [ ] Define measurable checks to confirm there is **no performance degradation** before, during, and after each quarterly test.
- [ ] Schedule and carry out the quarterly tests during pre-approved time windows, with the provider involved and support from the internal telecommunications operations team.
- [ ] For each quarter, collect and store the provider’s sign-off, the execution logs, and the verification results in the contingency planning records repository.
- [ ] Get an information security assurance that the testing activities and access routes meet the required security standards.


---

### CP-9 — System Backup (Control)

This requirement is about making sure your organisation can reliably restore important information after something goes wrong. It requires regular backups and strong protection of those backups.  

Without daily backups of users’ home files, user databases, and user settings—and daily backups of the system itself (including its current configuration, software components, and licences)—you could lose critical work or be unable to recover after accidental deletion, corruption, ransomware, or a system failure.  

Weekly backups of system documentation, including documents related to security and privacy, also help you rebuild the correct way of working and meet legal or regulatory duties.  

To meet this expectation, the organisation must: carry out backups on the stated schedule; keep written procedures and contingency plans that explain how backups are done and how they support recovery; record backup activity; identify where backups are stored; and assign named responsibilities.  

Backups must be protected so they remain confidential, cannot be changed without detection, and are available for restoration when needed.

##### CP-9 Backup schedule with signed integrity and immutable storage

- Category: Software
- Priority: Critical

###### WHAT must be done
Set up and run scheduled backups that cover (1) **user-level information** (user home folders, user databases, and user settings) **every day**, (2) **system-level information** (system status, operating system software, middleware, application software, and licences) **every day**, and (3) **system documentation** **every week**. Backups must be protected to maintain **confidentiality** and **integrity** (using **cryptographic hashes and/or digital signatures**) and must stay **available for restoring**.

###### WHY (control requirement)
CP-9 requires the organisation to back up systems in line with its contingency planning and backup requirements, including the agreed backup coverage and how often backups run. It also requires mechanisms to protect backup integrity (for example, **digital signatures and cryptographic hashes**). It further requires protection of backup information and alignment with contingency plans.

###### HOW (specific steps/approach)
1. **Define backup coverage and schedules** in an official backup inventory: link each live (production) system to the required backup categories (user home folders, user databases, user settings; system status/operating system/middleware/application software/licences; system documentation). Use the organisation’s agreed frequencies: **daily** for user-level and system-level backups, **weekly** for system documentation.
2. **Add integrity protection to backups**: for each backup job, create a cryptographic **hash** (and/or a signed backup record) that covers the backup contents and related details. Set up the restore process to **check** the hash/signature before any data is accepted for restoration.
3. **Protect backups for confidentiality and tamper resistance**: encrypt backups **while stored** and limit access to the backup storage to dedicated backup service identities and **authorised** restore staff. Store backups in an **immutable/tamper-evident** storage area (for example, object lock/WORM/retention-locked storage) to reduce the risk of ransomware and unauthorised changes.
4. **Align with contingency planning**: ensure backup retention and restore procedures support the contingency plan recovery targets (recovery time objective (RTO) / recovery point objective (RPO)). Make sure backup instructions (runbooks) point to the contingency plan restore steps and escalation routes.
5. **Keep records of backup activity and evidence**: retain backup job logs/records showing what was backed up, start/end times, whether it succeeded or failed, integrity check results, and identifiers for where backups are stored. Share logs with the organisation’s monitoring and audit tools where available.
6. **Demonstrate restore capability**: carry out and document regular restore tests (at least in line with the organisation’s contingency/business continuity plan (BCP) testing schedule) showing successful restoration from the same backup sets where integrity checks are performed.

###### WHO (role responsible)
- **Backup Operations Lead**: responsible for backup coverage, schedules, runbooks, and collecting evidence.
- **System/Platform Owners**: confirm the system inventory mapping and that system documentation sets are included.
- **Security/Compliance**: checks that integrity mechanisms (hash/signature) are configured correctly, access is restricted appropriately, and evidence is sufficient.

###### Acceptance criteria
- Daily backups complete successfully for **user home folders**, **user databases**, and **user settings** for all in-scope systems.
- Daily backups complete successfully for **system-level information** (system status, operating system software, middleware, application software, licences) for all in-scope systems.
- Weekly backups complete successfully for **system documentation** for all in-scope systems.
- Each backup set has an associated **cryptographic hash and/or signed record**, and restore processes **verify** integrity before restoring.
- Backups are stored with **confidentiality protections** (encryption + restricted access) and **tamper resistance** (immutable/tamper-evident storage).
- Backup job logs/records and integrity check results are kept and can be retrieved for audit.
- Restore tests produce documented evidence that restored data matches the expected integrity check outcomes and supports the contingency plan recovery steps.

###### Actions Required for Compliance

- [ ] Create and keep up to date an official backup inventory that links each in-scope system to the correct backup categories for (1) users, (2) the system itself, and (3) documentation.
- [ ] Set up the backup process to run **daily** backups for user data and **daily** backups for system data, and to run **weekly** backups of system documentation according to the agreed schedules.
- [ ] Use cryptographic integrity protection for every backup set by using hashes and/or signed manifest files, and require integrity checks when restoring data.
- [ ] Encrypt backup data while it is stored (“at rest”) and limit access to the backup repository to dedicated backup service accounts and authorised restore operators.
- [ ] Store backup copies in an unchangeable, tamper-evident storage location, with retention periods set to match organisational requirements.
- [ ] Export and keep backup job records and logs, including the job scope identifiers, whether each job succeeded or failed, and the results of integrity checks, so the activity can be audited.
- [ ] Run documented restore tests and keep evidence showing that the restored data passes the same data-integrity checks.


---

#### CP-9.1 — Testing for Reliability and Integrity (Enhancement)

This requirement is about proving that your backup copies can be used and are still correct when you need them. Without regular checks, you may only find out after an incident that the backup storage has failed, the usual recovery steps no longer work, or the restored files are incomplete or damaged—so you cannot restore critical information.

To meet this expectation, the organisation must, every quarter, choose a small random sample of backup items and try restoring them using the normal recovery process from the backup storage location (including any alternate backup site if one is used). After each restore, it must confirm that the recovered information is complete and matches the original expected content exactly.

The organisation must record the results so an independent reviewer can see what was tested, who carried it out, when it was done, what succeeded or failed, and what actions were taken to fix any problems. These records must be kept available for review.

##### Quarterly restore-and-compare tests for backup reliability/integrity

- Category: Software
- Priority: Critical

###### WHAT
Run a quarterly process that **checks backup information** by **restoring a randomly selected sample** from the **backup storage location** (and the alternate/backup site where used). Use the **normal recovery process**. Then **confirm the restored information is correct** by comparing it to the expected/known-good content.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Special Publication 800-53 **CP-9(1)** enhancement requires: **“Test backup information {{ insert: param, cp-9.1_prm_1 }} to verify media reliability and information integrity.”** The guidance also requires confidence that backups can be **retrieved reliably** (reliability includes the storage systems/components and the retrieval steps) and that **information integrity is maintained** (for example, by decrypting/restoring a random sample and comparing the restored content to the original/expected content).

###### HOW (specific steps/approach)
1. **Set the quarterly test scope and sampling** (aligned to the organisation-defined parameter **cp-9.1_prm_1 = Quarterly**):
   - Choose a **random sample** of backup items (for example, representative files/objects, or a representative backup set) using selection criteria that can be repeated.
   - Record the exact backup identifiers (backup ID, timestamp, storage tier, and whether the item is on the primary site or the alternate site).
2. **Restore using the normal recovery process**:
   - Restore each sampled item using the organisation’s standard backup recovery procedure (including the same encryption/decryption approach and the same restore tools).
   - If an alternate backup site is used, make sure at least some of the sampled restores are done from that alternate location (or clearly document why alternate-site sampling is not applicable).
3. **Check integrity after the restore**:
   - For file/object backups: calculate and compare cryptographic hashes (for example, **SHA-256**) of the restored content against the expected/known-good reference captured when the backup was taken.
   - For database/application backups: confirm integrity using checks appropriate to the application (for example, export/import validation, schema/version checks, and consistency checks) and compare against expected outputs.
   - Mark the test as failed if the restore works but the integrity check does not match.
4. **Create audit-ready evidence for each quarterly run**:
   - Keep a test record (manifest) listing the sampled backup identifiers and locations.
   - Record the restore start and end time, the restore result, any error details (if applicable), and the integrity comparison results (including the values compared or the verification outputs).
   - Record who carried out and/or approved the test (or the identity of the automation job) and when it was run.
5. **Set when to fix issues and what to re-test**:
   - If any sampled item fails to restore or fails the integrity check, start remediation (for example, investigate the backup job, storage health, encryption/key issues, or corruption) and run a follow-up restore-and-compare for the affected items.
   - Record the remediation results in the same evidence set.

###### WHO (role responsible)
- **Backup Operations Lead / Platform Engineer**: runs the restore-and-compare process (or oversees automation) and ensures the normal recovery process is used.
- **Information Security / Compliance Reviewer**: reviews the quarterly evidence for completeness and accuracy.
- **Application Owner (where integrity checking is specific to the application)**: confirms the integrity checks and expected/known-good references are appropriate.

###### Acceptance criteria
- Quarterly (per **cp-9.1_prm_1**) restore-and-compare tests are completed.
- For each quarterly run, a random sample of backup items is restored using the normal recovery process from the backup storage location.
- Restores include alternate-site retrieval where alternate sites are used (or a documented justification if not applicable).
- For every sampled item, the integrity check confirms the restored content matches the expected/known-good reference; no item is marked complete unless both the restore succeeds and the integrity matches.
- Evidence is kept and is sufficient for an independent reviewer to confirm: what was tested (backup IDs), when (date/time), where (primary/alternate), who/what carried it out, the restore results, the integrity results, and any remediation actions taken for failures.

###### Actions Required for Compliance

- [ ] Create a quarterly test plan template that sets the random selection rules and lists the required information for each test (backup ID, date and time, where the backup is stored, and whether it is the primary or an alternative copy).
- [ ] Set up an automated process that restores selected backup copies and then compares the restored data against the expected results, using the organisation’s usual recovery process (including handling encryption and decryption).
- [ ] Set up integrity checks for every type of backup: use cryptographic hash comparisons for file and object backups, and use the right consistency and validation checks for database and application backups.
- [ ] Store permanent, tamper-evident evidence for each run that is ready for audit (restore logs, integrity-check results, selected backup identifiers, the identity that ran the process, timestamps, and outcomes).
- [ ] Set up failure handling so that any restore problem or any mismatch in data integrity triggers an investigation and a follow-up restore-and-compare for the affected items.
- [ ] Set up an independent review at the end of every quarter to check that all evidence is complete and accurate before the CP-9(1) test cycle is closed.


---

#### CP-9.2 — Test Restoration Using Sampling (Enhancement)

This requirement is about showing that, if a disaster happens, the organisation can restore its most important services using a realistic selection of its stored backup data—not just assumptions. Otherwise, the business might only find out later that backups are incomplete, out of date, or unusable, which could cause critical functions such as email, file access, or customer systems to fail when they are needed most.

To meet this expectation, the organisation must:
- decide which specific functions will be tested
- choose a representative sample of backup information for those functions
- restore only the selected functions using that sample
- check that each restored function works as intended

The organisation must also record what was restored, which backup sample was used, what checks were carried out, and the results for each function. The evidence must be kept so it can be reviewed later, and it must demonstrate that the sample used was sufficient for the required level of confidence.

##### Sample-based restore runbooks with auditable evidence capture

- Category: Software
- Priority: Critical

###### WHAT
During contingency plan testing, restore only a defined **sample of backup information** for **selected system functions**. Then check that those functions work as intended and keep clear, auditable evidence showing what was sampled and what the results were.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 **CP-9(2)** enhancement requires: **"Use a sample of backup information in the restoration of selected system functions as part of contingency plan testing."** The guidance also expects confidence that the selected functions are fully tested by restoring a **sample of backup information**. Organisations should be able to decide the **sample size and selection** based on how much assurance is needed.

###### HOW (specific steps/approach)
Set up a repeatable, automated “sample-restore” capability for the application’s contingency testing that:
1. **Defines the selected system functions** to be tested (for example: authentication/login flow, core application programming interface (API) endpoints, database read/write smoke tests, message consumption/production, file/object retrieval, key scheduled jobs).
2. **Chooses a representative backup sample** for each function using a clear, auditable sampling method (for example: the most recent restore point plus one older restore point to cover format changes; sampling by backup type; or sampling by date/time windows aligned to change frequency). The sampling method must be written into the process so the same logic can be repeated and reviewed.
3. **Restores only the sampled backup information** into the **separate contingency test environment** (not production; use dedicated test credentials and network separation). Runbooks must be set up to accept only sampled backup identifiers (for example: snapshot IDs, backup set IDs, object storage prefixes, virtual machine (VM) image tags) and must include safeguards to prevent “restore everything”.
4. **Checks that the restored functions work as intended**, using automated checks where possible (for example: synthetic transactions, API checks, database connection and query smoke tests, message queue/topic checks, application health checks). For any behaviour that cannot be fully automated, include documented manual verification steps.
5. **Records and keeps evidence** that links together: (a) which functions were tested, (b) which backup sample identifiers were used, (c) restoration start/end times and supporting materials, (d) which verification checks were run and their results (pass/fail), and (e) the sampling rationale and method.
6. **Protects the integrity of the evidence** by storing logs and test summaries in an append-only location and by signing and permanently retaining the final test report.

###### WHO
- **Application Owner / Business Continuity Manager**: approves the list of selected system functions and the assurance level that determines the sample size.
- **Platform/Infrastructure Engineer (Backup and Disaster Recovery (DR))**: builds the restore runbooks and integrates the sampling logic with the backup tools.
- **Security/Compliance Lead**: reviews the sampling method, completeness of the evidence, and controls that prevent changes.
- **Operations/DR Test Lead**: runs the contingency test using the runbooks and confirms the verification results.

###### Acceptance criteria
- For each contingency plan test run, the test report clearly shows **(1)** the selected system functions, **(2)** the **backup sample identifiers** used for restoration, and **(3)** that restoration was performed **only** using that sample.
- Verification results are recorded for each selected function, with clear pass/fail outcomes and references to the evidence (logs/outputs/artefacts).
- The sampling method is documented and can be repeated; evidence shows that the sample size and selection match the defined assurance level.
- Evidence is kept in an auditable, tamper-evident way (append-only/immutable storage and a signed final report artefact).

###### Actions Required for Compliance

- [ ] Create a contingency test catalogue that links each application system function to its recovery target and the checks used to confirm it has been restored.
- [ ] For each function, choose and document a sampling method (including the sample size and how samples are selected) that matches the required level of assurance.
- [ ] Create parameterised “sample-restore” runbooks that only accept sampled backup identifiers, and add safeguards to prevent full restores.
- [ ] Automate the restoration process in a separate, isolated contingency testing environment, using dedicated test login details and network separation.
- [ ] Set up automated checks for every restored function (synthetic transactions, application programming interface (API) checks, service health checks, and database/message “smoke tests”), and document any manual steps that are still required.
- [ ] Produce an auditable test report that records: the functions tested, the backup sample identifiers used, how long restoration took, the checks used to confirm results, and the pass or fail outcome.
- [ ] Store the evidence from backups, restores, and checks in write-once, unchangeable storage, and sign the final test report file to confirm it has not been altered.


---

#### CP-9.3 — Separate Storage for Critical Information (Enhancement)

This requirement is about keeping the most important backup copies in a safe, separate location, so they are not lost if the main system is damaged. Without this separation, events such as fire, flood, theft, or a serious technical failure could destroy both the live equipment and the backups needed to restore it. This could prevent the organisation from recovering quickly and may expose sensitive security information.

The organisation must identify which backup contents are critical. This includes the software that runs key systems, security-related settings and tools, and inventories of important system components. It must then store these critical backups either in a different facility or in a fire-rated container, and in both cases ensure they are not kept in the same place as the operational system.

The organisation must document where the backups are stored and how they are configured. It must keep records showing that backups were completed and where they were stored. It must also include this separation approach in its contingency planning and system security documentation, with clear responsibility assigned to the relevant staff.

##### Store critical backup copies in non-collocated alternate facility

- Category: Software
- Priority: Critical

###### WHAT
Set up a backup destination plan that stores backup copies of **critical system software and other security-related information** (for example: operating systems, middleware, cryptographic key management systems, intrusion detection systems, and security-related records of system hardware/software/firmware) in a **separate location** or in a **fire-rated container** that is **not kept alongside** the live (operational) system.

###### WHY (control requirement)
CP-9(3) requires that backups of critical information are stored in a way that prevents losing both the live system and the backups during events such as fire, flood, theft, or a compromise of the site. This update specifically requires **not storing backups in the same place** as the operational system, and it applies to all critical information regardless of the backup type.

###### HOW (specific approach)
1. **Define what counts as critical backups**: create and maintain a “critical backup manifest” that lists each in-scope system and the backup categories that qualify as **critical system software and other security-related information** (operating systems, middleware, cryptographic key management systems, intrusion detection systems, and security-related inventories).
2. **Choose approved separate storage**: set up one or more backup repositories in an **alternative location** (for example, a second data centre or a different cloud region). If the organisation uses containers, use **fire-rated containers** that are physically separate from the operational environment.
3. **Apply non-collocation rules for each backup job**: configure the enterprise backup and orchestration platform so that backup jobs covering the critical scope write **only** to the approved separate destination(s). Stop any fallback to local or primary storage for these jobs (for example, use repository allow-listing and deny rules for local targets).
4. **Strengthen the separate repository**: apply protection measures suitable for the platform (for example, “cannot be changed” or “only add new data” retention where available, restricted administrative access, and encryption while data is moving and when stored) to reduce the risk of tampering and unauthorised deletion.
5. **Automate checks and keep proof**: for every critical backup run, automatically record evidence including the run identifier, the source system, a summary of the backup scope, and the **destination identifier/location**. Store these evidence records in a tamper-evident log system.
6. **Update contingency and security documents**: document the separate storage approach in contingency planning and system security documentation, including which critical systems map to the approved separate facility/container.

###### WHO
- **Backup/Infrastructure Engineering Lead**: implements the backup destination enforcement and strengthens the repository protections.
- **Information Security Officer / Compliance Lead**: checks that the critical backup manifest and the non-collocation design meet CP-9(3).
- **System Owners**: approve the critical backup manifest scope for their systems.

###### Acceptance criteria
- For every system listed in the critical backup manifest, backup runs covering the critical scope store data in an approved **non-collocated** repository (alternative facility or fire-rated container) and do not store it in the operational system’s same-site (collocated) storage.
- For at least one recent backup cycle per critical system, evidence exists showing: (a) the backup scope includes the required critical categories, and (b) the destination/location identifier matches the approved separate storage.
- Contingency planning and system security documentation clearly record the separate storage destination(s) and responsibilities.
- Backup job configuration includes technical controls (allow-list/deny rules) that prevent critical backups from being stored in primary/same-site repositories.

###### Actions Required for Compliance

- [ ] Create and get approval for a critical backup record (manifest) for every in-scope system. This must cover the operating system, middleware, cryptographic key management, intrusion detection system (IDS), and security-related inventories.
- [ ] Choose and record the approved backup locations that are not in the same building (either an alternate facility or a fire-rated container), including the physical location identifiers.
- [ ] Set up backup orchestration so that only the approved separate destination(s) are allowed for critical backup jobs, and block any write access to the on-site or primary repositories.
- [ ] Set up repository protections that fit the platform (for example, where available, make records immutable and append-only) and limit administrative access to the separate repository.
- [ ] Set up automated checks for every backup run to confirm the backup destination and included data match the approved “critical backup” list, and create tamper-evident proof records for each run.
- [ ] Update the contingency planning and system security documents to refer to the separate storage approach, the data mappings, and the responsible roles.


---

#### CP-9.5 — Transfer to Alternate Storage Site (Enhancement)

This requirement ensures your backup information can be sent to an off-site location quickly and in a way you can measure. This lets you recover if your main systems are damaged or unavailable. Without it, backups may arrive too late, not arrive at all, or be sent to the wrong place—meaning you may not be able to restore critical services when you need them most.

The organisation must send backup information to an agreed alternate storage site either by secure electronic transfer or by shipping storage media. The transfer must be completed within 4 hours, and data must be moved at a rate of at least 200 GB per hour.

Staff responsible for backups and staff responsible for information security must follow documented procedures. The off-site backup transfer must also be included in the organisation’s contingency planning, with clear responsibilities and defined steps.

The organisation must keep evidence and records showing the transfer took place. This includes the destination used, the start and end times, and the amount of data moved. The organisation must also have written agreements confirming that the alternate site can receive the backups.

##### Automated off-site backup transfer with 4h/200GBh SLO evidence

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated process to send system backup information to an approved alternate storage location. The transfer must finish within the organisation-defined **time period** and maintain a minimum **transfer rate**.

###### WHY (control requirement)
NIST SP 800-53 **CP-9(5)** (enhancement) requires: “Transfer system backup information to the alternate storage site {{ insert: param, cp-9.5_prm_1 }}.” The organisation-defined parameter is **within 4 hours** and **at least 200 GB per hour**.

###### HOW (specific steps/approach)
1. **Approve alternate storage locations**: Set up an approved list of the alternate site details (for example, endpoint/bucket/vault identifier). Confirm there is a signed and approved agreement that the site can receive backups.
2. **Automate the electronic transfer**: Configure the organisation’s backup system (or backup service) to copy and send backup sets electronically to the approved alternate site using approved methods (for example, HTTPS/SFTP/vendor replication). Make sure the transfer runs as part of the normal backup schedule and during disaster recovery (DR) or incident response activities.
3. **Set clear, measurable targets (service-level objectives)**: For every transfer, record: destination identifier, start time, end time, total data sent (GB), and the calculated speed (GB per hour). Set up alerts and controls so transfers that miss the targets (time taken over 4 hours, or speed under 200 GB per hour) are flagged and corrected (for example, retry with adjusted settings, or switch to a secondary approved alternate site if one is available).
4. **Keep transfers secure and reliable**: Use encryption while data is being sent (for example, TLS) and encryption when stored at the destination. Limit who can change backup destination settings using least privilege and change control.
5. **Keep evidence suitable for audit**: Store tamper-resistant records for each transfer, including the destination used, start/end times, dataset size, and the calculated transfer speed. Keep these records for audit purposes and also create a summary record that can be used as evidence for the contingency plan.
6. **Include this in contingency planning**: Update the system’s contingency and DR procedures so off-site transfer is clearly covered, including roles, when it should start, how it should be prioritised, and what to do if the targets cannot be met.

###### WHO
- **Backup/DR Engineer**: Sets up and fine-tunes the automated transfer, target measurement, and job reporting.
- **Information Security Officer / Security Architect**: Approves the alternate site, evidence requirements, and the safeguards.
- **System Owner / Service Owner**: Ensures the system security plan and contingency procedures reference the transfer process and responsibilities.

###### Acceptance criteria
- For each backup transfer event, there is evidence showing: (a) the destination is the approved alternate site, (b) the transfer completed **within 4 hours**, and (c) the sustained transfer rate is **≥ 200 GB/hour**, based on the recorded GB and elapsed time.
- Transfer jobs produce audit-ready records that include destination, start/end times, data volume, and calculated transfer speed, and these records are kept for review.
- If a transfer would miss the targets, the system raises an alert, and the runbook/DR procedure specifies the required corrective action (including any failover).
- The contingency/DR documentation explicitly includes the off-site transfer process, triggers, and assigned responsibilities.

###### Actions Required for Compliance

- [ ] Define and get approval for an allow-list of authorised alternative storage locations that match the **cp-9.5_prm_1** agreement.
- [ ] Set up the organisation’s backup system to electronically send backup information to the approved (allow-listed) alternate site.
- [ ] Set up backup transfer jobs to record the start time, end time, the destination identifier, and the total number of gigabytes (GB) transferred, so throughput can be calculated.
- [ ] Set automated checks and alerts to flag transfers that would take more than 4 hours to complete or that would process less than 200 gigabytes per hour.
- [ ] Turn on encryption for data while it is being sent and while it is stored, for both backup transfers and destination storage.
- [ ] Store tamper-evident records for each transfer, including the destination, time and date, data size (GB), and the calculated transfer speed, so they are available for audit record retention.
- [ ] Update the business continuity and disaster recovery (DR) procedures and the system security plan to include the off-site transfer trigger, the responsible roles, and the recovery actions to take.


---

#### CP-9.6 — Redundant Secondary System (Enhancement)

This requirement is about keeping a ready-to-use backup copy of your main systems somewhere else. If the main site has a serious problem, you should be able to switch to the backup without losing information or stopping the business.

Without this, events such as fire, flooding, power failure, or a major outage could damage both the main system and its backup at the same time. That could prevent you from restoring services or recovering recent data.

To meet this expectation, the organisation must:
- keep a separate backup system in a different location from the primary system
- keep it up to date by continuously copying information from the primary system
- make sure it can be brought into use when needed, with no unacceptable disruption

The organisation must also:
- document how backups are made and how the backup system is activated
- include this approach in its contingency planning
- assign named responsibilities
- keep records of backup and contingency testing, including evidence that the secondary system was successfully activated and that key information and service availability were checked and confirmed.

##### Geo-separated warm secondary with continuous mirroring and tested failover

- Category: Software
- Priority: Critical

###### WHAT
Set up a backup system that is a **redundant secondary system** and is **not located in the same place** as the main (primary) system. The secondary system must **copy the primary system closely enough** (including replicated information) that it can be **switched on if needed without losing information or causing unacceptable disruption**.

###### WHY (control requirement)
CP-9(6) enhancement requires the organisation to carry out system backup by keeping a **redundant secondary system** that is **separated geographically** from the primary system and can be **switched on without losing information or causing disruption**. The guidance explains that mirroring/replication (including replication of information) supports this, and that enough geographic separation can allow the secondary system to act as an alternative processing site.

###### HOW (specific approach)
1. **Design and prepare a warm secondary site** in a different site/region/building (define and document the separation criteria). Pre-stage the required infrastructure (computing, networking, identity integration, certificates/secrets, monitoring, and any required dependencies) so switching over is a controlled failover, not a rebuild.
2. **Set up continuous mirroring/replication** from the primary to the secondary for all in-scope data and system state:
   - **Databases**: use continuous replication, log shipping, or replication slots appropriate to the database platform.
   - **Application state and configuration**: replicate the required state (for example, replicated data stores, event streams, or synchronised configuration items) so the secondary can run the same workload.
   - **Storage/files**: replicate data sets and perform integrity checks (for example, checksums/versioning) so the secondary has the same information set.
3. **Set and enforce replication behaviour that matches agreed RPO/RTO targets** so switching over does not cause unacceptable data loss or operational disruption (document the expected maximum data loss window and recovery time, and ensure replication supports it).
4. **Create activation and rollback procedures (runbooks)** that set out the exact steps to switch to the secondary (for example, DNS/load balancer changeover, application configuration switch, service start order, and validation checks) and how to return to the primary if needed. Include clear validation steps to confirm service availability and data integrity.
5. **Apply security controls to the secondary** so failover does not bypass governance (for example, use the same enterprise identity, apply least-privilege access, encrypt replication connections, and monitor/alert on the secondary).
6. **Test and keep evidence** by running scheduled failover practice sessions (and at least one activation test during initial implementation) to show that:
   - the secondary system was successfully activated,
   - the integrity of replicated information was verified,
   - key services stayed available or disruption stayed within agreed limits,
   - results and corrective actions were recorded.

###### WHO
- **Disaster Recovery (DR)/Business Continuity Lead**: owns the DR design, RPO/RTO targets, and geographic separation criteria.
- **Infrastructure/Cloud Platform Engineer**: sets up the warm secondary site and networking.
- **Application/Database Engineer**: implements mirroring/replication and checks the application is ready to run.
- **Security Architect / Identity and Access Management (IAM) Lead**: ensures identity, access, encryption, and monitoring are correctly applied to the secondary.
- **Operations/Incident Manager**: maintains and runs the activation/rollback runbooks and ensures testing evidence is captured.

###### Acceptance criteria
- A secondary system exists in a **non-collocated** location (with documented separation criteria) and is kept **warm** (pre-provisioned and ready).
- Replication/mirroring is implemented for in-scope data/state and is continuously updated from the primary to the secondary.
- Documented activation/rollback runbooks exist and have been validated operationally.
- At least one controlled failover rehearsal has been completed, with evidence that activation worked, replicated information integrity was verified, and service disruption/data loss were within the defined thresholds.
- Monitoring/alerting and security controls are in place for the secondary, so failover does not create unauthorised access or loss of visibility.

###### Actions Required for Compliance

- [ ] Define and document the geographic separation rules for the secondary site (region/building), and identify which in-scope systems are included in the disaster recovery (DR) design.
- [ ] Set up a warm secondary environment at the separate site, using pre-prepared infrastructure and integrated identity and monitoring.
- [ ] Set up continuous copying and replication of all in-scope data and the required application settings from the primary system to the secondary system.
- [ ] Set and confirm recovery point objective (RPO) and recovery time objective (RTO) targets based on how data replication behaves, and document the maximum acceptable amount of data that could be lost and how long recovery can take.
- [ ] Create activation and rollback runbooks that include cutover steps and checks to confirm data integrity and service availability.
- [ ] Carry out at least one controlled failover practice run and keep audit-ready records showing that the failover activated successfully, that the system integrity checks passed, and that the disruption results were as expected.


---

#### CP-9.7 — Dual Authorization for Deletion or Destruction (Enhancement)

This requirement is about ensuring that confidential or secret information in backup copies cannot be deleted or destroyed by one person working alone. Without this safeguard, a single trusted employee could remove backup records by mistake or on purpose. This would make it harder to restore systems after an incident and could also allow unauthorised loss of sensitive information. It also makes it more likely that harmful actions would go unnoticed.

To meet this expectation, the organisation must:
- Clearly define which backup information is covered (all backups that contain confidential or secret data).
- Ensure that both the deletion and the destruction of any covered backup material require approval from two qualified, formally authorised people.
- Make sure each of the two approvers can judge whether the action follows organisational rules.

The approval process must be enforced by an in-built control that cannot be bypassed. It must also record:
- who approved the action,
- when it happened,
- what was deleted or destroyed, and
- whether the action was deletion or destruction.

The approach must be documented, included in system planning, covered in contingency planning, and supported by maintained design and configuration evidence. Responsibilities must be assigned to the relevant staff.

##### Two-person approval workflow for in-scope backup deletion/destruction

- Category: Software
- Priority: Critical

###### WHAT
Implement a dual-approval (two-person) process that ensures **deletion or destruction of in-scope backup information** (defined as **all backup information that contains Confidential or Classified (Secret) data**) cannot be carried out unless **two suitably qualified, formally authorised people** approve the action.

###### WHY (control requirement)
CP-9(7) enhancement requires: **“Enforce dual authorization for the deletion or destruction of {{ insert: param, cp-09.07_odp }}.”** Dual approval (two-person control) prevents a single trusted person from deleting or destroying backup information and reduces the risk of unauthorised or accidental loss of sensitive backup data.

###### HOW (specific steps/approach)
###### 1) Define and enforce the in-scope set
- Ensure backup items/collections include classification information (for example, sensitivity tags/labels) so the system can tell whether a backup contains **Confidential or Classified (Secret)** data.
- Configure the process so the dual-approval requirement applies to **all** in-scope backup information, with **no manual exceptions**.

###### 2) Build a request → dual-approval → execute workflow
- Implement deletion and destruction as **two-stage actions** in the backup management/orchestration layer:
  - **Stage A: Request** (made by a user who is allowed to request, but not to carry out the action).
  - **Stage B: Approval 1** (by an authorised approver role).
  - **Stage C: Approval 2** (by a different authorised individual/role).
  - **Stage D: Execute** only after both approvals are in place.
- Prevent any **single-person bypass** by ensuring the execution check happens on the server side (not in the user’s browser/app). The system must refuse to execute if the second approval is missing.

###### 3) Ensure approvers are qualified and formally authorised
- Set up and maintain two approver roles (or an approver pool with role limits), for example:
  - **Backup Deletion Approver**
  - **Security/Information Security (InfoSec) Destruction Approver**
- Limit who can be assigned these roles through the organisation’s identity and access management (IAM) process, so only **formally authorised** individuals can approve.
- Require stronger verification for the second approval (for example, phishing-resistant multi-factor authentication (MFA)) to increase confidence in the approval.

###### 4) Record audit evidence for both approvals and the action
- Record, in a way that can be audited and cannot easily be altered, at least:
  - the identities of both approvers (who approved)
  - the time and date of each approval
  - the action type (**deletion** versus **destruction**)
  - the target backup identifier(s) / backup set ID
  - the execution result (success/failure) and the reason code
- Send the logs to the enterprise security information and event management (SIEM) system and store them with immutability controls (for example, write once, read many (WORM)/object lock) to support auditability.

###### 5) Optional collusion reduction (rotation)
- Configure approval assignment to rotate approvers (for example, alternate members of the approver pool) so the same people are not routinely paired.

###### WHO
- **Backup platform owner / infrastructure engineer**: implement the workflow and enforcement in the backup management/orchestration layer.
- **IAM administrator**: set up approver roles and enforce separation of duties.
- **Information Security / compliance lead**: define qualification and authorisation requirements and approve the dual-approval policy.
- **Operations lead**: ensure runbooks and contingency procedures reference the two-person workflow.

###### Acceptance criteria
- For any backup identified as containing **Confidential or Classified (Secret)** data, **deletion or destruction cannot be carried out** unless **two separate authorised individuals** approve.
- Attempts to execute with only one approval are **rejected** by server-side enforcement and create an audit record showing the failure reason.
- Audit logs show **both approver identities**, approval timestamps, action type (delete versus destroy), and the affected backup set ID.
- Approver roles are limited to formally authorised individuals and are enforced through the organisation’s IAM integration.
- Dual-approval enforcement applies to **all** in-scope backups, with **no manual bypass routes**.

###### Actions Required for Compliance

- [ ] Define and implement a tagging system so that any backup sets containing Confidential or Classified (Secret) information are automatically identified as in-scope.
- [ ] Set up backup deletion and destruction as a step-by-step workflow in the backup management or orchestration layer: **request → first approval → second approval → execute**.
- [ ] Block execution on the server unless there are two separate authorised approvals.
- [ ] Set up two separate approver roles (and limit who can belong to each) in identity and access management (IAM), so that only formally authorised, qualified people can approve.
- [ ] Add step-up authentication using phishing-resistant multi-factor authentication (MFA) for the second approval.
- [ ] Set up tamper-evident audit logs for both approvals, the time of each event, the type of action taken (delete versus destroy), and the identifier of the affected backup, and send these logs to security information and event management (SIEM).
- [ ] Write down the procedure and test it, including a negative test that proves a single-approver request is rejected.


---

#### CP-9.8 — Cryptographic Protection (Enhancement)

This requirement is about protecting backup copies so that only authorised people and systems can read them or change them. If backups are not properly protected, an attacker or a careless insider could steal sensitive information from the backups, or quietly change the backups so that, when you try to restore after an incident, you end up with corrupted or malicious data instead of the real records.

To meet this requirement, the organisation must encrypt backup information while it is stored in both its main (primary) backup location and its backup fallback (alternate) location, using protection strong enough for the sensitivity of the backup content. The organisation should use the same level of protection at both locations, keep clear records of how it decided on the protection strength, and use secure processes to manage encryption keys so they are not exposed.

The organisation must also be able to demonstrate that unauthorised access cannot read or tamper with backups, and that any tampering is detected.

##### Encrypt and integrity-protect backups at primary and alternate storage

- Category: Software
- Priority: Critical

###### WHAT
Protect **system backup information** stored in **primary and alternate locations** using encryption and related safeguards by:
- Encrypting backup data **while it is stored** (at rest) in both locations.
- Adding **integrity protection** so unauthorised changes can be detected.
- Using cryptographic methods with strength chosen based on the backup information’s **security category/classification**.
- Applying the same protection approach in the same way for both the primary and alternate storage.
- Using a managed key approach (for example, key management service and/or hardware security module) so encryption keys are protected.

###### WHY (control requirement)
NIST SP 800-53 **CP-9(8)** requires: “Implement cryptographic mechanisms to prevent unauthorized disclosure and modification of {{ insert: param, cp-09.08_odp }}.” The guidance also states that the cryptographic strength must match the confidentiality and integrity needs of the backup information, and that this protection applies to backup information stored in **both primary and alternate locations**.

###### HOW (specific steps/approach)
1. **Match each backup dataset to its classification**: For each backup job/dataset, identify the security category/classification that applies to the backup information (the control parameter: **cp-09.08_odp = system backup information in storage at primary and alternate locations**).
2. **Standardise encryption for backups (backup platform/backup layer)**: Configure the backup platform/backup vault/object storage so backup data is encrypted before it is written to both the **primary** and **alternate** targets (do not rely only on disk-level encryption). Make sure the setting is enabled for both locations.
3. **Use managed keys with restricted access**: Connect the backup platform to an enterprise key management service (for example, key management service backed by hardware security module). Set key rules so only the backup service identities can use keys to encrypt and decrypt. Limit administrative permissions for keys.
4. **Enable integrity and tamper detection**: Turn on integrity protection features available in the backup solution (for example, authenticated encryption, signed backup records, or cryptographic checksums with verification). Ensure verification is performed and that results are logged.
5. **Choose cryptographic strength based on classification**: Implement an approved mapping from classification to cryptographic method (algorithm and key size) and apply it consistently to both primary and alternate storage. Keep a record of why each selection was made.
6. **Show enforcement with audit evidence**: Gather configuration evidence from the backup platform and key management service showing encryption and integrity protections are enabled for both locations, and keep it for audit purposes.
7. **Test resistance to disclosure and modification**: Run controlled tests using an unauthorised identity to confirm backups cannot be read or downloaded. Also try restoring or verifying a deliberately altered backup copy to confirm integrity checks fail.

###### WHO (role responsible)
- **Backup/Recovery Engineering Lead**: sets up the backup platform configuration for encryption and integrity.
- **Security Architect / Crypto Governance Lead**: defines the classification-to-cryptography strength mapping and approves the methods.
- **Cloud/Infrastructure Engineer (or OT Infrastructure Engineer where applicable)**: integrates the key management service/hardware security module and enforces key access rules.
- **GRC/Compliance Analyst**: checks that audit evidence and test results are complete.

###### Acceptance criteria
- Backups for all in-scope datasets are encrypted **while stored** in both **primary and alternate** locations.
- Integrity protection is enabled so tampering is detectable (for example, verification fails or signed record validation fails).
- The choice of cryptographic method (algorithm/key size) is documented, matches the backup information classification, and the same strength is used for both locations.
- Encryption keys are managed using an enterprise key management service/hardware security module approach with restricted permissions for key use.
- Audit evidence exists showing encryption and integrity settings for both locations, and test results demonstrate that unauthorised access to read backups is blocked and that tampering is detected.

###### Actions Required for Compliance

- [ ] Take an inventory of all backup datasets and link each one to the organisation’s security category or classification.
- [ ] Set up the backup system to encrypt backup files and data while they are stored, for both the main (primary) storage and the backup (alternate) storage targets.
- [ ] Integrate the backup system with an enterprise key management system and hardware security module (KMS/HSM), and allow key use only for the backup service identities.
- [ ] Enable integrity protection for backups by using authenticated encryption and/or signed backup records (manifests) and/or cryptographic checksum checks, and make sure the verification is carried out.
- [ ] Create a mapping from data classification to approved cryptographic strength (approved algorithms and key sizes), and apply it consistently in both locations.
- [ ] Collect and store audit evidence from the backup console and the key management console to show that encryption and data integrity checks are enabled for both the primary and the alternate storage.
- [ ] Carry out tests to try to access the system without authorisation and to check for unauthorised changes, and record the results to show that access is blocked and any modification is detected.


---

### CP-10 — System Recovery and Reconstitution (Control)

This requirement is about making sure your organisation can quickly put its systems back into a safe, working condition after something goes wrong, and then return them to full normal operation. Without clear recovery steps and follow-through, a disruption, security incident, or system failure could leave essential services unavailable for too long, lead to avoidable data loss, and result in temporary workarounds that increase risk.

The organisation must set out and document how recovery will happen. This includes the backup arrangements and evidence that backups and recovery plans have been tested. The organisation must also keep the relevant plans, procedures, and records up to date.

After any disruption, the organisation must restore the system to a known, working state within 24 hours using the documented contingency plan, aligned with business priorities and recovery objectives. Then, within 72 hours, it must fully restore the system by removing temporary recovery measures, confirming that full capabilities are back in place, restarting ongoing system checks, completing any required re-authorisation, and preparing for future incidents. Information security staff must be involved, with clearly assigned responsibilities.

##### Automated recovery runbook with 24h known-state and 72h reconstitution

- Category: Software
- Priority: Critical

###### WHAT must be done
Put in place and run a recovery and re-building capability that brings the system back to a **known, agreed working state within {{ cp-10_prm_1 }} (24 hours)** after a disruption, compromise, or failure. Then **restore it to full day-to-day operating capability within 72 hours**. This re-building must include turning off any temporary recovery measures, checking that the system is fully restored, bringing back continuous monitoring, and completing system re-approval where required.

###### WHY (control requirement)
CP-10 requires the organisation to “provide for the recovery and re-building of the system to a known state within {{ insert: param, cp-10_prm_1 }} after a disruption, compromise, or failure,” and to make sure recovery and re-building activities match mission and business priorities, **recovery time objectives (RTO)**, **recovery point objectives (RPO)**, and the requirements in the contingency plan. Further guidance also requires turning off temporary capabilities, checking the restored capabilities, restarting continuous monitoring, and re-approving the system (if required).

###### HOW (specific steps/approach)
###### 1) Set clear, measurable recovery and re-building targets for each workload
- For each critical service/workload, record:
  - **RTO for known working state** = within **{{ cp-10_prm_1 }} (24 hours)**.
  - **RTO for re-building to full capability** = within **72 hours**.
  - **RPO** aligned to the contingency plan requirements (recovery point objective).
- Categorise workloads as either:
  - “**rebuild-from-known-good**” (recreate the environment using signed and hardened building blocks), or
  - “**restore-from-backup**” (restore data and application state from backups).

###### 2) Create a repeatable, automated recovery method
- Create a **recovery runbook** that can be used during incidents to:
  - Set up or restore computing, network, and application components from **known-good building blocks** (for example, hardened images and signed configuration packages) or from **approved backups**.
  - Carry out health checks that are enough to confirm the system is in a **known, working state** (the “go/no-go” point for the 24-hour target).
  - Record what was turned on during recovery (including any temporary or reduced-function modes).
- Put the runbook into practice using an automation approach suitable for the environment (for example, cloud automation/workflow tools, configuration management pipelines, or IT service orchestration), with controlled change and approval where required.

###### 3) Carry out re-building as a separate phase, with clear deactivation of interim capabilities
- After the 24-hour switch to the known working state, run a **re-building pipeline** to:
  - Restore the full intended configuration and security posture (remove temporary or reduced controls used during recovery).
  - Complete **assessment of fully restored capabilities** (for example, full functional checks and, where applicable, data integrity checks).
  - **Re-establish continuous monitoring** (confirm that security monitoring and log/alert pipelines are fully enabled and tested).
  - Complete **system re-approval** steps where required by organisational policy (for example, re-enable approvals for privileged access, re-run approval workflows, or obtain re-approval sign-off).
  - Prepare for future incidents by updating recovery evidence and lessons learned in the contingency plan records.

###### 4) Keep audit-ready evidence and test the capability
- Keep evidence that recovery and re-building works as intended:
  - Runbook execution records (timestamps, actions taken, decision points).
  - Backup/restore or rebuild test results, where applicable.
  - Evidence that re-building is complete (monitoring re-enabled and validated; interim capabilities turned off; re-approval completed if required).
- Run controlled recovery/re-building exercises at a frequency that matches the organisation’s contingency plan testing requirements, and at least after significant changes to system architecture, backup approach, or security baselines.

###### WHO (role responsible)
- **Application Owner / Service Owner**: owns the workload RTO/RPO definitions and confirms acceptance of the “known working state”.
- **Incident Response Lead / IT Operations Lead**: runs the recovery runbook during incidents.
- **Information Security Officer / Security Engineering**: checks that security posture is fully restored, continuous monitoring is re-established, and re-approval requirements are met.
- **Platform/Infrastructure Engineering**: maintains the automation, building blocks, and orchestration.

###### Acceptance criteria
1. For each in-scope critical workload, the runbook can restore the service to a **known, working state within 24 hours** ({{ cp-10_prm_1 }}), supported by timestamped execution logs and health-check results.
2. Re-building completes within **72 hours**, supported by evidence that:
   - interim recovery capabilities have been turned off,
   - full capability assessment is complete,
   - continuous monitoring has been re-established and validated,
   - system re-approval is complete where required.
3. Recovery and re-building produces audit-ready evidence sufficient to show alignment to contingency plan requirements (including RTO/RPO and mission/business priorities).
4. Controlled exercises confirm the capability remains effective after changes (automation, baselines, backup/restore approach, monitoring integrations).

###### Actions Required for Compliance

- [ ] For each workload, document the recovery time objective (RTO) for a known state (within {{ cp-10_prm_1 }} / 24 hours) and the 72-hour reconstitution objective, aligned with the contingency plan Recovery Point Objectives (RPOs).
- [ ] Create and version a recovery runbook that can rebuild systems from approved “known-good” components or restore them from approved backups. Include clear health-check checkpoints to confirm the system is in the “known state” before continuing.
- [ ] Set up orchestration to run recovery steps, record evidence with timestamps, and switch between normal, interim, and degraded operating modes in a controlled way.
- [ ] Create a reconstitution phase checklist that: deactivates temporary capabilities, completes full capability assessments, and switches continuous monitoring back on and verifies it is working correctly.
- [ ] Add reauthorisation steps to the reconstitution process when organisational policy requires it.
- [ ] Run controlled recovery and reconstitution tests, and keep evidence showing that the 24-hour and 72-hour recovery targets were met.


---

#### CP-10.2 — Transaction Recovery (Enhancement)

This expectation is about making sure that if a transaction-based system (such as a database or a payment or order processing service) crashes or fails while making a change, it can restore itself to a correct and consistent state. Without this, partial changes could be left behind, leading to incorrect balances, duplicate records, missing orders, or other expensive errors that are difficult to spot and even harder to fix.

To meet this expectation, the organisation must build recovery into every transaction-based system and keep it working. This includes being able to undo incomplete work and, where needed, record changes so they can be replayed or reversed after a failure. The organisation must also keep clear records of what recovery actions were taken and retain the related system audit information, so this can be shown later.

Finally, recovery responsibilities and procedures must be documented, supported by contingency planning and testing, and backed by test results and evidence that match the recovery records.

##### Enable DB transaction recovery with rollback/journaling and evidence

- Category: Software
- Priority: Critical

###### WHAT
Set up transaction recovery for all parts of the application that use transactions. This means ensuring **rollback** is available for unfinished work, and enabling **transaction journaling / write-ahead logging (WAL)** so the system can return to a consistent state after a failure.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Special Publication 800-53 **CP-10(2) Transaction Recovery** enhancement requires: **“Implement transaction recovery for systems that are transaction-based.”** The guidance calls for transaction recovery methods such as **transaction rollback** and **transaction journaling**.

###### HOW (specific steps/approach)
1. **Identify transaction-based systems in scope** (for example: relational databases, transactional message/order/payment services, and any components that store business-critical information).
2. **Ensure rollback works correctly in the application** by using clear transaction boundaries (BEGIN/COMMIT/ROLLBACK) and stopping accidental auto-commit in the middle of work for all critical write actions.
3. **Enable and standardise journaling/WAL in the database** so the system can recover after a crash by replaying/undoing changes to reach a consistent state. Configure durable logging, the required recovery approach, and suitable log retention for recovery checks.
4. **Create transaction recovery records** during restart/recovery and when transactions fail, capturing at least: recovery start/finish, affected component/database, timestamps, and any available transaction identifiers.
5. **Keep audit evidence** by linking recovery records to existing audit and security information and event management (SIEM) logs (for example: service restart events, database error logs, and application transaction failure logs), and storing it in an audit-ready evidence repository.
6. **Test transaction recovery using controlled failure scenarios** (for example: stopping a transaction part-way through; crashing after commit but before any follow-on dependent writes where relevant). Save the exact recovery outputs and the linked audit logs.
7. **Document recovery responsibilities and verification steps** in runbooks that match the implemented mechanisms, including who reviews the evidence and how to confirm the system is consistent.

###### WHO (role responsible)
- **Application owner / Technical lead**: ensures transaction boundaries and correct rollback use in code and configuration.
- **Database administrator (DBA) / Platform engineer**: enables and standardises journaling/WAL and durable recovery settings.
- **Security/compliance engineer**: sets evidence requirements, ensures audit log linking, and checks the test evidence packages.
- **Operations / Site Reliability Engineering (SRE)**: runs the failure tests, captures recovery outputs, and maintains the runbooks.

###### Acceptance criteria
- For every in-scope transaction-based system, **rollback is implemented and clearly used** for critical write operations (for example: automated tests confirm partial changes are undone).
- For every in-scope database/transaction store, **journaling/WAL is enabled and configured** to support crash recovery (validated through configuration checks).
- After a simulated failure, the system **returns to a consistent state** without leaving partial or duplicate records (validated through test checks).
- A **recoverability evidence package** exists for each test event, containing: recovery records (from the database/service), linked audit and SIEM logs, and the test results.
- Runbooks exist and are up to date, describing **how to confirm recovery happened** and who is responsible for review and approval.

###### Actions Required for Compliance

- [ ] Create a complete list of all transaction-based components—such as databases and transaction services—in both the live (production) and testing environments.
- [ ] Update the application’s data access code to clearly define where each database transaction starts and ends, and make sure a rollback (undo) happens if any failure occurs.
- [ ] For every in-scope database or transaction store, enable durable journaling and write-ahead logging (WAL), and set the required recovery model.
- [ ] Set up automated collection of recovery records, including database recovery logs and journal details, plus the start and end events of each recovery, linked to the relevant time stamps and transaction identifiers.
- [ ] Match recovery evidence with existing audit records and security information and event management (SIEM) logs, and store a complete, audit-ready set of proof in the organisation’s evidence repository.
- [ ] Run controlled failure tests (for example, stopping a process in the middle of a transaction and simulating a crash after the transaction is completed) and verify that the system always returns to a consistent, correct state using automated checks.
- [ ] Publish and keep up to date runbooks that describe the steps for checking recovery works, the responsibilities of each role, and how to interpret the saved recovery and audit evidence.


---

#### CP-10.4 — Restore Within Time Period (Enhancement)

This requirement is about quickly putting damaged or disrupted computer parts back into a known, working state—specifically within 24 hours. If this is not possible, a serious incident, accidental deletion, or system failure could leave your business unable to operate for days. That can mean lost work, missed deadlines, and a risk that information could be changed without authorisation.

To meet this expectation, the organisation must:
- define and document a 24-hour recovery target
- ensure restoration uses approved, tracked recovery information that cannot be changed without detection, so the rebuilt components match a previously proven working state
- include the ability to reinstall from a known-good baseline when needed
- have clear, written recovery and rebuild procedures
- name the people responsible for carrying out these procedures
- have contingency planning that includes recovery steps
- keep evidence that recovery testing has been carried out, with measured results showing restoration within 24 hours

##### 24-hour restore using signed golden images and integrity-checked baselines

- Category: Software
- Priority: Critical

###### WHAT
Implement a restore capability that can rebuild system components to a **known, working state** within the organisation-defined time period (**cp-10.04_odp: within 24 hours**). Use **configuration-controlled** and **integrity-protected** restoration information.

###### WHY (control requirement)
NIST SP 800-53 **CP-10(4)** enhancement requires: “Provide the capability to restore system components within {{cp-10.04_odp}} from configuration-controlled and integrity-protected information representing a known, working state.” Guidance notes that restoration includes **reimaging**.

###### HOW (specific approach)
1. **Define “known-good” restoration items for each component type** (for example, web tier, application tier, database tier, and admin tooling). For each item, create a “known, working state” checklist covering service health, dependency checks, and application-level smoke tests.
2. **Create golden images/templates** (virtual machine images, container base images, or infrastructure templates). Ensure each one is linked to a **versioned configuration baseline** (for example, configuration manifests/infrastructure as code modules) that represents the approved working state.
3. **Integrity-protect the restoration information**: sign golden images/templates and baseline items (or publish cryptographic hashes). Store the verification information in a protected location. Restoration automation must **check signatures/hashes before any reimage/rebuild starts**.
4. **Automate the restore process** so it is repeatable and can be audited: (a) choose the approved item version, (b) verify integrity, (c) reimage/rebuild, (d) apply the approved configuration baseline, (e) run acceptance checks, and (f) record start/end times and results.
5. **Document and put recovery/reconstitution procedures into day-to-day use** (runbooks), including reimaging steps, rollback/abort conditions, required approvals, and escalation routes. Ensure the contingency plan points to these procedures and the restore target time.
6. **Run timed restore practice exercises** on representative components (start with non-production, then use production-like systems). Collect evidence that restoration finishes within **24 hours**, including acceptance checks. Record outcomes and fix any gaps (for example, missing dependencies, slow provisioning, or manual steps).

###### WHO
- **Disaster Recovery (DR) / Business Continuity Planning (BCP) Lead / Service Owner**: owns the defined known-good states and the mapping to the restore target time.
- **Platform/Infrastructure Engineers**: build and maintain golden images/templates and the restore automation.
- **Configuration Management / Infrastructure as Code (IaC) Lead**: maintains versioned configuration baselines and links to change control.
- **Information Security (or Security Engineering)**: ensures integrity protection, verification requirements, and evidence standards are met.
- **Operations / Incident Response Team**: runs the restore practice exercises and follows the runbooks.

###### Acceptance criteria
- For each in-scope component type, there is a **versioned golden image/template** and a **versioned configuration baseline** that together represent a known, working state.
- Restore automation (or the restore procedure) **verifies integrity** (signature/hash) for both the golden item and the configuration baseline **before** any reimaging/rebuild.
- Restore runbooks and the contingency plan content clearly support **reimaging/rebuild** and can be carried out by authorised roles.
- Evidence from timed restore practice exercises shows restoration to the known working state (including acceptance checks) is achieved **within 24 hours** for the tested component(s), with documented start/end times and results.

###### Actions Required for Compliance

- [ ] Set “known-good” recovery targets and approval checks for each type of component that must be restored within 24 hours.
- [ ] Create and version “golden” images/templates, and link each version to an approved configuration baseline under formal change control.
- [ ] Use digital signatures or hashes to protect the integrity of key “golden” files and configuration baselines, and make integrity checks mandatory before any restore operation.
- [ ] Set up an automated restore process that (1) checks the restored data is complete and correct, (2) rebuilds the system, (3) reinstalls the standard baseline application, and (4) runs acceptance tests, while recording the start and end times.
- [ ] Publish the restore and reconstitution runbooks, and make sure the contingency plan points to the restore process and clearly states the escalation and abort criteria.
- [ ] Run timed “restore” practice exercises on representative systems and keep audit-ready proof that restores can be completed within 24 hours.


---

#### CP-10.6 — Component Protection (Enhancement)

This requirement is about keeping the “recovery kit” that restores your systems safe and trustworthy. If something goes wrong, you should be able to rebuild the service without allowing the wrong people to tamper with the recovery materials. Without this, an attacker or a careless insider could change the hardware, software, or backup materials used to restore the system. This could lead to you restoring corrupted or malicious versions, or being unable to recover at all.

To meet this expectation, the organisation must keep an up-to-date list of all recovery and restoration components. This includes the backup and restore software needed (such as tools and any supporting system software). The organisation must protect these components using appropriate physical security measures and access restrictions.

Access must be limited to authorised personnel. This should be supported by documented contingency planning policy, recovery procedures, and a contingency plan, as well as system design and configuration records, a security plan, and records showing who is authorised and which credentials are in place and kept secure.

##### Recovery artefact vault with integrity checks and restricted access

- Category: Software
- Priority: Critical

###### WHAT
Set up a controlled “recovery and reconstitution artefact vault” to store and manage all parts needed to recover systems and rebuild them correctly. This includes recovery components (hardware, firmware, and software) and backup/restore components (for example, router tables, compilers, restore tools, and any required system software). The vault must provide both physical and technical protection, and ensure only authorised staff can access and use approved artefacts.

###### WHY (control requirement)
CP-10(6) (Enhancement) requires: **“Protect system components used for recovery and reconstitution.”** The guidance explains that protection includes **physical and technical controls**, and that **backup and restoration components** include items such as **router tables, compilers, and other system software**. The vault enforces protection of these recovery components, so system restoration cannot be undermined by unauthorised changes or by using untrusted artefacts.

###### HOW (specific steps/approach)
1. **Create and keep an authoritative inventory** of all recovery/reconstitution components and all backup/restore components. Record, for each item: version, purpose, owning team, and storage location.
2. **Physically protect recovery hardware and media** (for example, locked cabinets or rooms, and tamper-evident seals where appropriate). Use a clear **issue and return** process, with custody records logged.
3. **Technically protect recovery software/firmware/toolchains** by storing them in a **restricted repository** (for example, a private artefact repository or object storage), with:
   - **role-based access control (RBAC)** limited to recovery/reconstitution roles,
   - **immutable versioning** (versions cannot be altered after creation),
   - **mandatory integrity checks** (hash checking and/or signature validation) carried out when the artefact is downloaded or used,
   - **approval gates** for any update to recovery artefacts (artefacts must be signed/validated before they can be used).
4. **Control access to recovery activities** using the organisation’s identity provider. Only privileged recovery roles can perform recovery actions, using **strong authentication** and **just-in-time (JIT) elevation** for restore/reconstitution activities.
5. **Produce audit evidence**: record who accessed the vault/repository, which artefact version was taken, and which restore operation used it. Keep logs according to the organisation’s retention requirements.

###### WHO
- **Infrastructure/Platform Engineering Lead**: responsible for vault design, repository setup, and integration with backup and recovery tools.
- **Security Engineering / Cybersecurity**: sets integrity and signing requirements, and approves change gates for recovery artefacts.
- **Privileged Access Management (PAM) / Identity Team**: implements role-based access control (RBAC), just-in-time (JIT) elevation, and authentication requirements.
- **Operations/Disaster Recovery (DR) Team**: maintains the recovery artefact inventory, manages issue/return, and runs restore rehearsals.

###### Acceptance criteria
- A complete, up-to-date inventory exists for recovery and reconstitution components, including backup/restore components (router tables, compilers, restore tools, required system software).
- Recovery hardware/media are stored in controlled physical locations, with a documented custody/issue/return process.
- Recovery software/firmware/toolchains are stored in a restricted repository with immutable versioning and integrity checks enforced at the time of use.
- Only authorised recovery roles can retrieve artefacts. Access requires strong authentication and is auditable.
- Evidence is available showing: (a) authorised access to recovery artefacts, (b) integrity/signature validation results, and (c) the artefact version used during recovery/reconstitution tests.

###### Actions Required for Compliance

- [ ] Create an official inventory of recovery items, covering hardware, firmware, software, and backup and restore components.
- [ ] Set up a restricted recovery file repository with unchangeable version history and role-based access control (RBAC).
- [ ] Set up mandatory integrity checks (hash and signature validation) for every recovery file at the time it is downloaded or used.
- [ ] Set up a documented approval and change checkpoint so only security-reviewed, formally signed materials can be used for recovery.
- [ ] Store secure recovery hardware and media in controlled physical storage, using a formal process to issue and return items, with custody records logged.
- [ ] Connect recovery access to the organisation’s identity provider (IdP) to require strong sign-in checks and allow temporary, on-demand permission increases only when performing restore operations.
- [ ] Keep audit logs enabled so they record who accessed each artefact version and which restore or reconstitution test used it.


---

### CP-11 — Alternate Communications Protocols (Control)

This requirement is about making sure your organisation can still communicate during a disruption, even if the usual phone or messaging service stops working. Without an agreed backup plan, important decisions and urgent alerts could be delayed or missed, leaving staff unable to coordinate and putting people, services, and operations at risk.

To meet this expectation, the organisation must be able to use a secure voice and video calling service as the backup. If that backup fails, there must be a planned fallback to an encrypted satellite link. For critical alerts, there must also be a separate text-message route.

Before using these alternate methods, the organisation must assess and record any knock-on effects on day-to-day systems and working practices, and keep evidence that this assessment was completed and approved. The organisation must also clearly assign named responsibilities, document the steps and triggers for switching to the backup routes, keep the relevant plans and system records up to date, and be able to show the capability through practical testing.

##### Continuity alternate comms: Secure SIP TLS with satellite + SMS

- Category: Software
- Priority: Critical

###### WHAT
Set up an alternative communications capability to support business continuity, using the organisation-approved set: **Secure Session Initiation Protocol (SIP) over Transport Layer Security (TLS)** (primary alternate), **fallback to an encrypted satellite link**, and **out-of-band Short Message Service (SMS) for critical alerts**.

###### WHY (control requirement)
CP-11 requires the organisation to **provide the capability to use the alternate communications protocols** (cp-11_odp) to maintain business continuity. Guidance also requires assessing and recording **possible side effects** of introducing alternate protocols before implementation, because switching protocols can affect applications and day-to-day operations.

###### HOW (specific steps/approach)
1. **Create a Continuity Communications Register** listing the three protocols (Secure SIP over TLS, encrypted satellite link, out-of-band SMS). Include supported endpoints, routing rules, message/alert types, and operational limits.
2. **Implement Secure SIP over TLS as the first alternate path**: configure SIP proxy/registrar components to require TLS, enforce approved cipher suites, and set up certificate life-cycle and expiry monitoring.
3. **Implement a predictable fallback to the encrypted satellite link**: define clear triggers (for example, primary Wide Area Network (WAN)/SIP TLS health-check failure, loss of the primary signalling path, or a manual continuity switch), set up routing failover, and ensure the failover event is recorded for audit.
4. **Implement out-of-band SMS for critical alerts** using a dedicated alerting service that is independent of the primary communications path: set up recipient lists, message templates, rate limiting, and an acknowledgement/escalation process.
5. **Carry out and record side-effect analysis before enabling in live environments**: document impacts to applications (for example, SIP client behaviour, call routing, authentication processes), operational procedures (for example, who can place calls and how verification happens), and any operational technology/information technology (OT/IT) integration constraints. Link the results to the relevant change and approval records.
6. **Create operator runbooks and switching procedures**: define responsibilities, the step-by-step switching sequence, verification checks (for example, successful Secure SIP over TLS session set-up, satellite link availability, SMS delivery confirmation), and escalation routes.
7. **Run controlled continuity exercises** (table-top and/or technical failover drills) to provide evidence that the alternates work and that switching follows the documented behaviour.

###### WHO (responsible roles)
- **Continuity/Continuity of Operations (COOP) Owner**: maintains the Continuity Communications Register and ensures it is included in contingency/COOP planning.
- **Network/Telecom Engineer (Information Technology (IT)/Operational Technology (OT) as applicable)**: implements Secure SIP TLS and satellite failover routing.
- **Application Owner / Platform Engineer**: checks application-side impacts and integration behaviour.
- **Information Security Officer / Security Architect**: reviews side-effect analysis and approves security-relevant configuration.
- **Incident/Continuity Duty Officer**: performs runbook switching during exercises and incidents.

###### Acceptance criteria
- The system can **use Secure SIP over TLS** during a simulated disruption to primary communications.
- When Secure SIP TLS failure indicators occur, the system **automatically or procedurally switches over** to the **encrypted satellite link** using the documented triggers.
- **Critical alerts** are sent via **out-of-band SMS**, with delivery and acknowledgement evidence.
- A **documented side-effect assessment** exists and is linked to the relevant implementation/change approvals.
- Runbooks/procedures exist and are followed during at least one controlled continuity exercise, producing auditable evidence (logs, delivery confirmations, exercise report).

###### Actions Required for Compliance

- [ ] Document the Continuity Communications Register for **cp-11_odp** (secure Session Initiation Protocol (SIP) over Transport Layer Security (TLS), encrypted satellite fallback, and out-of-band Short Message Service (SMS)), including the routing rules and operational constraints.
- [ ] Set up secure Session Initiation Protocol (SIP) using Transport Layer Security (TLS) and require TLS for all connections, with monitoring to track certificate expiry and manage the certificate lifecycle.
- [ ] Set up predictable failover triggers and route traffic through the encrypted satellite link, and record all failover events for audit purposes.
- [ ] Set up an out-of-band text message (SMS) alert service with the approved recipient list, predefined templates for critical alerts, limits on how many messages can be sent in a given time, and a process to confirm delivery and escalate if messages are not acknowledged.
- [ ] Complete and record a side-effect assessment (including application and operational impacts), and link it to the change and approval evidence before enabling it in the live (production) environment.
- [ ] Publish operator runbooks that describe the switching steps, the checks to confirm everything is working correctly, the responsibilities of each role, and the escalation routes if there is a problem.
- [ ] Run a controlled continuity test to confirm that all backup options work as intended, and keep the supporting evidence (system logs, SMS delivery confirmations, and the test report).


---

### CP-12 — Safe Mode (Control)

This requirement is about putting a system into a locked-down “safe mode” when something looks seriously wrong. In safe mode, the system continues only the most critical work, while everything else is shut down. Without this, a malware incident, repeated suspicious login attempts, tampering with the system’s files or code, or the loss of the communications link the system needs could let an attacker cause wider damage, keep access available, or overwhelm the system and disrupt essential services.

The organisation must clearly define:
- what safe mode allows (only essential functions)
- what it limits (network use to pre-set rates)
- what it turns off (non-essential services and remote administration)

It must also define the warning signs that trigger safe mode, and ensure the system can enter safe mode automatically or allow authorised staff to switch it on manually, using documented procedures.

The organisation must test that safe mode triggers correctly, keep records of tests and incidents, and be able to show when safe mode was entered and what restrictions were applied.

##### Automated Safe Mode for defined triggers with bandwidth and admin blocks

- Category: Software
- Priority: Critical

###### WHAT
Set up a safe mode capability that, **when the defined conditions are detected**, automatically (and/or through authorised manual action) switches the application and its supporting infrastructure into a **predefined restricted operating posture**.

Safe mode must enforce **the defined restrictions**: allow only essential mission/business functions, **limit network bandwidth to predefined rates**, and **turn off non-essential services and remote administrative access**.

###### WHY (control requirement)
CP-12 requires that **when {{cp-12_odp.02}} conditions are detected**, the system enters safe mode with **{{cp-12_odp.01}} restrictions**. Safe mode must limit operations to selected essential functions and restrict communications bandwidth, including turning off non-essential services and remote administration.

###### HOW (specific approach)
###### 1) Define safe mode restrictions as enforceable “postures”
- Create a **Safe Mode Profile** for each environment (production, test, disaster recovery) and for each application tier (web/app/data/admin). Each profile must clearly define:
  - **Essential functions allow-list** (only the minimum set of application endpoints/services needed to continue critical business processing).
  - **Non-essential services disablement** (stop/disable background jobs, non-critical integrations, non-essential application programming interfaces, and any services not needed for essential functions).
  - **Remote administrative access block** (block remote administration routes such as Secure Shell (SSH), Remote Desktop Protocol (RDP), remote consoles, admin application programming interfaces, and privileged management endpoints; keep only locally required management routes if applicable).
  - **Bandwidth limits** (rate-limit outgoing and incoming non-essential traffic and cap overall communications to **predefined rates** using network controls).

###### 2) Map each detected condition to a safe mode action
Create detection rules that link each **{{cp-12_odp.02}} condition** to a safe mode action:
- **Malware outbreak** → trigger when confirmed malicious detections are reported by endpoint/application security tools.
- **Loss of required integrity checks** → trigger when integrity monitoring fails (for example, failed signature/hash verification, tamper detection, or failed secure boot/attestation where used).
- **Repeated authentication failures** → trigger when authentication/identity provider (IdP) events exceed the defined threshold (for example, brute-force indicators or repeated failures for privileged and/or service accounts).
- **Loss of required command-and-control connectivity** → trigger when required connectivity/health checks for critical dependencies are lost (for example, application health/heartbeat and required upstream/downstream connectivity).

###### 3) Apply safe mode automatically and allow authorised manual entry
- **Automatic entry**: when any trigger fires, an orchestration workflow applies the Safe Mode Profile to the affected assets.
- **Manual entry**: provide an authorised runbook/workflow to enter safe mode on demand (for example, during incident response) with approvals aligned to the organisation’s incident procedures.

###### 4) Ensure consistent enforcement across all tiers
- Apply safe mode at multiple layers so restrictions cannot be bypassed:
  - **Application layer**: use routing/feature flags to disable non-essential endpoints and integrations.
  - **Host/container layer**: stop/disable non-essential services; restrict administrative interfaces.
  - **Network layer**: apply rate limiting and block remote administrative traffic.

###### 5) Keep audit evidence
- Record: the trigger condition, the time safe mode was entered, which Safe Mode Profile was applied, and which restrictions were enforced (for example, firewall policy version, rate-limit configuration identifier, and list of disabled services).
- Keep logs for incident and audit purposes, and record test results for each trigger.

###### WHO
- **Application Owner / Engineering Lead**: defines the essential functions allow-list and implements safe mode behaviour at the application tier (feature flags/routing/integration disablement).
- **Security Engineering / Security Operations Centre (SOC) Automation Engineer**: implements detection rules and the orchestration workflow.
- **Infrastructure/Network Team**: implements bandwidth caps and remote administration blocks using network/host controls.
- **Incident Response Lead**: owns the manual safe mode runbook and the authorisation process.

###### Acceptance criteria
- For each defined **{{cp-12_odp.02}} condition**, the system enters safe mode within the agreed operational time window and applies **{{cp-12_odp.01}} restrictions**.
- While in safe mode:
  - Only the defined essential functions remain available.
  - Non-essential services are disabled.
  - Remote administrative access is blocked.
  - Network bandwidth is limited to the predefined rates (measured and verifiable).
- Safe mode entry is auditable: logs show the trigger, entry time, and the enforced restriction set.
- Manual safe mode entry is available to authorised personnel and is tested.
- Safe mode activation tests are carried out and evidence is retained for each trigger.

###### Actions Required for Compliance

- [ ] Create “Safe Mode” profiles that apply {{cp-12_odp.01}} restrictions in each environment, including: an essential allow-list, disabling non-essential functions, blocking remote administration, and using predefined bandwidth limits.
- [ ] Set up detection rules that link each {{cp-12_odp.02}} condition to a safe response: malware detected, loss of file integrity, repeated authentication failures, or loss of command-and-control connectivity.
- [ ] Set up an automated orchestration workflow to apply the Safe Mode Profile to the affected application tiers and supporting infrastructure whenever the defined triggers activate.
- [ ] Use application “safe mode” behaviour (feature flags and routing) to turn off non-essential endpoints and integrations, while keeping essential functions working.
- [ ] During safe mode, restrict network and administrative access by limiting how often requests can be made and by blocking remote administration, using configuration identifiers that can be measured and verified.
- [ ] Create an approved manual “safe mode” procedure (runbook/workflow) and link it to the incident response approval process.
- [ ] For every safe mode entry, create and keep audit records showing: the trigger, the time and date, the profile that was applied, and the restrictions that were enforced. Then run activation tests for each trigger.


---

### CP-13 — Alternative Security Mechanisms (Control)

This expectation is about making sure the organisation can still confirm people’s identities and keep access limited to the most sensitive systems, even if the usual sign-in method fails or is suspected to be compromised. Without a ready fallback, a serious outage or security incident could prevent senior leaders and system administrators from accessing systems, or could allow unauthorised access to privileged accounts and critical services—stopping essential work.

The organisation must set out in its contingency planning when it will use alternative security methods, document exactly which methods it will use, and ensure they are used only for privileged accounts and critical system services. It must provide one-time access codes (one-time pads) to named senior executives, officials, and system administrators. It must also have an emergency way to bypass the usual multi-step sign-in, but only with extra safeguards that are in place during the bypass and that end once the emergency is over.

The organisation must include these steps in its contingency and business continuity plans, configure the systems to support them, assign clear responsibilities, and keep evidence that it has tested the approach and that the results show it works.

##### Break-glass one-time pads for privileged access during MFA failure

- Category: Software
- Priority: Critical

###### WHAT
Set up pre-planned “backup” security options for **secure sign-in and access control for privileged accounts and critical system services** when the main security method is **not available or is suspected to be compromised**. Specifically:
1) Provide **one-time pads** to **named senior executives, officials, and system administrators** for privileged sign-in.
2) Provide an **emergency multi-factor authentication (MFA) bypass** that is only used when specific conditions are met, and is protected by **compensating controls** (limited to a set time, limited to a defined scope, and actively monitored).

###### WHY (control requirement)
National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 **Control CP-13** requires the organisation to **use alternative or additional security measures** for **security functions** when the main way of providing that security function is **not available or is compromised**. It also requires that alternative measures are used only for **critical security capabilities**, may be less effective than the main method, and can be put in place quickly to support mission and business continuity.

###### HOW (specific steps/approach)
###### 1) Define triggers and scope (contingency planning)
- In the organisation’s contingency and continuity planning documents, define clear triggers for using CP-13, such as:
  - Identity provider (IdP) or multi-factor authentication (MFA) outage
  - Suspected compromise of MFA tokens or IdP sign-in processes
  - Loss of access to the main MFA verification method
- Define the **scope**: the backup measures apply only to **privileged accounts** and **critical system services** (as defined in your access control and system criticality documentation).

###### 2) Implement one-time pad issuance and prevent reuse
- Create a pad inventory system (for example, using a secure vault workflow) that records:
  - Pad ID (unique), recipient (named role), issue date/time, issued-by identity, and used/retired status
- Store the pad material in a secure secret store or vault, with access limited to the authorised custodian(s).
- Use **dual control** for issuing (two people approve and handle the pads) and require a ticket or approval record linked to the CP-13 trigger.
- Enforce **no reuse** during sign-in:
  - Sign-in accepts a pad only once by checking the pad ID and immediately marking it as used.
  - Reject any later attempt using the same pad ID.

###### 3) Use pad-based sign-in for privileged access only
- Integrate with the enterprise identity and privileged access management (PAM) process so that pad-based sign-in is allowed only for:
  - The named privileged roles
  - The defined critical system services
- Keep the pad-based sign-in route separate from normal user sign-in to reduce the risk of accidental misuse.

###### 4) Emergency MFA bypass with compensating controls (time-limited and monitored)
- Add an emergency MFA bypass option in the IdP/PAM layer that can only be enabled through the incident process.
- Compensating controls must be active during the bypass, for example:
  - Limit bypass to privileged accounts only
  - Set a time limit (automatic expiry)
  - Increase monitoring and alerts for privileged sign-ins during the bypass
  - Add extra checks where feasible (for example, out-of-band approval or step-up authorisation)
- Ensure the bypass is automatically turned off when the emergency ends (clear expiry condition).

###### 5) Evidence and testing
- Update contingency and continuity plans to include the exact CP-13 procedures for both one-time pads and emergency MFA bypass.
- Run and record at least:
  - One tabletop exercise, and
  - One controlled technical test showing:
    - Trigger detection and authorisation
    - Pad issuance and successful privileged sign-in
    - No-reuse enforcement
    - Bypass enabling, compensating controls activation, and expiry

###### WHO
- **Information Security / Identity and Access Management (IAM) Lead**: defines triggers, scope, compensating controls, and approves CP-13 procedures.
- **Privileged Access / Privileged Access Management (PAM) Administrator**: implements integration and enforcement (pad checking, bypass toggle, scope restrictions).
- **Incident Manager / Security Operations Centre (SOC) Lead**: ensures CP-13 is used only through the defined incident process and records the trigger.
- **System Owner / Business Continuity Owner**: confirms that critical services are covered and that continuity objectives are met.

###### Acceptance criteria
- Contingency and continuity documentation clearly states the CP-13 triggers and that alternative measures apply only to **privileged accounts and critical system services**.
- One-time pads are issued only to **named roles**, using a controlled process with audit records and **dual control**.
- Pad-based sign-in enforces **no reuse** (a pad ID cannot be used for sign-in more than once).
- Emergency MFA bypass can only be enabled through the incident process, is **time-limited**, **scope-limited**, and has **compensating controls** active during the bypass; bypass automatically ends at expiry.
- At least one recorded test/tabletop exercise demonstrates end-to-end operation and produces audit evidence suitable for compliance review.

###### Actions Required for Compliance

- [ ] Define the triggers for CP-13 and document that alternative mechanisms apply only to privileged accounts and critical system services.
- [ ] Set up a one-time pad inventory with uniquely numbered pad IDs, require two people to approve and issue pads (dual control), and record all pad activity in an audit log.
- [ ] Add pad-based authentication to the privileged access process, using a one-time rule that prevents reuse.
- [ ] Set up an emergency multi-factor authentication (MFA) bypass as a separate, time-limited, limited-scope option, with compensating controls and automatic expiry.
- [ ] Update the contingency and business continuity plans to include step-by-step CP-13 procedures for issuing pads and using the emergency bypass.
- [ ] Run and record a controlled test (or tabletop exercise) to demonstrate pad authentication, that codes are not reused, that bypass activation works as intended, that compensating controls are in place, and that access expires as required.

