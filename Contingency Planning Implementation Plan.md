### CP-1 — Policy and Procedures (Control)

This requirement is about making sure the organisation has a clear, written plan for what to do when things go wrong, so services can be restored quickly and everyone understands their responsibilities before an emergency happens. Without an up-to-date contingency planning policy and practical procedures, confusion during a disruption could slow down recovery, increase downtime, and result in failing to meet legal and regulatory obligations.

The organisation must create and document a contingency planning policy and the procedures needed to carry it out. This must explain why the policy exists, what it covers, who is responsible for what, the commitment from senior leadership, how different teams work together, and how the organisation will meet compliance requirements. The policy must also align with all relevant laws, directives, regulations, and internal standards.

The chief information security officer (CISO), or a delegated contingency planning lead, must be formally responsible for developing, documenting, and sharing the policy with the CISO, the chief information officer (CIO), the leads for the security and privacy programme, and the system owners. The CISO (or delegated lead) must also share the procedures with the IT operations managers, the incident response lead, business continuity coordinators, and system administrators.

The policy must be reviewed and updated every year and after any significant change. This includes after security incidents, audit findings, major changes to systems or operational technology, changes in laws, and changes in risk assessments. The procedures must also be reviewed and updated every year and after test results show any shortcomings, after changes to roles or contact details, after changes to recovery capabilities, or after significant changes to network or operational technology architecture.

##### CISO-owned contingency planning policy & role-based procedures suite

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Draft authoritative **Contingency Planning Policy** (purpose/scope/management commitment/coordination security+privacy/roles & responsibilities/compliance alignment/references to procedures) | Compliance Manager | Enterprise | 24h | — |
| Develop **role-based procedure suite** (Recovery Roles & Escalation; Communications & Contact Management; DR Test Management; Post-incident Update Process; OT/Network change impact checklist where applicable) | Security Engineer | Enterprise | 32h | — |
| Establish **Contingency Planning Working Group charter** (membership, decision rights, sign-off workflow, concurrence model, escalation paths) and produce working group meeting cadence template | Project Manager | Enterprise | 12h | — |
| Define **dissemination audiences and evidence requirements** (named recipients for policy vs procedures; acknowledgement/receipt mechanism; retention requirements for audit evidence) | Compliance Manager | Enterprise | 10h | — |
| Implement **controlled-document governance** in the enterprise policy/GRC repository (versioning, access control, publication timestamps, and procedure-to-policy version linkage) | Platform Engineer | Enterprise | 16h | £3,000 |
| Create **review/update triggers and auditable rationale workflow** (annual + event-based triggers; update vs no-update decision record; evidence capture pack) | Data Protection Officer | Enterprise | 14h | — |
| Run **collaborative review and approvals** (Security programme lead + Privacy programme lead concurrence; CISO/delegated lead approval; produce approval record pack and sign-off minutes) | Cyber Security Lead | Enterprise | 18h | — |

Total Estimated Effort: **126h**  
Total Estimated Cost: **£3,000**

###### Actions Required for Compliance

- [ ] Draft and get approval for an organisation-wide business continuity (contingency planning) policy. The policy should be owned by the Chief Information Security Officer (CISO) (or a delegated Contingency Planning Lead) and must clearly state its purpose, coverage, responsibilities, how it will be coordinated, and how it aligns with required compliance obligations.
- [ ] Create role-based contingency planning procedures, including: a policy-to-procedure implementation guide; recovery roles and escalation routes; communications and contact management; disaster recovery testing management; and a process for updating information after an incident.
- [ ] Define and document the distribution lists for policy recipients and procedure recipients, and publish documents through a controlled, version-tracked repository.
- [ ] Create a Contingency Planning Working Group charter, with an approval process that includes sign-off from the Security and Privacy programme leads and agreement from Risk Management.
- [ ] Set review and update schedules: review the policy every year and whenever there is a material change. Review the procedures every year and whenever there are test failures, changes to roles, contacts, or recovery capability, or significant changes to the network or operational technology (OT) architecture.
- [ ] Keep complete, audit-ready records showing collaboration, approvals, sharing, and the decision made for each review or update (including why something was updated or why no update was needed).


---

### CP-2 — Contingency Plan (Control)

This requirement is about having a clear, ready-to-use plan for what to do if a key service stops working, is suspected to be compromised, or simply fails. Without it, essential work could stop, the wrong people might be contacted too late, recovery could be carried out in the wrong order, and the organisation might return to normal in a way that weakens the protections it originally put in place.

The organisation must create a contingency plan that:
- identifies the essential mission and business functions;
- sets recovery goals;
- defines the order for restoring services;
- includes simple ways to track progress;
- names specific people for each role, including their contact details;
- explains how essential functions will continue during disruption; and
- explains how full restoration will be completed later, without reducing the protections that were planned.

The plan must also set out how contingency information will be shared. It must be reviewed by the Chief Information Security Officer and the System Security Officer, and approved by the Authorising Official.

Copies of the plan must be given to the security operations centre (SOC), network operations centre (NOC), IT Operations, and the continuity of operations (COOP) team. Updates must be communicated to the SOC Manager, NOC Manager, System Owner, COOP Lead, and relevant teams.

The plan must be reviewed at least every year, updated when changes or issues arise, include lessons learned from testing and training, coordinate with incident handling, and be protected from unauthorised viewing or changes.

##### Single approved COOP contingency plan with named contacts & metrics

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Produce essential-function inventory for the application (mission/business functions, dependencies, IT/OT capabilities, and dependency mapping) | System Design Authority | Enterprise | 24h | — |
| Define restoration priorities and degraded/fallback/manual modes per essential function (including start/stop criteria and alternate information flows) | System Design Authority | Enterprise | 28h | — |
| Establish recovery objectives and measurable recovery metrics (RTO/RPO targets, objective recovery checks, and validation evidence requirements) | Compliance Manager | Enterprise | 20h | — |
| Draft the single authoritative COOP contingency plan document (structure, roles/responsibilities, activation triggers, restoration workstreams, and security-preserving restoration guidance) | Project Manager | Enterprise | 24h | — |
| Implement named contingency roles with contact details and escalation paths (including out-of-hours procedures and handoffs to SOC/NOC/IT Operations) | Operations Lead | Enterprise | 16h | — |
| Coordinate and align with incident handling (activation triggers, breach vs availability failure decisioning, and explicit non-conflict handoffs to incident response) | Cyber Security Lead | Enterprise | 18h | — |
| Governance, controlled distribution, and review evidence pack (CISO/SSO review, AO approval workflow, annual review cadence, access controls, and change history) | Compliance Manager | Enterprise | 22h | — |

Total Estimated Effort: **152h**  
Total Estimated Cost: **£0**

###### Actions Required for Compliance

- [ ] Create a list of the application’s essential functions and link each one to the required dependencies and capabilities.
- [ ] For each essential function, define what the degraded, fallback, and manual modes are, how information will flow in each case, and the conditions that trigger each mode.
- [ ] Set recovery time objective (RTO) and recovery point objective (RPO) targets and define restoration priorities for each essential function, and add measurable recovery measures and checks.
- [ ] Document the contingency roles, listing named contacts for each role (security operations centre (SOC) manager, network operations centre (NOC) manager, system owner, and continuity of operations (COOP) lead) and the escalation routes to follow.
- [ ] Set up incident-handling coordination, including what triggers activation, how responsibilities are handed over, and how contingency actions differ between a suspected security breach and an availability failure.
- [ ] Put controlled access in place for the contingency plan and limit who can view and distribute it to the security operations centre (SOC), network operations centre (NOC), IT Operations, and the continuity of operations plan (COOP) team.
- [ ] Arrange and record an annual review by the Chief Information Security Officer (CISO) and the Senior Security Officer (SSO), obtain approval from the Authorising Officer (AO), and keep an auditable record of any changes.


---

#### CP-2.1 — Coordinate with Related Plans (Enhancement)

This requirement is about making sure your disruption and recovery plans are developed together, not separately. If your business continuity, disaster recovery, continuity of operations, crisis communications, critical infrastructure plans, incident and breach response, insider-threat actions, data-breach response, and building emergency plans are not coordinated, teams may act at the wrong time, contact the wrong people first, give conflicting instructions, or leave responsibilities uncovered—turning a manageable disruption into a longer, more expensive problem.

To meet this expectation, the organisation must:
- identify who is responsible for each related plan,
- name specific people to coordinate the work, and
- include people who handle information in the planning discussions.

When the contingency plan is created, these responsible owners must provide input so that the triggers for action, escalation routes, roles, handovers, and procedures are consistent across all documents.

The organisation must also keep evidence that this joint work has been done, and maintain a repeatable process to review and update the plans together whenever changes occur.

##### Plan-of-plans coordination for contingency planning (CP-2(1))

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Establish the standing “Contingency Plan Coordination” working group (terms of reference, membership list, meeting cadence, escalation for coordination issues) | Project Manager | Enterprise | 8h | — |
| Develop and approve a RACI (or equivalent) mapping contingency plan roles to named owners of each related plan (BCP/DR/CoOP/Crisis Comms/Critical Infrastructure/Cyber IR/Insider Threat/Data Breach/Breach Response/Occupant Emergency) | Compliance Manager | Enterprise | 16h | — |
| Run joint drafting walkthroughs/tabletop exercises for agreed disruption scenarios and produce scenario alignment outputs (triggers, escalation order/decision rights, roles, handoffs, communications approvals) | BCM/DR Lead (Contingency Planning Lead) | Enterprise | 32h | — |
| Create and embed a consistency checklist into the contingency plan template/workflow (references to related plans; cross-checks for triggers, escalation routes, roles, handoffs, procedures) | System Design Authority | Enterprise | 24h | — |
| Produce coordination evidence pack for audit readiness (meeting minutes, sign-offs by related-plan owners, tracked changes, issues log with resolution or scheduled actions) | Compliance Manager | Enterprise | 20h | — |
| Define and document joint review/update cadence (at least annual, plus invocation when related plans change) including triggers for re-coordination and ownership for updates | Project Manager | Enterprise | 12h | — |
| Conduct final cross-plan alignment sign-off session and confirm contingency plan references are complete and consistent across all related plans | BCM/DR Lead (Contingency Planning Lead) | Enterprise | 12h | — |

**Total Estimated Effort:** 124h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Set up a Contingency Plan Coordination working group and appoint named representatives from each organisation responsible for a related plan.
- [ ] Create and approve a RACI (responsible, accountable, consulted, informed) contingency plan that assigns an owner to each role for every related plan listed in the CP-2(1) guidance.
- [ ] Set out standard disruption scenarios and hold joint tabletop walkthroughs while drafting the contingency plan, with clear handover points.
- [ ] Update the system contingency plan template and workflow so that each plan must (1) link to the related plans it connects to, and (2) include a completed consistency checklist covering triggers, escalation, responsibilities, handovers, and procedures.
- [ ] Collect and keep evidence that coordination took place, such as meeting minutes, approvals (sign-offs), tracked changes, and an issues log showing how each issue was resolved or the dated actions taken.
- [ ] Set up and document a shared review schedule. When any related plan changes, it should trigger coordinated updates to the system contingency plan.


---

#### CP-2.2 — Capacity Planning (Enhancement)

This expectation is about making sure the organisation has enough “spare capacity” to keep essential services running during an emergency, even if performance is worse than normal. Without careful planning, the organisation could end up lacking the computing power needed to handle critical information, the communications capacity needed to keep people and customers connected, or the environmental support needed to keep key facilities operating (such as power, cooling, or other essential site services). This could lead to delays or failure when it matters most.

To meet this expectation, the organisation must plan in advance for emergency conditions by:
- defining what “necessary capacity” means,
- identifying the likely degraded conditions, and
- using its risk assessment, the system’s importance level, and its tolerance for risk to set capacity targets for information processing, telecommunications, and environmental support.

It must record these results in the relevant planning documents, link them to the contingency procedures, assign named responsibilities, involve those with information security responsibilities, and keep evidence that the plans were reviewed and approved.

##### Risk-based contingency capacity targets for IT processing, comms, and facilities

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Establish scope, inputs, and linkage requirements (contingency plan/procedures, system security plan, system impact level, RTO/RPO, risk tolerance) and confirm named owners/responsibilities | Project Manager | Enterprise | 8h | — |
| Derive contingency degradation scenarios from the contingency plan and risk assessment (e.g., reduced compute headroom, constrained WAN bandwidth, increased latency, degraded backup throughput, degraded UPS/generator/cooling) and document assumptions | Business Continuity Manager | Enterprise | 16h | — |
| Define “necessary capacity” targets per essential function and degraded scenario, aligned to impact level and organisational risk tolerance (measurable thresholds for availability, performance degradation, RTO/RPO-aligned throughput/job completion) | Compliance Manager | Enterprise | 24h | — |
| Create capacity resource mapping across information processing, telecommunications, and environmental support (CPU/memory headroom, storage IOPS/throughput, queue/concurrency limits; bandwidth/session/DNS/remote access capacity; UPS/generator runtime and cooling/power constraints) | Infrastructure/Platform Engineering Lead | Enterprise | 24h | — |
| Calculate and document contingency capacity targets for each scenario and contingency duration (including minimum capacity required, calculation method, evidence of alignment to risk assessment, and scenario-by-scenario target tables) | Infrastructure/Platform Engineering Lead | Enterprise | 32h | — |
| Produce the auditable capacity planning record and ensure traceability (assumptions, calculations, targets, scenario definitions, ownership, and explicit links to contingency procedures and system security plan) | Business Continuity Manager | Enterprise | 16h | — |
| Implement review/approval cadence and evidence capture (information security review, system owner sign-off, periodic re-approval triggers for major changes; store evidence in the governance repository) | Compliance Manager | Enterprise | 16h | — |
| Validate operational usability of targets (walkthrough with contingency execution owners; confirm how targets will be used during contingency operations and what evidence will be recorded during execution) | Service Delivery Manager | Enterprise | 8h | — |

**Total Estimated Effort:** 144h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Identify the key mission and business functions, and the backup scenarios that could reduce performance in processing, communications, and environmental support.
- [ ] Set clear, measurable targets for reduced (degraded) capacity to support information processing, telecommunications, and environmental services, matched to the agreed impact level and risk tolerance.
- [ ] Assign each essential function to the specific capacity resources it needs (processing power, storage, input/output performance, user sessions, network bandwidth and domain name system (DNS), and limits for uninterruptible power supply (UPS), generators, cooling, and power).
- [ ] For each degraded scenario, calculate the minimum contingency capacity needed for the required contingency period, and record the assumptions and results.
- [ ] Link the capacity planning record to the contingency plan and procedures, and to the system security plan. Record the named people responsible for each task.
- [ ] Carry out and record an information security review, and obtain formal approval (sign-off) for the capacity targets and supporting documents (artefacts).
- [ ] Carry out regular reviews of capacity targets, and also review them whenever changes are triggered, so they stay up to date with system and infrastructure changes.


---

#### CP-2.3 — Resume Mission and Business Functions (Enhancement)

This requirement is about making sure the organisation can quickly restart its most important work after a serious disruption. If the contingency plan is used, but there is no clear, ready-to-use way to restart the essential mission and business functions within 24 hours, customers may not be able to access services, critical work could be delayed, and the organisation could face legal, financial, or reputational damage.  

To meet this expectation, the organisation must first identify and document which mission and business functions are essential, and set a goal to restore them within 24 hours of activating the contingency plan. It must also have a documented restart plan that begins immediately when the contingency plan is triggered, clearly names the people responsible for carrying out the work, and includes those responsible for information protection and privacy.  

The plan must be based on the organisation’s impact assessment, match its security and privacy requirements, refer to any related plans or records, and set out the steps for restarting operations so the organisation can demonstrate that it is planned to achieve the 24-hour target.

##### 24-hour resumption plan for essential functions on contingency activation

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm scope and acceptance criteria for “essential functions” and the 24-hour resumption target (including definitions of T+0, T+2h, T+8h, T+24h) | Business Continuity Manager | Enterprise | 8h | — |
| Produce authoritative list of essential mission/business functions from BIA outputs and map each to minimum viable services and supporting application components (including dependencies) | Business Continuity Manager | Enterprise | 16h | — |
| Draft per-essential-function resumption procedures with step-by-step recovery processes, intermediate milestones, rollback/containment steps, and explicit start trigger on contingency plan activation timestamp/event | Service Delivery Manager | Enterprise | 40h | — |
| Define named responsibilities and coverage model for recovery execution, including explicit information security and privacy decision-making roles (emergency access approvals, logging/monitoring posture, data handling constraints) | Compliance Manager | Enterprise | 16h | — |
| Align each resumption procedure to security/privacy requirements (least privilege, encryption expectations, logging/monitoring, data minimisation/retention handling during recovery) and reference relevant enterprise standards/policies | Information Security Lead | Enterprise | 24h | — |
| Implement activation-to-execution mechanism in the contingency activation workflow (runbook selection/issuance, ticket/incident creation, assignment of recovery owners, and time-stamped evidence capture requirements) | Operations Lead | Enterprise | 24h | — |
| Run tabletop exercise(s) to validate executability against the 24-hour objective and produce audit-ready evidence pack (time-to-first-service metrics, actions taken, gaps, and remediation actions) | Project Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 152h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Confirm the official list of the essential mission and business functions, using outputs from the business impact analysis (BIA).
- [ ] Create a restart plan for each critical business function. Include a starting point for when the contingency plan is activated and set milestone targets for every 24 hours.
- [ ] Assign named, accountable roles for each essential function, including clear information security and privacy responsibilities.
- [ ] Review and update each resumption procedure so it matches the system security plan and privacy requirements, including least-privilege access, logging and monitoring, and limits on how data can be handled.
- [ ] Set up a process that moves from activation to execution, automatically continues the correct recovery steps, and records time-stamped proof.
- [ ] Run at least one tabletop exercise to test the restart procedures, and record evidence showing they meet the 24-hour target.


---

#### CP-2.5 — Continue Mission and Business Functions (Enhancement)

This requirement is about making sure the organisation can keep its most important work running even if key systems or storage locations fail. It also requires that the organisation does not stop its emergency arrangements until everything is fully back to normal at its main sites.

Without this, an incident could cause essential services to stop, delay critical decisions or payments, or force staff to improvise without a clear plan—leading to avoidable losses and reputational damage.

The organisation must:
- identify which mission and business functions are essential
- create and keep up to date a contingency plan and supporting procedures showing how those essential functions will continue with minimal or no day-to-day disruption
- define its main processing and storage sites for contingency purposes, and allow these to change if circumstances require it
- document agreements for both primary and backup sites
- assign clear responsibilities to named individuals, including those who understand the essential functions and those responsible for information security
- test the plan and record the results

Business continuity must continue until full restoration is confirmed at the defined primary processing and/or storage sites.

##### Essential-function continuity plan with primary-site restoration gates

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Establish and maintain the essential-function register (cp-02.05_odp = essential), including mapping to required application components and supporting services (identity, authorisation, messaging, databases, storage, monitoring/logging) | Business Continuity Manager | Enterprise | 40h | — |
| Define primary processing and primary storage sites for contingency purposes, including workload/data-domain mapping and a controlled mechanism to change contingency sites (decision criteria, approval workflow, version control) | System Design Authority | Enterprise | 32h | — |
| Produce continuity procedures and runbooks for essential functions: disruption detection/escalation, activation steps, communications plan, named roles/responsibilities (incl. information security), and operational instructions for alternate-site operation | Compliance Manager | Enterprise | 56h | — |
| Implement “full system restoration” return gates at the named primary processing and/or primary storage sites (testable criteria for service health and data integrity/consistency, incl. replication lag thresholds and integrity checks) | Security Engineer | Enterprise | 40h | — |
| Document and maintain site agreements (primary/alternate processing and storage) covering activation triggers, responsibilities, security expectations, capacity assumptions, and review/refresh dates | Service Delivery Manager | Enterprise | 24h | £6,000 |
| Integrate contingency approach into security planning: update system security plan and related security documentation to reference continuity arrangements and confirm security control continuity during disruption and return (access management, logging/monitoring, privileged access handling) | Data Protection Officer | Enterprise | 32h | — |
| Execute tabletop-to-live continuity testing and evidence pack: validate activation timing, sustainment, correct termination only after return gates; record results, deviations, corrective actions, and closure evidence | Project Manager | Enterprise | 64h | £12,000 |

**Total Estimated Effort:** 288h  
**Total Estimated Cost:** £18,000

###### Actions Required for Compliance

- [ ] Create and keep a record of the essential mission and business functions, and link each one to the required applications and supporting services.
- [ ] Identify the primary processing site and the primary storage site for contingency purposes, and define an approved process for updating them when circumstances change.
- [ ] Create continuity procedures (runbooks) for each essential function, covering how to activate and operate it, how communications will work, and who is responsible for each task (including input from information security).
- [ ] Set clear, testable “full system restoration” stop points (return gates) at the main processing and/or main storage sites, and do not shut down the backup or alternate operations until those stop points are met.
- [ ] Create and keep up to date site agreements for primary and backup processing and for primary and backup storage. Include the conditions that trigger activation, who is responsible for what, and the dates for scheduled reviews.
- [ ] Run at least one tabletop exercise that is followed by a live continuity test, record the results and any deviations, and complete corrective actions to demonstrate readiness.


---

#### CP-2.6 — Alternate Processing and Storage Sites (Enhancement)

This requirement is about ensuring the organisation can continue its most important work somewhere else if its main sites become unavailable, and then return to the original sites only after they are fully ready again. Without this, a disruption could stop key services for customers, employees, or regulators, leading to serious financial loss, reputational damage, and operational chaos.

The organisation is expected to:
- identify which mission and business functions are essential
- create and document a clear plan to move those functions to specific alternate processing and/or storage sites with little or no interruption
- keep running the essential functions at the alternate sites until the original sites are fully restored

The organisation must also:
- assign named responsibilities
- involve people with information security responsibilities
- complete a business impact analysis to support what is considered essential
- put practical agreements in place with the alternate sites
- test the plan and record the results

Finally, the organisation must keep the relevant planning and security information up to date, including how the move back to the primary sites will be handled.

##### Alternate-site transfer plan with secure IT failover and switch-back gates

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Derive essential-function scope from BIA outputs and map “essential” functions (cp-02.06_odp) to concrete application components and dependencies (identity, monitoring, logging, backup, messaging, integrations) | Compliance Manager | Enterprise | 24h | — |
| Select and document alternate processing/storage sites and define transfer boundaries per component (including connectivity paths, DNS/service endpoints, security service forwarding requirements) | System Design Authority | Enterprise | 32h | — |
| Produce the auditable alternate-site transfer plan/runbook with activation triggers, roles/RACI, failover sequence, sustainment procedures, and explicit switch-back criteria (evidence requirements and approval gates) | Project Manager | Enterprise | 40h | — |
| Implement identity-integrated access controls for contingency and automation (conditional access, privileged phishing-resistant MFA, least privilege, service/workload identity, break-glass process) | Data Protection Officer | Enterprise | 48h | — |
| Configure secure failover/switch-back automation using infrastructure-as-code and orchestration runbooks (network rules, routing/DNS changes, deployment/config baselines, database/storage failover steps, evidence capture) | DevOps Lead | Enterprise | 72h | £18,000 |
| Ensure security logging, monitoring/observability, and audit evidence retention during failover and switch-back (SIEM forwarding, admin action logging, validation dashboards, tamper-evident evidence store) | Security Engineer | Enterprise | 40h | £6,000 |
| Execute tabletop exercise and at least one technical failover + controlled switch-back test with recorded evidence, deviations, corrective actions, and plan updates | Quality Assurance Lead | Enterprise | 32h | — |
| Establish ongoing plan governance (version control, change management hooks, periodic review cadence, and trigger-based updates after infrastructure/app/security changes) | Operations Lead | Enterprise | 24h | — |

Total Estimated Effort: **312h**  
Total Estimated Cost: **£24,000**

###### Actions Required for Compliance

- [ ] Map **CP-02.06** essential mission and business functions to specific application parts and their dependencies, using the outputs from the business impact assessment (BIA).
- [ ] For each essential function, choose and document an alternative processing and/or storage site, including the required network connections and the security service endpoints.
- [ ] Create an alternate-site transfer plan (runbook) that includes: the conditions that trigger activation, clearly named responsibilities, the step-by-step failover order, ongoing support procedures, and clear approval checkpoints for switching back.
- [ ] Set up automated failover handling that uses infrastructure and configuration “as code” plus step-by-step runbook instructions, and that records proof (evidence) of what was done and the checks used to confirm it worked.
- [ ] Set up identity-based access controls for contingency plans (conditional access, least privilege, phishing-resistant multi-factor authentication for privileged access, and workload identities for automated tasks) and confirm they work correctly at alternate sites.
- [ ] Carry out regular failover and return-to-normal tests, record the results, and update the plan with corrective actions until the return-to-normal requirements are consistently met.


---

#### CP-2.7 — Coordinate with External Service Providers (Enhancement)

This requirement is about making sure your plans for coping with disruption still work when key services are provided by outside organisations. If you depend on another organisation for services such as hosting, managed information technology, payments, or customer support, that organisation’s ability to recover and keep operating will directly affect whether your own essential services can continue. Without coordination, you may only find out too late that their recovery times, responsibilities, or communication steps do not meet your needs.

To meet this expectation, the organisation must:
- identify every external provider it relies on during disruption;
- share the specific parts of its disruption plans that relate to those providers; and
- work with each provider to align the timing, responsibilities, and readiness needed to meet your recovery objectives.

The organisation should keep clear, dated records showing these agreements and reviews, make sure the right internal people are involved (including those responsible for protecting information), and confirm that any commitments in contracts support the disruption expectations.

##### Provider contingency annexes aligned to organisational recovery needs

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Identify and prioritise critical external providers (service inventory for disruption scenarios) and confirm which services require contingency alignment | Project Manager | Enterprise | 24h | — |
| Map organisational contingency requirements (RTO/RPO, escalation/notification windows, restoration responsibilities, assumptions/constraints) to each provider’s service components | Compliance Manager | Enterprise | 32h | — |
| Produce Provider Contingency Annex template (contractual schedule) including minimum required clauses: scope/scenarios, RTO/RPO, responsibilities, escalation/communications, constraints, evidence/assurance, and audit rights | Compliance Manager | Enterprise | 40h | — |
| Negotiate annexes and obtain formal sign-off for each critical provider; document agreed alignment outcomes or approved workarounds/alternatives | Procurement Contract Owner | Enterprise | 56h | £18,000 |
| Create and maintain auditable coordination register linking annexes to contingency plan sections, contract versions, sign-off dates, and named coordination participants | Business Continuity/Disaster Recovery Lead | Enterprise | 24h | — |
| Run and record table-top coordination exercises per critical provider (or after material service changes), capture gaps, and drive remediation or formal risk acceptance | Security Engineer | Enterprise | 48h | £6,000 |
| Establish ongoing review cadence (e.g., annual/after major change) and version control process for annex updates, evidence collection, and assurance summaries | Operations Lead | Enterprise | 24h | — |

**Total Estimated Effort:** 248h  
**Total Estimated Cost:** £24,000

###### Actions Required for Compliance

- [ ] Identify and record all external service providers whose services are needed to keep essential business functions running during a disruption.
- [ ] Match each provider’s service components to the organisation’s contingency requirements, where applicable including recovery time objective (RTO), recovery point objective (RPO), notification time windows, and expectations for restoring services.
- [ ] Create a “Provider Contingency Annex” template that sets out the recovery targets, who is responsible, the escalation contact details, and the communication timeframes.
- [ ] Negotiate with each critical provider, obtain formal approval, and securely store the signed annexes for each one.
- [ ] Collect evidence from each provider showing how often their business continuity and disaster recovery (BCP/DR) tests are carried out, and the results (or equivalent assurance), and record this in an auditable coordination log.
- [ ] For each critical service provider, run a scenario-based coordination exercise (or do so after any major service changes). Record the results, any gaps found, and either the fixes required or the decision to accept the remaining risk.


---

#### CP-2.8 — Identify Critical Assets (Enhancement)

This requirement is about making sure the organisation clearly identifies which systems and day-to-day activities are truly vital to keeping essential services running when something goes wrong. Without this, the organisation may spend time and money protecting the wrong things, or only realise too late that a key computer service, supporting tool, manual process, or the people who carry it out is missing from the emergency plans—causing avoidable disruption to the mission and business activities.

To meet this expectation, the organisation must first define which mission and business functions are considered essential. It must then identify the critical assets that support those functions, covering both:
- the technical parts (for example, key system components, services, products, and the mechanisms that make them work)
- the operational parts (for example, manual procedures and the people responsible for carrying them out)

This identification must be based on business impact and business continuity planning inputs, recorded in organisational documents, and used to guide contingency planning. That includes setting named responsibilities, relevant policies and procedures, and plans that reference and manage these critical assets during contingency operations, so resources are prioritised appropriately.

##### Critical assets register linking essential functions to IT/OT assets

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define scope of “essential” functions for `cp-02.08_odp = essential`, including function list and rationale mapped to BIA/criticality analysis inputs | Compliance Manager | Enterprise | 16h | — |
| Create asset taxonomy and traceability schema (technical vs operational asset types, identifiers, contingency operation categories, evidence/source fields) | System Design Authority | Enterprise | 24h | — |
| Map essential functions → supporting capabilities → critical technical assets (multi-tier components, identity services, data stores, backup/restore mechanisms, monitoring/alerting, network services, and other required mechanisms) | IT/OT Architecture & DR/BCP Lead | Enterprise | 32h | — |
| Identify and document supporting operational assets for each essential function (runbooks/procedures, escalation/approval steps, named roles/teams, vendor contacts where applicable) | Operations Lead | Enterprise | 24h | — |
| Build the auditable Critical System Assets Register (including traceability links to BIA/architecture/security plan sections and contingency procedures) | Project Manager | Enterprise | 40h | — |
| Establish governance: update triggers, review cadence, change/configuration management integration, and evidence capture for at least one review cycle | Compliance Manager | Enterprise | 24h | — |
| Ensure contingency planning/procedures reference register entries and prioritise recovery actions accordingly (DR failover, degraded-mode, manual workarounds) | Security Engineer | Enterprise | 24h | — |
| Validate external dependencies: confirm critical assets provided by external service providers are identified and traceable to contingency operations (where applicable) | Data Protection Officer | Enterprise | 12h | — |

**Total Estimated Effort:** 196h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Define and document the application’s key purpose and business functions, using inputs from business impact analysis (BIA) and criticality analysis.
- [ ] Create a clear list of critical assets, including both the technical safeguards and the operational processes and responsibilities (roles).
- [ ] Update the Critical System Assets Register so each entry can be traced back to the Business Impact Assessment (BIA) and to the relevant contingency plan or procedure sections.
- [ ] Assign an owner (a named team or person) for every operational procedure and for every critical technical mechanism.
- [ ] Set up governance with a regular review schedule and clear triggers for when changes or configuration updates happen, so the register stays up to date.
- [ ] Update the contingency plans and recovery procedures to point to the register, and prioritise recovery actions in line with it.
- [ ] Identify any outside service providers that are relied on for critical assets, and where relevant, make sure this matches control CP-2(7).


---

### CP-3 — Contingency Training (Control)

This requirement is about making sure people know exactly what to do when the organisation has to switch to emergency or backup ways of working. Without regular, role-specific contingency training, staff may not know where to report, which duties to prioritise, or how to carry out critical tasks away from the usual site. This could slow recovery and increase the impact of an incident, outage, or other disruption.

The organisation must provide the right contingency training to each person within 30 days of them taking on a contingency role. It must repeat the training at least once every year, and re-train people when systems or working arrangements change. The organisation must also review the training materials every quarter, and update them after contingency tests or exercises (including lessons learned), after audit or assessment findings, after security incidents or breaches, and after changes to relevant laws, directives, regulations, policies, standards, or guidance.

The organisation should keep records showing who was trained, when they were trained, and what was updated.

##### Automate role-based contingency training with trigger-driven updates

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define contingency role catalogue and plain-language role descriptions mapped to mission-essential functions (version-controlled document) | Business Continuity Manager | Enterprise | 24h | — |
| Create role-to-training matrix mapping each contingency role to module(s), including module granularity and assignment rules | Compliance Manager | Enterprise | 20h | — |
| Configure enterprise learning platform automation: role-triggered enrolment, 30-day completion timer, annual refresh with expiry/recertification dates, and completion status reporting | Training/HR Learning Operations Lead | Enterprise | 56h | £18,000 |
| Implement quarterly content review workflow in the platform: review assignments to content owners, version incrementing, change logging, and impacted-role identification for re-enrolment | Platform Engineer | Enterprise | 48h | £6,000 |
| Integrate trigger-driven update events (exercise/lessons learned, audit findings, security incidents/breaches, policy/standards/legal changes) into the training workflow with traceability to affected modules/roles | DevOps Lead | Enterprise | 64h | £12,000 |
| Build audit-ready evidence model and reporting: training completion records (person/module/version/date) and content review/update history (quarterly outcomes, version history, trigger/event cause) with export/report templates | Data Protection Officer | Enterprise | 32h | — |
| Conduct end-to-end testing and acceptance: simulate role assignment, initial 30-day completion, annual refresh, quarterly review updates, and each trigger event; remediate gaps and produce implementation sign-off pack | Quality Assurance Lead | Enterprise | 40h | — |
| Operational readiness: runbooks, admin guides, monitoring/alerting for overdue completions and failed re-enrolments, and staff training for content owners and learning ops | Operations Lead | Enterprise | 24h | £3,000 |

**Total Estimated Effort:** 308h  
**Total Estimated Cost:** £39,000

###### Actions Required for Compliance

- [ ] Create a contingency role catalogue and clearly define each role’s responsibilities in line with the contingency plan.
- [ ] Create a role-to-training matrix that links each contingency role to the specific training modules it must complete, including the required level of detail for each module.
- [ ] Set up the enterprise learning platform to automatically enrol people assigned to contingency roles, and require course completion within 30 days.
- [ ] Set up annual review tasks and expiry dates for re-certification for all users who have contingency roles.
- [ ] Set up a quarterly process to review content, track module version changes, and identify which roles are affected.
- [ ] Use trigger events (training exercises and lessons learned, audit findings, security incidents, and legal or policy changes) to start a review and update of the module, and to re-enrol participants.
- [ ] Set up audit-ready records for training completion (who completed it, what training it was, which version, and when) and for content review and updates (what was changed, when it was changed, and why).


---

#### CP-3.1 — Simulated Events (Enhancement)

This requirement is about ensuring people practise real crisis situations, not just discuss them. By running realistic simulated events during contingency training, staff can learn how to respond quickly and correctly when problems occur, such as a website going offline, data being locked up in a ransomware-style incident, severe weather damaging or destroying facilities, or critical equipment and software failing.  

To meet this expectation, the organisation must define a set of realistic simulated crisis scenarios and include them in its contingency training curriculum and materials. The training must match what is set out in its contingency planning policy, contingency plan, and system security plan.  

Staff responsible for planning and carrying out the response, as well as those with information security responsibilities, must take part in these scenario-based exercises. The organisation must also keep records showing which scenarios were used and what happened, including the outcomes from post-exercise reviews and the improvements fed back into future training and relevant plans.

##### Simulated crisis injects for contingency training (cyber, ransomware, outage)

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define exercise scope and scenario-to-policy mapping (CP-3(1) enhancement): document alignment to contingency planning policy, contingency plan, training curriculum/materials, and system security plan | Compliance Manager | Enterprise | 24h | — |
| Design “inject orchestrator” control plane architecture (training-safe boundaries, tagging, start/stop, escalation triggers, rollback/cleanup approach) and produce implementation runbook | System Design Authority | Enterprise | 32h | — |
| Build scenario packs for at least 3 scenarios (cyber disruption, ransomware-style training impact, major hardware/software failure) with explicit participant actions, observable indicators, and verification/cleanup steps | Software Lead | Enterprise | 56h | — |
| Implement training-safe execution mechanisms in segregated environments (e.g., edge/DNS routing to maintenance endpoint; training dataset access-lock/rename simulation; controlled service stop/failover with monitoring gaps) | Platform Engineer | Enterprise | 64h | — |
| Integrate orchestrator with monitoring/SIEM and ticket/incident channels using “training” event tagging (ensure detection/triage workflows are exercised without polluting production incident metrics) | DevOps Lead | Enterprise | 40h | — |
| Implement evidence capture and improvement loop (inject timeline logging, participant/role evidence hooks, automated post-exercise verification checklist, debrief template, corrective action tracking) | Quality Assurance Lead | Enterprise | 24h | — |
| Run at least one full end-to-end exercise and produce audit-ready evidence pack (scenario used, timeline, actions, outcomes, debrief findings, improvements fed into plans/materials; attendance/role logs) | Project Manager | Enterprise | 32h | — |
| Tooling hardening and governance (change/config management for training stacks, access controls for orchestrator, secure-by-design review, and rollback assurance testing) | Security Engineer | Enterprise | 24h | £6,000 |

**Total Estimated Effort:** 296h  
**Total Estimated Cost:** £6,000

###### Actions Required for Compliance

- [ ] Define and document a set of simulated crisis scenarios that are safe for training. Link these scenarios to the contingency planning policy, the contingency plan, the training curriculum and materials, and the system security plan.
- [ ] Create an exercise “inject” controller that starts scheduled cyber disruption events, simulates ransomware-style data damage, and triggers hardware and software failure events within separate training and disaster recovery (DR) environments.
- [ ] Implement “cyber disruption” by using controlled edge and domain name system (DNS) routing to temporarily put services into a maintenance or unavailable state, with automatic rollback to restore normal operation if needed.
- [ ] Use ransomware-style “injections” in a controlled test using a dedicated training dataset, and temporarily remove access permissions to mimic the same kind of “data becomes unavailable” effect—without encrypting any real business data.
- [ ] Use controlled service stops and failovers to simulate major outages in non-production and training environments, with monitoring in place and clear decision points for when to recover.
- [ ] Run at least one complete scenario-based contingency exercise, with contingency and implementation staff and information security staff taking part. Record who attended and keep evidence showing which roles participated.
- [ ] Record exercise logs, capture the results of debriefs and any corrective actions, then update training materials and the relevant plans as part of the improvement loop.


---

#### CP-3.2 — Mechanisms Used in Training Environments (Enhancement)

This expectation is about making emergency practice feel like the real situation, by using the same everyday ways of working that the organisation already relies on. Without this, training can become a “paper exercise”, leaving staff unsure what to do when a real disruption happens. That increases the risk of slow or incorrect decisions, actions being missed, and poor coordination during incidents that affect customers, services, or critical operations.

To meet this expectation, the organisation should set out in its contingency planning policy how it will use real working processes, systems, and facilities to create realistic simulated events. It should then reflect this approach in its contingency plan, training programme, and training materials. The organisation should also clearly name the people responsible for planning, running, and delivering the training, make sure the training follows the planned approach, and keep records showing which real operational methods were actually used and how they improved realism, including any justified reasons where something could not be reused.

##### Training-mode execution using real workflows, systems and facilities

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define training-mode architecture pattern (segregated access paths, environment flags, URL/tenant/namespace separation, workflow reuse rules, and “no production writes” guardrails) | System Design Authority | Enterprise | 40h | — |
| Implement training-mode configuration in the application and supporting services (routing, queue/workspace separation, sandbox/synthetic data handling, feature flags, and safe workflow execution paths) | Platform Engineer | Enterprise | 80h | — |
| Implement identity and access controls for training participants (time-bound least-privilege roles via enterprise IdP, MFA enforcement, approval workflow, and training-mode account lifecycle) | Security Engineer | Enterprise | 48h | — |
| Implement audit-ready evidence capture (workflow audit trails, application logs, comms delivery receipts, exercise run logs; plus evidence schema and retention alignment) | Cyber Security Lead | Enterprise | 56h | £15,000 |
| Build scenario-to-mechanism mapping and facilitator tooling (runbook step tagging, mechanism reference templates, realism delta section in after-action reporting, and validation checks) | Compliance Manager | Enterprise | 32h | — |
| Execute end-to-end pilot exercise in training mode and verify acceptance criteria (mechanism invocation proof, zero production record impact testing, evidence completeness, and remediation actions) | Service Delivery Manager | Business Unit | 24h | £5,000 |
| Operationalise governance for repeated exercises (change/config management for training-mode, runbook version control, periodic access review, and lessons-learned update cycle) | Project Manager | Enterprise | 24h | — |

Total Estimated Effort: **304 Hours**  
Total Estimated Cost: **£20,000**

###### Actions Required for Compliance

- [ ] Set up a training-mode configuration that uses the same workflows and screens as production, but blocks any changes to production customer, financial, and other regulated records.
- [ ] Create scenario runbooks that map every step to the exact operational method to be used (the workflow step, escalation route, communication channel, and reporting template).
- [ ] Create synthetic (sandbox) test data and make sure the simulated events are entered into the same operational forms and reporting tools used during real operations.
- [ ] Set up time-limited, least-privilege training access through the organisation’s identity provider, using strong authentication and recording all required activity in logs.
- [ ] For each exercise run, collect and record audit evidence, including workflow audit trails, application logs, and communications delivery receipts.
- [ ] Require after-action reports to include a “realism delta” section that documents the methods used, any intentional differences, and the reasons for those differences.


---

### CP-4 — Contingency Plan Testing (Control)

This requirement is about making sure your organisation’s emergency back-up plans are not just written down, but actually work when something goes badly wrong. Without regular testing, a plan may look fine on paper yet fail in practice, which can stop day-to-day operations, put important assets at risk, and prevent people from carrying on their work during a disruption.

To meet this expectation, the organisation must test its contingency plan at least once every quarter. Testing must use a mix of:
- checklist reviews,
- walk-throughs, and
- parallel tests,

to judge how effective the plan is. It must also use:
- tabletop exercises, and
- full interrupt simulations (a complete disruption test),

to confirm the organisation is ready to carry out the plan.

After each quarterly test, the organisation must review the results, record what was tested and what happened, decide whether any weaknesses or failures were found, and start corrective actions when needed. The organisation must also assign clear responsibilities to specific people for running the tests and reviewing the outcomes, including people with information security responsibilities.

##### Quarterly contingency plan testing with evidence-led remediation

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define quarterly contingency testing scope and cadence per system (quarter-to-test-type mapping) including minimum evidence requirements | Project Manager | Enterprise | 24h | — |
| Develop and approve standardised exercise packs (checklist review, walk-through, parallel test, tabletop, full interrupt simulation) aligned to contingency plan requirements | Compliance Manager | Enterprise | 56h | — |
| Establish evidence capture and audit pack template (test log structure, roles/participants, outcomes, deviations, and operational impact on assets/operations/individuals) | Data Protection Officer | Enterprise | 24h | — |
| Build the quarterly test schedule and coordination workflow (change management coordination, safety/rollback criteria for interrupt simulation, communications plan triggers) | Service Delivery Manager | Enterprise | 32h | — |
| Execute first quarterly effectiveness + readiness cycle for the target system(s) with evidence-led recording (including checklist review, walk-through, parallel test, tabletop, and full interrupt simulation) | Operations Lead | Business Unit | 80h | — |
| Run fixed results review and remediation triage after each quarterly test (effectiveness/readiness assessment, security participation, severity classification, corrective action creation with owners/due dates) | Compliance Manager | Enterprise | 32h | — |
| Implement corrective actions and perform targeted re-testing to close findings with re-test evidence (including retesting relevant scenarios and updating the contingency plan where required) | Security Engineer | Department | 48h | — |

**Total Estimated Effort:** 296h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Publish a quarterly schedule for testing the system’s contingency plan, including: checklist review, a walkthrough, a parallel test, a tabletop exercise, and a full interruption simulation.
- [ ] Create exercise packs that match the contingency plan requirements. Each pack should include the scenario objectives, the people involved (roles), the key decisions to be made (decision points), and the rules for when to pause or stop and when to restart the exercise for full interruption simulations.
- [ ] Run the quarterly effectiveness and readiness checks, and record what was tested, the results, and any deviations in an evidence pack.
- [ ] Record and review how the contingency operations seen during the tests affect day-to-day organisational activities, assets, and individuals.
- [ ] Hold a meeting to review the post-test results, including responsibilities for information security, identify weaknesses, and assign a severity level.
- [ ] Open corrective actions with a named responsible person and a due date, and require proof that the issue has been retested before closing the action.


---

#### CP-4.1 — Coordinate with Related Plans (Enhancement)

This requirement is about making sure your organisation’s plans for major disruptions are prepared and carried out with the teams responsible for other plans that could be affected. If you test your contingency plans on their own, you may miss important handovers, give staff and the public conflicting information, or only find out too late that the people responsible for business continuity, recovery, day-to-day operations, crisis communications, critical infrastructure, emergency response, or similar incident handling are not working to the same assumptions as your tests.

To meet this expectation, the organisation must identify who is responsible for each relevant related plan, and then coordinate the testing of your contingency plans with those responsible. This includes involving them in both the planning and the running of the test. This applies even if you do not have a dedicated team for related plans—coordination is still required wherever those responsibilities sit.

##### Coordinate contingency plan testing with related-plan owners

- Category: Manual
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Create and maintain a related-plan ownership register mapping related plan types to named organisational owners | Business Continuity Manager | Enterprise | 16h | — |
| Define the contingency plan test procedure update, including the mandatory coordination step (identify in-scope related plan types and invite owners) | Compliance Manager | Enterprise | 12h | — |
| Develop and publish the coordination checklist template and evidence requirements (invitations/attendees, documented input/sign-off, scenario applicability justification) | Project Manager | Enterprise | 10h | — |
| Run a pre-test coordination meeting pack (agenda, roles, escalation/handovers, communications triggers) and conduct at least one pilot coordination session with in-scope related-plan owners | Service Delivery Manager | Enterprise | 12h | — |
| Implement the test pack workflow to capture owner sign-off/documented input and to store auditable evidence in the test record | Operations Lead | Enterprise | 14h | — |
| Update the after-action report template to include a “coordination outcomes” section and ensure it is completed for each test | Quality Assurance Lead | Enterprise | 8h | — |
| Execute coordination for the next contingency plan test cycle and validate acceptance criteria (in-scope plan types, named owners, evidence, checklist completion, and justifications where applicable) | Business Continuity Manager | Enterprise | 20h | — |

**Total Estimated Effort:** 92h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Create and keep up to date a register of ownership for each related plan type covered in the CP-4(1) guidance.
- [ ] Update the contingency plan testing procedure so that it requires identifying the plan types that are in scope, and sending mandatory invitations to the plan owners.
- [ ] Make a coordination checklist a required item in the test pack, and include it as a required section in the after-action report.
- [ ] Hold a pre-test coordination meeting with all relevant owners of the plans in scope to agree on responsibilities, how issues will be escalated and handed over, and what communication actions will be triggered.
- [ ] For each test, collect and keep proof that the owner took part (for example, invitation records, attendee lists, and either sign-off or documented input).
- [ ] Record a clear, auditable reason in the test record whenever the related plan owner is not involved because the scenario does not apply.


---

#### CP-4.2 — Alternate Processing Site (Enhancement)

This requirement is about making sure your backup location is truly ready to take over if your main site is unavailable. If you do not visit and check it in practice, you may only find out too late that the backup site does not have the key facilities, support, access arrangements, or ability to carry out essential work. This can lead to avoidable delays and disruption to important business services.

To meet this expectation, the organisation must plan and schedule a test of its contingency plan at the backup processing site. The people who would use the plan must be involved, and there must be an on-site familiarisation walk-through showing the specific resources that would be used during an emergency. The organisation must then run a practical test to confirm the site can support contingency operations, record what was done and the results (including any major differences from the primary site), and use what it learns to update the contingency plan where needed.

The organisation must also keep the relevant site agreements and service commitments available as evidence, and ensure the test outcomes are reflected in the organisation’s security planning documents where applicable.

##### Alternate site visit and practical contingency capability test

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define alternate-site contingency test scope, measurable success criteria, and evidence requirements (including pass/fail thresholds per capability: identity/access, communications, workflow execution, data/service access) | Business Continuity/DR Manager | Enterprise | 16h | — |
| Produce dated alternate-site test plan and runbook (agenda, roles, safety/security briefing, test scripts, contingency workflow steps, escalation/stop criteria, evidence capture templates) | Project Manager | Enterprise | 20h | — |
| Schedule and coordinate test logistics with alternate site facility/service owner and relevant third parties (access arrangements, vendor/third-party support availability, communications channels, required accounts) | Service Delivery Manager | Business Unit | 12h | £2,000 |
| Conduct on-site familiarisation walk-through using a structured checklist and capture evidence of resources/capabilities used during contingency operations (entry/security process, work areas, secure storage, network connectivity points, operational tooling/workstations, third-party access paths) | Operations Lead | Department | 24h | £3,000 |
| Execute practical capability drills at the alternate site (establish communications, perform authentication/access to required systems via enterprise identity integration, run controlled end-to-end contingency workflow using defined dataset/representative transaction flow) | Application/Infrastructure Operations Lead | Department | 32h | £4,000 |
| Record results and perform gap analysis vs primary site (document significant differences, security-relevant constraints/access/support deviations, outcomes against each success criterion, and any exceptions/risks) | Compliance Manager | Enterprise | 16h | — |
| Update contingency plan with action owners and target dates (or formally justify no update), and retain/validate supporting agreements/service commitments as audit-ready evidence | Data Protection Officer | Enterprise | 18h | — |

Total Estimated Effort: **138h**  
Total Estimated Cost: **£9,000**

###### Actions Required for Compliance

- [ ] Create a contingency test plan for an alternate site, including the scope, clear measurable success criteria, and the evidence required to prove the results.
- [ ] Arrange a visit to the alternate processing site and run practical drills. Confirm that the contingency team members and information security representatives will attend.
- [ ] Carry out a structured on-site walkthrough to show, in detail, the exact resources and facilities used during contingency operations.
- [ ] Run hands-on readiness drills at the alternate site to test identity and access, communications, and a complete, end-to-end example of the contingency process.
- [ ] Record the test results, confirm whether they meet the success criteria, and document any significant differences compared with the primary site.
- [ ] Update the contingency plan to include the findings, the named people responsible for each action, and the target dates. If no update is needed, document why.
- [ ] Keep and refer to any relevant site access and support agreements, along with the agreed service commitments, as part of the test evidence.


---

#### CP-4.3 — Automated Testing (Enhancement)

This requirement is about running your disaster recovery plan in a repeatable, automated way, so you can be confident you can switch to backup systems when it really matters. Without these rehearsals, a contingency plan may look good on paper but fail in practice, leaving your business unable to keep operating during outages, data loss events, or other disruptions.

The organisation must define an automated approach for testing the contingency plan, then set up automated test rehearsals that are triggered through its normal software build and release process. The organisation must automatically create and configure the test environments using repeatable setup scripts, and run planned failover drills that switch to backup systems and then back safely where applicable. For each rehearsal, it must keep clear records showing what was tested, who was responsible and/or who approved it, what happened, and the results. It must also ensure that only authorised people can start the automated rehearsals.

##### Automated contingency test orchestration via CI/CD and IaC

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define contingency test approach for the specified scope: objectives, systems/functions under test, verification checks (health/synthetic/log assertions), expected failover behaviour, safe switch-back steps, and success/failure criteria | Business Continuity Owner | Enterprise | 24h | — |
| Design evidence model and retention controls: evidence schema linked to CI/CD run ID, required metadata (timestamps, operator/approver identity), evidence integrity approach (e.g., hashing/signing), access controls, and retention mapping to policy | Compliance Manager | Enterprise | 16h | — |
| Implement IaC module(s) for ephemeral realistic test environments (networking, identity integration hooks, logging/monitoring wiring, data stores as applicable) with deterministic outputs/digests for audit | Infrastructure Lead | Enterprise | 40h | £3,000 |
| Build scripted failover drill automation (deterministic failover, post-failover verification, safe switch-back where applicable) with pipeline-friendly exit codes and structured test reports | Security Engineer | Enterprise | 40h | — |
| Create dedicated CI/CD “Contingency Test” pipeline with authorised trigger gating (scheduled + approval-gated manual), full lifecycle stages (provision → deploy/validate → pre-checks → failover drill → post-checks → switch-back → teardown → evidence packaging) | DevOps Lead | Enterprise | 48h | £6,000 |
| Implement evidence packaging and storage integration (collect logs/reports/IaC outputs, attach run metadata, store in access-controlled repository, ensure audit-ready linkage to run ID, and capture failure evidence) | Operations Lead | Enterprise | 24h | £2,500 |
| Validate end-to-end rehearsal in a controlled dry-run and perform tabletop-to-automation alignment (including negative testing to confirm pipeline fails and evidence reflects failure when verification criteria are not met) | Quality Assurance Lead | Enterprise | 24h | — |
| Total Estimated Effort |  |  | **216h** |  |
| Total Estimated Cost |  |  |  | **£11,500** |

###### Actions Required for Compliance

- [ ] Define what the automated contingency test will cover, what counts as a successful outcome, and how you will verify that the contingency plan works.
- [ ] Set up an infrastructure-as-code (IaC) temporary test environment that matches the disaster recovery (DR) setup and works with the organisation’s identity system, logging, and monitoring.
- [ ] Set up a continuous integration and continuous delivery (CI/CD) “contingency test” pipeline with steps for: provisioning, deployment and baseline checks, scripted failover, verification, switch-back (if applicable), and removal of the test setup.
- [ ] Run repeatable, scripted failover tests and then check the system after failover. If the required conditions are not met, make the pipeline fail.
- [ ] Set up pipeline triggers so they can only be started by authorised people, using an approval step and an execution identity with the minimum required permissions (least-privilege).
- [ ] Automate the creation of evidence for each run (including the pipeline run ID, infrastructure-as-code outputs and checksums, failover and verification results, timestamps, and the person who initiated and approved it) and store it in an auditable repository with a defined retention period.


---

#### CP-4.4 — Full Recovery and Reconstitution (Enhancement)

This requirement is about ensuring your systems can be fully restored after a serious disruption, and then returned to normal service in a controlled, repeatable way. If this is not done properly, a major outage, corrupted information, or a failed application could leave your business unable to operate. Teams would then have to guess what to fix, which increases the risk of further mistakes and long delays.

To meet this expectation, the organisation must include two steps in contingency plan testing:  
- a complete recovery to a pre-agreed, known condition  
- a full re-establishment back to fully operational service, as required

The organisation must have clear, written procedures for both recovery and re-establishment. It must define what the “known condition” means for the system’s hardware, software, and data, and use that definition during the test. The organisation must record what was done, keep the test evidence and results, and obtain documented sign-off confirming that recovery and then normal service were successfully restored with minimal disruption to business activities.

##### Evidence-backed recovery and reconstitution using known-state restore packs

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define the per-system “known state” template and acceptance criteria (hardware/compute profile, software build IDs, configuration baseline/IaC commit, data snapshot/schema reference; include evidence requirements for CP-4(4)) | Compliance Manager | Enterprise | 24h | — |
| Implement restore pack artefact model and mapping to the known state (versioned manifest, integrity/signing approach where feasible, repository structure, access controls, retention rules) | Security Engineer | Enterprise | 32h | £8,000 |
| Develop/extend automation to generate and validate restore packs (build/version verification, configuration drift checks, data snapshot/schema checks, service health checks; produce machine-readable validation outputs) | Platform Engineer | Department | 56h | £12,000 |
| Execute contingency test runbook with two explicit phases (Recovery → Reconstitution) including controlled environment selection, step-by-step execution, and automated evidence capture (timestamps, restore pack IDs, validation outputs, deviations) | Operations Lead | Department | 40h | — |
| Implement evidence packaging and audit-ready sign-off workflow (phase-level evidence bundle, deviation handling, sign-off records for recovery complete and reconstitution complete; ensure traceability to known state and restore pack IDs) | Project Manager | Enterprise | 24h | — |
| Run at least one end-to-end test cycle in a segregated environment and remediate gaps (lessons learned, update known-state definitions, tune automation checks, confirm minimal disruption criteria via business/mission transaction tests) | Service Delivery Manager | Business Unit | 32h | — |
| Conduct security and compliance review of the known-state and restore pack approach (sensitive data handling during tests, access logging, integrity assurances, alignment to CP-4(4) expectations; produce review report) | Data Protection Officer | Enterprise | 16h | — |

**Total Estimated Effort:** 224h  
**Total Estimated Cost:** £20,000

###### Actions Required for Compliance

- [ ] Define and document the system’s known starting point, including the hardware profile, the software versions, the configuration baseline version, and the reference for the data snapshot and data structure (schema).
- [ ] Create a restore pack format that is versioned and access-controlled, and that matches the known system state exactly while keeping all required system state information.
- [ ] Set up automated checks during the recovery phase to confirm the correct artefacts and versions are used, to detect any configuration changes (configuration drift), and to verify that the data and its structure (schema) are intact.
- [ ] Set up automated and controlled steps for the reconstitution phase, including enabling the approved workflow, turning on monitoring and alerts, and running business transaction tests.
- [ ] Run contingency plan tests using the restore pack in separate, isolated environments. Record evidence for both phases, including the date and time, the restore pack ID, the validation results, and any deviations.
- [ ] Get documented approval that **recovery is complete** and **reconstitution is complete**, and keep the test pack and results for audit purposes.


---

#### CP-4.5 — Self-challenge (Enhancement)

This requirement is about deliberately putting your live systems under safe, planned stress tests, so you understand how they behave when something goes wrong. Without this, a real cyber incident or service outage could spread more widely than expected, leaving critical services slow, unusable, or unable to recover quickly. You may also miss hidden connections between systems until it is too late.

The organisation is expected to use automated, simulated attacks and controlled service disruptions on its on-premises production network services and critical application servers. For example, this may include temporarily reducing network bandwidth and temporarily limiting user or system permissions. The purpose is to deliberately cause harmful effects and then check whether services can still work as intended and recover within the planned timeframe.

The organisation must:
- define the test scope and process
- ensure tests are authorised and can be repeated in the same way
- record what was disrupted and what happened
- analyse the results to identify unexpected dependencies and weaknesses
- document how the findings will be used in recovery and re-establishment planning

The organisation must also keep the relevant contingency planning policy, recovery procedures, contingency plan, updates to the system security plan, and evidence of the test documentation, results, and named responsibilities.

##### Automated resilience self-challenge with scoped disruption and evidence

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Build the resilience self-challenge test catalogue (targets, adverse-effect hypotheses, service/recovery owners, max impact thresholds, stop/rollback conditions, kill-switch triggers) | Compliance Manager | Enterprise | 40h | — |
| Design and document the orchestration runbook workflow (authorisation gates, allow-lists, blast-radius limits, duration limits, automated pre/post checks, rollback steps, audit logging requirements) | Project Manager | Enterprise | 56h | — |
| Implement bandwidth degradation mechanism (approved traffic shaping/QoS profiles per subnet/VLAN/application flows with fixed durations and enforced maximum reduction levels) | Network/Infrastructure Engineering Lead | Enterprise | 80h | £12,000 |
| Implement time-bound privilege restriction mechanism via IAM (temporary role removal / reduced API scopes / disabling specific admin capabilities for selected service accounts/users; reversible and least-privilege scoped) | Security Engineer | Enterprise | 72h | £18,000 |
| Implement controlled service disruption mechanism (rate limiting/throttling and targeted restarts of non-safety-critical components; ensure no broad “stop all” actions; include guardrails and rollback) | Platform Engineer | Enterprise | 64h | £6,000 |
| Evidence capture and telemetry pipeline (collect/retain run telemetry: network performance, app availability/latency/error rates, identity/authorisation events; store disruption parameters and observed outcomes audit-ready) | Operations Lead | Enterprise | 56h | £10,000 |
| Execute at least one authorised end-to-end self-challenge test and perform dependency analysis (run, verify restoration, analyse unexpected dependencies/weaknesses, produce findings and update contingency/recovery artefacts) | Cyber Security Lead | Enterprise | 48h | — |

**Total Estimated Effort:** 416h  
**Total Estimated Cost:** £46,000

###### Actions Required for Compliance

- [ ] Create a resilience self-assessment test catalogue for the on-premises production network services and critical application servers, with named owners and clear responsibilities for recovery.
- [ ] Define the approved ways to disrupt service, including the settings for reducing bandwidth and temporarily restricting privileges for a limited time. Include the maximum allowed impact and the steps to undo the changes (rollback).
- [ ] Set up automated procedures (“runbooks”) that enforce approved target lists, limit how much impact changes can have (“blast radius”), apply changes only during defined test periods, and include an emergency stop (“kill switch”) that can halt the process if needed.
- [ ] Set up identity-based processes to temporarily and reversibly restrict access rights for selected users and service accounts for the length of each test.
- [ ] Set up telemetry collection and evidence capture to record which components were disrupted, the operating settings used, the start and stop times, the impact that was observed, and how well recovery performed.
- [ ] Carry out an analysis of any dependencies identified after testing, and update the contingency plan, recovery and re-establishment procedures, and the system security plan sections based on the results.


---

### CP-6 — Alternate Storage Site (Control)

This requirement is about making sure your organisation can still recover important backup information if your main site is unavailable, by keeping copies somewhere else. Without a properly set-up alternate storage location, a major disruption—such as a site outage, equipment failure, or a wider incident—could mean you cannot restore systems or continue essential work.

To meet this expectation, the organisation must:
- choose a backup storage site that is in a different geographic location from the primary site
- put formal agreements in place that clearly allow backups to be securely stored and later retrieved
- ensure the alternate site provides protection and access safeguards equivalent to those at the primary site, including suitable environmental conditions and secure handling of backup media

The organisation must also:
- document who is responsible
- create clear, step-by-step procedures for storing and retrieving backups at the alternate site
- keep the relevant plans and records up to date, so the arrangements are understood and can be used during an incident.

##### Geographically separate backup vault with auditable chain-of-custody

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Select and document geographically distinct alternate backup storage site (address/region, backup scope, storage areas) and update system/contingency documentation accordingly | Business Continuity/DR Manager | Enterprise | 16h | — |
| Draft, review and execute in-force agreements/operational contracts with the alternate site covering secure storage, delivery/retrieval workflow, turnaround times, incident/availability expectations, environmental constraints and access rules | Compliance Manager | Enterprise | 24h | £25,000 |
| Define and implement auditable chain-of-custody process for backup media (tamper-evident packaging/seals, unique batch/container identifiers, labelling conventions, handover/return forms/logs, named roles) | Security Engineer | Enterprise | 20h | £3,000 |
| Establish evidence pack for “equivalent security and protection” at the alternate site (facility security documentation, access control/visitor management evidence, environmental protections, inspection/audit reports) and obtain formal sign-off | Compliance Manager | Enterprise | 18h | £2,500 |
| Produce alternate-site backup dispatch/ingestion and retrieval runbooks (step-by-step workflows, batch reference generation, confirmation steps, escalation paths, roles/responsibilities) and integrate into operational procedures | Infrastructure Lead | Enterprise | 22h | — |
| Perform controlled retrieval test(s) and tabletop exercise(s) per cycle; record outcomes, remedial actions, and retain audit-ready evidence (chain-of-custody logs, retrieval confirmations, test results) | Project Manager | Enterprise | 28h | — |
| Align and retain records for auditability (contingency plan references, agreement artefacts, chain-of-custody logs, evidence pack, test results) and ensure access to records is controlled | Data Protection Officer | Enterprise | 14h | — |

**Total Estimated Effort:** 142h  
**Total Estimated Cost:** £30,500

###### Actions Required for Compliance

- [ ] Choose and record a separate backup storage location that is in a different geographic area for the application’s backup coverage.
- [ ] Carry out active agreements covering secure off-site backup storage, authorised delivery, the process for retrieving backups, expected turnaround times, and incident notification.
- [ ] Define and put in place chain-of-custody procedures for handing over backup media, including the use of seals, batch identifiers, records (logs), and clearly named responsible roles.
- [ ] Check and document that the alternate site’s physical and environmental protections, and its access rules, are the same as those at the primary site.
- [ ] Publish runbooks for alternate-site backup dispatch and ingestion, and for retrieval request and confirmation, including the escalation routes.
- [ ] Carry out and record at least one successful “alternate site” data retrieval test, and run one tabletop exercise for each defined cycle.


---

#### CP-6.1 — Separation from Primary Site (Enhancement)

This requirement is about keeping your backup storage in a location that is different enough from your main storage, so that the same disaster or mistake is less likely to affect both at the same time. Without this, a single event—such as a flood or fire, a building or structural failure, a deliberate break-in, or even human error—could leave you unable to recover your data because both locations would be affected together.

To meet this expectation, the organisation must:
- identify at least one alternate storage site; and
- use its risk assessment to decide how much separation is needed to reduce the chance that both sites are hit by the same threats, including natural disasters, structural failures, hostile attacks, and human mistakes.

The organisation must also:
- clearly record the chosen alternate site in its key planning documents;
- include it in the recovery plan and in day-to-day recovery procedures;
- put formal agreements in place for both the main and alternate sites; and
- assign named people responsibility for using the alternate site during recovery and for related information protection activities.

It must keep supporting records that show the separation decision and the reasons for it.

##### Document and implement a threat-based separated alternate backup site

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Perform threat-based risk assessment review for backup separation (natural disasters, structural failures, hostile attacks, errors of omission/commission) and confirm required separation evidence | Compliance Manager | Enterprise | 16h | — |
| Select and document alternate backup storage site(s), including separation mapping to risk assessment threat domains and rationale for “hostile attacks: separation less relevant” | Security Engineer | Enterprise | 24h | — |
| Produce backup independence design for the alternate site (immutable/write-once settings, separate credentials/roles for restore, encryption/key management approach, and deletion/alteration prevention) | System Design Authority | Enterprise | 20h | — |
| Update contingency planning artefacts and recovery procedures to include alternate site details and exact restore path (backup sets, access method, authorisation/approval workflow) | Project Manager | Enterprise | 16h | — |
| Establish formal agreements and named responsibilities for alternate-site recovery (service availability/access during recovery, independence from primary outages, RACI/named roles, evidence retention expectations) | Service Delivery Manager | Enterprise | 18h | £3,000 |
| Execute validation: recovery tabletop exercise plus at least one practical restore test from the alternate site with documented outcomes, timing, and any remediation actions | Operations Lead | Enterprise | 24h | £1,500 |
| Compile audit-ready evidence pack for CP-6(1) enhancement (alternate site record, separation rationale, independence controls, contingency/recovery updates, agreements, and restore validation results) | Compliance Manager | Enterprise | 12h | — |

**Total Estimated Effort:** 130h  
**Total Estimated Cost:** £4,500

###### Actions Required for Compliance

- [ ] Choose a different storage location for backup and recovery copies, and record where it is and the service details.
- [ ] Document the reason for separating responsibilities, linked to the threats identified in the organisation’s risk assessment (natural disasters, structural failures, hostile attacks, and mistakes made by not acting or acting incorrectly).
- [ ] Update the system contingency plan and the day-to-day recovery procedures to clearly name the alternate site and list the restore steps.
- [ ] Put in place and sign agreements that clearly set out responsibilities for the main and backup sites, how access will work during recovery, and that the backup site can operate independently if the main site is unavailable.
- [ ] Assign named roles or specific individuals responsible for alternate-site recovery and related information protection activities.
- [ ] Run a recovery tabletop exercise and carry out at least one restore test to confirm the alternate site is operationally usable.


---

#### CP-6.2 — Recovery Time and Recovery Point Objectives (Enhancement)

This requirement is about making sure your backup location is genuinely ready to restore normal service quickly, with the right amount of data loss. If it is not set up properly, a major disruption could mean you cannot access the backup site when needed, recovery actions fail because of incorrect setup, and you end up restoring services too slowly or losing more data than you can tolerate.

To meet this expectation, the organisation must prepare its alternate storage site—including the physical premises and the supporting systems—so that recovery can restore the required services within the agreed recovery time objective (how quickly you must be back) and restore data to the agreed recovery point objective (the latest time you can afford to lose). The site must also be configured so recovery can be carried out correctly, without avoidable misconfiguration, in line with the organisation’s contingency planning.

##### Configure alternate site for RTO/RPO with restore rehearsals

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Produce RTO/RPO-to-recoverable-components mapping (per critical service/data store) including recovery method and validation approach | Compliance Manager | Enterprise | 24h | — |
| Design and configure alternate site connectivity and dependency access (network routing, identity integration endpoints, logging/monitoring reachability, messaging/database dependency wiring) | System Design Authority | Enterprise | 40h | — |
| Configure recovery storage/backup/restore mechanisms to meet RPO (replication/point-in-time restore, retention settings, encryption/key access, integrity controls for recovery media/objects) | Infrastructure Lead | Enterprise | 56h | £12,000 |
| Pre-provision recovery compute/environment readiness to meet RTO (templates/VM images/container images, automated environment build, required admin tooling and baseline hardening) | DevOps Lead | Enterprise | 48h | £6,000 |
| Implement version-controlled recovery execution runbooks (and where feasible infrastructure-as-code) with ordered restore steps and application-level health validation checks | Software Lead | Enterprise | 32h | — |
| Execute restore rehearsals and capture RTO/RPO evidence (timing from recovery start to service restoration; latest recoverable data timestamp; validation outputs; evidence packaging for audit) | Service Delivery Manager | Enterprise | 40h | — |
| Perform gap analysis and remediation cycle (update alternate site configuration/runbooks/backup patterns; re-test until acceptance criteria met) | Project Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 264h  
**Total Estimated Cost:** £18,000

###### Actions Required for Compliance

- [ ] Document the recovery time objective (RTO) and recovery point objective (RPO) targets for each application component, and specify the required recovery method (restore, replication, or point-in-time recovery).
- [ ] Set up the alternate site’s storage, computing, and network connections so it can carry out the recovery methods and meet the achievable recovery time objective (RTO) and recovery point objective (RPO).
- [ ] Use version-controlled recovery runbooks (and automation where possible) that clearly set out the exact restore steps and the checks to confirm everything is working correctly.
- [ ] Set up protection and controlled access for recovery data used during restores at an alternate site, including encryption key access, recovery roles with the minimum necessary permissions (least privilege), and checks to maintain data integrity.
- [ ] Run scheduled automated restore practice sessions and measure and record recovery time objective (RTO) and recovery point objective (RPO).
- [ ] Fix any rehearsal gaps that affect recovery time objective (RTO) or recovery point objective (RPO), or any failures to execute correctly, then re-test until the agreed acceptance criteria are met.


---

#### CP-6.3 — Accessibility (Enhancement)

This requirement is about making sure your organisation can still access backup information somewhere else if a major, wide-area disruption stops normal access. Without this, authorised staff may not be able to reach the planned alternate storage location because roads are blocked, the site is physically inaccessible, or electronic connections fail. This could prevent you from restoring critical systems and records when you need them most.

To meet this expectation, the organisation must first define what it means by a wide-area disruption. It must then identify and document realistic access problems that could affect getting to the alternate storage site for that scenario. For each problem, it must record clear, practical steps to overcome it, including copying backup information to other alternate locations if the original location cannot be reached. It must also plan how staff will gain physical access to retrieve backups if electronic access is not available.

These actions must be included in the organisation’s contingency planning documents and supported by the organisation’s risk assessment and assigned responsibilities.

##### Accessibility failure-modes register for alternate backup sites

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define “area-wide disruption/disaster” scope and triggers to be used in contingency planning artefacts (e.g., regional power loss, ISP/cloud impairment, road/airport closures, site security lockdown) | Project Manager | Enterprise | 16h | — |
| Create an accessibility failure-modes register template (fields: problem, impact on authorised access, detection trigger, mitigation action, restoration method, owner, evidence location) and agree governance/ownership rules for updates | Compliance Manager | Enterprise | 24h | — |
| For each designated alternate storage site, populate the risk-driven accessibility failure-modes register covering both electronic/communications and physical/travel categories, including explicit if/then mitigations (backup duplication/restoration order and physical retrieval procedures) | Business Continuity/DR Manager | Business Unit | 56h | — |
| Map register entries into the contingency/disaster recovery playbook as a problem→mitigation decision flow, including escalation/decision points and explicit references to evidence locations and responsible owners | System Design Authority | Enterprise | 24h | — |
| Define and document restoration/duplication mechanics across alternate sites (secondary alternate site(s), restore order, expected restoration method, and verification steps) and align with application/infrastructure owners | Infrastructure Lead | Department | 32h | — |
| Define physical access and credential/authorisation retrieval process for electronic-access failure (offline media/backup retrieval locations, pre-authorised roles, access procedure, and evidence capture requirements) | Security Engineer | Department | 24h | — |
| Run tabletop exercises covering at least one electronic-access disruption and one physical-access disruption; record outcomes, update the register and playbook, and produce an audit-ready evidence pack | Quality Assurance Lead | Enterprise | 40h | £2,500 |
| Total Estimated Effort |  |  | **216h** |  |
| Total Estimated Cost |  |  |  | **£2,500** |

###### Actions Required for Compliance

- [ ] Define and document what counts as an organisation-wide disruption for the purposes of your risk assessment scope.
- [ ] Create an accessibility failure-modes register for each designated alternate backup storage site, split into electronic and physical (including travel) categories.
- [ ] For each type of failure, set out clear “if this happens, then do this” actions. Include the named secondary alternate sites that will be used to duplicate backups and restore services.
- [ ] Document a physical process for retrieving access when electronic access fails, including which pre-authorised roles can act and where offline backup media is stored.
- [ ] Add the register to the contingency and disaster recovery plan as a “problem to mitigation” guide, including the escalation steps to follow.
- [ ] Run practice tabletop exercises that cover at least one electronic access failure and at least one physical access failure, and update the risk register and response playbook based on the results.


---

### CP-7 — Alternate Processing Site (Control)

This expectation is about having a backup location that is ready to use. If your main site becomes unavailable, you must be able to quickly move and restart the essential work that supports handling classified Secret information and time-critical command-and-control services. Without this, a disruption could prevent you from operating when it matters most, which could lead to mission failure, loss of critical services, or unsafe handling of sensitive information.

To meet this expectation, the organisation must:
- choose an alternate site in a different geographic location;
- clearly identify which essential functions must be moved and restarted;
- ensure the move and restart can be completed within 4 hours;
- put in place the legal and contractual arrangements needed for the move and restart;
- ensure the right equipment and supplies are already at the alternate site, or can be delivered there within 4 hours;
- provide security and operational safeguards at the alternate site that are equivalent to those at the primary site;
- document the arrangements and procedures;
- assign named responsibilities; and
- be able to show that you are ready to meet the 4-hour target.

##### Geographically distinct alternate site with ≤4-hour Secret failover

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define the “alternate processing service catalogue” (transfer set) for ≤4-hour Secret failover, including dependencies (identity, key/crypto services, logging/SIEM ingestion, network services, admin tooling) | Compliance Manager | Enterprise | 32h | — |
| Select and document the geographically distinct alternate site, including environmental/physical protection baseline for Secret handling and evidence of geographic separation | System Design Authority | Enterprise | 24h | — |
| Pre-stage the alternate-site hot/warm standby capability: confirm secure baseline, required connectivity, and readiness of restart prerequisites to meet the 4-hour activation target | Infrastructure Lead | Business Unit | 40h | £18,000 |
| Map and implement equivalent security/operational controls at the alternate site (access enforcement, privileged access monitoring, encryption/key handling parity, logging/monitoring parity, network segmentation) and produce an equivalence matrix | Security Engineer | Department | 48h | £6,500 |
| Establish enforceable activation agreements/SLAs (activation authorisation, response/availability commitments aligned to 4 hours, personnel transfer/coordination, physical access/environmental access terms) | Compliance Manager | Enterprise | 24h | £12,000 |
| Produce activation triggers, roles, and end-to-end runbooks (decision authority, communications re-establishment, transfer/assignment of personnel, step-by-step resumption, validation gates) including audit-ready checklists | Project Manager | Enterprise | 32h | — |
| Execute failover/resumption exercises (table-top and technical) and retain evidence (timings, checklists, system health validation, control equivalence verification) with corrective actions tracked to closure | Service Delivery Manager | Team | 40h | £4,000 |

**Total Estimated Effort:** 240h  
**Total Estimated Cost:** £40,500

###### Actions Required for Compliance

- [ ] Document the alternate processing service catalogue for the defined essential mission and business functions—secret processing and time-critical command-and-control services—and list their dependencies.
- [ ] Choose an alternate processing site in a different geographic location and document the environmental and physical security requirements for handling Secret information.
- [ ] Set up an activation process that includes start triggers, who is authorised to make decisions, assigned roles, and a step-by-step guide for transferring or resuming work—aligned to a target of completing it within 4 hours or less.
- [ ] Put in place enforceable agreements and service level agreements (SLAs) that clearly authorise activating the alternate site, coordinating the required personnel, and meeting the required response times.
- [ ] Create a mapping that shows how the primary site and the alternate site controls provide the same level of security and operational coverage for the essential functions, including access rules, monitoring and logging, and cryptographic or key handling where applicable.
- [ ] Run and record regular failover and recovery tests. Measure how long it takes for the defined essential functions to be fully operational again, and keep the results in a format suitable for audit.


---

#### CP-7.1 — Separation from Primary Site (Enhancement)

This requirement is about making sure your business has a genuinely different backup location so you can keep operating if your main site becomes unusable. It addresses the real risk that the same disruption could affect both locations at the same time—for example flooding or fire, failures of buildings or infrastructure, deliberate break-ins or sabotage, or mistakes made while switching over.

To meet this expectation, the organisation must choose at least one alternate processing site that is far enough away from the primary site to reduce the likelihood that the same problems would affect both. This decision must be based on the organisation’s own assessment of the threats that could realistically happen.

The organisation must then clearly document which alternate site has been chosen and explain why the distance between the sites is considered sufficient in its contingency planning policy, contingency plan, system recovery documentation, and the agreements with both the primary and alternate sites. This ensures everyone involved understands where to go and what to do during an emergency.

##### Document and implement risk-based alternate processing site separation

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Refresh site separation risk assessment for the application, mapping organisation risk assessment threats to failure modes impacting both primary and alternate sites (including non-hostile threats and failover human error) | Business Continuity/DR Manager | Enterprise | 24h | — |
| Define measurable separation criteria and produce a separation rationale that links each criterion to the specific mitigated threats; explicitly document how hostile-attack susceptibility is addressed without relying on separation alone | Information Security Lead | Enterprise | 16h | — |
| Select and document at least one alternate processing site meeting the separation criteria (e.g., geographic/structural/power/network/telecom/access diversity) and record the site selection decision and assumptions | Infrastructure/Cloud Platform Lead | Enterprise | 20h | — |
| Update contingency planning policy, contingency procedures, contingency plan, and system recovery/system security documentation to include the alternate site, activation expectations, and the separation rationale | Compliance Manager | Enterprise | 18h | — |
| Establish formal agreements (e.g., MSAs/SOWs/SLAs or provider letters) between primary and alternate site owners/providers, explicitly referencing alternate site contingency responsibilities and activation expectations | Project Manager | Enterprise | 14h | £6,000 |
| Implement operational readiness for failover (warm/cold standby approach as appropriate): produce runbooks, confirm dependency independence, and document configuration drift controls and periodic review triggers | Operations Lead | Enterprise | 22h | — |
| Produce audit-ready evidence pack (risk assessment record, site selection record, approved documentation set, and signed agreements) and complete internal review/approval workflow | Compliance Manager | Enterprise | 10h | — |

**Total Estimated Effort:** 124h  
**Total Estimated Cost:** £6,000

###### Actions Required for Compliance

- [ ] Carry out a site separation risk assessment for the application, mapping how threats could lead to the same failure across both the primary site and the alternate site(s).
- [ ] Choose an alternative processing site that meets the documented separation requirements for the relevant non-hostile threats.
- [ ] Define and get approval for “sufficient separation” by linking each separation requirement to the specific threats identified in the risk assessment.
- [ ] Update the contingency planning policy, contingency procedures, contingency plan, and system recovery and system security documents to record the alternate site and the reasons for choosing it.
- [ ] Put in place and document agreements with the owners or providers of the primary site and the alternate site(s). These agreements should clearly set out the alternate-site contingency responsibilities.
- [ ] Review and provide evidence of how hostile attacks are handled, to ensure that separation alone is not relied on. Document the compensating security controls and the monitoring expectations.


---

#### CP-7.2 — Accessibility (Enhancement)

This requirement is about ensuring that your backup locations can still support your organisation if a major, wide-area emergency disrupts normal operations. If you do not check in advance that these locations are usable, you may find that people, systems, or services cannot be reached or used properly during a disaster. This can lead to delays, lost work, or an inability to carry on essential activities.

To meet this expectation, the organisation must:
- Define what it considers a wide-area disruption or disaster for its own planning.
- Identify the specific backup processing sites it would use.
- Check those sites for any accessibility problems that could prevent them from supporting operations in the relevant disaster scenarios.

For every issue found, the organisation must:
- Record the problem clearly.
- Link it to the specific scenario where it would occur.
- Document clear, practical actions to reduce the impact, including what will be done, who will do it, and when it will be done, so the plan can be followed during the event.

These details must be included in the organisation’s contingency planning materials, supported by the relevant site agreements, and assigned to named staff responsible for contingency actions, system recovery, and oversight. The same information must also be reflected in the system-level planning documents and kept for audit purposes.

##### Alternate-site accessibility risk register with tabletop mitigations

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define “area-wide disruption/disaster” scope and planning assumptions for accessibility alternates (including scenario taxonomy, triggers, and applicability rules) | Business Continuity Manager | Enterprise | 16h | — |
| Identify and document alternate processing sites per major scenario set (site IDs, expected workloads/services, primary-to-alternate transition expectations, and dependencies map) | Project Manager | Enterprise | 24h | — |
| Create the alternate-site accessibility risk register template (required fields: site ID, scenario(s), problem/impact, detection indicator, mitigation actions, trigger condition, named owner role, target completion date, evidence references) | Compliance Manager | Enterprise | 16h | — |
| Perform accessibility risk assessment per alternate site and populate the register (identity access, network reachability, application access, admin access, data access; include explicit runbook-style mitigations) | Security Engineer | Enterprise | 56h | — |
| Define and integrate tabletop mitigation runbook steps into contingency planning materials (who does what, when, escalation paths, timing targets, and pre-positioned artefacts/validation steps) | Operations Lead | Enterprise | 24h | — |
| Execute tabletop exercises for each major scenario set (facilitation, participant roles, constrained-conditions scripts, capture of outcomes, and actions log) | Service Delivery Manager | Enterprise | 32h | £3,000 |
| Update the risk register and contingency/runbook documents based on tabletop outcomes; produce audit-ready evidence pack (assessments, exercise outputs, approvals, and version control references) | Compliance Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 192h  
**Total Estimated Cost:** £3,000

###### Actions Required for Compliance

- [ ] In your business continuity and disaster recovery planning documents, define and record what counts as an organisation-wide disruption or disaster.
- [ ] Create a list of backup processing sites and match the expected workloads and services to each disruption scenario.
- [ ] Carry out an accessibility assessment for each alternate site, covering identity access, whether the network can be reached, access to applications, access to administrative functions, and access to data. Record the findings.
- [ ] Set up an accessibility risk register for an alternative site, linking each risk to the relevant scenario, and recording the potential impact, how it can be detected, the conditions that would trigger it, the named person responsible, and the mitigation actions.
- [ ] Turn each mitigation into clear runbook steps that state **what** to do, **when** to do it, and **who** is responsible. Include these steps in contingency planning materials and in system-level planning documents.
- [ ] Run tabletop exercises for each major scenario, and update the risk register and runbooks based on the results.
- [ ] Keep the assessment results and tabletop exercise evidence, and confirm that responsibility for contingency actions and oversight is assigned to specific named staff.


---

#### CP-7.3 — Priority of Service (Enhancement)

This requirement is about ensuring that, if your business systems need to be moved to a different processing location, your service provider will treat you as a priority. This helps you return to normal operations within the time you have planned for. Without clear priority commitments, you may have to wait behind other customers, leading to longer disruption, missed deadlines, and avoidable financial and reputational harm.

To meet this expectation, the organisation must first decide:
- what level of service availability it needs from an alternative processing location, and
- how quickly services must be restored after a disruption.

It must then decide what type of alternative processing it will use, either:
- a logical fallback (a backup that takes over within the same environment), and/or
- a physical alternative site (a separate location).

Next, the organisation must put clear written agreements in place with the relevant providers. These agreements must explicitly include priority treatment that matches the organisation’s availability needs and the agreed restoration time. The organisation must also ensure that its contingency planning documents and recovery responsibilities refer to these agreements. Finally, it must name specific people who are responsible for creating, reviewing, approving, and enforcing the contract terms.

##### Priority-of-service clauses aligned to RTOs in alternate site agreements

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define in-scope critical services and document RTO/availability targets for logical and/or physical alternate processing (including service tiering) | Business Continuity/Disaster Recovery (BC/DR) Lead | Enterprise | 24h | — |
| Produce contracting template pack: standard alternate processing site agreement/SLA clauses with priority-of-service provisions explicitly referencing RTO tiers (support priority, restoration sequencing, escalation/incident severity handling) | Legal/Contract Manager | Enterprise | 40h | — |
| Create RTO-to-clause mapping register (auditable): service → RTO tier → agreement/SLA document ID → exact clause/SLA line items enforcing priority and restoration timing | Compliance Manager | Enterprise | 32h | — |
| Implement procurement/renewal gate: workflow rule and checklist requiring drafter selection of RTO tier and mandatory inclusion of mapped priority-of-service clauses (with approval evidence capture) | Project Manager | Enterprise | 24h | — |
| Update contingency/disaster recovery documentation to reference agreement identifiers and provide invocation steps for priority treatment (including named escalation contacts/process) | Business Continuity/Disaster Recovery (BC/DR) Lead | Enterprise | 20h | — |
| Establish controlled evidence repository and version control: store signed agreements/SLA effective dates and ensure mapping register entries remain current for audits | Operations Lead | Enterprise | 16h | — |
| Run pilot negotiation and validation for a representative set of services; confirm enforceability and alignment between RTOs and priority-of-service clauses, then refine templates/register | Security Engineer | Enterprise | 24h | £6,000 |
| Total Estimated Effort |  |  | **200h** |  |
| Total Estimated Cost |  |  |  | **£6,000** |

###### Actions Required for Compliance

- [ ] For each critical service, document the required availability targets and the recovery time objectives (RTOs) for alternate processing using logical and/or physical systems.
- [ ] Create standard alternate-processing contract and service level agreement (SLA) templates that include enforceable clauses for priority of service and the order in which services are restored.
- [ ] Maintain an RTO-to-clause mapping register that links each service’s recovery time objective (RTO) to the exact agreement and service level agreement (SLA) line items.
- [ ] Set up a procurement approval checkpoint that requires the correct selection of the required recovery time objective (RTO) tier and the mandatory inclusion of priority-of-service clauses.
- [ ] Update business continuity and disaster recovery (DR) procedures to reference contract agreement identifiers, and explain how to activate the provider’s priority during incidents.
- [ ] Store signed agreements and service level agreements (SLAs), along with mapping evidence, in a secure controlled repository. Include the effective date and keep a full version history.


---

#### CP-7.4 — Preparation for Use (Enhancement)

This requirement is about making sure your backup location is genuinely ready to take over and run the business if the main site cannot. Without proper preparation, essential services could be delayed or fail in an emergency because the backup site is only planned “on paper”, not set up as a working environment with the right configurations, people, and support in place.

The organisation is expected to plan in advance for using the alternate site as part of its documented recovery arrangements. This includes clearly naming who is responsible for preparing the site, who will restore systems there, and who is responsible for protecting information. There must also be formal, signed agreements that allow the site to be used when needed.

The organisation must set up the alternate site’s systems to match the required setup of the main site, keep the security planning for that location up to date, and ensure essential supplies and practical logistics are available. Finally, recovery steps must be tested, or otherwise shown to work, at the alternate site.

##### Alternate site configuration baseline and readiness evidence pack

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define “essential systems” scope and configuration alignment rules (match vs documented exceptions) including identity/auth, network services, monitoring/logging, secrets/key management, encryption, privileged access, and any OT/edge components | Business Continuity/DR Lead | Enterprise | 16h | — |
| Produce alternate-site configuration baseline specification aligned to primary-site required settings (versions/build identifiers, endpoints, hardening profiles, logging destinations/retention, encryption/key-management, privileged access controls) | System Design Authority | Enterprise | 24h | — |
| Implement baseline using reproducible configuration artefacts (IaC/config management), including versioning, approval-controlled repositories, and environment parameterisation for alternate-site differences (e.g., IPs/cert SANs) | Platform Engineer | Department | 40h | £6,000 |
| Perform security-relevant configuration alignment validation (baseline-to-primary comparison, evidence of exception handling, and sign-off readiness for security planning updates) | Security Engineer | Department | 24h | — |
| Update system security planning and contingency/recovery documentation to explicitly cover alternate-site activation/restore steps and reference the same security objectives/settings as the primary baseline | Compliance Manager | Enterprise | 16h | — |
| Create and maintain the alternate-site readiness evidence pack (baseline approval record; drift/consistency check results; recovery runbooks referencing alternate-site health checks; tabletop evidence pack) | Business Continuity/DR Lead | Enterprise | 24h | — |
| Execute one non-production recovery validation (or equivalent proven readiness) demonstrating alternate-site can support essential functions; capture results, remediation actions, and final evidence pack updates | Operations Lead | Department | 32h | £2,500 |
| Confirm essential supplies and logistics for activation (accounts/keys access, spare capacity/credentials, vendor/landlord access contacts, connectivity prerequisites, physical/consumables) and record activation conditions and responsible parties | Service Delivery Manager | Business Unit | 16h | £1,200 |

**Total Estimated Effort:** 192h  
**Total Estimated Cost:** £9,700

###### Actions Required for Compliance

- [ ] Identify and record the key systems and configuration settings that must be the same as those at the primary site, at the alternate processing site.
- [ ] Create a version-controlled “alternate site” configuration baseline for all essential systems, using infrastructure-as-code and configuration management.
- [ ] Set up identity, privileged access, encryption and key management, and logging and monitoring to match the required configuration for the primary site (and document any exceptions that are allowed).
- [ ] Update the system security plan and the recovery and contingency documentation so they explicitly cover the alternate site, and reference the baseline.
- [ ] Create recovery runbooks that cover activating an alternate site, the steps to restore and switch over (failover), and health checks for every essential system.
- [ ] Run tabletop exercises and at least one recovery test in a non-production environment to gather evidence that the alternate site can support essential functions.
- [ ] Check and record the key materials and logistics needed to activate the service, including: access credentials and access routes, required connectivity, spare capacity and consumables, and the named people who can be contacted for access.


---

#### CP-7.6 — Inability to Return to Primary Site (Enhancement)

This requirement is about making sure the organisation can continue its work even if it is not possible to return to its main site—for example, after a flood or hurricane damages the building and rebuilding there is not sensible. Without this planning, the organisation could be forced to stop work at the worst possible time, lose critical services, and make rushed, inconsistent decisions that increase operational and safety risks.

To meet this expectation, the organisation must:
- Set out a clear policy for these situations.
- Identify the specific circumstances that would prevent returning to the main site.
- Plan in advance what will happen for each circumstance.

It must also prepare practical, documented procedures for moving to at least one alternative processing site. This includes:
- Details of the alternative site(s).
- Any necessary agreements with the site owner or provider.
- What is needed to set up secure operation there.

Finally, the organisation must assign named people responsible for restoring services and for protecting information during the switch, including deputies or cover arrangements. It must also keep all supporting documents up to date and easy to find.

##### Predefined failover to alternate site when primary return is impossible

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define “preclude returning” triggers and decision criteria; update the application/business continuity plan with approval workflow and evidence requirements | Compliance Manager | Enterprise | 16h | — |
| Select alternate processing site(s) (hot/warm/cold as appropriate), document scope and responsibilities, and obtain signed contingency/continuity agreements permitting failover use | Project Manager | Enterprise | 24h | £3,000 |
| Produce application-specific alternate-site failover runbooks (failover initiation, service start order, replication validation, DNS/load balancer cutover, expected timelines, rollback/stop conditions) and store in version-controlled repository | Software Lead | Department | 32h | — |
| Define and document alternate-site security expectations and update the application system security plan (logging/monitoring coverage, encryption in transit/at rest, identity-based access, privileged access controls, incident response during failover) | Information Security Lead | Enterprise | 24h | — |
| Assign named reconstitution and information security roles with deputies; configure break-glass/continuity access approach and ensure auditability requirements are met | IAM/Privileged Access Administrator | Enterprise | 20h | £2,500 |
| Execute tabletop exercises and technical readiness checks (certificate/secret availability, backup integrity, replication health, security controls active at alternate site) and record audit-ready evidence | Business Continuity Manager | Enterprise | 28h | £1,500 |
| Conduct a controlled rehearsal/failover simulation (non-production or limited-scope) to validate runbooks, cutover/rollback timing, and operational handovers; capture lessons learned and update procedures | Operations Lead | Business Unit | 24h | £4,000 |
| Establish ongoing review cadence (exercise frequency, technical control checks, agreement validity, runbook version governance) and embed into change/configuration management processes | Service Delivery Manager | Enterprise | 16h | — |

Total Estimated Effort: **184h**  
Total Estimated Cost: **£11,000**

###### Actions Required for Compliance

- [ ] Define and get approval for clear triggers and decision criteria for when it is impossible or impractical to return to the primary site.
- [ ] Choose an alternative processing site or sites and get signed agreements that allow contingency and business continuity use.
- [ ] Create application-specific alternate-site failover runbooks, including instructions for switching over (cutover), checks to confirm everything is working (validation), steps to reverse the change if needed (rollback), and the expected timeframes for each stage.
- [ ] Update the application system security plan to include the security requirements for an alternative site, covering logging, encryption, access control, and incident response.
- [ ] Assign named responsibilities for failover and recovery, and for information security, including named deputies, and document who covers which areas.
- [ ] Run tabletop exercises and carry out regular technical readiness checks to confirm that the alternate site can take over and that security controls are activated.


---

### CP-8 — Telecommunications Services (Control)

This requirement is about ensuring your organisation can still communicate by phone and data even if your main communication links fail, so essential work can continue without delay. Without backup telecommunications arrangements and the correct agreements in place, a failure at either your main site or your backup site could prevent teams from coordinating, supporting customers, or carrying out critical duties at any time of day, which could cause serious disruption.

To meet this expectation, the organisation must:
- Clearly identify which essential functions need continuous 24/7 phone and data communications for command, control, and support.
- Set a target to restore these services within 24 hours when the primary services are unavailable at either site.
- Put alternative phone and data telecommunications in place before they are needed.
- Cover both failure scenarios in its contingency planning policy and procedures.
- Include these arrangements in the contingency plan.
- Keep documented agreements with the relevant service providers or internal teams so restoration within 24 hours is achievable.

Finally, the organisation must assign named responsibilities for planning, recovery, information protection, and contracting, and keep the supporting records up to date.

##### Alternate voice/data telecoms with 24-hour restoration SLAs

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Produce telecom service catalogue for essential 24x7 voice/data “command, control, and support” functions (including mapping to specific endpoints/services and dependencies) | Compliance Manager | Enterprise | 24h | — |
| Document primary vs alternate processing/storage site telecom paths for each essential function (circuits/providers, routing approach, termination at alternate site, and assumptions/constraints) | System Design Authority | Enterprise | 32h | — |
| Draft and approve documented agreements for alternate voice/data services with explicit restoration within 24 hours (QoS/availability expectations, activation/escalation contacts, service credits/SLAs, evidence requirements) | Project Manager | Enterprise | 40h | £25,000 |
| Procure/contract and onboard alternate telecom services (carrier/managed service setup, provisioning, test credentials, and integration of escalation/activation procedures) | Infrastructure Lead | Enterprise | 24h | £60,000 |
| Update contingency plan and runbooks to include failover/activation steps for loss of primary telecoms at either site (including decision criteria, communications, security considerations, and evidence capture) | Operations Lead | Enterprise | 24h | — |
| Assign named responsibilities and implement an evidence ownership matrix (service catalogue owner, contract manager, failover executor, contingency activator, and record retention approach) | Compliance Manager | Enterprise | 16h | — |
| Execute restoration/failover testing demonstrating restoration of defined essential voice/data communications within 24 hours; record outcomes and lessons learned; implement remediation where gaps are found | Quality Assurance Lead | Enterprise | 48h | £10,000 |
| Conduct governance review and audit-ready pack compilation (traceability from CP-8 requirement to catalogue, agreements, runbooks, test evidence, and approvals) | Data Protection Officer | Enterprise | 16h | — |

**Total Estimated Effort:** 224h  
**Total Estimated Cost:** £95,000

###### Actions Required for Compliance

- [ ] Create a telecom services catalogue that links command, control, and support activities to specific 24/7 voice and data services (cp-08_odp.01).
- [ ] Document the main and backup telecommunications routes for the processing and storage sites for each essential service.
- [ ] Negotiate and sign documented agreements with providers for backup voice and data services, including restoration within 24 hours (cp-08_odp.02).
- [ ] Update the contingency plan and runbooks to include the steps for activating them if the main telecommunications service is lost at either site.
- [ ] Assign named responsibilities for executing telecom failover, managing contracts, activating contingency plans, and capturing evidence
- [ ] Run system recovery and failover tests, and keep evidence suitable for audit showing that service can be restored within 24 hours.


---

#### CP-8.1 — Priority of Service Provisions (Enhancement)

This requirement is about making sure that your phone and data connections used for urgent national security emergency work are treated as a priority when problems happen. If there are no clear, agreed priority arrangements in advance, an outage could mean your organisation has to wait longer for services to be restored or for new connections to be put in place, which could delay critical response.

To meet this expectation, the organisation must agree primary and backup telecommunications service contracts that clearly set out preferential handling during outages and during restoration. These contracts must also match the organisation’s own targets for how quickly services must be available again.

The organisation must also identify which emergency-preparedness telecommunications services it depends on, check whether each service is provided by a common carrier, and, where it is, request Telecommunications Service Priority so the provider gives preferential restoration and setup.

The organisation should document these arrangements, keep evidence that the priority requests were made, and ensure its recovery planning clearly links to the agreed contracts and responsibilities.

##### Contractual priority-of-service clauses mapped to telecom RTOs

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Draft **Telecom Resilience Requirements** document defining service classes (e.g., voice/SIP trunks, leased lines, dedicated internet, mobile/APNs) and mapping each class to availability targets and RTO schedule | Telecom/Network Resilience Lead | Enterprise | 32h | — |
| Create **Priority & RTO contract clause pack** (primary + alternate) including: priority-of-service restoration/provisioning clause, disruption/restoration trigger, measurable restoration/provisioning commitment or explicit RTO reference, expedited additional-line provisioning clause, and escalation contacts/roles | System Design Authority | Enterprise | 40h | — |
| Define **traceability model** (evidence mapping) linking clause pack commitments to the Telecom Resilience Requirements RTOs, including a standard attachment template for each agreement | Compliance Manager | Enterprise | 16h | — |
| Implement **contract lifecycle workflow** in the contract management system with policy checks preventing signature unless clause pack + RTO mapping + named responsibilities are present for both primary and alternate agreements | Project Manager | Enterprise | 24h | £6,000 |
| Configure **controlled repository** (versioned document control + immutable audit trail approach) for storing signed agreements and the clause pack version used, including retention rules | Operations Lead | Enterprise | 16h | £3,000 |
| Update **telecom contingency plan** and service recovery runbooks to reference the priority-of-service contractual obligations and escalation paths (including how incident responders should invoke/verify commitments) | Data Protection Officer | Enterprise | 20h | — |
| Run **provider onboarding/contract refresh** sessions and produce a completion pack (gap assessment, clause pack insertion evidence, and sign-off) for applicable primary and alternate telecom agreements | Compliance Manager | Business Unit | 24h | £8,000 |

**Total Estimated Effort:** 172h  
**Total Estimated Cost:** £17,000

###### Actions Required for Compliance

- [ ] Define service categories and measurable availability targets, including recovery time objectives (RTOs), in a Telecom Resilience Requirements document
- [ ] Create a contract clause pack for priority restoration and recovery time objective (RTO), covering preferential restoration or provisioning and faster provisioning of additional lines.
- [ ] Set up a contract lifecycle workflow that prevents signatures unless the priority clauses and the recovery time objective (RTO) mapping are included for both the primary agreement and the alternate agreement.
- [ ] Sign the main and backup telecommunications agreements using the approved clause set, and record the named people responsible for escalation.
- [ ] Store signed agreements and clause pack versions in a controlled, audit-ready repository, with retention.
- [ ] Update the telecommunications contingency plan and the service recovery step-by-step guides to reference the contractual priority-of-service commitments and the escalation routes.


---

#### CP-8.2 — Single Points of Failure (Enhancement)

This expectation is about making sure your backup communications are truly separate, so that one outage does not affect both your main service and your fallback. Without this, a single physical issue—such as shared wiring or shared infrastructure—could disable your main internet or phone connection and your backup at the same time, leaving staff unable to operate or recover.

To meet this, the organisation must:
- identify every main communications service it relies on
- arrange a separate alternate service for each one
- document which backup matches which primary service

It must also write and keep clear procedures for what to do if the primary service fails, who is authorised to switch to the alternate, and how to test and use the alternate during recovery. These details must be included in its contingency planning and system recovery records.

Finally, it must have formal agreements in place and obtain enough information from providers to confirm that the primary and alternate do not unintentionally use the same physical lines, and keep evidence of these checks.

##### Contract route-diverse alternates with provider physical separation evidence

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Refresh authoritative telecom service inventory for the application (service purpose, provider, circuit/contract IDs, endpoints/locations, component dependencies) | Infrastructure Lead | Enterprise | 24h | — |
| For each primary telecom service, define alternate procurement requirements (route/physical separation outcomes, separate handover locations, “no shared physical lines” assurance, required transparency artefacts and identifiers) | System Design Authority | Enterprise | 16h | — |
| Negotiate and update contracts/service orders with enforceable clauses for provider transparency and physical transmission capability disclosure (including circuit/service IDs and handover point requirements) | Compliance Manager | Enterprise | 24h | £8,000 |
| Collect provider transparency evidence for each primary↔alternate pair (engineering diagrams, diversity reports, written attestations, circuit mapping) and create/update an auditable evidence register linking evidence to specific agreements and identifiers | Operations Lead | Enterprise | 20h | — |
| Document primary↔alternate mapping in contingency/DR artefacts (service identifier mapping, activation guidance, staff reference tables) | Service Delivery Manager | Enterprise | 12h | — |
| Perform verification exercise (tabletop/controlled validation) to confirm staff can identify correct alternates and that provider contact paths and service identifiers are accurate | Project Manager | Enterprise | 10h | £2,500 |
| Conduct internal compliance review and sign-off against acceptance criteria (traceability from inventory → contracts → evidence register → contingency mapping) | Compliance Manager | Enterprise | 8h | — |

**Total Estimated Effort:** 114h  
**Total Estimated Cost:** £10,500

###### Actions Required for Compliance

- [ ] List each main telecommunications service the application and the service provider use, and record the connection endpoints and the circuit or service identifiers.
- [ ] Set separate alternate requirements for each primary service to ensure route diversity and to keep handover lines and physical lines separate.
- [ ] Update procurement contracts and service orders to include enforceable clauses that require physical separation and provide evidence of provider transparency.
- [ ] Collect and store provider engineering and diversity reports, along with written statements, that name the exact circuit or service identifiers they refer to.
- [ ] Update the contingency planning documents to include a traceable link between the primary and alternate options, using the same service identifiers.
- [ ] Run a tabletop validation exercise to confirm that, during recovery, the correct backup option can be identified and used.


---

#### CP-8.3 — Separation of Primary and Alternate Providers (Enhancement)

This requirement is about making sure your backup phone and internet connections come from genuinely different providers, so that one disaster or mistake does not affect both at the same time. Without this, the same event—such as a natural disaster, building or equipment failure, deliberate attack, or human error—could disrupt both your main service and your backup service, leaving you unable to communicate when it matters most.

To meet this requirement, the organisation must first use its risk assessment to decide what level of separation is enough. It must then clearly identify which telecommunications services are the primary ones and which are the alternate ones. The organisation must obtain the alternate services from providers that are physically and organisationally separate from the primary providers, with minimal shared infrastructure and sufficient geographic separation. It must also document why this separation reduces the same risks.

The organisation must keep its contingency planning documents and procedures up to date. This includes the relevant provider contract details, site information, and the named people responsible for switching to the alternate service and coordinating recovery communications.

##### Risk-based dual telecom providers with documented separation

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Derive measurable telecom separation criteria from the telecom-specific risk assessment for each in-scope site and service type (e.g., carrier legal entity, POP/exchange location, physical route/disaster zone, limits on shared infrastructure) | Compliance Manager | Enterprise | 24h | — |
| Produce primary vs alternate telecom service mapping per business-critical integration path (user access, API connectivity, admin access, monitoring/telemetry egress, SIEM forwarding), including failover circuit/link design and dependencies | System Design Authority | Enterprise | 32h | — |
| Identify and qualify candidate alternate telecom providers against separation criteria (organisational and physical separation evidence, shared infrastructure assessment, geographic diversity) and produce provider selection recommendation pack | Telecom/Network Engineering Lead | Enterprise | 40h | — |
| Execute procurement/vendor management actions for alternate services (contract clauses supporting independence/separation expectations, service ordering, and implementation acceptance criteria) | Project Manager | Enterprise | 24h | £60,000 |
| Create and maintain the auditable separation evidence register linking each primary/alternate provider agreement to site/POP identifiers, circuit identifiers, and risk-assessment rationale (including documented mitigations for any unavoidable shared elements) | Compliance Manager | Enterprise | 28h | — |
| Update telecom/IT continuity procedures to embed separation into contingency operations: triggers, named roles, escalation/NOC contacts, step-by-step switching/restore instructions, and rollback expectations | Business Continuity Manager | Enterprise | 20h | — |
| Validate operational readiness via at least one documented failover readiness activity (table-top and/or controlled switching) and record outcomes, gaps, and remediation actions | Operations Lead | Enterprise | 16h | £5,000 |
| Conduct evidence review and compliance sign-off against CP-8(3) acceptance criteria (traceability, audit readiness, and completeness checks) | Compliance Manager | Enterprise | 12h | — |

| Total Estimated Effort | Total Estimated Cost |
|---:|---:|
| 196h | £65,000 |

###### Actions Required for Compliance

- [ ] Carry out a telecommunications-focused risk assessment for each site and each type of telecommunications service, and set clear, measurable separation requirements for the primary provider versus the alternate provider.
- [ ] Create and keep an up-to-date register of the primary and backup (alternate) telecommunications services for each business-critical application connection path.
- [ ] Procure alternative telecommunications services from providers that meet the organisation’s separation requirements for organisational, physical, and geographic independence, and record this evidence in contracts and service orders.
- [ ] Document the provider, site, point of presence (POP), and circuit details, and include the risk-assessment reasoning showing that the service is less vulnerable to common threats.
- [ ] Update the contingency plan to include clear failover triggers, named responsibilities, and step-by-step instructions for switching to backup telecommunications routes.
- [ ] Carry out regular failover readiness checks (for example, tabletop exercises and/or controlled switching) and keep the results as audit evidence.


---

#### CP-8.4 — Provider Contingency Plan (Enhancement)

This requirement is about making sure your phone and internet providers have a clear, tested plan for keeping services running—or getting them back quickly—when major disruptions happen. Without this, a widespread outage, natural disaster, or other serious problem could leave your organisation unable to communicate, carry out work, or recover in time, causing real operational and financial harm.  

To meet this expectation, the organisation must require that both its main telecommunications provider and its backup provider have documented contingency plans, and it must review those plans to confirm they match the organisation’s recovery needs. The organisation must also get proof at least once every year that each provider has tested its contingency plan and trained the people responsible for carrying it out. The organisation must keep records of the plan reviews and the yearly evidence, and these expectations must be included in the provider agreements or equivalent contracts.

##### Annual review and evidence pack for telecom provider contingency plans

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define an organisational “Telecommunications Contingency Requirements” standard (restoration objectives, escalation/notification expectations, restoration approach, communications channels, evidence expectations) | BCM/DR Manager | Enterprise | 24h | — |
| Create a provider “Contingency Evidence Pack” template (summary review fields, roles/escalation matrix, restoration overview, last exercise date/excerpt, last training date/roster excerpt or attestation, material changes statement) | Compliance Manager | Enterprise | 16h | — |
| Draft and approve contractual clause set for primary and alternate telecom providers (annual evidence pack obligation, documented plan maintenance, material change notification, limited review under NDA, structured summary fallback) | Compliance Manager | Enterprise | 20h | — |
| Update and execute contractual amendments for both primary and alternate providers (including NDA/structured summary mechanism where full disclosure is not feasible) | Project Manager | Business Unit | 40h | £12,000 |
| Establish the annual review workflow in the GRC/BCM process (intake, structured checklist review, review outcome recording, gap handling, evidence acceptance gates for testing + training) | GRC/Compliance Lead | Enterprise | 28h | — |
| Implement audit-ready evidence retention and traceability (controlled repository, linking provider agreement → evidence pack → annual review record → follow-up correspondence; retention alignment) | Operations Lead | Enterprise | 18h | £3,000 |
| Run the first annual cycle: request evidence packs, perform structured reviews for both providers, document outcomes, and issue follow-up/corrective action where evidence is missing or insufficient | Compliance Manager | Enterprise | 32h | — |
| Optional coordinated exercise leverage: identify feasible external/industry exercise opportunities and capture participation/testing evidence for inclusion in the annual evidence packs | BCM/DR Manager | Enterprise | 12h | £2,000 |

**Total Estimated Effort:** 190h  
**Total Estimated Cost:** £17,000

###### Actions Required for Compliance

- [ ] Define the organisation’s telecommunications business continuity and disaster recovery (BCM/DR) requirements, including restoration goals, escalation and notification expectations, the restoration approach, and the communication channels, in a BCM/DR standard.
- [ ] Create a template for a provider contingency evidence pack that supports quick summary reviews, and includes fields for the most recent test or exercise and the most recent training evidence.
- [ ] Update the agreements with the main and backup telecommunications providers so they must:

- provide documented contingency plans, and  
- submit an evidence pack at least once every year, and  
- notify us of any material changes.
- [ ] Set up an annual governance, risk and compliance (GRC) and business continuity management (BCM) process to receive evidence packs, carry out a structured checklist review, and record the results of each review.
- [ ] Set up evidence approval checkpoints so the annual review cannot be completed unless, for every provider, there is dated testing evidence and dated training evidence.
- [ ] Store evidence packs and annual review records in a secure, controlled repository, with traceable links to the provider agreements and any follow-up actions.


---

#### CP-8.5 — Alternate Telecommunication Service Testing (Enhancement)

This requirement is about making sure your backup phone system and communication routes are genuinely ready to use, not just documented. If your main service fails, you may be unable to contact customers, staff, or emergency services, and important business activities could be disrupted. Testing only occasionally, or without the right arrangements with service providers, increases the risk that the backup will not work when you need it most.

The organisation must test its alternative telecommunications services at least once every quarter, using the arrangements agreed in its contracts with the service providers. The tests must be carried out in a way that does not disrupt mission-critical operations. The organisation must also:

- have written procedures for how the tests are carried out  
- include the alternative services in its contingency planning  
- clearly assign responsibility for the tests  
- involve the relevant service providers and the appropriate internal security-responsible staff, where required  
- keep clear records showing the quarterly tests were completed and recording the results

##### Quarterly alternate telecom testing with provider sign-off

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Update/renew provider agreements to include quarterly alternate telecom testing clauses (test windows, responsibilities, escalation contacts, evidence artefacts, no-degradation expectations, rollback/mitigation) | Service Delivery Manager | Enterprise | 24h | £12,000 |
| Define and publish the standard “Quarterly Alternate Telecom Test Pack” procedure aligned to contingency planning (scope, pre-checks, step-by-step execution, verification criteria, stop/rollback criteria, evidence checklist) | Compliance Manager | Enterprise | 16h | — |
| Establish measurable “no degradation” verification criteria and thresholds (before/during/after checks for routing/health, connectivity probes, call/SIP trunk success, latency/packet-loss thresholds, critical business function verification) | Security Engineer | Enterprise | 12h | — |
| Plan and execute the first quarterly test in parallel with operations using pre-approved windows (run non-disruptive verification first; execute alternate-path actions only within contract-approved window) | Operations Lead | Department | 20h | — |
| Capture and retain audit-ready evidence in contingency planning records for each quarter (test pack reference, quarter/date, alternate services tested, provider sign-off, execution logs, verification results, explicit no-degradation confirmation or documented deviations/corrective actions) | Project Manager | Enterprise | 10h | — |
| Conduct information security review/attestation for the quarterly test approach (confirm test traffic/access paths comply with security controls; approve evidence retention and any compensating controls) | Information Security Lead | Enterprise | 8h | — |
| Implement quarterly governance cadence (RACI, scheduling, escalation workflow, sign-off workflow, and lessons-learned update to the test pack for continuous improvement) | Project Manager | Enterprise | 10h | — |

**Total Estimated Effort:** 100h  
**Total Estimated Cost:** £12,000

###### Actions Required for Compliance

- [ ] Update service provider contracts to include quarterly alternate telecommunications testing time windows, responsibilities, escalation contacts, and the required proof (evidence) documents.
- [ ] Create a standard alternative telecommunications testing procedure (test pack) that includes clear start and stop conditions, rollback steps, and an evidence checklist.
- [ ] Define measurable checks to confirm there is **no performance degradation** before, during, and after each quarterly test.
- [ ] Schedule and carry out the quarterly tests during pre-approved time windows, with the provider involved and support from internal telecommunications operations.
- [ ] For each quarter, collect and store the provider’s sign-off, the execution logs, and the verification results in the contingency planning records repository.
- [ ] Obtain an information security assurance that the testing activities and access routes meet the required security standards.


---

### CP-9 — System Backup (Control)

This requirement is about making sure your organisation can reliably restore important information after something goes wrong. It requires regular backups and protection of those backups.  

Without daily backups of users’ home files, user databases, and user settings—and daily backups of the system itself, including its current state, software components, and licences—you could lose critical work or be unable to recover after accidental deletion, corruption, ransomware, or a system failure.  

Weekly backups of system documentation, including documents related to security and privacy, help you rebuild the correct way of working and meet legal or regulatory duties.  

To meet this expectation, the organisation must:  
- carry out backups on the stated schedule  
- keep written procedures and contingency plans explaining how backups are done and how they support recovery  
- record backup activity  
- identify where backups are stored  
- assign named responsibilities  

Backups must be protected so they remain confidential, cannot be changed without detection, and are available for restoration when needed.

##### CP-9 Backup schedule with signed integrity and immutable storage

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Create/refresh authoritative backup inventory mapping each in-scope production system to backup categories (user home dirs, user databases, user configuration data; system state/OS/middleware/application/licences; system documentation) and apply daily/weekly schedules | Backup Operations Lead | Enterprise | 24h | — |
| Design backup job architecture and runbooks (including encryption-at-rest, repository selection, retention aligned to contingency objectives, and restore workflow steps) with explicit integrity verification requirements | System Design Authority | Enterprise | 32h | — |
| Implement cryptographic integrity protection: generate per-backup-set hashes and/or signed manifests (including metadata coverage) and configure restore workflow to verify integrity before acceptance | Security Engineer | Enterprise | 40h | £6,000 |
| Configure immutable/tamper-evident backup repository controls (e.g., WORM/object lock/retention-locked storage), encryption-at-rest, and least-privilege access for backup service identities and authorised restore operators | Infrastructure Lead | Enterprise | 24h | £18,000 |
| Implement backup activity logging and evidence capture (job scope, timings, success/failure, integrity verification results, repository identifiers) and integrate exports to monitoring/audit tooling | Operations Lead | Enterprise | 20h | £4,000 |
| Execute initial restore tests for each backup category (daily user-level/system-level and weekly documentation) with documented evidence that integrity verification outcomes match expected results | Quality Assurance Lead | Enterprise | 24h | — |
| Establish ongoing operational cadence: schedule periodic restore testing aligned to contingency/BCP testing cadence, review integrity verification failures, and update runbooks/change controls | Service Delivery Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 180h  
**Total Estimated Cost:** £28,000

###### Actions Required for Compliance

- [ ] Create and keep up to date an official backup inventory that links each in-scope system to the correct backup categories for users, systems, and documentation.
- [ ] Set up backup scheduling so that **daily** user backups and **daily** system backups run automatically, and so that **weekly** system documentation backups run automatically according to the agreed schedules.
- [ ] Use cryptographic integrity protection for every backup set by using hashes and/or signed manifest files, and check the integrity during every restore.
- [ ] Encrypt backup data when it is stored and limit access to the backup repository to dedicated backup service identities and authorised restore operators.
- [ ] Store backup copies in an unchangeable, tamper-evident storage location, with retention periods set to match organisational requirements.
- [ ] Export and keep records of backup job logs, including the items covered (scope identifiers), whether each job succeeded or failed, and the results of integrity checks, so the process can be audited.
- [ ] Carry out documented restore tests and keep evidence that the restored data passes the same integrity checks.


---

#### CP-9.1 — Testing for Reliability and Integrity (Enhancement)

This requirement is about proving that your backup copies can be used and are still correct when you need them. Without regular checks, you may only find out later that the backup storage has failed, the usual recovery steps no longer work, or the restored files are incomplete or damaged, meaning you cannot restore critical information after an incident.

To meet this expectation, the organisation must, every quarter, choose a small random selection of backup items and try restoring them using the normal recovery process from the backup storage location (including any alternate backup site if one is used). After each restore, it must check that the recovered information is complete and matches the expected original content exactly.

The organisation must record the results so an independent reviewer can confirm what was tested, who carried it out, when it was done, what succeeded or failed, and what actions were taken to fix any problems. These records must be kept available for review.

##### Quarterly restore-and-compare tests for backup reliability/integrity

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define quarterly restore-and-compare scope, sampling method (random with reproducible criteria), and minimum alternate-site sampling rules; publish as an enterprise procedure aligned to cp-9.1_prm_1 | Compliance Manager | Enterprise | 16h | — |
| Design the evidence model and audit-ready manifest schema (backup identifiers, storage location, restore timestamps, outcomes, integrity results, executor/automation identity, remediation links) | Data Protection Officer | Enterprise | 12h | — |
| Implement/extend automation to select sample backup items, trigger restores via the normal recovery workflow, and capture restore logs/outputs into the evidence store | Platform Engineer | Department | 40h | £6,000 |
| Implement integrity verification logic per backup type (file/object hash compare; database/application validation checks) including expected/known-good reference retrieval and comparison rules | Software Lead | Department | 48h | £8,000 |
| Establish access controls and operational safeguards for restore testing (least-privilege roles, segregation from production operations, key-handling/decryption permissions, and approval workflow for failed tests) | Cyber Security Lead | Enterprise | 24h | — |
| Create remediation and re-test workflow (failure triage runbook, re-restore for affected items, escalation criteria, and evidence updates) and validate end-to-end with a dry-run | Operations Lead | Business Unit | 20h | — |
| Run the first quarterly cycle (execute sample restores from primary and alternate where applicable), produce the audit pack, and perform an independent evidence review against acceptance criteria | Service Delivery Manager | Enterprise | 32h | — |

**Total Estimated Effort:** 192h  
**Total Estimated Cost:** £14,000

###### Actions Required for Compliance

- [ ] Create a quarterly test plan template that sets out the random selection rules and the required information to record, including the backup identifier, date and time, where the backup is stored, and whether it is the primary or alternate copy.
- [ ] Set up an automated process that restores selected backup copies and then compares the restored data, using the organisation’s usual recovery steps (including handling encryption and decryption).
- [ ] Set up integrity checks for every type of backup: use cryptographic hash comparisons for file and object backups, and use consistency and validation checks that fit the application for database and application backups.
- [ ] Store permanent, tamper-resistant, audit-ready evidence for each run, including restore logs, integrity check results, sampled backup identifiers, the identity of the person or system that ran it, timestamps, and the outcome.
- [ ] Set up failure handling so that any restore problem or any mismatch in data integrity triggers an investigation and a follow-up restore-and-compare for the affected items.
- [ ] Set up an independent review at least once every quarter to check that all required evidence is complete and accurate before the CP-9(1) test cycle is closed.


---

#### CP-9.2 — Test Restoration Using Sampling (Enhancement)

This requirement is about proving that, if a disaster happens, the organisation can bring its most important services back online using a realistic selection of its stored backup data—not just by claiming it would work. Without this, the organisation might only find out later that backups are incomplete, out of date, or unusable, which could cause critical functions such as email, file access, or customer systems to fail when they are needed most.

To meet this expectation, the organisation must:
- decide which specific functions will be tested
- choose a representative sample of backup data for those functions
- restore only the selected functions using that sample
- check that each restored function works as intended

The organisation must also record what was restored, which backup sample was used, what checks were carried out, and the results for each function. This evidence must be kept so it can be reviewed later, and it must show that the sample used was sufficient for the level of assurance required.

##### Sample-based restore runbooks with auditable evidence capture

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define the “selected system functions” catalogue and assurance-to-sample-size mapping (including sampling rationale and selection criteria) | Compliance Manager | Enterprise | 24h | — |
| Design the sample-restore runbook framework: parameter schema (function list, backup sample identifiers, restore guardrails), environment isolation requirements, and execution workflow | System Design Authority | Enterprise | 32h | — |
| Implement sampling logic integration with backup tooling (encoded, repeatable method; e.g., most recent + older restore point, stratified by backup type/date windows) and generate an auditable “sample manifest” per test run | Platform Engineer | Department | 56h | £8,000 |
| Develop/extend restore runbooks to restore **only** sampled backup identifiers into the isolated contingency environment (including “no restore all” safeguards and validation of sample manifest inputs) | DevOps Lead | Department | 48h | — |
| Build automated verification checks per selected function (synthetic transactions/API probes/DB smoke queries/messaging checks + documented human steps where automation is not feasible) and produce structured pass/fail outputs | Software Lead | Business Unit | 64h | — |
| Implement evidence capture and tamper-evident retention: append-only log storage, evidence index linking functions ↔ sample identifiers ↔ restore/verification artefacts, and signing/immutability of the final test report | Security Engineer | Enterprise | 40h | £6,500 |
| Execute pilot contingency test runs (end-to-end dry run + one live sample-restore test), remediate gaps, and finalise audit-ready documentation and operator guidance | Service Delivery Manager | Team | 24h | — |

**Total Estimated Effort:** 288h  
**Total Estimated Cost:** £14,500

###### Actions Required for Compliance

- [ ] Create a contingency test catalogue that links each application system function to its recovery goal and the checks used to confirm it has been restored.
- [ ] For each function, choose and document a sampling approach (including the sample size and how samples are selected) based on the required level of assurance.
- [ ] Create parameterised “sample-restore” runbooks that can only use sampled backup identifiers, and add safeguards to prevent full restores.
- [ ] Automate the restoration process in a separate, isolated contingency testing environment, using dedicated test login details and network separation.
- [ ] Set up automated checks for every restored function (synthetic transactions, application programming interface (API) probes, health checks, and database/message “smoke tests”), and document any manual steps that still need to be done.
- [ ] Produce an auditable test report that records: which functions were tested, the backup sample identifiers used, how long restoration took, the checks performed to confirm results, and whether each test passed or failed.
- [ ] Store evidence of restores and verification in write-once, unchangeable storage, and sign the final test report file to confirm it has not been altered.


---

#### CP-9.3 — Separate Storage for Critical Information (Enhancement)

This requirement is about keeping the most important backup copies somewhere safe and separate, so they are not lost if the main system is damaged. Without this separation, events such as fire, flood, theft, or a serious technical failure could destroy both the live equipment and the backups needed to restore it. This could prevent the organisation from recovering quickly and may expose sensitive security information.

The organisation must identify which backup contents are critical. This includes the software that runs key systems, security-related settings and tools, and records of important system components. It must then store these critical backups either in a different facility or in a fire-rated container. In both cases, the organisation must ensure the backups are not kept in the same place as the operational system.

The organisation must document where the backups are stored and how they are set up. It must also keep records showing that backups were completed and where they were stored. Finally, it must include this separation approach in its contingency planning and system security documentation, with clear responsibility assigned to the relevant staff.

##### Store critical backup copies in non-collocated alternate facility

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Create/maintain the “critical backup manifest” mapping in-scope systems to critical backup categories (OS, middleware, cryptographic key management systems, IDS, security-related hardware/software/firmware inventories) | Compliance Manager | Enterprise | 24h | — |
| Define the approved non-collocated backup repositories (alternate facility and/or fire-rated container design), including repository identifiers, allowed source systems, and scope boundaries | System Design Authority | Enterprise | 16h | — |
| Configure backup orchestration enforcement: implement repository allow-listing/deny rules so critical-scope backup jobs write only to approved non-collocated destinations (no fallback to primary/collocated targets) | Infrastructure Lead | Enterprise | 40h | — |
| Harden the separate repository: apply encryption in transit/at rest, restricted admin access, and immutable/append-only retention where supported by the backup platform/storage mechanism | Security Engineer | Enterprise | 32h | £12,000 |
| Implement automated verification and evidence capture per critical backup run (run ID, source system, critical scope summary, destination identifier/location) and store evidence in a tamper-evident log store | DevOps Lead | Enterprise | 32h | £6,000 |
| Update contingency planning and system security documentation to reference the separate storage destination(s), responsibilities, and evidence requirements for CP-9(3) | Project Manager | Enterprise | 16h | — |
| Execute pilot and audit readiness: run at least one recent backup cycle per critical system, validate destination enforcement, and produce an audit pack (configuration screenshots/log extracts/evidence records) | Quality Assurance Lead | Enterprise | 24h | — |

**Total Estimated Effort:** 184h  
**Total Estimated Cost:** £18,000

###### Actions Required for Compliance

- [ ] Create and get approval for a critical backup record (manifest) for each in-scope system. This must cover the operating system, middleware, management of cryptographic keys, intrusion detection system (IDS) details, and security-related inventory information.
- [ ] Choose and record approved backup storage locations that are not in the same place as the primary system (for example, a separate facility or a fire-rated container), including the physical location identifiers.
- [ ] Set up backup orchestration so that only the approved separate destination(s) are allowed for critical backup jobs, and block any write access to the on-site or primary repositories.
- [ ] Set up repository protections that fit the platform (for example, make records immutable or append-only retention where available) and limit administrative access to the separate repository.
- [ ] Set up automated checks for every backup run to confirm the backup destination and included data match the critical backup plan, and create tamper-evident proof records for each run.
- [ ] Update the contingency planning and system security documents to reference the separate storage approach, the data mappings, and the responsible roles.


---

#### CP-9.5 — Transfer to Alternate Storage Site (Enhancement)

This requirement ensures that your backup information can be sent to an off-site location quickly and in a way you can measure. This lets you restore services if your main systems are damaged or unavailable. Without it, backups may arrive too late, not arrive at all, or be sent to the wrong place—meaning you may not be able to restore critical services when you need them most.

The organisation must send backup information to an agreed alternate storage site either by secure electronic transfer or by shipping storage media. The transfer must be completed within 4 hours, and data must be moved at a rate of at least 200 gigabytes per hour.

Staff responsible for backups and staff responsible for information security must follow documented procedures. They must also include off-site backup transfers in the organisation’s contingency planning, with clear responsibilities and defined steps.

The organisation must keep evidence and records showing the transfer took place. This includes the alternate site used, the start and end times, and the amount of data moved. The organisation must also have written agreements confirming that the alternate site can receive the backups.

##### Automated off-site backup transfer with 4h/200GBh SLO evidence

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define CP-9(5) SLO parameters (4 hours / 200 GB per hour), measurement method (GB calculation, elapsed time boundaries), and evidence schema for transfer jobs | Compliance Manager | Enterprise | 16h | — |
| Authorise and implement allow-listed alternate storage destinations (endpoint/bucket/vault identifiers), including approval workflow and least-privilege change controls | Security Engineer | Enterprise | 24h | — |
| Configure automated off-site backup transfer in the enterprise backup platform (replication/transfer protocol, scheduling, DR/incident workflow triggers) | Backup/DR Engineer | Enterprise | 40h | — |
| Implement SLO instrumentation and guardrails (telemetry capture: destination, start/end, GB transferred, computed throughput; alerting; retry/failover logic when SLO would be missed) | Platform Engineer | Enterprise | 40h | — |
| Enforce transfer integrity and confidentiality (TLS in transit, destination encryption at rest, certificate/secret handling, access restrictions) | Security Engineer | Enterprise | 24h | — |
| Build immutable/tamper-evident audit-ready evidence store for each transfer job and produce an audit summary record suitable for contingency plan evidence | Operations Lead | Enterprise | 32h | £6,000 |
| Update contingency/DR procedures and runbooks to explicitly cover off-site transfer process, triggers, prioritisation, roles/responsibilities, and remediation steps | Project Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 192h  
**Total Estimated Cost:** £6,000

###### Actions Required for Compliance

- [ ] Define and get approval for a list of approved alternative storage locations that match the **cp-9.5_prm_1** agreement.
- [ ] Set up the organisation’s backup system to electronically send backup information to the approved (allow-listed) alternate site.
- [ ] Set up backup transfer jobs to record the start time, end time, the destination identifier, and the total number of gigabytes (GB) transferred, so throughput can be calculated.
- [ ] Set up automated checks and alerts to flag any data transfers that would take longer than 4 hours or run at less than 200 gigabytes per hour.
- [ ] Use encryption for data while it is being transferred and while it is stored in the backup and at the destination.
- [ ] Store tamper-evident records for each transfer, including the destination, the date and time, the amount in gigabytes (GB), and the calculated data transfer speed, so the information is available for audit retention.
- [ ] Update the business continuity and disaster recovery (DR) procedures and the system security plan to include the off-site transfer trigger, the responsibilities of each role, and the steps to fix any issues.


---

#### CP-9.6 — Redundant Secondary System (Enhancement)

This requirement is about keeping a ready-to-use backup copy of your main systems in a different location, so that if the main site has a serious problem you can switch over without losing information or stopping the business.

Without this, events such as fire, flood, power failure, or a major outage could damage both the main system and its backup at the same time. That could prevent you from restoring services or recovering recent data.

To meet this expectation, the organisation must:
- keep a separate secondary backup system located away from the primary system
- keep it up to date by continuously copying information from the primary system
- ensure it can be brought into use when needed, with no unacceptable disruption

The organisation must also:
- document how backups are taken and how the backup system is activated
- include this approach in its contingency planning
- assign named responsibilities
- keep records of backup and contingency testing, including evidence that the secondary system was successfully activated and that key information and service availability were checked and confirmed

##### Geo-separated warm secondary with continuous mirroring and tested failover

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define geographic separation criteria, DR architecture boundaries, and RPO/RTO targets for warm secondary activation (including documented max data loss window and recovery time) | Compliance Manager | Enterprise | 24h | — |
| Design warm secondary reference architecture (networking, compute sizing, identity integration approach, certificate/secret handling, logging/monitoring hooks, dependency mapping) and produce DR design pack ready for change approval | System Design Authority | Enterprise | 40h | — |
| Provision warm secondary environment with pre-staged infrastructure (non-collocated site/region, network connectivity, DNS/LB readiness, baseline hardening, configuration baselines, and access pathways) | Infrastructure Lead | Enterprise | 56h | £45,000 |
| Implement continuous mirroring/replication for in-scope data and state (DB continuous replication/log shipping/slots, application state/config replication, storage replication with integrity verification) | Software Lead | Enterprise | 72h | £18,000 |
| Configure and validate replication behaviour against RPO/RTO (replication lag monitoring, failover readiness checks, consistency/integrity validation routines, and automated gating conditions) | Security Engineer | Enterprise | 32h | £6,000 |
| Implement security controls for the secondary (least-privilege access, encrypted replication channels, secrets management, audit logging to SIEM, and monitoring/alerting parity with primary) | Cyber Security Lead | Enterprise | 40h | £10,000 |
| Create activation and rollback runbooks (step-by-step cutover/return, service start order, validation checks, rollback triggers, communications/incident handover) and deliver tabletop + initial controlled activation test with evidence pack | Operations Lead | Enterprise | 48h | £2,500 |
| Schedule and execute failover rehearsals (including at least one during initial implementation and subsequent periodic rehearsal), record outcomes/corrective actions, and retain audit-ready evidence | Service Delivery Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 356h  
**Total Estimated Cost:** £81,500

###### Actions Required for Compliance

- [ ] Define and document the geographic separation requirements for the secondary location (site/region/building), and identify which in-scope systems are included in the disaster recovery (DR) design.
- [ ] Set up a warm secondary environment at the separate location, using pre-prepared infrastructure and integrated identity and monitoring.
- [ ] Set up continuous copying and replication of all in-scope data and the required application settings from the primary system to the secondary system.
- [ ] Set and check the recovery point objective (RPO) and recovery time objective (RTO) based on how the replication works, and record the maximum amount of data loss and the longest acceptable recovery time.
- [ ] Create activation and rollback runbooks, including cutover steps and checks to confirm data integrity and service availability.
- [ ] Carry out at least one controlled failover practice and keep audit-ready records showing that the switch to the backup system worked, that checks for data integrity passed, and that the disruption results were as expected.


---

#### CP-9.7 — Dual Authorization for Deletion or Destruction (Enhancement)

This requirement is about ensuring that confidential or secret information in backup copies cannot be deleted or destroyed by one person working alone. Without this safeguard, a single trusted employee could remove backup records by mistake or on purpose. That would make it harder to restore systems after an incident and could also allow unauthorised loss of sensitive information. It also increases the risk that harmful actions go unnoticed.

To meet this expectation, the organisation must:
- Clearly define which backup information is covered (all backups that contain confidential or secret data).
- Ensure that both deletion and destruction of any covered backup material require approval from two qualified, formally authorised people.
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

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define in-scope classification logic for backup deletion/destruction (Confidential + Classified (Secret)) and map to backup metadata model (tags/labels) | Compliance Manager | Enterprise | 16h | — |
| Design dual-approval workflow (Request → Approval 1 → Approval 2 → Execute) including separation of duties, no bypass paths, and server-side enforcement requirements | System Design Authority | Enterprise | 24h | — |
| Implement workflow in backup management/orchestration layer (state machine, approval capture, execution gating, idempotency, and rejection on single approval) | Software Lead | Enterprise | 56h | — |
| Integrate with IAM for approver role enforcement and step-up authentication for Approval 2 (phishing-resistant MFA where available) | Security Engineer | Enterprise | 40h | £20,000 |
| Implement tamper-evident audit logging for both approvals and execution outcome (immutable storage/WORM/object-lock integration, SIEM forwarding, retention alignment) | Operations Lead | Enterprise | 32h | £8,000 |
| Add automated tests and security validation (unit/integration tests, negative tests for missing second approval, API/endpoint hardening, least-privilege checks) | Quality Assurance Lead | Enterprise | 24h | — |
| Update runbooks and operational procedures (request/approval/execute steps, incident/rollback guidance, periodic approver rotation policy) | Service Delivery Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 208h  
**Total Estimated Cost:** £28,000

###### Actions Required for Compliance

- [ ] Define and implement a tagging system so that backup sets containing Confidential or Classified (Secret) information are automatically identified as within scope.
- [ ] Set up backup deletion and destruction as a step-by-step workflow in the backup management or orchestration system: **request → first approval → second approval → execute**.
- [ ] Block execution unless two separate authorised approvals are in place, using checks on the server side.
- [ ] Set up two separate approver roles (and limit who can be in each role) in identity and access management (IAM) so that only formally authorised, qualified people can approve.
- [ ] Add step-up authentication, using phishing-resistant multi-factor authentication (MFA), for the second approval.
- [ ] Set up tamper-evident audit logs for both approvals, including the time, the type of action taken (delete versus destroy), and the identifiers of the affected backup. Then send these logs to the security information and event management (SIEM) system.
- [ ] Write down and test the process, including a negative test to prove that requests are not approved when they do not meet the single-approver requirement.


---

#### CP-9.8 — Cryptographic Protection (Enhancement)

This expectation is about protecting backup copies so that only authorised people and systems can read them or change them. If backups are not properly protected, an attacker or a careless insider could steal sensitive information from the backups, or quietly change the backups so that, when you try to restore after an incident, you end up with corrupted or malicious data instead of the real records.

To meet this requirement, the organisation must encrypt backup information while it is stored in both its main (primary) backup location and its backup fallback (alternate) location, using protection strong enough for the sensitivity of the backup content. The organisation should apply the same level of protection at both locations, keep clear records showing how it chose the protection strength, and use secure processes to manage the encryption keys so they are not exposed.

It should also be able to demonstrate that unauthorised access cannot read or tamper with backups, and that any tampering is detected.

##### Encrypt and integrity-protect backups at primary and alternate storage

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Identify in-scope backup jobs/datasets and map each to the applicable security category/classification (cp-09.08_odp parameter) | Compliance Manager | Enterprise | 24h | — |
| Define and approve a classification → cryptographic strength mapping (algorithm + key size) aligned to organisational crypto standards, including rationale and exceptions process | Security Engineer | Enterprise | 32h | — |
| Configure backup platform/object storage to enforce encryption-at-rest for backup objects in both primary and alternate targets (application/backup-layer, not disk-only) | Backup/Recovery Engineering Lead | Department | 40h | — |
| Integrate backup platform with enterprise KMS/HSM and implement restricted key usage policies (backup service identities only; deny/limit admin decrypt; least privilege) | Infrastructure Lead | Enterprise | 48h | £12,000 |
| Enable integrity/tamper detection for backups (authenticated encryption and/or signed manifests/cryptographic checksums), ensure verification is executed and results are logged for both locations | System Design Authority | Department | 40h | — |
| Implement consistent cryptographic posture across primary and alternate storage (configuration baselines, drift controls, and automated checks) | DevOps Lead | Enterprise | 24h | — |
| Collect and package audit evidence (backup configuration exports, KMS/HSM key policy evidence, integrity verification logs) and run controlled tests for unauthorised read and tampered restore/verification failure | Compliance Manager | Enterprise | 32h | — |

| Total Estimated Effort | 240h |  |
|---|---:|---:|
| Total Estimated Cost |  | £12,000 |

###### Actions Required for Compliance

- [ ] Take an inventory of all backup datasets and assign each one to the organisation’s security category or classification.
- [ ] Set up the backup system to encrypt backup files and data while they are stored, for both the main (primary) storage location and the backup (alternate) storage location.
- [ ] Connect the backup system to the organisation’s key management system and hardware security module (KMS/HSM), and allow key use only for the backup service identities.
- [ ] Enable integrity protection for backups by using authenticated encryption and/or signed backup records (manifests) and/or cryptographic checksum verification, and make sure the verification step is carried out.
- [ ] Set up a clear mapping from each data classification level to an approved cryptographic strength (approved algorithms and key sizes), and apply it consistently in both locations.
- [ ] Collect and store audit evidence from the backup console and the key management console to show that encryption and data integrity checks are enabled for both the primary and alternate storage.
- [ ] Carry out tests to try to access the system without authorisation and to check for tampering, and record the results to show that unauthorised disclosure is blocked and any changes are detected.


---

### CP-10 — System Recovery and Reconstitution (Control)

This requirement is about making sure your organisation can quickly put its systems back into a safe, working condition after something goes wrong, and then return them to full normal operation. Without clear recovery steps and follow-through, a disruption, security incident, or system failure could keep essential services unavailable for too long, lead to avoidable data loss, and result in temporary workarounds that increase risk.

The organisation must set out and document how recovery will happen. This includes backup arrangements and proof that backups and recovery plans have been tested. The organisation must also keep the relevant plans, procedures, and records up to date.

After any disruption, the system must be restored to a known, working state within 24 hours using the documented contingency plan. This plan must align with business priorities and recovery objectives.

Then, within 72 hours, the organisation must fully restore the system by removing temporary recovery measures, confirming that full capabilities are back in place, restarting ongoing system checks, completing any required re-authorisation, and preparing for future incidents. Responsibilities must be clearly assigned, with involvement from information security staff.

##### Automated recovery runbook with 24h known-state and 72h reconstitution

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define workload-specific recovery objectives (known-state RTO=24h, reconstitution RTO=72h, RPO alignment) and acceptance gates for “known working state” | Compliance Manager | Enterprise | 24h | — |
| Design the automated recovery runbook workflow (phase 1: known-state cutover; phase 2: reconstitution) including interim capability list, explicit deactivation steps, and reauthorization triggers | System Design Authority | Enterprise | 32h | — |
| Implement orchestration automation for recovery/reconstitution (infrastructure provisioning/restore, health-check acceptance gate, evidence capture, rollback/degraded-mode handling) | Platform Engineer | Enterprise | 80h | £12,000 |
| Implement reconstitution pipeline (full security posture restoration, functional/data integrity assessment checks, continuous monitoring re-enable/validation, interim control deactivation, reauthorization workflow integration) | Security Engineer | Enterprise | 72h | £6,000 |
| Integrate audit-ready evidence generation (timestamped execution logs, action/decision records, health-check outputs, monitoring validation evidence) and map evidence to contingency plan/CP-10 expectations | Compliance Manager | Enterprise | 24h | — |
| Conduct controlled recovery/reconstitution exercises for each in-scope critical workload (including post-change regression runs) and produce test reports with remediation actions | Quality Assurance Lead | Enterprise | 40h | £3,000 |
| Operationalise runbook governance (runbook versioning, controlled approvals, access controls for execution, incident handover checklist, and ongoing maintenance cadence) | Operations Lead | Enterprise | 24h | — |

**Total Estimated Effort:** 296h  
**Total Estimated Cost:** £21,000

###### Actions Required for Compliance

- [ ] For each workload, document the recovery time objective (RTO) for a known state (within {{ cp-10_prm_1 }} / 24 hours) and the 72-hour reconstitution objective, aligned with the contingency plan Recovery Point Objectives (RPOs).
- [ ] Create and version a recovery runbook that can rebuild systems from verified “known-good” components or restore them from approved backups. Include clear health checks and decision points (gates) to confirm the system is in a “known state” before proceeding.
- [ ] Set up orchestration to run recovery steps in order, record proof with timestamps, and switch between normal, interim, and reduced-function (degraded) operating modes in a controlled way.
- [ ] Create a reconstitution phase checklist that turns off temporary capabilities, completes full capability checks, and switches continuous monitoring back on and verifies it is working correctly.
- [ ] Add the reauthorisation steps to the reconstitution process when organisational policy requires them.
- [ ] Run controlled recovery and reconstitution tests, and keep records showing that the 24-hour and 72-hour recovery targets were met.


---

#### CP-10.2 — Transaction Recovery (Enhancement)

This expectation is about making sure that if a transaction-based system (such as a database or a payments or order processing service) crashes or fails while it is making changes, it can restore the system to a correct and consistent state. Without this, partial changes could be left behind, leading to incorrect balances, duplicate records, missing orders, or other expensive errors that are difficult to spot and even harder to fix.

To meet this expectation, the organisation must build transaction recovery into every transaction-based system and keep it working. This includes the ability to undo incomplete work, and, where needed, record changes so they can be replayed or reversed after a failure. The organisation must also keep clear records of what recovery actions were taken and retain the related system audit information, so this can be shown later.

Finally, recovery responsibilities and procedures must be documented, and supported by contingency planning and testing. Test results and evidence must match the recorded recovery actions.

##### Enable DB transaction recovery with rollback/journaling and evidence

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define transaction recovery scope and evidence requirements (in-scope components, databases/stores, recovery artefacts to capture, mapping to CP-10(2)) | Compliance Manager | Enterprise | 16h | — |
| Review and enforce application transaction boundaries (standardise BEGIN/COMMIT/ROLLBACK usage, disable/avoid auto-commit on critical write paths, update coding standards and configuration defaults) | Software Lead | Enterprise | 24h | — |
| Implement/verify rollback correctness for critical write operations (code changes + automated tests that prove partial work is undone on failure) | Software Lead | Enterprise | 32h | — |
| Configure and standardise database journaling/WAL and durable recovery settings across in-scope databases (recovery model, log durability, retention for verification, configuration baselines) | Database administrator (DBA) | Enterprise | 24h | £6,000 |
| Implement recovery record generation and correlation hooks (emit recovery start/finish + identifiers; correlate with application failure logs and database error logs) | Security Engineer | Enterprise | 20h | — |
| Build audit-ready evidence repository structure and retention workflow (per test event package: recovery records, correlated logs, configuration snapshots, approvals) | Data Protection Officer | Enterprise | 16h | — |
| Execute controlled failure testing and evidence packaging (forced termination mid-transaction; crash/restart scenarios; archive exact artefacts and results; remediate findings) | Operations Lead | Enterprise | 32h | £3,000 |
| Produce and publish runbooks for recovery verification (who reviews, how to confirm consistency, evidence checks, escalation triggers, periodic review cadence) | Service Delivery Manager | Enterprise | 16h | — |

Total Estimated Effort: **180h**  
Total Estimated Cost: **£9,000**

###### Actions Required for Compliance

- [ ] Create a complete list (inventory) of all transaction-based components—such as databases and transaction-handling services—in both the live (production) and testing environments.
- [ ] Update the application’s data access code to clearly define where each database transaction starts and ends, and make sure a rollback is triggered if any failure occurs.
- [ ] For every in-scope database or transaction store, turn on durable journaling and write-ahead logging (WAL), and set the required recovery model.
- [ ] Set up automated collection of recovery records, including database recovery logs and journal details, plus events showing when recovery starts and finishes, linked to the relevant time stamps and transaction identifiers.
- [ ] Match the recovery records with existing audit logs and security information and event management (SIEM) logs, and store a complete set of audit-ready evidence in the organisation’s evidence repository.
- [ ] Run controlled failure tests (for example, stopping a process in the middle of a transaction and simulating a crash after the transaction is completed) and confirm that the system always returns to a consistent, correct state using automated checks.
- [ ] Publish and keep up to date runbooks that set out the steps for verifying recovery, who is responsible for each step, and how to interpret the retained recovery and audit evidence.


---

#### CP-10.4 — Restore Within Time Period (Enhancement)

This requirement is about quickly putting damaged or disrupted computer parts back into a known, working condition—specifically within 24 hours. Without this, a serious incident, accidental deletion, or system failure could leave your business unable to operate for days. That could mean lost work, missed deadlines, and a risk that information could be changed without authorisation.

To meet this expectation, the organisation must:
- define and document a 24-hour recovery target
- make sure restoration uses approved, tracked recovery information that cannot be changed without detection, so the rebuilt components match a previously proven working state
- include the ability to reinstall from a known-good starting point when needed
- have clear, written recovery and rebuild procedures
- name the people responsible for carrying out these procedures
- have contingency plans that include recovery steps
- keep evidence that recovery testing has been carried out, with measured results showing that restoration can be completed within 24 hours

##### 24-hour restore using signed golden images and integrity-checked baselines

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define in-scope component classes and “known, operational state” acceptance checklists (service health, dependency checks, application smoke tests) | Compliance Manager | Enterprise | 16h | — |
| Produce versioned golden image/template set per component class and link each to a versioned configuration baseline (IaC/config manifests) | System Design Authority | Enterprise | 40h | — |
| Implement integrity protection for restoration artefacts: signing workflow for golden images/templates and baseline artefacts; publish/verify cryptographic hashes | Security Engineer | Enterprise | 32h | £8,000 |
| Build/extend restore automation workflow to: select approved artefact version → verify signatures/hashes → reimage/rebuild → apply baseline → run acceptance checks → record evidence (timestamps, results) | Platform Engineer | Enterprise | 56h | £12,000 |
| Create and operationalise restore runbooks + contingency-plan updates (reimaging steps, rollback/abort criteria, required approvals, escalation paths, authorisation model) | Operations Lead | Enterprise | 24h | — |
| Execute timed restore drills (non-production first, then production-like) for representative component classes; capture audit evidence and measure completion within 24 hours | Service Delivery Manager | Enterprise | 32h | — |
| Remediate drill gaps and harden evidence collection (audit trail completeness, failure-mode handling, performance tuning to meet 24-hour target) | DevOps Lead | Enterprise | 24h | £3,000 |

| Total Estimated Effort | 254h |  |
|---|---:|---:|
| Total Estimated Cost |  | £23,000 |

###### Actions Required for Compliance

- [ ] Set “known-good” recovery targets and approval checks for each component type that must be restored within 24 hours.
- [ ] Create and version “golden” images/templates, and link each version to an approved configuration baseline under change control.
- [ ] Use digital signatures or hashes to protect the integrity of key “golden” files and configuration baselines, and make integrity checks mandatory before any restore operation.
- [ ] Set up an automated restore process that checks the data is intact, rebuilds the system, installs the standard (baseline) application, and runs acceptance tests, while recording the start and end times.
- [ ] Publish the restore and reconstitution runbooks, and make sure the contingency plan refers to the restore process and the escalation and abort criteria.
- [ ] Run timed “restore” practice exercises on representative components and keep audit-ready records showing that systems can be restored within 24 hours.


---

#### CP-10.6 — Component Protection (Enhancement)

This requirement is about keeping the “recovery kit” that restores your systems safe and trustworthy. If something goes wrong, you should be able to rebuild service without allowing the wrong people to tamper with it. Without this, attackers or careless insiders could change the hardware, software, or backup materials used for restoration. This could lead to you restoring corrupted or malicious versions, or being unable to recover at all.

To meet this expectation, the organisation must keep an up-to-date list of all recovery and restoration components. This includes the backup and restore software needed, such as the tools and any supporting system software. These components must be protected using suitable physical security measures and access restrictions.

Access must be limited to authorised personnel. This should be supported by documented contingency planning policy, recovery procedures, and a contingency plan. It should also be supported by system design and configuration records, a security plan, and records showing who is authorised and which credentials are in place and kept secure.

##### Recovery artefact vault with integrity checks and restricted access

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define recovery artefact vault target architecture (physical + technical), trust model, and control requirements (RBAC, immutable storage, integrity/signature verification, JIT access, audit evidence) | System Design Authority | Enterprise | 24h | — |
| Create and populate authoritative recovery artefact inventory (hardware/media, firmware, compilers, router tables, restore tools, required system software) with versioning, purpose, owning team, storage location, and approval status | Compliance Manager | Department | 32h | — |
| Implement restricted artefact repository/object storage with immutable versioning and enforced access policies (private buckets/repositories, least-privilege, separation of duties) | Platform Engineer | Enterprise | 40h | £18,000 |
| Establish signing/approval gates for recovery artefacts (key management approach, signing workflow, validation requirements, promotion process to “approved/usable”) | Security Engineer | Enterprise | 32h | £6,000 |
| Implement mandatory integrity verification at download/use time (hash checking and/or signature validation, failure handling, and usability enforcement) | Software Lead | Enterprise | 40h | — |
| Integrate vault access with identity provider and PAM (strong authentication, privileged recovery roles, just-in-time elevation, session controls, and approval workflows) | DevOps Lead | Enterprise | 24h | £12,000 |
| Design and implement audit evidence capture (who accessed, which artefact version retrieved, which restore operation used it), log retention alignment, and SIEM export | Operations Lead | Enterprise | 24h | £5,000 |

Total Estimated Effort: **216h**  
Total Estimated Cost: **£41,000**

###### Actions Required for Compliance

- [ ] Create a complete, authoritative list of recovery items, covering hardware, firmware, software, and backup and restore components.
- [ ] Set up a restricted recovery file repository with unchangeable versions and role-based access control (RBAC).
- [ ] Set up mandatory integrity checks (hash and signature validation) for every recovery file at the time it is downloaded or used.
- [ ] Set up a documented approval and change checkpoint so that only security-reviewed and formally signed materials can be used for recovery.
- [ ] Store secure recovery hardware and media in controlled physical storage. Use a documented issue-and-return process and keep records of who has custody (custody logs).
- [ ] Integrate recovery access with the organisation’s identity provider (IdP) to require strong authentication and grant temporary, on-demand permission for restore operations.
- [ ] Enable and keep audit logs that show who accessed each version of an artefact and which restore or reconstitution test used it.


---

### CP-11 — Alternate Communications Protocols (Control)

This requirement is about making sure your organisation can still communicate during a disruption, even if the usual phone or messaging service stops working. Without an agreed backup plan, important decisions and urgent alerts could be delayed or missed, leaving staff unable to coordinate and putting people, services, and day-to-day operations at risk.

To meet this expectation, the organisation must be able to use a secure voice and video calling method as the backup. If that backup fails, there must be a planned fallback to an encrypted satellite link. For critical alerts, there must also be a separate text-message route.

Before using these alternate methods, the organisation must assess and record any knock-on effects on everyday systems and working practices, and keep evidence that this assessment was completed and approved. It must also clearly assign named responsibilities, document the steps and triggers for switching to the backup routes, keep the relevant plans and system records up to date, and be able to demonstrate the capability through practical testing.

##### Continuity alternate comms: Secure SIP TLS with satellite + SMS

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Establish Continuity Communications Register (Secure SIP TLS, encrypted satellite, out-of-band SMS) including endpoints, routing rules, message/alert types, operational constraints, and audit logging requirements | Compliance Manager | Enterprise | 16h | — |
| Design Secure SIP over TLS architecture: SIP proxy/registrar configuration approach, required TLS settings (cipher suites, protocol versions), certificate trust model, and certificate/expiry monitoring integration | System Design Authority | Enterprise | 24h | — |
| Implement Secure SIP over TLS: configure SIP proxy/registrar to require TLS, enforce approved cipher suites, integrate certificate lifecycle controls, and add monitoring/alerting for TLS session health and expiry | Security Engineer | Department | 40h | £6,000 |
| Implement deterministic fallback orchestration to encrypted satellite link: define health-check triggers, failover routing logic, manual continuity switch controls, and ensure failover events are logged to SIEM/audit store | Infrastructure Lead | Enterprise | 32h | £12,000 |
| Implement out-of-band SMS critical alerting: deploy/configure dedicated alerting service, recipient lists, message templates, rate limiting, delivery/acknowledgement capture, and escalation workflow | Platform Engineer | Enterprise | 32h | £8,000 |
| Perform side-effect analysis and produce approval-ready impact assessment (application behaviour, authentication/call routing impacts, operational procedure changes, OT/IT constraints) and link outcomes to change/approval records | Data Protection Officer | Enterprise | 24h | — |
| Create operator runbooks and switching procedures (step-by-step sequence, verification checks, escalation paths, evidence to capture) and update operational controls for continuity exercises | Service Delivery Manager | Department | 16h | — |
| Execute controlled continuity exercises (table-top + technical failover drill) and produce auditable evidence pack (logs, SIEM events, SMS delivery confirmations, exercise report, lessons learned and remediation actions) | Project Manager | Enterprise | 24h | £3,000 |
| **Total Estimated Effort** |  |  | **208h** |  |
| **Total Estimated Cost** |  |  |  | **£29,000** |

###### Actions Required for Compliance

- [ ] Document the Continuity Communications Register for **cp-11_odp**, covering **secure Session Initiation Protocol (SIP) over Transport Layer Security (TLS)**, **encrypted satellite fallback**, and **out-of-band text messages (SMS)**, including the **routing rules** and **operational limits**.
- [ ] Set up secure Session Initiation Protocol (SIP) over Transport Layer Security (TLS) with mandatory TLS settings, and monitor certificate renewals and expiry dates.
- [ ] Set up predictable failover triggers and route traffic through the encrypted satellite link, and record all failover events for audit purposes.
- [ ] Set up an out-of-band text message (SMS) alert service with the intended recipients, predefined templates for critical alerts, limits on how many messages can be sent in a given time, and rules for confirming delivery and escalating if messages are not acknowledged.
- [ ] Complete and record a side-effect assessment (including application and operational impacts), and link it to the change and approval evidence before enabling the change in the live production environment.
- [ ] Publish operator runbooks that describe the switching steps, how to verify the change, who is responsible for each task, and how to escalate issues if something goes wrong.
- [ ] Run a controlled continuity test to confirm that all backup options work properly, and keep the supporting evidence (system logs, SMS delivery confirmations, and the test report).


---

### CP-12 — Safe Mode (Control)

This requirement is about putting a system into a locked-down “safe mode” when something looks seriously wrong. In safe mode, the system continues only the most critical work, while everything else is shut down. Without this, a malware incident, repeated suspicious login attempts, unauthorised changes to the system’s files or code, or the loss of the communications link the system relies on could allow an attacker to cause wider damage, keep access available, or overwhelm the system and disrupt essential services.

The organisation must clearly define:
- what safe mode allows (only essential functions)
- what it limits (network use to pre-set rates)
- what it turns off (non-essential services and remote administration)

It must also define the warning signs that trigger safe mode. The system must be able to switch into safe mode automatically, or allow authorised staff to switch it manually, using documented procedures.

The organisation must test that safe mode triggers correctly, keep records of tests and incidents, and be able to show when safe mode was entered and what restrictions were applied.

##### Automated Safe Mode for defined triggers with bandwidth and admin blocks

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define Safe Mode Profile schema and per-environment/tier posture parameters (allow-list essential functions, disablement list, admin block rules, bandwidth caps) | System Design Authority | Enterprise | 24h | — |
| Implement application-tier safe mode enforcement (feature flags/routing/integration disablement; ensure only essential endpoints/services remain) | Software Lead | Department | 40h | — |
| Implement host/container-tier safe mode enforcement (stop/disable non-essential services; restrict admin interfaces; ensure safe-mode config is applied idempotently) | Platform Engineer | Department | 32h | — |
| Implement network-tier bandwidth limiting and remote admin blocks (rate-limiting for defined traffic classes; deny SSH/RDP/remote console and privileged management paths) | Infrastructure Lead | Department | 32h | £6,000 |
| Build detection-to-action orchestration workflow (condition detection mapping, automatic safe mode entry, authorised manual entry with approvals, rollback/exit criteria) | Security Engineer | Enterprise | 48h | — |
| Implement audit evidence and logging (trigger details, safe mode profile/version, enforced restriction identifiers, configuration IDs; integrate with SIEM/retention requirements) | Compliance Manager | Enterprise | 24h | — |
| Execute safe mode activation and evidence tests per trigger (automated test cases, timing/operational window validation, negative tests for bypass, DR/test environment run) | Quality Assurance Lead | Business Unit | 40h | £3,500 |
| Produce runbook and operational readiness (incident response safe mode procedure, roles/approvals, monitoring dashboards/alerts, tabletop exercise) | Service Delivery Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 276h  
**Total Estimated Cost:** £9,500

###### Actions Required for Compliance

- [ ] Create “Safe Mode” profiles that apply the {{cp-12_odp.01}} restrictions in each environment, including an essential allow-list, disabling non-essential functions, blocking remote administration, and setting predefined bandwidth limits.
- [ ] Set up detection rules that link each {{cp-12_odp.02}} condition to a safe mode response for: malware detection, loss of file integrity checks, repeated authentication failures, and loss of command-and-control connectivity.
- [ ] Set up an automated orchestration workflow to apply the Safe Mode profile to the affected application tiers and supporting infrastructure whenever the defined triggers activate.
- [ ] Set up “application safe mode” behaviour using feature flags and routing to turn off non-essential endpoints and integrations, while keeping essential functions working.
- [ ] During safe mode, restrict network and administrative access by limiting how often requests can be made and by blocking remote administration access, using configuration identifiers that can be measured and verified.
- [ ] Create an authorised “manual safe mode” runbook (step-by-step workflow) and link it to the incident response approval process.
- [ ] For every safe mode entry, create and keep audit records showing the trigger, time and date, the profile that was applied, and the restrictions that were enforced. Also run activation tests for each trigger.


---

### CP-13 — Alternative Security Mechanisms (Control)

This expectation is about making sure the organisation can still confirm people’s identities and keep access limited to the most sensitive systems even if the usual sign-in method fails or is suspected to be compromised. Without a ready alternative, a major outage or security incident could prevent senior leaders and system administrators from accessing systems, or could allow unauthorised access to privileged accounts and critical services—stopping essential work.

The organisation must set out in its contingency planning when it will use alternative security methods, document exactly which methods it will use, and ensure they apply only to privileged accounts and critical system services. It must provide one-time codes to named senior executives, officials, and system administrators. It must also have an emergency way to bypass the usual multi-step sign-in, but only with extra safeguards that are in place during the bypass and are removed once the emergency ends.

The organisation must include these steps in its contingency and business continuity plans, configure the systems to support them, assign clear responsibilities, and keep evidence that it has tested the approach and that the test results show it works.

##### Break-glass one-time pads for privileged access during MFA failure

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| CP-13 contingency trigger & scope design: define MFA/IdP outage and suspected compromise triggers; confirm privileged roles and critical system services scope; update contingency/continuity procedures | Compliance Manager | Enterprise | 24h | — |
| One-time pad architecture & data model: design pad inventory workflow, pad ID lifecycle (issued/used/retired), dual-control issuance record, and audit logging requirements | System Design Authority | Enterprise | 32h | — |
| Secure vault/secret-store implementation for pad material: configure restricted access for authorised custodians, implement dual control for issuance, and establish tamper-evident audit trails | Security Engineer | Enterprise | 40h | £12,000 |
| Pad-based privileged authentication integration: implement pad verification with atomic non-reuse enforcement, separate pad auth path from normal authentication, and enforce role/service scope checks | Software Lead | Enterprise | 64h | £8,000 |
| Emergency MFA bypass capability: implement incident-process-only enablement, time-bound automatic expiry, scope-limited privileged-only enforcement, and compensating controls (step-up/out-of-band approval hooks where feasible) | Platform Engineer | Enterprise | 56h | £10,000 |
| Monitoring, alerting & SIEM evidence: add high-signal alerts for bypass usage and privileged pad logins, ensure log retention/immutability alignment, and produce audit-ready evidence mappings | Operations Lead | Enterprise | 32h | £6,000 |
| Testing & assurance: tabletop exercise plus controlled technical test plan and execution (trigger authorisation, pad issuance/auth success, non-reuse, bypass activation/expiry), including evidence pack for compliance review | Quality Assurance Lead | Enterprise | 40h | — |

**Total Estimated Effort:** 288h  
**Total Estimated Cost:** £36,000

###### Actions Required for Compliance

- [ ] Define the triggers for CP-13 and document that alternative mechanisms apply only to privileged accounts and critical system services.
- [ ] Set up a one-time pad inventory with unique pad identifiers, two-person approval for issuing pads, and records of all pad activity for auditing.
- [ ] Add pad-based authentication to the privileged access process, using a one-time rule that prevents reuse.
- [ ] Set up an emergency multi-factor authentication (MFA) bypass as a separate switch that is limited to a specific time window and scope, includes compensating controls, and automatically expires.
- [ ] Update contingency and business continuity plans to include step-by-step CP-13 procedures for issuing pads and using the emergency bypass.
- [ ] Run and record a controlled test (or tabletop exercise) to demonstrate that pad authentication works as intended, that codes are not reused, that bypass activation cannot be triggered, that compensating controls are in place, and that access expires as required.

