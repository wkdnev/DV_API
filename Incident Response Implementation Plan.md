### IR-1 — Policy and Procedures (Control)

This requirement is about making sure the organisation has a clear, written plan for what to do when something goes wrong, and that the right people know it. Without an up-to-date incident response policy and practical procedures, a serious event could be handled inconsistently, important decisions could be delayed, evidence could be handled incorrectly, legal and regulatory duties could be missed, and recovery could take longer and cost more.

The organisation must create, document, and share an organisation-wide incident response policy. This policy must explain its purpose, what it covers, the roles and responsibilities of different people, management commitment, how different parts of the business will work together, and how the organisation will meet compliance requirements. It must also align with relevant laws, regulations, organisational policies, standards, and guidance.

An incident response policy owner within the Chief Information Security Officer (CISO) office must manage the creation, documentation, and distribution of both the policy and the procedures.

The policy and procedures must be reviewed and updated at least every year, and also after major security incidents, audit findings, breach notifications, significant legal or regulatory changes, Cybersecurity Maturity Model Certification (CMMC) assessment results, or major changes to systems or system architecture. They must be shared with the relevant leadership, incident responders, security, privacy, legal and compliance teams, information technology (IT) and operational technology (OT) operations managers, and system owners.

##### IR policy & procedures governed by IRPO with event-driven reviews

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Establish IR policy governance: confirm IRPO mandate, approval workflow, RACI, and coordination points with Security and Privacy programmes (incl. meeting cadence and decision rights) | Compliance Manager | Enterprise | 16h | — |
| Draft organisation-level IR policy (single source of truth): purpose, scope, management commitment, roles/responsibilities, coordination model, compliance alignment (laws/regulations/standards), and meaningful description of how IR is implemented | Cyber Security Lead | Enterprise | 40h | — |
| Develop supporting IR procedures (runbooks): incident intake/triage, escalation, investigation, containment/eradication/recovery coordination, evidence handling, communications, and post-incident review/lessons learned (including privacy/legal triggers and record-keeping considerations) | Security Engineer | Enterprise | 56h | — |
| Validate operational usability: workshops with SOC leadership, incident responders, security engineering, IT/OT operations, and system owners; incorporate feedback and produce procedure-to-role guidance (who does what, when) | Operations Lead | Enterprise | 24h | — |
| Define dissemination and controlled access: publish policy/procedures in approved repository with versioning/change history; implement acknowledgement/attestation mechanism for required roles; confirm distribution lists and access permissions | Platform Engineer | Enterprise | 24h | £3,000 |
| Implement event-driven review triggers and update records: define annual and post-trigger review process, evidence requirements (last review date, rationale, approvals), and a lightweight tracker for audit readiness | Project Manager | Enterprise | 16h | — |
| Execute initial dissemination and evidence capture: distribute policy and procedures to defined audiences; collect acknowledgements; produce an initial “go-live” evidence pack for audit (approvals, dissemination logs, contribution evidence from Security/Privacy/Legal) | Compliance Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 192h  
**Total Estimated Cost:** £3,000

###### Actions Required for Compliance

- [ ] Appoint an Incident Response Policy Owner (IRPO) within the Chief Information Security Officer (CISO) team and publish their governance responsibilities.
- [ ] Draft and get approval for an organisation-wide incident response policy that sets out its purpose, what it covers, who is responsible for what, how incidents are coordinated, management’s commitment, and how it aligns with legal and regulatory requirements.
- [ ] Develop incident response procedures as step-by-step implementation guides (runbooks), using input from the security and privacy programme.
- [ ] Share the policy with the identified policy audiences, and share the procedures with the identified procedure audiences, using a controlled document repository.
- [ ] Set up a documented process to review and update policies and procedures every year and after each defined event: a major incident, an audit finding, a breach notification, a material legal or regulatory change, a Cybersecurity Maturity Model Certification (CMMC) outcome, or a significant change to the system architecture.
- [ ] Collect and keep evidence that information was shared or accessed, and that security, privacy, and legal checks were completed and approved, so the organisation is ready for audit.


---

### IR-2 — Incident Response Training (Control)

This requirement is about ensuring the right people are trained to respond quickly and correctly when something goes wrong. Without regular, job-specific training, staff may not recognise suspicious activity, may report issues late, or may take the wrong actions during an incident. This can cause more disruption, loss of sensitive information, and longer recovery times.

The organisation must provide incident-response training to all relevant system users within 30 days of them taking on an incident-response role or receiving the related system access. Training must then be refreshed whenever system changes mean it is no longer up to date. Everyone with these responsibilities must also complete a refresher at least once every year.

In addition, the organisation must review the training materials at least every quarter and update them after incident-response plan testing results, lessons learned from real incidents, audit or assessment findings, and changes to relevant laws, directives, regulations, policies, standards, or guidance.

##### Automate role-based IR training enrolment and quarterly content updates

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define role-to-training mapping, module catalogue, and due-date logic (30-day initial, annual refresher, quarterly review cadence) including authoritative role/access signals and re-enrolment triggers | Cyber Security Lead | Enterprise | 24h | — |
| Configure LMS/training platform data model for auditable evidence (enrolment timestamp, module version, completion status, completion timestamp) and reporting fields | LMS/Training Platform Administrator | Enterprise | 32h | — |
| Implement identity-to-LMS automated enrolment workflow (IdP group/role assignment and access grant events → correct module enrolment) with exception handling for ambiguous/edge cases | IAM/Identity Engineering Lead | Enterprise | 40h | £8,000 |
| Build annual refresher scheduling and automated reminders (per role category), including non-completion tracking and governance exception routing | Operations Lead | Enterprise | 24h | — |
| Implement quarterly content review workflow with document control/versioning, approval records, and publishing “latest approved” module versions to the LMS | Compliance Manager | Enterprise | 32h | — |
| Create trigger intake and change impact assessment process (IR plan testing results, lessons learned, audit/assessment findings, legal/policy/standard changes) that updates curriculum items and determines whether re-enrolment is required | Project Manager | Enterprise | 24h | — |
| Develop audit-ready reporting dashboards/exports and evidence packs (trained users, due dates, completion timeliness, module versions, quarterly approvals, trigger-to-update traceability) | Internal Audit/Compliance (or GRC) | Enterprise | 24h | — |

**Total Estimated Effort:** 200h  
**Total Estimated Cost:** £8,000

###### Actions Required for Compliance

- [ ] Define which role is trained on which training module, and set the training depth for each role (user, administrator, or incident responder).
- [ ] Link trusted identity and access management (IAM) and human resources (HR) role and access information with the learning management system (LMS) to automatically enrol users and calculate their due dates for the next 30 days.
- [ ] Set up the learning management system (LMS) to record evidence that can be audited, including the course module version, the time a learner enrolled, and the time the learner completed the module.
- [ ] Arrange annual refresher training for each job role, with automated reminders and a process to route exceptions when people do not complete the training.
- [ ] Set up a quarterly process to review content, using tracked versions and formal sign-off, and publish the most recently approved module.
- [ ] Set up a process to collect and review information from incident response (IR) plan testing results, lessons learned, audit or assessment findings, and changes to laws or policies. Use this information to update the training curriculum and decide what parts of the programme need re-enrolment.
- [ ] Produce regular compliance reports that show, for each user, the required training for their role, the due date, the training module version, and the quarterly approvals.


---

#### IR-2.1 — Simulated Events (Enhancement)

This requirement is about making sure people practise dealing with real-life emergencies, not just reading about them. Without realistic practice, staff may hesitate, miss important steps, or contact the wrong people when something goes wrong. This can delay action, increase damage, and raise the risk of harm to customers’ personal information.  

The organisation is expected to include realistic simulated incident scenarios in its incident response training. It should use its incident response policy and incident response plan as the basis for what participants must do, including the specific responsibilities and key decisions for each role. Training should follow the organisation’s training procedures, course content, and materials. It should also clearly show participants how to carry out their own duties during the simulations, including any privacy-related responsibilities where relevant.  

The organisation must keep records confirming that the simulated events were included, delivered, completed, and reviewed. Any follow-up actions from these exercises must be used to improve future training.

##### Role-based simulated incident injects mapped to IR plan actions

- Category: Manual
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Establish exercise scope, success measures, and IR plan/policy sections to be exercised (including roles, escalation thresholds, evidence/notification requirements) | Compliance Manager | Enterprise | 16h | — |
| Build scenario library (e.g., credential compromise, ransomware/availability impact, suspicious data exfiltration, malicious API activity) with objectives, realism level, expected participant actions, and targeted IR plan steps/decision points | Incident Response Training Lead | Department | 40h | — |
| Create scenario-to-plan mapping matrix and obtain formal validation/approval from the incident response function | Incident Response Manager | Enterprise | 24h | — |
| Develop role cards and mandatory action checklists per role (SOC/monitoring analyst, incident commander, application owner, IT operations, communications lead, privacy lead where applicable) including concrete artefacts to collect/draft | Security Engineer | Department | 32h | — |
| Prepare controlled inject delivery packs (timed inject scripts, facilitator guides, and pre-prepared telemetry/log artefacts aligned to SIEM/monitoring sources) | Operations Lead | Business Unit | 24h | £3,000 |
| Run at least one full role-based tabletop/hybrid tabletop exercise and capture auditable training evidence (attendance, inject IDs, actions/decisions, facilitator checklist results) | Service Delivery Manager | Business Unit | 24h | — |
| Conduct AAR, produce corrective action log, and update scenario scripts/role cards/training materials for the next cycle (including evidence linkage to plan/policy sections) | Project Manager | Enterprise | 20h | — |

**Total Estimated Effort:** 180h  
**Total Estimated Cost:** £3,000

###### Actions Required for Compliance

- [ ] Create a library of simulated incident scenarios that are relevant to the application, and set clear learning objectives for each scenario.
- [ ] Create a matrix that maps each “inject” to the specific steps and decision points in the incident response plan and policy.
- [ ] Create role cards and facilitator checklists that require participants to carry out specific actions that match the plan.
- [ ] Prepare test “inject” files using the organisation’s real monitoring and logging sources (for example, security information and event management (SIEM) alert summaries and sample logs) so the results are realistic.
- [ ] Run time-limited practice exercises with controlled scenario prompts, and record who attended, what happened during each prompt, and what decisions were made.
- [ ] Carry out an after-action review and update the scenario scripts, role cards, and training materials based on the corrective actions.


---

#### IR-2.2 — Automated Training Environments (Enhancement)

This requirement is about giving incident response teams a realistic place to practise responding to real problems, not just discussing them. Without this, staff may not know what to do when something goes wrong, may miss important steps, may handle key information incorrectly, or may communicate too late—turning a manageable incident into a larger service outage, loss, or privacy breach.

The organisation must provide an automated training setup that runs tabletop-style exercises. Each exercise should use timed, pre-set prompts that introduce new information as the session progresses. During each prompt, trainees must follow the organisation’s step-by-step incident response playbooks. The system must record what they did and when, store the evidence for later review, and automatically produce an after-exercise score that highlights strengths and areas for improvement.

The exercises and scoring must match the organisation’s incident response policy, training approach, course content, learning materials, and any relevant plans and records. They must also include staff who have incident response, information security, and privacy responsibilities.

##### Automated IR training platform with injects, playbooks, evidence scoring

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define IR training requirements and scenario-to-playbook mapping approach (including measurable required actions, timeliness windows, escalation criteria, and evidence fields) | Compliance Manager | Enterprise | 24h | — |
| Build scenario library design and inject timeline specification (tabletop + inject stages, fact progression rules, stage gating, and role-based participation model) | System Design Authority | Enterprise | 32h | — |
| Configure/implement platform workflow for guided trainee interaction (stage-linked required actions, checklist/ticket/form capture, response validation, and audit trail hooks) | Platform Engineer | Enterprise | 56h | — |
| Implement evidence capture, retention, and tamper-evident storage (timestamping, trainee identity/role linkage, artefact upload handling, evidence indexing, and export for review) | Security Engineer | Enterprise | 48h | £18,000 |
| Implement rubric-based after-action scoring engine and automated scorecard/report generation (per inject stage scoring, evidence references, strengths/gaps, and configurable rubrics) | Software Lead | Enterprise | 56h | — |
| Integrate with enterprise identity and access controls (SSO, role mapping, least-privilege access to exercises/evidence, and environment segregation for dev/test/prod) | Infrastructure Lead | Enterprise | 32h | — |
| Governance alignment and validation (map scenarios/rubrics to IR policy/procedures/curriculum; privacy review for privacy-related injects; produce audit-ready traceability matrix) | Data Protection Officer | Enterprise | 24h | — |

| Total Estimated Effort | 272h |  |
| Total Estimated Cost |  | £18,000 |

###### Actions Required for Compliance

- [ ] Create a scenario authoring template that links each step in an incident response playbook to the actions required during the injection stage and the scoring rules (rubrics).
- [ ] Create an initial library of “inject” scenarios (the minimum viable set) that matches the organisation’s incident response (IR) policy, training curriculum, and relevant security and privacy plans.
- [ ] Set up the training platform so it delivers time-based prompts and requires trainees to respond with answers that match the relevant playbook steps for the current stage of the scenario.
- [ ] Set up automated evidence collection for every required step (date and time, training stage, trainee identity and role, and what was submitted) and store it in a secure, tamper-evident system that can be audited.
- [ ] Set up automated after-action scoring that generates a scorecard/report. The report should point to the evidence that was captured and show how it met the scoring criteria (rubric) outcomes.
- [ ] Run a pilot exercise with the incident response (IR), security, and privacy teams, and get approval that the scoring and required actions match the agreed playbooks and procedures.
- [ ] Document the exercise runbook (how to start scenarios, manage participants, and collect evidence and scorecards) and add it to the organisation’s training governance process.


---

#### IR-2.3 — Breach (Enhancement)

This requirement is about making sure people can recognise when sensitive information may have been exposed or accessed in the wrong way, and understand exactly what to do next. Without clear training, staff may miss early warning signs, report problems late, or treat a suspected incident as harmless—allowing harm to grow and personal details to be misused.  

The organisation must provide practical, plain-language training that explains what counts as a data breach. This includes cases involving personal information, whether the issue is confirmed or only suspected, and whether it happens through emails and files, printed documents, or even spoken conversations.  

The training must also set out the organisation’s step-by-step process for reporting both confirmed and suspected breaches, including who to contact and what information to include. This should be reinforced through discussion-based practice sessions that simulate real breach situations, so staff can follow the reporting process under pressure.

##### Breach recognition & reporting training with PII scenarios

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define breach training scope, role mapping, completion targets, and refresh cadence (including contractors and high-risk roles) | Project Manager | Enterprise | 16h | — |
| Produce breach reporting process training pack (who to report to, reporting channel, required details, expected timescales, and “do not investigate beyond guidance”) | Compliance Manager | Enterprise | 24h | — |
| Develop scenario library covering confirmed vs suspected breaches across electronic, paper, and oral media, with explicit PII-as-breach guidance | Security Engineer | Enterprise | 56h | — |
| Create facilitator-led session materials and e-learning content outline (baseline recognition + higher-risk role modules), including accessibility and language considerations | Quality Assurance Lead | Enterprise | 32h | — |
| Configure learning delivery and tracking: enrolment rules by role, completion recording, and audit-ready evidence capture (attendance, completion status, scenario check results) | Operations Lead | Enterprise | 24h | £6,000 |
| Run tabletop exercises (at least annually): plan, execute, capture outcomes, identify gaps, and produce remediation actions and follow-up owners | Incident Response Lead | Enterprise | 40h | — |
| Co-review and sign-off with Privacy Officer / Data Protection Lead and Security stakeholders; update content to ensure consistency with PII breach obligations and organisational policy | Data Protection Officer | Enterprise | 16h | — |
| Implement effectiveness checks (scenario-based quizzes/decision prompts) and report results to stakeholders with improvement backlog | Compliance Manager | Enterprise | 20h | — |

**Total Estimated Effort:** 218h  
**Total Estimated Cost:** £6,000

###### Actions Required for Compliance

- [ ] Create a role-based training plan (a matrix) for all staff who may come across or report suspected security breaches.
- [ ] Create a library of breach scenarios for electronic, paper, and spoken (oral) information, clearly labelled as either confirmed or suspected.
- [ ] For every scenario, include the organisation’s breach reporting steps (who to report to, which channel to use, what information is required, and the expected timescale).
- [ ] Review training materials together with information security and privacy stakeholders to ensure that any personal data (PII) incident is handled as a data breach.
- [ ] Provide baseline training and run guided sessions led by facilitators for higher-risk roles, and record when each participant has completed the training.
- [ ] Run tabletop exercises using the scenario library, and record outcomes and follow-up remediation actions in a way that can be audited.
- [ ] Set up scenario-based checks to confirm that learners can correctly identify and report suspected and confirmed data breaches.


---

### IR-3 — Incident Response Testing (Control)

This requirement is about making sure your organisation can respond effectively when something goes wrong, by regularly testing how your incident response team would act. Without these checks, you may only find out too late that your plans are unclear, people do not know their responsibilities, key actions take too long, or the response causes unnecessary disruption to services, important resources, or even affected individuals.

To meet this expectation, the organisation must test its incident response capability for the relevant system every quarter using three types of exercises: a tabletop exercise (a structured discussion), a parallel simulation (a simulated incident handled alongside normal work without fully stopping), and a full interrupt simulation (a more disruptive test that interrupts normal operations to check end-to-end readiness).

Before each quarter’s testing, the organisation must prepare a test plan and materials. After each test, it must record the results, including evidence that the exercise was effective and any impacts on organisational operations, assets, and individuals, and keep these records so they can be reviewed.

##### Quarterly IR testing with tabletop, parallel, and full interrupt

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define quarterly IR test scope and objectives for the target enterprise application (system boundaries, roles/RACI, scenario selection approach, evidence requirements, effectiveness metrics including impacts on operations/assets/individuals where applicable) | Compliance Manager | Enterprise | 16h | — |
| Produce tabletop exercise pack (structured scenario, decision/checklist prompts, communications walkthrough, decision log template, participant instructions, and expected evidence outputs) | Incident Response Lead | Enterprise | 20h | — |
| Produce parallel simulation plan and materials (monitoring plan, operational impact metrics, data capture approach, runbook for IR actions while normal operations continue, and evidence capture templates) | SOC Manager | Enterprise | 24h | — |
| Produce full interrupt simulation plan and materials (controlled interruption approach, pre-approved continuity/rollback steps, safety/stop conditions, stakeholder approvals checklist, and evidence capture templates) | Operations Lead | Enterprise | 28h | — |
| Execute the quarterly test cycle: run tabletop, parallel simulation, and full interrupt simulation; capture auditable outputs (attendance/participation records, decision/timeline logs, actions taken, measured outcomes) | Incident Response Lead | Enterprise | 40h | — |
| Conduct post-test review, effectiveness assessment, and corrective action tracking to closure (identify weaknesses/deficiencies, validate impacts on operations/assets/individuals, assign owners/due dates, update playbooks/checklists/runbooks) | Compliance Manager | Enterprise | 24h | — |
| Archive and retain evidence in a controlled repository (versioned storage of test plans/materials/results, audit trail, and linkage to corrective actions for the quarter) | Data Protection Officer | Enterprise | 12h | — |

**Total Estimated Effort:** 164h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Set the quarterly incident response (IR) test timetable for the specified system and confirm which test types are required: tabletop exercises, parallel simulations, and full interrupt simulations.
- [ ] Create an incident response (IR) test plan template for each quarter that covers the scope, objectives, responsibilities, expected evidence, and prompts for assessing impact.
- [ ] Develop and get approval for scenario packs and runbooks for each type of test, including decision records, step-by-step checklists, and instructions for monitoring and collecting evidence.
- [ ] Complete the tabletop exercise, run the parallel simulation, and carry out the full interruption simulation within the quarter. Record auditable evidence of the results, including attendance, timelines, decisions made, and actions taken.
- [ ] Record and keep test results in a secure, controlled storage location, including evidence that the tests worked and any effects on the organisation’s operations and assets (and on individuals where relevant).
- [ ] Carry out a review after the test to identify any shortcomings, agree corrective actions with named owners and target completion dates, and monitor progress until everything is completed before the next quarterly cycle.


---

#### IR-3.1 — Automated Testing (Enhancement)

This requirement is about making sure your incident response team can practise how they would react to real problems, using automated test runs rather than guesswork. Without this, you may only find out during a real incident that people do not follow the right steps, important actions are missed, or the process fails when repeated pressure is applied—leaving customers and the business exposed.

The organisation is expected to run automated tabletop exercises and step-by-step response rehearsals using a system that can carry out the response plan. The system should be given clearly fake alerts, and the results should be checked using recorded system evidence rather than opinions or screenshots. The tests must use realistic scenarios and be run in environments that match how you operate, including repeated or higher-volume situations to stress the team’s capability.

A test plan must be in place. Test results must be recorded, checked against the plan and procedures, reviewed by the named responsible roles, and kept as auditable records for future learning and improvement.

##### SOAR synthetic-alert harness with log-evidence incident response tests

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define incident response scenario catalogue mapped to IR procedures, including expected playbook actions and measurable outcomes per scenario (phishing, suspicious login, malware alert) | Compliance Manager | Enterprise | 24h | — |
| Design and implement synthetic alert harness with Run ID generation/propagation, realistic non-production event fields, and safe routing to SOAR/ticketing/notification targets | SOAR Engineer | Department | 56h | — |
| Refactor/implement SOAR playbooks as testable procedures: enforce measurable outputs per step (ticket ref, escalation case ID, evidence object IDs), and define explicit conditional branches per scenario | Software Lead | Department | 72h | — |
| Implement log-based validation rules (detection-as-code assertions) with authoritative log sources, timestamped evidence capture, and time-window checks keyed by Run ID | Security Engineer | Department | 56h | — |
| Configure realistic test execution environments and integrations (SIEM/SOC, ticketing, EDR/SOAR execution logs, email delivery logs where applicable) using non-production targets; validate evidence paths end-to-end | Infrastructure Lead | Enterprise | 40h | £8,000 |
| Implement stress/repeat mode with burst controls, throttling, stop conditions, and rate-limited synthetic alert injection; document operational runbook for safe execution | Operations Lead | Enterprise | 32h | — |
| Build auditable evidence pack generation per Run ID (run summary, step trace, validation query results, exceptions) and implement secure storage/retention workflow for review | Data Protection Officer | Enterprise | 32h | £2,500 |
| Establish review and pass/fail workflow: route evidence packs to incident response testing responsible roles, capture remediation actions for failures, and produce a signed-off test cycle record | Project Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 336h  
**Total Estimated Cost:** £10,500

###### Actions Required for Compliance

- [ ] Create a library of incident scenarios linked to incident response procedures, with clearly defined, measurable expected outcomes.
- [ ] Set up a test “alert harness” that creates alerts in a non-production environment and adds a unique run identifier (Run ID) to all downstream outputs.
- [ ] Update security orchestration, automation and response (SOAR) playbooks so that every step produces measurable results that can be checked and verified (for example: ticket IDs, message IDs, evidence IDs, and escalation IDs).
- [ ] Create checks based on log records that look at the official (authoritative) logs and confirm that the expected events occur within the agreed time windows.
- [ ] Set up test runs that use the same integration and logging routes as the live (production) environment, but run them against non-production systems.
- [ ] Add a configurable “stress” or “repeat” mode, with safe speed limits (throttling) and clear stop conditions.
- [ ] For each Run ID, create an evidence pack that can be audited, and send it to the named reviewers for recorded pass/fail decisions and sign-off of any required fixes (remediation).


---

#### IR-3.2 — Coordination with Related Plans (Enhancement)

This requirement is about making sure your plans for dealing with serious incidents are agreed and coordinated with the teams responsible for the other key emergency and recovery plans. This ensures everyone understands their role and follows the same approach. Without this coordination, exercises can create a false sense of readiness, important messages may be sent through the wrong routes, critical services may not be restored in line with your recovery plans, and the people responsible for safety, communications, and business continuity may end up working against each other during a real event.

To meet this expectation, the organisation must:
- identify who is responsible for each relevant plan that could be affected
- invite those people to incident response exercises and practice drills
- make sure the exercise steps, responsibilities, and the records kept afterwards match the incident response plan and the related plans for business continuity, disaster recovery, continuity of operations, contingency, crisis communications, critical infrastructure, and occupant emergency, including information and privacy responsibilities.

##### Coordinate incident response exercises with related plan owners

- Category: Manual
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Establish the Related-Plan Owner Matrix covering exercise types/scenarios and related plan categories (BCP/DR/COOP/contingency/crisis communications/critical infrastructure/occupant emergency as applicable) | Compliance Manager | Enterprise | 16h | — |
| Define exercise participation requirements per scenario in the matrix (required roles, in-scope plan sections, and trigger/decision-point alignment requirements) | Incident Response Programme Manager | Enterprise | 24h | — |
| Create standardised exercise pack templates requiring explicit plan version/owner references, role cards, injects, communications channel references, and an evidence checklist | Project Manager | Enterprise | 32h | — |
| Implement a pre-exercise coordination gate in the workflow system (e.g., ITSM/ticketing) so scheduling/approval requires named plan-owner review and confirmation for in-scope sections | Operations Lead | Enterprise | 40h | £6,000 |
| Configure after-action reporting workflow to require plan-owner-reviewed sections and sign-off on improvement actions (owners and due dates) | Service Delivery Manager | Enterprise | 24h | £2,500 |
| Stand up an auditable evidence repository structure and retention approach (attendance/participation, approved exercise packs, sign-offs, after-action reports linked to plan owners) | Data Protection Officer | Enterprise | 16h | — |
| Pilot the end-to-end process with 1–2 exercises, capture gaps, and update the matrix/templates/workflow to achieve acceptance criteria | Incident Response Programme Manager | Enterprise | 24h | — |

|  |  |  | **Total Estimated Effort** | **Total Estimated Cost** |
|---|---|---:|---:|---:|
|  |  |  | **196h** | **£8,500** |

###### Actions Required for Compliance

- [ ] Identify and record which parts of the organisation are responsible for each plan category that could be affected by incident response testing.
- [ ] Create a “Related Plan Owner Matrix” exercise that matches each scenario or type to the required plan owners and the plan sections that are in scope.
- [ ] Update the incident response exercise pack templates so they must include: references to the plan version, named participants responsible for the plan, and an evidence checklist.
- [ ] Set up a pre-exercise approval step in the workflow system that requires sign-off from all required owners of related plans (and from Security and Privacy teams where applicable).
- [ ] Run the exercises using the approved materials and record who took part, whether each role was carried out as planned, and which communication channels were used as proof.
- [ ] Require each related plan owner to approve (sign off) the parts of the after-action report that affect their plan(s), and record the improvement actions, including the responsible owner and the due date.
- [ ] Store and keep verifiable records that link each exercise or drill to the related plans, approvals, and improvement actions.


---

#### IR-3.3 — Continuous Improvement (Enhancement)

This requirement is about learning from real practice so your incident response works in the moment—not just in documents. If organisations do not regularly test their incident response and then use what they learn to improve, they may respond too slowly, make the wrong decisions under pressure, and repeat the same mistakes. This can turn manageable incidents into expensive disruption, reputational harm, and harm to customers or staff.

To meet this expectation, the organisation must run incident-response tests and use both:
- descriptive feedback (for example, observations and interview notes), and
- measured results (for example, timings and scores)

to judge how effective the response process is and to identify specific improvements.

The organisation must also produce performance measures and metrics that are accurate, interpreted in the same way each time, and set out clearly enough that another competent person could repeat the same evaluation using the same evidence.

The organisation should:
- record the test results,
- clearly explain how each metric was worked out,
- keep the records for later checking,
- assign named people to carry out the testing and evaluation, and
- involve staff with information security and privacy responsibilities in the assessment and improvement decisions.

##### Incident response test scorebook with qualitative/quantitative metrics

- Category: Manual
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Establish IR testing governance: define programme scope, cadence (tabletop + technical drills), test approval workflow, and roles/responsibilities for evidence capture, scoring, review, and closure tracking | Project Manager | Enterprise | 16h | — |
| Create IR testing evidence framework in the incident-response testing playbook (qualitative + quantitative evidence sources, required artefacts, naming conventions, retention expectations, and privacy handling guidance) | Compliance Manager | Enterprise | 24h | — |
| Design the standardised incident-response “scorebook” template (metric catalogue, definitions/purpose, allowed evidence inputs, calculation formulas with rounding rules, interpretation/classification guidance, and reproducibility notes for missing/ambiguous data) | Security Engineer | Enterprise | 32h | — |
| Build metric derivation and audit-ready reporting pack (scorebook version control, evidence reference schema, metric calculation worksheets/forms, and required report sections linking metrics to evidence and assumptions) | Cyber Security Lead | Enterprise | 24h | — |
| Run blended pilot test cycle (at least 1 tabletop + 1 controlled technical drill) using the scorebook; capture raw evidence, compute qualitative and quantitative metrics, and validate scoring consistency via an internal reproducibility check | Operations Lead | Enterprise | 40h | — |
| Conduct structured evaluation workshops after each pilot test (evidence completeness review, reconcile qualitative vs quantitative findings, agree actionable improvements, and document metric-to-action traceability) | Incident Response Manager / SOC Lead | Enterprise | 16h | — |
| Implement improvement tracking to closure (update playbooks/runbooks/escalation paths/detection tuning as applicable, record which metrics/evidence justified each change, and confirm re-test requirements) | Service Delivery Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 176h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Define the qualitative and quantitative evidence sources to be used for incident-response testing in an incident-response testing playbook
- [ ] Create and version a metric scorecard that includes the metric definitions, how each metric is calculated (including formulas), the assumptions used, and the rules for interpreting the results.
- [ ] Set up a regular combined tabletop exercise and technical drill schedule, based on the incident response plan’s scenarios.
- [ ] Run each test and collect proof that it meets the scorebook requirements, including the date and time and the reasons for each decision.
- [ ] Run a post-test review workshop to calculate the results, compare them with the qualitative feedback, and choose specific improvements.
- [ ] Produce an audit-ready test report that shows the metric results and the documented steps used to calculate them, and keep it for later rechecking.


---

### IR-4 — Incident Handling (Control)

This requirement is about making sure the organisation deals with serious problems in a planned, repeatable way, rather than improvising under pressure. If incidents are handled inconsistently, important evidence may be missed, damage may spread, systems may be put back incorrectly, and lessons may be lost—leaving the organisation exposed to the same harm again, disruption to services, and potential breaches involving personal information.

To meet this expectation, the organisation must have clear, documented incident-handling procedures that match its incident response plan and cover the full process: preparing, spotting and understanding what is happening, stopping the impact, removing the cause, and safely restoring services. The organisation must also coordinate these actions with plans for keeping essential operations running during disruption.

Finally, after each incident, the organisation must record what worked and what did not, update procedures, refresh training, and practise through tests or exercises. It must then apply these improvements consistently across the organisation so that the thoroughness, effort, coverage, and results are predictable every time.

##### Playbook-based incident handling with cross-team coordination

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Draft incident playbook framework mapped to IRP phases (prep, detection & analysis, containment, eradication, recovery) including standard closure criteria and continuity/DR “continuity switch” triggers | Cyber Security Lead | Enterprise | 40h | — |
| Create playbooks for required incident types (suspicious email, suspected unauthorised access, malware/ransomware-like activity, suspected supply chain compromise) with triage criteria, decision points, eradication actions, recovery verification steps, and explicit stakeholder triggers | Security Engineer | Enterprise | 56h | — |
| Define cross-functional coordination model (RACI + escalation paths) covering mission/business owners, system owners, AO, HR, physical security, personnel security, legal, risk executive/function, operations, and procurement; publish as an auditable reference linked from each playbook | Compliance Manager | Enterprise | 32h | — |
| Implement case management workflow design for multi-source intake (SIEM/SOAR alerts, endpoint/network telemetry, identity events, physical access anomalies, user/admin reports) including incident record normalisation rules and evidence checklist per lifecycle stage | Project Manager | Enterprise | 24h | — |
| Evidence capture and chain-of-custody standards: define required artefacts, timestamping expectations, approval/verification evidence requirements, retention alignment, and minimum “audit-ready” evidence set for tabletop/real incidents | Data Protection Officer | Enterprise | 24h | — |
| Continuity/contingency integration: update each playbook with continuity switch actions (failover/manual operations/DR runbook invocation), decision triggers, responsible roles, and required post-switch verification | Operations Lead | Enterprise | 20h | — |
| Lessons-learned improvement loop: establish incident review template, version control approach for playbooks/procedures, training/exercise update workflow, and traceability from review outcomes to changes and completion evidence | Quality Assurance Lead | Enterprise | 24h | — |
| Run tabletop/exercise pack for at least 2 incident types to validate coordination, evidence capture, and continuity switch actions; produce findings and required remediation backlog | Service Delivery Manager | Enterprise | 24h | £6,000 |

**Total Estimated Effort:** 244h  
**Total Estimated Cost:** £6,000

###### Actions Required for Compliance

- [ ] Create incident playbooks aligned to the incident response plan stages for: suspicious emails, unauthorised access, malware or ransomware-like activity, and suspected supply chain compromise.
- [ ] Create a cross-functional responsibility and escalation matrix (RACI) covering the mission or business owners, system owners, authorised officer (AO), legal, human resources (HR), physical security, personnel security, the risk executive, operations, and procurement.
- [ ] Set up one incident case workflow that brings in reports in a consistent way from the following sources: security information and event management (SIEM) and security orchestration, automation and response (SOAR), endpoint and network monitoring, physical access monitoring, and reports from users and administrators.
- [ ] Set required evidence-recording fields and approval or verification checks for every step in each playbook, including the date and time, supporting records, affected systems, and the results.
- [ ] Add clear continuity and disaster recovery (DR) switch steps and decision triggers to every playbook. Reference the relevant continuity and disaster recovery (DR) runbooks and the named roles responsible.
- [ ] Set up a “lessons learned” review process that creates numbered (versioned) updates to playbooks and procedures, along with any related training and practice changes, and that clearly links each update back to the review findings (traceability).


---

#### IR-4.1 — Automated Incident Handling Processes (Enhancement)

This requirement is about making sure that when something goes wrong, your team can respond in a consistent, well-documented way using the correct automated tools. Without this, incidents may be handled differently each time, important evidence could be missed or gathered incompletely, and it may be difficult to prove what happened, who did what, and what tools were used during the investigation. This leaves the organisation exposed to repeated problems and poor decision-making.

To meet this expectation, the organisation must support its incident-handling process with:
- an online incident management system
- tools that capture live evidence from systems that are currently running
- tools that record complete network traffic for later review
- forensic analysis tools to examine evidence in a structured way

The organisation must also:
- document how these tools are used in its incident response policy and incident handling procedures
- describe this support in system design and configuration documentation
- keep audit records showing that the tools were used
- ensure the incident response plan and the system security plan clearly include these automated mechanisms

Named responsibilities for incident handling and information security must cover the use of these tools.

##### Automated incident case workflows with live response, full PCAP and forensics

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Select and confirm the integrated toolchain (online incident management + SOAR/orchestration + live response + packet capture + forensic analysis) and produce an implementation architecture with data flows and trust boundaries | System Design Authority | Enterprise | 24h | £— |
| Configure the online incident management system for workflow-driven case handling (incident types, structured fields, evidence checklist, approvals, timestamps) and enable case-to-evidence linkage model | Platform Engineer | Enterprise | 32h | £— |
| Implement SOAR/playbook runbooks for defined incident types covering: live response collection steps, time-bounded full packet capture start/stop, evidence packaging/transfer, and forensic ingestion triggers | Security Engineer | Enterprise | 56h | £— |
| Integrate live response tooling with least-privilege access and strong authentication; implement automated evidence attachment to the correct incident case with integrity metadata (e.g., hashes) and chain-of-custody fields | Security Engineer | Enterprise | 40h | £— |
| Integrate full network packet capture on approved capture points/sensors or host-based capture locations; implement retention window controls, hashing, and tamper-evident metadata capture | Infrastructure Lead | Enterprise | 40h | £— |
| Integrate forensic analysis tooling for automated ingestion (indexing/metadata capture), write-back of findings to the case record, and evidence reference linking | Software Lead | Enterprise | 32h | £— |
| Implement auditability and SIEM/SOC logging correlation: generate auditable records for every automated action (start/stop/completion/transfer/ingestion) correlated to incident case ID; validate log completeness and retention | Compliance Manager | Enterprise | 24h | £— |
| Update governance and support documentation: incident response plan, system security plan, incident handling procedures, and system design/configuration documentation to reference automated mechanisms, responsibilities, operational constraints, and evidence handling | Compliance Manager | Enterprise | 24h | £— |

Total Estimated Effort: **272h**  
Total Estimated Cost: **£0**

###### Actions Required for Compliance

- [ ] Choose and set up an online incident management system, including case fields for an evidence checklist and approval steps.
- [ ] Set up security orchestration and automated response (SOAR) workflows that link each type of incident to a step-by-step playbook. Each playbook should cover real-time response actions, network traffic capture, and forensic investigation steps.
- [ ] Set up live response tools to collect and attach evidence to the correct incident record, using the minimum access permissions needed (least-privilege access).
- [ ] Set up automated full network traffic recording so it can be started and stopped only at approved recording points, for fixed time periods during investigations.
- [ ] Integrate forensic analysis tools to automatically collect evidence, record information that confirms the evidence has not been altered, and store the analysis results back in the case file.
- [ ] Set up central audit logging so that every automated evidence action is recorded and linked to the incident case reference (ID).
- [ ] Update the incident response plan, system security plan, incident handling procedures, and system design and configuration documentation to explain the automated mechanisms used and who is responsible for each task.


---

#### IR-4.2 — Dynamic Reconfiguration (Enhancement)

This requirement is about being able to quickly change the protection rules for your networks while an incident is happening. The goal is to limit damage immediately, rather than waiting for a long-term fix. Without this ability, an attacker could keep using the same access paths, trigger the same alerts repeatedly, or reach the parts of your systems you were trying to contain—making the breach worse and harder to control.

To meet this expectation, the organisation must include, as part of its incident response capability, the ability to:
- dynamically update router rules
- update traffic allow/block rules on firewalls or network security devices (“guards”)
- adjust the settings of intrusion detection or prevention sensors
- update firewall or guard filter rules

This must cover:
- network edge routers
- firewalls/guards
- intrusion detection/prevention sensors
- OT (operational technology) network segmentation gateways

The organisation must also:
- set clear time targets for completing these changes
- document how it will make these changes in its incident response and security plans (including system design and configuration details)
- ensure authorised staff can carry out the changes safely
- keep records showing what was changed, who made the change, and when—including evidence that the changes were completed within the agreed time targets.

##### Automated incident reconfiguration playbooks for network/security/OT

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Establish reconfiguration capability catalogue (approved component classes × reconfiguration types) mapping to exact device/configuration primitives; include rollback primitives and validation hooks | Cyber Security Lead | Enterprise | 40h | — |
| Define organisation timeframes per reconfiguration type and implement orchestration SLA logic (start/end timestamps, fail/rollback triggers, timeout handling) | Compliance Manager | Enterprise | 24h | — |
| Implement policy-as-code playbook framework (version control structure, peer review workflow, parameter schema, rollback templates, pre/post check interfaces) | Software Lead | Enterprise | 56h | — |
| Develop and unit-test playbooks for each reconfiguration type across component classes (router rules, ACL updates, IDS/IPS parameters, firewall/guard filter rules) including compilation/validation and post-change behavioural checks | Security Engineer | Department | 96h | — |
| Integrate execution authorisation with enterprise identity/RBAC (least-privilege service identity, allow-listed management actions, step-up approval for incident roles) | Platform Engineer | Enterprise | 40h | — |
| Implement incident-linked auditable evidence generation (audit record schema, evidence capture of actor identity, parameters, timestamps, pre/post results, rollback outcome) and integrate with SIEM/logging | Operations Lead | Enterprise | 32h | — |
| OT segmentation gateway safety guardrails implementation (maintenance window constraints if required, strict change scope to affected zone, conservative rollback criteria) and OT engineering validation sign-off | OT/Industrial Control Systems Engineer | Department | 32h | — |

| Total Estimated Effort |  |  | **320h** |  |
| Total Estimated Cost |  |  |  | **£0** |

###### Actions Required for Compliance

- [ ] Define the approved dynamic reconfiguration catalogue that maps each reconfiguration type to the configuration building blocks it supports for each component type.
- [ ] Set up incident containment playbooks that are version-controlled and use parameters, with built-in checks before and after the action and an automatic rollback option for routers, firewalls/guards, intrusion detection and prevention systems (intrusion detection and prevention systems (IDS/IPS)), and operational technology (OT) network segmentation gateways.
- [ ] Set up orchestration workflows to enforce the organisation’s time limits for each type of reconfiguration, and to record the start and end times for every run.
- [ ] Link playbook execution to your enterprise identity and role-based access control (RBAC) so only authorised incident roles can make changes, and ensure automation uses the minimum necessary permissions with pre-approved (allow-listed) credentials.
- [ ] Set up audit logging that is linked to each incident and records: the incident ID, the affected component(s), the type of reconfiguration, the parameters applied, the identity of the person or system that made the change, the relevant timestamps, and the results of the checks and any rollback actions.
- [ ] Work with operational technology (OT) engineering to test the OT segmentation gateway playbooks, so that during incidents the scope and rollback rules are applied in a way that keeps operational technology (OT) systems safe.


---

#### IR-4.3 — Continuity of Operations (Enhancement)

This expectation is about keeping the organisation working when something goes wrong. It requires clear steps for what staff should do during serious incidents. Without this, a system could fail because of mistakes made during design or build, or be disrupted by deliberate attacks (whether or not they are aimed at the organisation). This could stop important services, delay critical work, or force an uncontrolled shutdown at the worst possible time.

The organisation must first define and document the types of incidents that will trigger continuity actions, including:
- malfunctions caused by design or implementation errors or missing elements
- targeted malicious attacks
- untargeted malicious attacks

The organisation must also define and document the continuity actions it may take in response, such as:
- reducing system capability in an orderly way
- shutting systems down in a controlled manner
- switching to manual work or alternative technology
- using misleading tactics to reduce harm
- routing information through alternative paths
- operating in a special “under attack” reserved mode

Staff responsible for incident handling, with input from information security leads, must be assigned to decide on and carry out these actions. This must be supported by written procedures, plans, and practical mechanisms. The organisation must keep records showing what actions were taken and that they were intended to keep the organisation’s mission and business functions running.

##### Continuity incident playbooks with incident-class decision support

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Produce version-controlled “Continuity Incident Playbook” artefact mapping the 3 incident classes to allowed continuity actions (incl. rationale, safety constraints, and IR-4(3) alignment) | Compliance Manager | Enterprise | 24h | — |
| Define and document incident-class decision logic: responder checklist prompts, classification criteria (design/implementation malfunction vs targeted attack vs untargeted attack), and ambiguity/escalation rules | Security Engineer | Enterprise | 32h | — |
| Design approval workflow and role-based authorisation for high-impact actions (shutdown, under-attack reserved mode), including required approver identity, ticket/record requirements, and conflict handling with automated disablement expectations (IR-4(5)) | Data Protection Officer | Enterprise | 16h | — |
| Implement executable runbooks in operational tooling: degradation mode (feature flags/throttling), manual/alternative fallback procedure, alternate information flows (endpoints/queues) with integrity checks, and under-attack reserved mode behaviour changes | Platform Engineer | Department | 80h | £12,000 |
| Implement audit-ready evidence capture: logging schema for incident class selection, actions executed, approver identity, timestamps, outcomes; integrate with SIEM/central logging and ensure retention alignment | Operations Lead | Enterprise | 40h | £6,000 |
| Embed playbook and decision checklist into incident workflow (case templates/forms, guided prompts, and enforcement of required approvals before high-impact actions can be triggered) | Service Delivery Manager | Business Unit | 24h | £3,000 |
| Execute tabletop + controlled technical exercises covering each incident class and validate correct action selection/execution, operational safety, and evidence completeness; produce exercise reports and remediation actions | Quality Assurance Lead | Enterprise | 32h | — |

| Total Estimated Effort | 268h |  |
|---|---:|---:|
| Total Estimated Cost |  | £21,000 |

###### Actions Required for Compliance

- [ ] Create a continuity playbook that is stored with version control, linking incident categories (ir-04.03_odp.01) to the required actions (ir-04.03_odp.02), including the approval levels needed for each action.
- [ ] Set up an incident response checklist that tells responders how to categorise each incident as one of the following: a design or implementation failure, a targeted attack, or an untargeted attack.
- [ ] Build the “classification to action” mapping into the security operations centre (SOC) or security orchestration, automation and response (SOAR) workflow, or into the incident case management process, so the correct set of actions is shown.
- [ ] Set up safeguards that keep the system running in a controlled way if it starts to fail, allow backup routes for information to flow, and switch to a limited “under attack” mode when needed—while recording all activity in audit logs.
- [ ] Write down and test the manual or alternative technology fallback steps, and make sure they can be accessed when incidents happen.
- [ ] Run practice tabletop and technical exercises for each type of incident, and record evidence showing that the correct actions were chosen and carried out.


---

#### IR-4.4 — Information Correlation (Enhancement)

This requirement is about making sure the organisation can connect what happened during an incident with the specific actions people took, so there is one clear, organisation-wide account. Without this, different teams may record events separately, which can leave gaps in understanding who did what, when, and why. That can slow down learning, lead to repeated mistakes, and result in poor decisions about prevention, communication, and any handling of personal data.

To meet this expectation, the organisation must:
- define which incident information sources must be linked to which recorded response actions
- name the people responsible for doing the linking and for ensuring information and privacy responsibilities are met
- specify who is authorised to receive the combined results

It must also have documented processes to ensure incident-handling steps capture the needed details. These steps must be supported by planned and configured mechanisms that create, store, and keep records of the links between events and actions, along with the reports they produce.

Finally, the organisation must use these linked reports to produce an organisation-wide view and keep audit evidence showing the links and review by the relevant roles.

##### Case ID correlation linking incident evidence to response actions

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define correlation scope, minimum data model, and linkage rules (Case ID, evidence sources, structured response action identifiers, time windows, entity mapping) | Compliance Manager | Enterprise | 24h | — |
| Implement authoritative Case ID at triage and enforce attachment of all evidence/response records to the single Case ID (including validation to prevent “shadow” cases) | Security Engineer | Enterprise | 32h | — |
| Configure SIEM/SOAR integrations to auto-link/enrich cases with correlated detections and entities from at least two sources (e.g., SIEM alerts + EDR detections or audit logs) | DevOps Lead | Enterprise | 56h | £18,000 |
| Extend incident workflow to capture response actions in structured form (action type, who/what/when/why, approvals where applicable) and ensure timeline rendering links evidence → actions | Software Lead | Enterprise | 48h | £12,000 |
| Implement RBAC and audit logging for correlated case views and linkage artefacts (including retention of correlation rule versions and linkage records) | Infrastructure Lead | Enterprise | 40h | £6,000 |
| Add privacy/security correlation gates for correlated exports/reports (data minimisation/redaction where feasible, approval workflow, and documented controls evidence) | Data Protection Officer | Enterprise | 32h | — |
| Perform end-to-end testing and audit readiness validation using representative incident samples; produce evidence pack mapping to IR-4(4) requirements | Quality Assurance Lead | Enterprise | 24h | — |

Total Estimated Effort: **256h**  
Total Estimated Cost: **£36,000**

###### Actions Required for Compliance

- [ ] Define and document the correlation scope: the incident information sources that are required and the response action records that are required so they can be linked.
- [ ] Create an official Incident or Case ID at triage, and require all evidence and response actions to be linked to that ID.
- [ ] Set up security information and event management (SIEM) and security orchestration, automation and response (SOAR) connections so they automatically join related alerts into cases and add supporting details and references to the evidence.
- [ ] Update the incident workflow so that response actions are recorded in structured fields (who, what, when, why, and action type) rather than as free text only.
- [ ] Set up role-based access control (RBAC) so only authorised people can view and export linked case information, and turn on audit logging to record events related to links and workflow activity.
- [ ] Add privacy and security checks (gate) and minimise data use for correlated outputs that include personal data, by masking or redacting it where feasible.
- [ ] Test with a sample of past incidents to confirm that information links correctly from start to finish, and produce an audit-ready correlation report.


---

#### IR-4.5 — Automatic Disabling of System (Enhancement)

This requirement is about ensuring your systems can protect themselves by automatically shutting down when something seriously wrong is detected. If a cyber-attack interferes with how the system works or steals organisational information, or if a major software fault occurs that could affect your ability to carry out your mission—or even put people’s safety at risk—the system should not continue running in a dangerous state.

To meet this expectation, the organisation must:
- agree and document clear trigger conditions for these two types of problems
- configure the system so it can automatically disable itself when those conditions occur
- ensure the disabling behaviour can be changed through configuration by authorised people, without rebuilding the system

The organisation must also:
- document how the triggers and disabling actions work
- include this information in its security and incident response plans
- assign responsibility for what happens next
- check that automatic disabling does not harm business continuity, and resolve any conflicts using appropriate safeguards

##### Configurable auto-disable on integrity/exfiltration/serious error

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Design the Disable Mode state model (safe-mode vs service stop vs egress block vs quarantine) including deterministic transition rules and rollback/recovery semantics | System Design Authority | Enterprise | 24h | — |
| Implement configurable trigger evaluation engine (integrity compromise / exfiltration / serious software error) with thresholds, suppression windows, tenant/service scoping, and idempotent firing | Software Lead | Department | 80h | — |
| Build integration adapters for enterprise detection sources (SIEM/XDR/DLP/observability) to normalise events into the trigger engine’s schema and support authenticated, auditable control-plane invocation | Platform Engineer | Enterprise | 56h | — |
| Implement orchestration/invocation mechanism to apply Disable Mode actions via approved automation interfaces (feature flags/service management/orchestration APIs), including audit logging (who/what/when) and tamper-evident event records | DevOps Lead | Enterprise | 56h | — |
| Implement authorised configuration management (RBAC/least privilege, change approval workflow, versioned configuration, and audit trails) for enablement, thresholds, scope, and action parameters | Compliance Manager | Enterprise | 32h | — |
| Continuity assessment and conflict resolution for CP-2 / IR-4(3): define immediate vs override-required behaviour, safe fallback guarantees, and recovery runbooks; produce tabletop/technical test plan | Data Protection Officer | Enterprise | 24h | — |
| Execute test & evidence generation: test triggers in non-prod, validate time-to-disable, false-positive suppression, recovery steps, and produce audit-ready evidence pack for IR-4(5) enhancement | Quality Assurance Lead | Business Unit | 40h | — |

Total Estimated Effort: **312h**  
Total Estimated Cost: **£0**

###### Actions Required for Compliance

- [ ] Set up configurable alert triggers for suspected data integrity compromise, data exfiltration, and serious software errors, using measurable detection signals.
- [ ] Implement a **Disable Mode** (a safe or reduced-functionality state) with pre-approved actions to disable capability, such as **stopping or scaling down services**, **blocking outbound network traffic**, **revoking active sessions**, and **quarantining workloads**.
- [ ] Integrate detection alerts from security information and event management (SIEM), extended detection and response (XDR), data loss prevention (DLP), and observability into a verified, traceable process that is logged and can be audited, which then triggers “Disable Mode”.
- [ ] Set up configuration settings for enablement, alert thresholds and suppression time windows, the scope of coverage, and the type of disable action, and store them in a controlled configuration management system.
- [ ] Test the continuity safeguards by checking that **Disable Mode** meets the requirements of **CP-2/IR-4(3)**, and document the safe fallback and recovery steps.
- [ ] Carry out tabletop exercises and technical tests to confirm that authorised configuration changes are recorded, and that systems are disabled as expected when the defined triggers activate.


---

#### IR-4.6 — Insider Threats (Enhancement)

This requirement is about being prepared to deal with problems caused by people inside the organisation, such as staff or contractors who misuse their access, behave carelessly, or deliberately cause harm. If there is no clear way to respond to insider-related concerns, issues may be missed, important evidence may be lost, decisions may be delayed, and the organisation may face financial loss, disruption, or the exposure of sensitive information.

To meet this expectation, the organisation must have a written incident response policy and clear, step-by-step procedures that specifically cover insider-threat incidents. These must be supported by practical reporting and handling processes that incident responders can follow. The organisation must also keep relevant documentation showing how key systems are built and configured, and maintain an incident response plan and a system security plan that set out what to do and who to involve, including how to escalate concerns and communicate updates. Finally, it must keep the records needed to investigate and manage these incidents, and be able to demonstrate that the approach works in practice.

##### Insider-threat incident handling playbooks in case management

- Category: Software
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define insider-threat incident scenarios and decision points mapped to triage questions and response actions (credential misuse, privileged misuse, data exfiltration, sabotage/disruption, negligent mishandling) | Compliance Manager | Enterprise | 24h | — |
| Produce playbook templates for triage → investigation → containment → eradication → recovery → closure, including scenario-specific “when to escalate” triggers and required handler fields | Security Engineer | Enterprise | 32h | — |
| Embed playbooks into the organisation’s case/incident management workflow (forms, required fields, routing/escalation paths, role-based assignment, audit trail of workflow actions) | Platform Engineer | Enterprise | 56h | — |
| Implement standardised evidence capture/preservation workflow (evidence checklist per scenario, evidence reference linking to case, retention location rules, immutability/controlled access requirements) | Forensics Lead | Enterprise | 48h | £18,000 |
| Configure investigation output requirements and case closure artefacts (timeline, affected systems/data inventory, initial impact assessment, eradication/recovery decision record, lessons learned and detection/control update actions) | Operations Lead | Enterprise | 24h | — |
| Run tabletop exercises across major system classes (at least SaaS, on-prem component, API/service), capture gaps, and update playbooks/workflow/evidence requirements accordingly | Project Manager | Enterprise | 40h | £6,000 |
| Conduct usability and audit-readiness review (evidence completeness checks, retention/audit evidence sampling, sign-off against NIST IR-4(6) enhancement expectations) | Compliance Manager | Enterprise | 16h | — |

Total Estimated Effort: **240h**  
Total Estimated Cost: **£24,000**

###### Actions Required for Compliance

- [ ] Define insider-threat scenarios and, for each one, set out the triage questions to ask, the evidence needed, the containment actions to take, and the conditions that trigger escalation.
- [ ] Set up the case-management process so it always collects the required insider-threat details and sends each case to the right team for routing and escalation based on the scenario.
- [ ] Link security monitoring records (from security information and event management (SIEM) and log sources) and application audit logs to the case evidence capture process, so evidence collection happens as part of the workflow.
- [ ] Set up an auditable way to store evidence with controlled, non-editable retention, and automatically link each evidence reference to the relevant case.
- [ ] Create containment playbook steps for each scenario that preserve logs and prevent loss of evidence before any eradication actions are carried out
- [ ] Run tabletop exercises for each major system type and record any deviations, missing evidence, and updates needed to the playbooks.


---

#### IR-4.7 — Insider Threats — Intra-organization Coordination (Enhancement)

This expectation is about ensuring that, when an insider threat incident occurs, the right people across the organisation work together from start to finish, rather than each team acting on its own. Without clear coordination, important steps could be missed, decisions could be delayed, evidence could be handled incorrectly, and actions taken could conflict with privacy duties or legal requirements—leaving the organisation exposed and making it harder to put things right.

The organisation must identify and clearly assign responsibilities to the Senior Agency Information Security Officer, the Risk Executive (function), the Senior Agency Official for Privacy, legal counsel, human resources, procurement, personnel, physical security, mission or business owners, system owners, and operations personnel. It must also define a documented way for them to coordinate.

The organisation must ensure the full incident journey is covered—preparation, detection and analysis, containment, eradication, and recovery—using its incident response policy, incident handling procedures, incident response plan, insider threat programme plan, insider threat concept of operations, system security plan, privacy plan, and any other relevant records. This includes any arrangements for external law enforcement support, if that support is used.

##### Insider threat incident command workflow with named coordination entities

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Draft the Insider Threat Incident Command (ITIC) charter that explicitly names all entities in `ir-04.07_odp` and maps responsibilities across preparation, detection/analysis, containment, eradication, and recovery; include references to existing records (incident response policy/procedures/plan, insider threat programme plan, insider threat CONOPS, system security plan, privacy plan, and related records). | Compliance Manager | Enterprise | 24h | — |
| Define the single repeatable ITIC workflow (“decision gates and hand-offs”) including: stage entry/exit criteria, triggers, evidence/documentation to capture/retain, named leads/approvers per gate, and documented privacy/legal counsel consultation points. | Cyber Security Lead | Enterprise | 32h | — |
| Create the external law enforcement support annex (if applicable): triggers for escalation, points of contact, approval steps, information-sharing boundaries, and alignment with Legal Counsel and the privacy plan. | Legal Counsel | Enterprise | 16h | — |
| Establish audit-ready document management approach for ITIC artefacts: controlled storage locations, naming/versioning standards, traceability links to insider threat programme plan and incident response records, and retention rules for workflow/evidence/exercise outputs. | Data Protection Officer | Enterprise | 20h | — |
| Plan and run an end-to-end tabletop exercise using the ITIC workflow across all lifecycle stages with all required entities; document outcomes, observed gaps, and corrective actions with owners and due dates. | Project Manager | Enterprise | 40h | £3,000 |
| Produce the post-exercise improvement plan and update the ITIC charter/workflow accordingly; confirm governance sign-off and ensure updated artefacts remain traceable to the insider threat programme plan and incident response records. | System Design Authority | Enterprise | 24h | — |
| Validate completeness against acceptance criteria: confirm every lifecycle stage includes named responsibilities and approval/consultation points for all entities in `ir-04.07_odp`, and confirm privacy/legal counsel involvement is recorded at the relevant gates; compile evidence pack for audit. | Compliance Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 172h  
**Total Estimated Cost:** £3,000

###### Actions Required for Compliance

- [ ] Draft an Insider Threat Incident Command (ITIC) charter that lists every organisation named in `ir-04.07_odp` and assigns responsibilities for each lifecycle stage.
- [ ] Publish an ITIC workflow that sets out the decision points, what starts each step, who takes over at each hand-off, and what proof and documents are required from preparation through recovery.
- [ ] Document the privacy and legal advice consultation steps in the ITIC workflow, and link them to the privacy plan and the incident response records.
- [ ] Add an external law enforcement support annex (only if it is used). It should set out the conditions that trigger support, the approval steps, and the liaison contact details, coordinated by legal counsel.
- [ ] Run a complete end-to-end tabletop exercise with all required participants, and record the results, any gaps identified, and the corrective actions to address them.
- [ ] Store the ITIC charter, workflow, exercise evidence, and improvement actions in a controlled document system, with clear traceability to the insider threat programme plan and the incident response plan.


---

#### IR-4.8 — Correlation with External Organizations (Enhancement)

This requirement is about making sure that when something goes wrong, your organisation does not handle the incident in isolation. Instead, it must share the right incident details with key external partners so everyone can build a shared understanding of what is happening. Without this, you could miss important clues, wrongly judge how serious the incident is, or take slower or less effective actions because other organisations may have identified the same threat first.

To meet this expectation, the organisation must put in place a clear process for coordinating with the Department of Defense (DoD) and coalition partners, the United States Computer Emergency Readiness Team (US-CERT), the Cybersecurity Maturity Model Certification (CMMC) assessment bodies, and managed service providers. This includes naming specific people responsible for information security and privacy oversight, and for coordinating incident communications.

The organisation must document:
- which external organisations it will work with
- what information will be shared (observable signs, which systems are affected, severity, key timing details, and what remediation actions are taken or planned)
- how incoming information will be matched to the organisation’s own records
- who to contact at each partner

During incidents, the organisation must share and combine the agreed information, use the combined view to make better response decisions, and keep records showing what was shared and what the matching found. These coordination steps must be reflected in its incident response policy, procedures, incident response plan, system security plan, and privacy plan.

##### External incident sharing & correlation workflow with partner playbooks

- Category: Manual
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Create and approve the “external incident coordination register” (partner categories, purposes, named contacts, escalation paths, and ownership) | Compliance Manager | Enterprise | 16h | — |
| Define the standard incident information package template (required fields: incident indicators, affected systems, severity, timelines, remediation actions) including severity normalisation guidance | Security Engineer | Enterprise | 24h | — |
| Establish approval gates and redaction rules (security technical approval, privacy approval, data minimisation/limiting rules, and “share/no-share” decision criteria) | Data Protection Officer | Enterprise | 20h | — |
| Document the external incident correlation workflow (ingest external indicators, normalise, match to internal telemetry/asset context, produce correlation outcomes, and update incident record) | SOC Manager | Enterprise | 32h | — |
| Build partner playbooks mapped to partner categories (trigger conditions, required approvals, correlation steps, sharing steps, and post-share follow-up) | Project Manager | Enterprise | 24h | — |
| Operationalise during live exercises (run at least one tabletop scenario end-to-end: trigger playbook, perform correlation, apply approvals/redaction, and share the approved package) | Service Delivery Manager | Enterprise | 16h | — |
| Implement audit evidence capture requirements (log what was shared, with whom, when, correlation results, playbook/approval decision used; link to incident case) and update relevant incident/system security/privacy plans to reference the workflow and register | Compliance Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 156h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Create and get approval for an external incident coordination register. This register must list the external organisations defined by the organisation and the named contacts for each.
- [ ] Create incident-sharing templates that list the signs of an incident, which systems are affected, the severity, the key dates and times, and the steps to fix it.
- [ ] Put in place approval checkpoints for security and privacy, and define rules for removing or limiting sensitive details when sharing incident information.
- [ ] Document and put in place a process that links external signals to internal system monitoring data and information about affected assets, and records the results of each correlation.
- [ ] Update the incident response plan, system security plan, and privacy plan to reference the external coordination workflow and the partner register.
- [ ] Set up records of evidence for every external sharing event—what was shared, who shared it, and when—and link those records to the relevant incident case.


---

#### IR-4.9 — Dynamic Response Capability (Enhancement)

This requirement is about being able to respond quickly and adapt during an incident. It relies on ready-to-use instructions, the right monitoring and containment actions, and automated fixes when appropriate. Without this, an organisation may respond too slowly, follow the wrong steps, or fail to limit the damage—allowing problems to spread, services to stay disrupted, or sensitive information to be exposed.

To meet this expectation, the organisation must use its incident “playbooks” (step-by-step guides based on its mission and business processes), its system-level tools for detecting and containing issues, and its automated remediation workflows to manage incidents. It must also be able to quickly deploy new or replacement versions of these capabilities while the incident is still ongoing.

The organisation must keep clear, documented incident handling procedures, maintain an incident response plan and a system security plan, and maintain system design and configuration documentation showing how these response capabilities work together. Finally, it must keep audit records of the actions taken during response, and have defined organisational processes with named individuals responsible for incident handling and information security.

##### Incident response capability pipeline with in-incident deployment

- Category: Software
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define dynamic response capability artefact model (playbook, detection/containment module, remediation workflow) including required metadata, evidence outputs, rollback targets, and versioning scheme | System Design Authority | Enterprise | 24h | — |
| Implement capability repository structure and CI validation pipeline (schema/dependency checks, unit tests for workflow logic, dry-run simulations with evidence-field verification) | Software Lead | Enterprise | 56h | £18,000 |
| Implement policy-as-code deployment authorisation rules (auto-approve vs approval-required, incident-commander selection of capability version, environment/system scoping) | Compliance Manager | Enterprise | 32h | — |
| Build signing, promotion, and release gating (dev→test→prod), ensuring only approved signed artefacts can be deployed; integrate with existing change/release controls | DevOps Lead | Enterprise | 40h | £6,000 |
| Integrate pipeline with SOAR/IR orchestration layer for in-incident deployment (capability selection UI/API, execution runner, mapping to relevant systems, operator identity capture) | Security Engineer | Enterprise | 48h | £12,000 |
| Implement rollback mechanism and audit evidence generation (previous known-good version tracking, rapid rollback execution, immutable audit record of deployment and evidence outputs) | Operations Lead | Enterprise | 40h | — |
| End-to-end testing and readiness (table-top + technical tests for in-incident replacement, evidence completeness checks, rollback demonstration, runbook updates, and handover to incident response operations) | Quality Assurance Lead | Enterprise | 32h | £4,000 |

**Total Estimated Effort:** 272h  
**Total Estimated Cost:** £40,000

###### Actions Required for Compliance

- [ ] Define and document the types of incident response materials you will use (for example, step-by-step playbooks, detection and containment components, and remediation workflows). Include the required information (metadata) for each type and specify the evidence outputs they must produce.
- [ ] Set up a continuous integration (CI) validation process that uses a code repository, including checks against the required data format (schema), automated tests for the workflow, and “dry run” simulations to confirm evidence and ticket updates before they are applied.
- [ ] Use “policy-as-code” to set deployment authorisation rules, so you control which actions can run automatically and which actions need incident commander approval.
- [ ] Package and digitally sign the capability artefacts, then move them through development to testing to production (dev → test → production) using the existing change and release approval process.
- [ ] Integrate the pipeline with the incident response orchestration and security orchestration, automation and response (SOAR) layer so that, during an incident, you can deploy a selected replacement capability version.
- [ ] Roll back to a previously verified “known-good” version of the capability, and ensure every deployment and execution produces records that are ready for audit.


---

#### IR-4.10 — Supply Chain Coordination (Enhancement)

This expectation is about making sure that if something goes wrong anywhere in your supply chain, you coordinate with the other organisations involved, rather than dealing with it on your own. Without clear coordination, a problem caused by a supplier, a supplier’s supplier, a product or component, the way something is developed, or even distribution and warehousing could go unnoticed, slow down recovery, and leave you unable to meet your legal reporting duties.

To meet this expectation, your organisation must:
- define what counts as a supply-chain incident
- identify which partners you will coordinate with
- assign named people who are responsible for coordinating and sharing information

You must include this in your incident response policy, procedures, and plans. You also need your contracts and service agreements with suppliers and service providers to clearly state what incident information will be shared, with whom, and how—including support for any required reporting to government oversight bodies.

Where coordination is needed, you should also obtain and review key partners’ incident handling plans.

##### Contractual supply-chain incident cooperation framework and partner packs

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define supply-chain incident scope and reusable trigger template (primary/sub-tier, IT products/components, development processes/personnel, distribution/warehousing facilities) aligned to IR governance | Security Engineer | Enterprise | 16h | — |
| Draft “Supply-chain Incident Cooperation” contract/SLA clause set (scope, notification timelines, information content, secure sharing methods, named contacts, escalation routes, joint coordination cadence, government reporting support language) | Compliance Manager | Enterprise | 24h | — |
| Legal/compliance validation of disclosure constraints and government reporting workflow alignment (including review of permitted/required disclosures and evidence handling expectations) | Data Protection Officer | Enterprise | 16h | — |
| Update incident response policy/procedures and incident response plan references to link the framework (roles, joint communications, update cadence, evidence handling, and escalation triggers) | Cyber Security Lead | Enterprise | 20h | — |
| Design and implement partner onboarding/renewal “incident coordination pack” requirements (repository structure, versioning approach, required partner artefacts, RACI mapping template, 24/7 escalation contact capture) | Third-Party Risk Manager | Enterprise | 24h | £6,000 |
| Build contract lifecycle enforcement workflow (procurement/contracting gatekeeping so onboarding/renewal cannot complete without clause acceptance and approved partner coordination pack) | Project Manager | Enterprise | 20h | £3,000 |
| Pilot with a representative set of in-scope partners and produce audit-ready evidence pack (completed packs, accepted clauses, test of escalation/notification timelines, lessons learned and final revisions) | Service Delivery Manager | Business Unit | 16h | — |
| Train procurement, third-party risk, and incident response stakeholders on the framework and partner packs (including how to execute secure information sharing and escalation during an incident) | Operations Lead | Enterprise | 12h | — |

**Total Estimated Effort:** 148h  
**Total Estimated Cost:** £9,000

###### Actions Required for Compliance

- [ ] Define and document a standard definition of a supply-chain incident and the specific events that trigger notification. This should cover primary and sub-tier suppliers, information technology (IT) products and components, software development processes and staff, and distribution and warehousing sites.
- [ ] Create a standard contract/service-level agreement (SLA) clause set for “Supply-chain Incident Cooperation” that covers: what information must be shared, how it will be shared securely, the named points of contact, the escalation routes, and the notification and follow-up timeframes.
- [ ] Update the incident response policy and procedures, and the incident response plan, to reference the supply-chain incident cooperation framework and the expected approach for joint communications.
- [ ] Create partner onboarding and renewal requirements to collect each partner’s incident response (IR) plan (or an equivalent document). Then produce a partner-specific incident coordination pack that includes responsibilities (RACI) and clear escalation routes.
- [ ] Set up a contract approval checkpoint so procurement cannot complete onboarding or renewal unless the incident cooperation clauses and the partner-specific coordination pack have been accepted.
- [ ] Check with Legal and Compliance that the information-sharing and government reporting language matches the relevant reporting requirements and disclosure limits.


---

#### IR-4.11 — Integrated Incident Response Team (Enhancement)

This requirement is about having a team that is ready to be deployed immediately when something goes wrong, wherever your organisation needs them. Without this, a serious security incident could spread further, important facts could be lost before they are properly recorded, and recovery could take much longer—leaving your people, customers, and day-to-day operations exposed to avoidable harm.

To meet this expectation, your organisation must set up and maintain an integrated incident response team, with the right mix of people to: handle incidents, preserve and examine evidence, analyse malicious software, support technical fixes, and provide immediate operational support. You must also have clear written guidance and plans for how incidents will be handled and prepared for, including links to your wider security and privacy planning. You must assign responsibility for incident handling, and for privacy and security decisions.

Finally, the team must be able to be deployed to any location you identify within two hours, and you should be able to demonstrate that this is tested and works in practice.

##### Deployable integrated IR pods with 2-hour dispatch evidence

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Charter the integrated IR team and define pod role responsibilities (RACI), escalation paths, and evidence-handling authority | Compliance Manager | Enterprise | 24h | — |
| Define the deployable location register and the 2-hour dispatch model (activation triggers, travel/remote-first actions, pre-positioned kit rules, and acceptance criteria per location) | Project Manager | Enterprise | 32h | — |
| Stand up distributed IR pods (regional coverage model) including on-call rota design, minimum role coverage per activation, and operational readiness checklists | Service Delivery Manager | Enterprise | 40h | — |
| Pre-position response capability at each deployable location (forensic/evidence preservation materials, chain-of-custody forms, secure storage/access arrangements, and standard triage kits) | Operations Lead | Enterprise | 56h | £18,000 |
| Implement and document the integrated incident case workflow (evidence preservation triggers, documentation standards, handover to recovery/engineering, and evidence workflow templates) | Quality Assurance Lead | Enterprise | 40h | — |
| Configure evidence workflow tooling and audit-ready retention approach (case management integration with logging/SIEM where applicable; evidence index, retention tags, and export format) | Platform Engineer | Enterprise | 48h | £6,000 |
| Run timing drills and retain audit-ready dispatch evidence (tabletops + timed exercises per location; capture timestamps, outcomes, and corrective actions) | Security Engineer | Enterprise | 64h | £4,000 |

**Total Estimated Effort:** 304h  
**Total Estimated Cost:** £28,000

###### Actions Required for Compliance

- [ ] Set up the integrated incident response team and publish a responsibility matrix covering incident handling, preserving evidence, investigating intrusions, analysing malicious code, coordinating with privacy and security engineering, and providing real-time operational support.
- [ ] Set up distributed incident response (IR) teams (“IR pods”) with clear on-call responsibilities and coverage for required roles, including a rota or a fast escalation route for analysing suspected malicious code.
- [ ] Create and keep an up-to-date, approved list of deployment locations, and document the dispatch plan for each location to meet the 2-hour response requirement.
- [ ] Set up approved forensic and evidence-preservation kits, and the required access arrangements, at each location where teams may be deployed, so that forensic preservation can begin immediately when needed.
- [ ] Set up a standard incident case process that starts evidence preservation, records the details, and hands the case over to the recovery and mitigation teams.
- [ ] Run timed, location-specific practice drills and tabletop exercises, and keep audit-ready records showing that dispatch happens within 2 hours for every listed location.


---

#### IR-4.12 — Malicious Code and Forensic Analysis (Enhancement)

This expectation is about making sure that, after something suspicious happens, the organisation closely examines any harmful code and any leftover traces found on the affected systems. The goal is to understand what the attacker did. Without this, the business may miss hidden damage, fail to remove the real cause, and repeat the same mistakes in future incidents—leaving the organisation vulnerable to the same or similar attacks.

The organisation must follow its incident response and forensic procedures to identify and analyse any malicious code that remains. It must also analyse other leftover evidence, such as suspicious files, scripts, or data. This work must be carried out in a controlled, isolated environment to avoid spreading or destroying evidence.

The organisation must then record and keep the results of both analyses. These records should be used to learn how the attacker operated and to improve future incident handling, with clear responsibilities, approved analysis methods, and supporting records such as audit logs and case notes.

##### Isolated malware lab workflow for post-incident code/artifact analysis

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define IR workflow updates for IR-4(12): post-containment/eradication residuals scope, evidence requirements, and lab invocation criteria (playbook + runbook) | Compliance Manager | Enterprise | 16h | — |
| Design evidence-to-analysis standard: evidence manifest schema, chain-of-custody fields, per-platform collection checklist, and structured case report template | Data Protection Officer | Enterprise | 24h | — |
| Build/secure isolated malware analysis lab: network segmentation, egress controls, analyst access model, snapshot/reset approach, and lab hardening checklist | Infrastructure Lead | Enterprise | 40h | £18,000 |
| Implement evidence collection automation and tooling integration (hashing, metadata capture, artefact packaging, manifest generation, and storage hooks to case management) | Platform Engineer | Enterprise | 32h | £6,000 |
| Develop analysis workflow (static-first then dynamic): instrumentation plan, sandbox execution procedure, behaviour capture outputs, and TTP inference guidance | Security Engineer | Department | 24h | — |
| Integrate outputs into case management and retention controls: access logging, retention policy mapping, audit trail verification, and evidence/report linkage to incident case | Operations Lead | Enterprise | 16h | — |
| Detection improvement loop: convert extracted indicators/behaviours into at least one SIEM/EDR/ SOAR artefact with traceability back to the incident case | Quality Assurance Lead | Department | 24h | £3,000 |
| Execute acceptance test using a recent incident or tabletop sample: end-to-end run, evidence manifest completeness check, isolated-lab connectivity validation, and sign-off against acceptance criteria | Project Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 192h  
**Total Estimated Cost:** £28,000

###### Actions Required for Compliance

- [ ] Update the incident response playbook to add a step after containment to identify any remaining malicious code and related files or records, so they can be analysed.
- [ ] Define and implement a standard “evidence manifest” format that records item details such as file checksums (hashes), dates and times (timestamps), file locations (paths), and relevant logs, and includes chain-of-custody information.
- [ ] Set up a dedicated, isolated malware analysis laboratory with restricted access, controlled outbound internet connections, and the ability to take snapshots and reset the environment.
- [ ] Create an analysis runbook that carries out static analysis first, and only then runs dynamic analysis inside a fully isolated laboratory.
- [ ] Create a structured analysis report template that records: indicators, what was observed, any remaining or persistent effects, and the likely tactics, techniques, and procedures (TTPs).
- [ ] Set up records retention and access logging for evidence manifests and analysis reports as part of case management.
- [ ] Automate the transfer of extracted indicators and behaviours into security information and event management (SIEM) and endpoint detection and response (EDR) detection and hunting materials, with clear traceability back to the incident case.


---

#### IR-4.13 — Behavior Analysis (Enhancement)

This expectation is about recognising the warning signs that someone is probing or attacking your systems, and then determining what they targeted and when. Without this, unusual activity—such as attempts to trigger decoy traps and hidden “tripwires”, or suspicious behaviour during highly trusted sign-ins—could be overlooked or misread, leaving you vulnerable to theft, disruption, or repeated attacks before you understand what happened.

To meet this requirement, the organisation must review any unusual or suspected hostile behaviour connected to its deception environment (honeypots and canary tokens), as well as privileged access sessions and sign-in records. It must do this using its incident response policy and incident response plan, the documented ways it monitors systems, and the actual monitoring records and relevant system settings.

The review must identify the specific resources that were targeted and the timing of the activity. It must also apply the organisation’s agreed rules for what counts as genuinely suspicious behaviour versus likely false alarms. Finally, it must clearly record the approach and the evidence, so the findings can be traced and acted on.

##### Evidence-linked behaviour analysis playbooks for deception & privileged access

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define investigation record schema (evidence-linked) including targeted resource identifiers, time window fields, evidence source/field mapping, correlation keys, and threshold decision rationale aligned to IR-4(13) param `ir-04.13_odp` | Compliance Manager | Enterprise | 24h | — |
| Implement detection-as-code playbooks for deception alerts (honeypot hits + canary token triggers) that query monitoring records for the derived time window and output targeted resource + incident timeline with referenced evidence fields | Security Engineer | Enterprise | 56h | £6,000 |
| Implement detection-as-code playbooks for privileged access anomalies using PAM/IdP telemetry (where available) and correlated admin actions; output privileged/admin resource(s), account/session context, and evidence-backed timing | Security Engineer | Enterprise | 64h | £8,000 |
| Implement detection-as-code playbooks for authentication anomalies (success/failure, MFA, session establishment/termination, session context) and correlation to privileged/deception indicators; enforce explicit false-positive/false-negative threshold selection and record rationale | Cyber Security Lead | Enterprise | 56h | £6,000 |
| Evidence collection hardening: implement timezone handling, correlation-key standards, log source/field validation, and “query actual monitoring records” enforcement (fail closed when evidence is missing/unavailable) | Platform Engineer | Enterprise | 40h | £4,000 |
| Auditability & IR alignment: produce playbook documentation pack (inputs/outputs, evidence references, threshold rules, timeline reconstruction method) and run tabletop review against the incident response policy/plan | Incident Response Lead | Enterprise | 32h | — |
| SOC enablement & tuning: deploy to non-prod, run test cases (benign + adversarial), capture analyst feedback, tune thresholds, and confirm outputs meet acceptance criteria for targeted resources and timeline reconstruction | Service Delivery Manager | Enterprise | 48h | £3,000 |

**Total Estimated Effort:** 320h  
**Total Estimated Cost:** £27,000

###### Actions Required for Compliance

- [ ] Define and publish a standard format for recording investigations of IR-4(13) evidence, including the specific resource identifiers to focus on and the time periods to analyse.
- [ ] Set up security automation using security orchestration, automation and response (SOAR) and security information and event management (SIEM) playbooks that respond when honeypots are triggered or when canary token alerts occur, and automatically gather evidence from the log sources listed in the documentation.
- [ ] Set up linked playbooks that review records of privileged access sessions and login activity to rebuild what happened over time and spot which administrator systems were specifically targeted.
- [ ] Set up playbooks to use the exact log sources and fields, and ensure all time-window searches use the same time zone when collecting evidence.
- [ ] Add the organisation’s agreed thresholds for false positives and false negatives into the decision rules used by the playbook, and require a justification for the chosen threshold in every investigation record.
- [ ] Check that the playbook outputs match the incident response policy and plan, and run tabletop exercises to confirm that the right resources and timing are identified correctly.


---

#### IR-4.14 — Security Operations Center (Enhancement)

This requirement is about having a dedicated team that continuously monitors your organisation’s computer systems and networks, identifies suspicious activity early, and coordinates a fast, sensible response. Without this, issues such as unauthorised access, malware, or data theft can go unnoticed for too long, giving attackers time to cause more damage, disrupt services, or take advantage of weaknesses before anyone acts.

To meet this expectation, the organisation must set up and keep running a Security Operations Centre, either in-house or through a specialist provider, staffed by people with the right skills. The organisation must clearly define who is responsible for handling incidents, who is responsible for managing disruptions, and who carries out day-to-day monitoring.

The organisation must also keep written incident-handling and day-to-day operating procedures, including an incident response plan and a contingency plan. It must ensure the team can collect and combine relevant security information from different parts of the environment so they can understand what is happening and take timely action.

##### Establish staffed SOC with SIEM correlation and incident workflows

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define SOC operating model (coverage, staffing levels, escalation paths, RACI for detection→triage→contain→eradicate→recover→lessons learned) and publish SOC governance pack | SOC Manager / Security Operations Lead | Enterprise | 24h | — |
| Establish SOC incident lifecycle procedures and evidence requirements (incident record template, approval gates, timestamping expectations, closure rationale, audit trail requirements) | Compliance Manager | Enterprise | 20h | — |
| Design and implement SIEM correlation approach (event normalisation requirements, time sync/NTP expectations, enrichment strategy for identity/asset criticality, correlation rule catalogue structure) | Security Engineer | Enterprise | 40h | — |
| Configure multi-source telemetry ingestion into SIEM (perimeter, network devices, endpoint agent feeds) including field mapping, retention alignment, and validation of end-to-end event flow | Platform Engineer | Enterprise | 56h | £12,000 |
| Implement SOC workflows and playbooks (human-in-the-loop triage, analyst approval for disruptive actions, SOAR-style automation where available, ticketing/evidence capture integration) | Software Lead | Enterprise | 48h | £8,000 |
| Run SOC capability testing (tabletop exercises + detection validation using representative alert simulations) and produce remediation backlog with prioritised improvements | Quality Assurance Lead | Enterprise | 24h | — |
| Stand up audit-ready reporting and metrics (MTTA/MTTR, alert fidelity, coverage gaps, incident timeliness evidence packs, periodic governance reporting cadence) | Data Protection Officer | Enterprise | 20h | — |

**Total Estimated Effort:** 232h  
**Total Estimated Cost:** £20,000

###### Actions Required for Compliance

- [ ] Define the security operations centre (SOC) operating model, including the hours it is covered, how issues are escalated, and who is responsible for detection, triage, containment, and recovery (RACI).
- [ ] Assign Security Operations Centre (SOC) roles (security analysts, incident response staff, and security engineers) and document their responsibilities and required skills.
- [ ] Set up security information and event management (SIEM) and security analytics to collect security activity data from perimeter defences, network devices, and endpoint agent feeds.
- [ ] Set up event normalisation, time synchronisation, and additional context (identity and asset criticality) so that related events can be linked together and we have a complete, end-to-end view of what is happening.
- [ ] Create security operations centre (SOC) incident workflows and playbooks that require human approval before taking disruptive actions, aligned to the incident lifecycle.
- [ ] Document security operations centre (SOC) operating procedures and incident response procedures, and run tabletop exercises and detection validation tests with recorded results.
- [ ] Create incident records that are ready for audit, including where the issue was detected, the analysis performed, who approved it, what actions were taken, and why the incident was closed.


---

#### IR-4.15 — Public Relations and Reputation Repair (Enhancement)

This requirement is about protecting the organisation’s public reputation when something goes wrong, and then actively rebuilding trust afterwards. If an incident becomes public or makes the organisation look bad, rumours and incomplete information can spread quickly. This can damage relationships with customers, partners, and other key people, and make it harder to continue day-to-day work.  

To meet this expectation, the organisation must treat public-facing incidents as a signal to begin planned public communications. It should decide in advance what will be said and how it will be shared. It must also include specific reputation-repair actions as part of its incident response, with the aim of restoring confidence among the people it serves.  

The organisation should set out these responsibilities in its incident response policy, procedures, and plans. It must ensure that the right named people are responsible for handling incidents and communications, and it must keep records showing that public relations and reputation-repair actions were carried out.

##### Incident PR playbooks and reputation repair workflow

- Category: Manual
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define public-visibility triggers and map them to incident classes in the Incident Response Plan (IRP), including activation criteria and escalation paths | Compliance Manager | Enterprise | 16h | — |
| Develop PR playbooks per incident class (holding statements, verification steps, stakeholder-specific messaging for customers/partners/regulators/employees, and update cadence) | Communications/PR Lead | Enterprise | 40h | — |
| Establish approval workflow requirements and sign-off matrix (required roles, decision points, and publication gates) aligned to Legal/Privacy and security facts | Project Manager | Enterprise | 24h | — |
| Implement reputation-repair workstreams within incident records (tracked action list mapped to affected constituents, ownership, due dates, and completion evidence requirements) | Incident Response Lead | Enterprise | 24h | — |
| Define audit-ready evidence capture standards for PR execution (draft/final versions, approval timestamps, publication timestamps, and completion evidence) and update incident record templates accordingly | Compliance Manager | Enterprise | 16h | — |
| Configure ITSM/incident management workflow to enforce PR publication sign-off (no publication without required approvals) and ensure evidence fields are mandatory | ITSM/Workflow Owner | Business Unit | 32h | £3,000 |
| Implement access restrictions for PR execution tooling/channels using enterprise identity controls (RBAC, least privilege, and phishing-resistant MFA for PR approvers) | Security Engineer | Enterprise | 24h | £2,500 |
| Run tabletop exercises for PR playbooks (at least one per year), including scenario scripts, facilitator guides, scoring, and corrective action tracking | Service Delivery Manager | Enterprise | 24h | £1,500 |

**Total Estimated Effort:** 220h  
**Total Estimated Cost:** £7,000

###### Actions Required for Compliance

- [ ] Document the events that make information publicly visible, and link each one to the specific incident response playbook in the incident response plan.
- [ ] Create incident response playbooks for the most common incident types, including what to say while investigating, frequently asked questions, how to confirm the facts, and how often to publish updates.
- [ ] Set up the IT service management (ITSM) incident process so that named approvals are required before anything is released publicly. The required approvers are the Incident Response lead, the Communications/Public Relations (Comms/PR) lead, and Legal/Privacy as applicable.
- [ ] Add a “reputation repair” action workstream to the incident record template. Link it to the affected groups, and include measurable proof that the actions have been completed.
- [ ] Record evidence for public relations (PR) activity in the incident log, including drafts, approvals, publication dates and times, and confirmation that reputation repair has been completed.
- [ ] Limit access to tools used to run pull requests and to publish content, using the minimum permissions needed (least-privilege) and phishing-resistant multi-factor authentication (MFA) for people who approve changes.
- [ ] Run and record at least one tabletop exercise each year to check that the trigger is activated correctly, approvals happen at the right time, messages are accurate, and reputation-repair actions are carried out as planned.


---

### IR-5 — Incident Monitoring (Control)

This requirement is about making sure every security incident is noticed, recorded, and fully dealt with, with a clear written record. Without this, incidents can be missed, important details can be lost, and the organisation may not be able to understand what happened, protect people and systems properly, or learn how to stop the same problem happening again.

The organisation is expected to track every incident by creating and maintaining a separate record for it, keeping the current status up to date as it moves from the first report through investigation and resolution, and recording enough information to support later investigation and review. It should collect incident information from all relevant sources, such as alerts from system or network monitoring, incident reports from response teams, user complaints, reports from supply-chain partners, audit and physical-access monitoring, and reports from users and administrators.

It must also have documented procedures and named responsibilities for incident monitoring, ensure these are reflected in its incident response planning and related plans, and keep the records and supporting evidence available and retrievable for authorised staff.

##### Incident register with mandatory fields, status timeline, and evidence links

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define incident register data model and mandatory field schema (unique ID, type/source, detection time, affected assets/services, initial description, current status, assigned owner/team, investigation notes, post-incident review fields) | Cyber Security Lead | Enterprise | 24h | — |
| Design enforced incident lifecycle states and status-change rules (Reported → Triage → Investigating → Contained → Resolved/Closed) including required rationale, timestamp, actor/role, and “not yet available” justification for closure | System Design Authority | Enterprise | 20h | — |
| Implement immutable status history/timeline and audit trail (append-only event log, role/actor capture, tamper-evident storage approach, retention alignment) | Security Engineer | Enterprise | 40h | — |
| Implement evidence linking model and integration with controlled evidence/log repository (evidence reference types, permissions, link validation, retrieval workflow for authorised staff) | Platform Engineer | Enterprise | 48h | £12,000 |
| Build multi-source intake mapping and ingestion workflows (SIEM/SOAR alerts, EDR alerts, helpdesk/email-to-ticket; normalise into the same incident schema and populate source fields) | DevOps Lead | Enterprise | 56h | £8,000 |
| Add post-incident review templates and closure gating (impact assessment, contributing factors/root cause, lessons learned, follow-up actions with owners/due dates; enforce completion or justified deferral) | Compliance Manager | Enterprise | 24h | — |
| Operationalise workflow responsibilities and monitoring (triage/investigation/evidence curator roles, incident response plan references, runbook updates, and test/acceptance evidence for audit readiness) | Project Manager | Enterprise | 28h | — |

**Total Estimated Effort:** 240h  
**Total Estimated Cost:** £20,000

###### Actions Required for Compliance

- [ ] Set up an incident record template with required fields for a unique reference ID, current status, a timeline of events, the assets affected, investigation notes, and the results from the post-incident review.
- [ ] Set up the stages an incident can go through and require specific details whenever its status changes (time, who or what role made the change, and the reason). Keep an unchangeable audit record of every change.
- [ ] Integrate security information and event management (SIEM), security orchestration, automation and response (SOAR), and endpoint detection and response (EDR) alerts so that incidents are automatically created or linked in the central incident register.
- [ ] Combine helpdesk, email, and other reporting channels into a single incident reporting workflow, using consistent categorisation of the source type.
- [ ] Set up a way to link incident records to the controlled evidence and log storage system, and require that every investigation step includes a reference to the evidence used.
- [ ] Create post-incident review templates and require them to be completed (or formally deferred with a valid reason) before the incident can be closed.


---

#### IR-5.1 — Automated Tracking, Data Collection, and Analysis (Enhancement)

This requirement is about ensuring security incidents are recorded, collected, and reviewed in a consistent, automated way, rather than relying on scattered emails or guesswork. Without this, important information about what happened, when it happened, and who is dealing with it can be missed or lost, which delays action and increases the risk that the same issue repeats or causes greater harm.

The organisation is expected to use its Department of Defence (DoD) incident ticketing system and security operations centre (SOC) case management database to track every incident. It must automatically gather incident details from its monitoring alerts and from information collected from devices and networks, and store everything in a single central incident repository for later review.

It must also automatically analyse the incident information using its built-in analysis rules, automated response workflows, and forensic analysis dashboards. At the same time, it must keep clear written procedures, records, and plans showing how monitoring is carried out and who is responsible, with the ability to support monitoring around the clock.

##### Automate incident tracking, collection, and analysis via IR + SIEM/SOAR

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define single incident/case identifier (case ID) strategy and data model (fields, join keys, evidence references, retention/audit metadata) | System Design Authority | Enterprise | 24h | — |
| Implement SIEM → DoD IR ticketing integration (auto-create or auto-link incidents; structured field mapping; idempotency; rate limiting) | Security Engineer | Enterprise | 48h | £12,000 |
| Configure SOAR playbooks for enrichment, evidence retrieval, timeline updates, and execution status/output recording into the case | DevOps Lead | Enterprise | 56h | £8,000 |
| Integrate endpoint/network telemetry collection and attachment to cases (case ID/correlation keys; time-windowing; evidence normalisation) | Platform Engineer | Enterprise | 64h | £10,000 |
| Configure SIEM correlation rules and write correlation summaries into structured case fields (including detection source, severity, indicators, and confidence) | Security Engineer | Enterprise | 40h | — |
| Implement forensic analytics dashboard generation and automated linking/attachment to cases (timeline/entity/graph/UEBA outputs; access control) | Architect | Enterprise | 32h | £6,000 |
| Establish central storage/audit trail for ingestion, enrichment, analysis outputs, and evidence attachments; implement audit-ready logging and reporting | Compliance Manager | Enterprise | 40h | — |
| Operationalise 24x7 monitoring workflow (failover/retry behaviour, backpressure handling, monitoring/alerting for integration health; runbooks) and conduct end-to-end testing | Operations Lead | Enterprise | 56h | £5,000 |

**Total Estimated Effort:** 360h  
**Total Estimated Cost:** £41,000

###### Actions Required for Compliance

- [ ] Define and use one consistent incident or case reference number across the Department of Defense incident response (DoD IR), security information and event management (SIEM), security orchestration, automation and response (SOAR), and all telemetry data sources.
- [ ] Set up security information and event management (SIEM) so it can automatically create or link incident records in the Department of Defense (DoD) incident ticketing system, using mapped structured fields.
- [ ] Combine information from endpoint devices and network monitoring so that alerts and supporting evidence are automatically attached to the correct incident response (IR) case using matching reference keys.
- [ ] Set up security information and event management (SIEM) correlation rules to produce correlation summaries and analysis results, and store them in structured case fields.
- [ ] Develop and deploy security orchestration, automation and response (SOAR) playbooks to add useful information to cases, gather evidence, carry out only authorised actions, and record the playbook results in the case timeline.
- [ ] Connect forensic analytics dashboards to automatically create and link standard investigation reports to the incident response (IR) case.
- [ ] Test that the system can run end to end, 24 hours a day, 7 days a week, using test incidents. Also confirm that the audit trail records coverage for data intake, data enrichment, analysis, and attaching evidence.


---

### IR-6 — Incident Reporting (Control)

This requirement is about making sure that if anyone suspects something has gone wrong—such as suspicious activity, a possible data breach, or unusual system behaviour—they report it quickly to the organisation’s incident reporting team. The risk it addresses is that delays or unclear reporting can allow harm to spread, make the problem harder to control, and increase the chance that sensitive information is lost or misused before the right people can act.

To meet this expectation, the organisation must clearly state who is responsible for reporting, give staff simple instructions and practical ways to submit reports, and ensure that suspected incidents are reported within 24 hours of the suspicion being noticed. When a report is made, the organisation must send the incident details to the Security Operations Centre incident response lead and also to the Department of Defence (DoD) Cyber Incident Reporting mailbox, and keep records and supporting documents showing what was reported and when.

##### Identity-authenticated incident reporting workflow with SOC routing

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define IR-6 workflow requirements and evidence model (24-hour timer, required metadata fields, authority routing rules, audit evidence checklist) | Compliance Manager | Enterprise | 16h | — |
| Design the identity-authenticated reporting channel (UI/flow, guided “suspected incident” form, attachment handling, data minimisation, validation rules) | System Design Authority | Enterprise | 24h | — |
| Implement IdP SSO integration for the reporting channel (authenticated submission, user attribution, contractor/partner support, session handling) | Security Engineer | Enterprise | 32h | — |
| Build SOC case creation integration (case/ticket auto-generation with timestamp, reporter identity, category, narrative, affected asset, attachments; mapping to SOC case management fields) | Platform Engineer | Enterprise | 56h | — |
| Implement automated notifications to authorities (route/assign to SOC incident response lead; structured notification to DoD Cyber Incident Reporting mailbox via approved email/secure messaging; delivery status capture) | DevOps Lead | Enterprise | 40h | £3,000 |
| Enforce 24-hour operational expectation (workflow timers, escalation rules, SOC acknowledgement/triage escalation thresholds; ensure submission time is recorded and immutable for audit) | Operations Lead | Enterprise | 24h | — |
| Implement audit-ready retention and reporting (store submission record, case timeline, notification delivery status, attachment provenance; retention controls; evidence export for audits) | Data Protection Officer | Enterprise | 24h | — |

| Total Estimated Effort |  |  | **216h** |  |
| Total Estimated Cost |  |  |  | **£3,000** |

###### Actions Required for Compliance

- [ ] Design and publish an organisation-approved “suspected incident” reporting form or portal, and use it as the single place to submit reports.
- [ ] Integrate the portal with the organisation’s identity provider (IdP) so that submissions are authenticated and include the required user details (attributes).
- [ ] Set up security operations centre (SOC) case management so every submission automatically creates a case, including time and date stamps and all required information fields (metadata).
- [ ] Set up automated routing and assignment of each security operations centre (SOC) incident to the incident response lead, and automatically notify the Department of Defense (DoD) Cyber Incident Reporting mailbox.
- [ ] Add automated workflow timing and escalation rules, and make sure the submission, case, and notification dates and times are recorded for audit evidence.
- [ ] Check that end-to-end reporting works correctly by submitting tests, and confirm that evidence is kept so you can show what was reported and when.


---

#### IR-6.1 — Automated Reporting (Enhancement)

This expectation is about ensuring that, when something goes wrong, the organisation automatically creates and shares the correct incident report, without relying on people to copy, paste, or remember what to do. Without this, important information could be delayed, sent to the wrong people, left out, or shared in different formats, which increases the risk that problems spread further or are not dealt with quickly and properly.

To meet this expectation, the organisation must use automated incident reporting methods that: (1) use incident reporting software to generate or prepare the report, (2) send the report to the named recipients using automatically generated emails, and (3) publish incident reports on the organisation’s website, with automatic updates whenever the content changes.

This approach must follow the organisation’s incident reporting policy and procedures. It must also be supported by how the systems are designed and configured, as shown in the relevant plans and documentation, with records kept to prove that the automation works as intended.

##### Automated incident reporting via IR platform email and web publishing

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Confirm IR-6b reporting triggers, required report fields, and template content mapping to incident lifecycle states (including evidence link requirements) | Compliance Manager | Enterprise | 16h | — |
| Configure SOAR/incident platform workflow: incident trigger conditions → report generation template → incident report record/content creation | Software Lead | Department | 24h | — |
| Implement automated email notifications to IR-6b recipient groups/roles (via identity integration), including message formatting and suppression rules | Security Engineer | Department | 20h | — |
| Implement website/CMS publishing integration (API/webhook push preferred; otherwise scheduled read-only sync) with automatic updates on report content changes | Platform Engineer | Department | 28h | £3,000 |
| Lock down integration paths: least-privilege service identities, allow-listed endpoints, secret management, and restricted admin access for workflow/publishing components | Cyber Security Lead | Enterprise | 20h | — |
| Produce audit-ready evidence package and runbook: workflow execution logs, email delivery logs (message IDs/timestamps/recipients), and website publish/update logs (page/version/timestamps) | Compliance Manager | Enterprise | 16h | — |
| Execute end-to-end test for at least one incident: validate trigger, generated content, email delivery, and website update; capture evidence and remediate gaps | Project Manager | Enterprise | 20h | — |

**Total Estimated Effort:** 144h  
**Total Estimated Cost:** £3,000

###### Actions Required for Compliance

- [ ] Choose and set up an incident management and security automation, orchestration, and response (SOAR) platform to run the incident reporting process as the workflow engine.
- [ ] Define the stages of an incident and link each stage to the automated reporting triggers that match the organisation’s incident reporting procedure.
- [ ] Create incident report templates in the platform that automatically fill in the required fields from the incident record.
- [ ] Set up automated email notifications to the IR-6b recipient groups and roles, and check that email delivery records are being captured.
- [ ] Integrate the platform with the organisation website or content management system (CMS) so incident reports are automatically published and kept up to date, using an application programming interface (API) or webhook, or through a scheduled synchronisation.
- [ ] Set up service accounts with the minimum permissions needed (least privilege) and restrict network access using allow-lists for the email and website publishing integrations.
- [ ] Run an end-to-end test incident and keep records as evidence for workflow runs, email delivery, and website publishing or updates.


---

#### IR-6.2 — Vulnerabilities Related to Incidents (Enhancement)

This requirement ensures that, when a security incident occurs, any weaknesses identified during the incident are quickly shared with the right decision-makers. The real-world risk is that a problem found part-way through an incident could be overlooked or treated as a one-off event. If that happens, the same weakness may remain in place and be exploited again, leading to further disruption, loss, or harm to the organisation and the people it serves.

To meet this expectation, the organisation must:
- identify any system weaknesses linked to reported incidents;
- record these weaknesses in the incident report; and
- submit the details through its established incident reporting process to the system owner, the mission or business owner, the senior information security lead, the senior privacy lead, the authorised decision-maker, and the risk executive.

The organisation must then analyse the findings together with these leaders, use the results to prioritise what to fix first, start the appropriate remedial actions, and keep records showing what was reported, analysed, and decided.

##### Incident-to-vulnerability reporting workflow to required leadership roles

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define IR-6(2) incident-related vulnerability data schema (fields, validation rules, evidence link requirements, and mapping to ir-06.02_odp roles) | Compliance Manager | Enterprise | 16h | — |
| Extend incident reporting record model and UI/API to capture “vulnerability discovered”, affected assets/components, weakness type, confidence/impact notes, and evidence links | Software Lead | Enterprise | 40h | — |
| Implement triage gate/workflow automation: auto-generate incident-related vulnerability package/section (or linked record) when incident is tagged as uncovering a vulnerability | Platform Engineer | Enterprise | 32h | — |
| Configure auditable routing and approvals for all ir-06.02_odp roles (notifications, time-stamped workflow steps, participation evidence capture; no ad-hoc email) | DevOps Lead | Enterprise | 24h | — |
| Implement “analysis before closure” enforcement: block incident closure/resolution until required roles record review outcomes (prioritisation, mitigation initiation, or documented risk acceptance path) | Operations Lead | Enterprise | 24h | — |
| Integrate with vulnerability/change/remediation management to create/attach remediation tasks with severity-based SLAs and traceability back to the incident/vulnerability package | Infrastructure Lead | Enterprise | 32h | £6,000 |
| Build audit-ready evidence pack generation (role participation logs, analysis notes/decisions, links to mitigation tasks, retention tagging) and test against IR-6(2) evidence expectations | Quality Assurance Lead | Enterprise | 24h | £2,500 |
| Conduct end-to-end testing, pilot rollout, and operational handover (runbooks, monitoring/alerts for workflow failures, and training for incident managers and system owners) | Project Manager | Enterprise | 24h | £3,000 |

**Total Estimated Effort:** 240h  
**Total Estimated Cost:** £11,500

###### Actions Required for Compliance

- [ ] Update the incident reporting template to include fields for vulnerability information related to the incident, including the affected assets or components, links to supporting evidence, the type of weakness, and the confidence and impact levels.
- [ ] Set up an incident triage rule that creates a vulnerability package whenever an incident is labelled as uncovering a vulnerability.
- [ ] Set up workflow routing and approval steps so the vulnerability package is sent to the roles listed in **ir-06.02_odp**, and record time-stamped proof that those roles took part.
- [ ] Require a closure check that captured analysis results are approved by the required roles, and that a recorded decision is made showing how issues were prioritised and mitigated, or how the risk was accepted.
- [ ] Integrate the workflow with the organisation’s change management and vulnerability management processes to create trackable repair tasks, with response times based on severity (service level agreements, SLAs).
- [ ] Check that audit evidence is being produced correctly by running test incidents and confirming that each incident record links to the vulnerability details, shows which roles were involved, records the analysis decisions, and includes the mitigation actions.


---

#### IR-6.3 — Supply Chain Coordination (Enhancement)

This requirement is about making sure that, if something goes wrong that involves a supplier’s product or a part of your supply chain, you promptly and clearly tell the right external parties what happened. If you do not, the supplier and other involved organisations may not be able to stop the problem, protect customers, or fix the root cause—allowing the same weakness to spread through deliveries, installations, or ongoing services.

To meet this expectation, the organisation must:

- define what counts as a supply-chain-related incident  
- appoint named people to coordinate reporting  
- decide what information is safe and useful to share  
- keep written plans for how incident reporting and supply-chain coordination will work  

When an incident occurs, the organisation must share relevant details with:

- the product or service provider  
- other supply-chain organisations involved  
- any applicable supply-chain governance body, such as the Federal Acquisition Security Council  

This must be done using agreed communication routes. The organisation must also record what information was shared, when it was shared, who received it, and why sharing it was appropriate.

##### Automated supply-chain incident notification workflow with audit trail

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Extend incident taxonomy and classification rules to include supply-chain incident types; define affected supplier/provider role mappings per incident type | Cyber Security Lead | Enterprise | 24h | — |
| Design and implement the “Supply-chain Coordination” playbook in the incident management system with required structured outbound-notification fields (component/product identifiers, versions/serials, detection time, impact summary, IOCs as applicable, containment actions, requested actions) | System Design Authority | Enterprise | 40h | — |
| Implement policy-based sharing gates (workflow rules) covering: approval for sensitive indicators/forensic artefacts/customer-data references; required field validation; recipient eligibility checks; escalation triggers for governance-body routing | Security Engineer | Enterprise | 56h | — |
| Build automated recipient determination using maintained supplier/provider party lists and contractual/SLA notification metadata; include mapping for provider, integrators, distributors, resellers and governance-body applicability | Platform Engineer | Enterprise | 40h | — |
| Configure auditable evidence capture for every external notification (template/summary ID, recipients, timestamps, approvers, rationale/value justification, and immutable audit log linkage to the incident record) | Compliance Manager | Enterprise | 32h | — |
| Integrate with external notification channels (e.g., email/API/webhook) with secure handling of content (redaction controls for sensitive fields, attachment handling rules, and retry/error logging) | DevOps Lead | Enterprise | 24h | £6,000 |
| Execute end-to-end testing and tabletop exercises (including negative tests for missing fields/insufficient approvals and governance-body routing cases); produce test evidence and update runbooks | Quality Assurance Lead | Enterprise | 32h | — |

**Total Estimated Effort:** 248h  
**Total Estimated Cost:** £6,000

###### Actions Required for Compliance

- [ ] Extend the incident classification to include supply-chain incident types, and link each type to the supplier or provider roles that are affected.
- [ ] Create a supply-chain coordination playbook and define the required outbound notification fields in the incident management system.
- [ ] Set up policy-based sharing controls (“sharing gates”) that require approval before sharing sensitive indicators, and that enforce rules for choosing who can receive them.
- [ ] Add supplier and provider party mapping from procurement, vendor management, and contract information into the workflow used to identify the correct recipient.
- [ ] Set up routing rules for the governance body to handle the relevant supply-chain governance obligations (for example, the Foreign Account Tax Compliance Act (FATCA) where applicable).
- [ ] Keep a complete, auditable record for every external notification, including the recipients, date and time, who approved it, a summary of the message template and content, and the reason for sending it.


---

### IR-7 — Incident Response Assistance (Control)

This expectation is about making sure people have a clear and dependable way to get help when something goes wrong. It should help them quickly understand what to do and how to report the issue. Without this, suspicious events or real incidents may be dealt with in different ways, reported too late, or reported without enough information. That can make damage worse, slow recovery, and increase the risk of harm to customers and the organisation.

To meet this expectation, the organisation must provide an incident support route as part of its incident response capability. This route must be available to people using the relevant systems and must offer practical guidance for both handling incidents and reporting them. The support should be delivered through agreed support options, such as a help desk, an assistance team, or an automated reporting and tracking process. It must also include access to specialist forensic support and, where needed, consumer redress services.

The organisation must name specific people responsible for this support, make sure they can access the tools needed to help, document how support will be provided in its incident response documents, and keep its privacy and system security plans aligned with how support is delivered.

##### Incident report & triage service desk with guided playbooks

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define incident reporting service desk requirements (intake channels, playbook triggers, evidence prompts, required fields, workflow states, audit logging requirements) and produce implementation-ready design document | Cyber Security Lead | Enterprise | 24h | — |
| Configure service desk incident reporting entry point (portal form + phone/email-to-ticket mapping), including user-facing labelling “Incident reporting / Report & Triage” and publishing links in application help/landing pages | Service Delivery Manager | Enterprise | 32h | £3,000 |
| Implement guided, role-appropriate playbooks in the ticket intake flow (phishing, malware, unauthorised access, data exposure) with “what to do now” and “what not to change/delete” prompts, plus required reporting detail capture | Software Lead | Enterprise | 40h | — |
| Integrate ticket capture with enterprise identity provider to auto-populate user/context fields (user, group/role, device/location where available, timestamps) and enforce data minimisation (no unnecessary sensitive data entry) | Platform Engineer | Enterprise | 32h | £6,000 |
| Configure incident workflow states and mandatory fields (Received → Triaged → Assigned → Investigating → Contained/Eradicated → Recovered → Closed), including evidence/communications requirements and auditable status-change logging | Operations Lead | Enterprise | 28h | — |
| Implement automated routing rules to correct incident response queues (category, impacted application/system, severity, business unit), including queue ownership, resolver group assignment, and escalation paths | Infrastructure Lead | Enterprise | 24h | — |
| Add escalation hooks for specialist services: digital forensics work order + approvals, and consumer redress/legal review work order + approvals where required; include tested triggers and handoff evidence | Compliance Manager | Enterprise | 24h | £4,500 |
| Update incident response documentation plus system security plan and privacy plan references (assistance access route, information collected, handling rules, escalation routes) and produce audit evidence pack (screenshots/config exports, workflow logs) | Data Protection Officer | Enterprise | 20h | — |
| **Total Estimated Effort** |  |  | **244h** |  |
| **Total Estimated Cost** |  |  |  | **£13,500** |

###### Actions Required for Compliance

- [ ] Set up one single “Incident reporting / Report and triage” contact point in the service desk (portal, phone, and email-to-ticket) for the application’s users.
- [ ] Create guided incident intake playbooks that include immediate actions to take, prompts to preserve evidence, and the required information fields for reporting.
- [ ] Link the service desk to the organisation’s identity provider so ticket details are filled in automatically (user identity, role or group, and time stamps), using data minimisation.
- [ ] Set up automated rules to route support tickets into the correct incident response triage teams, and require specific evidence and communication details before tickets can move to the next stage in the workflow.
- [ ] Set up workflow escalation actions to create forensics work orders and, where relevant, consumer redress and legal review work orders, with approval triggers.
- [ ] Update the incident response documentation. Also make sure the system security plan and the privacy plan clearly name the support (assistance) mechanism and the escalation routes.


---

#### IR-7.1 — Automation Support for Availability of Information and Support (Enhancement)

This requirement is about ensuring help for urgent incidents is always available, including outside normal working hours, and that people are kept informed automatically. Without it, staff may find it harder to get the right guidance when something goes wrong, support requests could be delayed because they have to be logged manually, and requesters might not receive timely updates—allowing problems to worsen or creating confusion about what is happening.

To meet this expectation, the organisation must run a 24/7 incident response assistance portal that automatically accepts support requests, immediately confirms receipt with a reference number (ticket reference), and sends proactive status updates to the requester by email and through an approved secure messaging channel, based on how the ticket progresses.

The organisation must clearly set out who is allowed to use the portal and assign named responsibilities for using and overseeing it. It must involve information security oversight, document the assistance procedures and how the automated features are used, keep records of the portal’s design and configuration, and be able to show that the portal and notifications work as intended.

##### 24x7 incident response portal with automated ticketing and proactive updates

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define portal target architecture, ticket-state model, and notification workflow (state machine, templates, escalation rules, and integration approach with ITSM + secure messaging) | System Design Authority | Enterprise | 40h | — |
| Implement portal (24x7 web/API) with authenticated access and role-based authorisation (requester submission + IR assistance management views) | Software Lead | Enterprise | 120h | £15,000 |
| Configure automated ticket intake and acknowledgement (portal submission → ITSM ticket creation → immediate acknowledgement with ticket reference) | Platform Engineer | Enterprise | 56h | — |
| Implement proactive status updates driven by ITSM ticket state transitions (email + approved secure messaging channel; ensure idempotency and delivery rules) | DevOps Lead | Enterprise | 64h | £8,000 |
| Produce audit-ready governance and evidence pack (procedures for portal use, workflow/notification configuration evidence, access control evidence, integration diagrams, and operational runbook) | Compliance Manager | Enterprise | 48h | — |
| Implement monitoring, logging, and synthetic availability/automation tests (24/7 reachability checks; submit-and-verify acknowledgement + at least one state-change update) | Operations Lead | Enterprise | 40h | £6,000 |
| Security assurance for the portal and integrations (threat model, secure configuration review, vulnerability scanning coordination, and evidence of remediation/acceptance) | Security Engineer | Enterprise | 48h | £10,000 |

**Total Estimated Effort:** 416h  
**Total Estimated Cost:** £39,000

###### Actions Required for Compliance

- [ ] Choose and set up the 24/7 incident response support portal, and connect it to the organisation’s identity provider so only authorised users can access it.
- [ ] Set up automated ticket intake so that when people submit requests through the portal, the system automatically creates incident-response tickets in the IT service management (ITSM) system.
- [ ] Set up an immediate automated acknowledgement that sends the requester a ticket reference through the portal response and/or a notification.
- [ ] Define the stages of a ticket’s life cycle, and link each stage change to proactive notification rules for email and approved secure messaging.
- [ ] Set up secure messaging integration and record an audit log for every outbound status update.
- [ ] Create and keep audit-ready records covering how the portal is used, how automated notifications are set up, and how the workflow and state machine are designed.
- [ ] Set up continuous monitoring and automated test checks to confirm the portal is reachable 24 hours a day, 7 days a week, and that messages are successfully received and notifications are delivered.


---

#### IR-7.2 — Coordination with External Providers (Enhancement)

This requirement is about making sure your organisation can work smoothly with outside specialists when something goes wrong, so help is coordinated quickly and clearly. Without a direct, cooperative arrangement and named contacts, an incident could be dealt with slowly or in different ways, important information might not be shared on time, and the outside provider might not know who to contact or what actions to take—making it more likely that systems are damaged and the business is disrupted.

To meet this expectation, the organisation must set up a clear working relationship with each external provider that helps protect, monitor, analyse, detect, and respond to unauthorised activity on your systems and networks. The organisation must also identify and document the specific incident-response team members who will liaise with each provider.

The organisation should ensure its incident-response documents and procedures explain how help will be requested and coordinated, and that the named contacts are provided to the relevant providers so coordination can happen before any incident occurs.

##### Provider incident-response addendum and named liaison contacts

- Category: Manual
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Draft standard “incident-response cooperation addendum” template covering triggers, provider workflow, triage/analysis/response actions, acknowledgement/escalation timelines, evidence handling, and information-sharing boundaries | Compliance Manager | Enterprise | 24h | — |
| Create “provider liaison pack” structure and governance approach (version control, naming conventions, approval workflow) including per-provider fields: scope, named IR liaison(s), backup liaison(s), out-of-hours contacts, escalation path, and containment authorisation roles | Security Engineer | Enterprise | 16h | — |
| Update incident response procedures to reference the liaison pack and define the step-by-step method to request provider assistance (channels, required incident metadata, handover/evidence transfer steps, and boundaries) | Incident Response Lead / Security Operations Lead | Enterprise | 12h | — |
| Implement contract management workflow to incorporate the addendum into relevant provider agreements and maintain a register of “addendum required / addendum signed / addendum pending” status | Project Manager | Enterprise | 18h | — |
| Onboard providers: issue liaison pack contacts via an authorised channel, obtain provider confirmation of receipt, and capture/retain evidence for audit (including provider escalation details and any provider-assisted containment constraints) | Contract/Procurement Manager | Enterprise | 20h | £2,500 |
| Validate coordination readiness: run tabletop exercises per critical provider (at least annually) to test correct contact selection, escalation timing, and alignment with the addendum; document outcomes and remediation actions | Quality Assurance Lead | Enterprise | 24h | £3,000 |
| Maintain ongoing assurance: schedule annual liaison pack review and addendum re-confirmation cadence, including change triggers (new provider, contact changes, scope changes) and periodic evidence checks | Operations Lead | Enterprise | 10h | — |

**Total Estimated Effort:** 124h  
**Total Estimated Cost:** £5,500

###### Actions Required for Compliance

- [ ] Create a draft standard addendum template for working together during an incident, covering: when to start cooperation (triggers), the step-by-step workflow, what each provider must do, escalation timeframes, how evidence is handled, and the limits on what information can be shared.
- [ ] For each external provider that supports monitoring, detection, analysis, and response, attach the addendum and obtain their signature.
- [ ] Create and keep up to date a controlled provider liaison pack for each provider. It should list the incident response (IR) liaisons, their backups, out-of-hours contacts, and the escalation routes.
- [ ] Update the incident response procedures to point to the liaison pack and set out a clear, step-by-step process for requesting help from the provider and handing over the case.
- [ ] Share the named liaison contacts with each provider through an authorised method, and record each provider’s confirmation that they received them.
- [ ] Run tabletop exercises for each critical supplier to confirm the right people are contacted, escalations happen at the correct times, and responsibilities match the addendum.


---

### IR-8 — Incident Response Plan (Control)

This requirement is about having a clear, trusted “playbook” for what to do when something goes wrong, so the organisation can respond quickly and in the same way every time, rather than improvising under pressure. Without a well-prepared plan, important decisions may be delayed, responsibilities may be unclear, the wrong people may be involved, and critical information may be shared incorrectly—leading to greater damage and longer recovery. Where personal data is involved, it can also result in missed or inappropriate notifications to the right oversight bodies or affected individuals.

The organisation must create and keep up to date an incident response plan that explains:
- how the response capability will be built and run
- how the response is organised
- how it fits with the wider business
- what counts as a reportable incident
- how performance will be measured
- what resources and management support are needed
- how incident information will be shared internally and with relevant external parties

The plan must be approved by the chief information security officer (CISO) and the Head of Information Security Governance at least once every year, and also after major system or organisational changes. Copies must be distributed to security operations centre (SOC) shift leads, incident response team members, and IT Operations managers.

Any updates must be communicated to the incident response (IR) manager and SOC shift leads, and also to the CISO office, the SOC, and IT Operations change management. The plan must be protected so it cannot be viewed or changed without authorisation.

##### Single-source IR plan with approvals, distribution, and PII breach workflow

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Draft “Single Source of Truth” IR Plan structure (sections, roles/responsibilities, incident taxonomy, metrics/KPIs, resources/support, internal/external sharing) aligned to IR-8 expectations | Compliance Manager | Enterprise | 24h | — |
| Build/author PII breach notification workflow annex (decision criteria for oversight vs affected individuals, approval/authorisation steps, timing/escalation triggers, notification content templates, record-keeping requirements) | Data Protection Officer | Enterprise | 20h | — |
| Configure controlled document repository governance (versioning, auditable change history, access groups, MFA enforcement for IR roles, edit permissions limited to authorised approvers) | Platform Engineer | Enterprise | 16h | £3,000 |
| Define approval and re-approval triggers and evidence linkage to change management (annual review; after major system/organisational changes; mapping to change records and audit trail requirements) | Security Engineer | Enterprise | 14h | — |
| Establish distribution and communication plan for updates (publish approved plan + annex index; notify IR Manager & SOC shift leads; notify CISO office, SOC, and IT Operations change management; confirm recipient list) | Project Manager | Enterprise | 10h | — |
| Run review, approval, and sign-off cycle (CISO + Head of Information Security Governance) including document review pack, tracked feedback, and final approval evidence capture | Compliance Manager | Enterprise | 12h | — |
| Execute tabletop validation of the PII breach workflow and IR plan usability (scenario-based walkthrough; confirm decision/authorisation steps, escalation timings, and record-keeping outputs) | Quality Assurance Lead | Enterprise | 10h | — |

**Total Estimated Effort:** 106h  
**Total Estimated Cost:** £3,000

###### Actions Required for Compliance

- [ ] Create the incident response (IR) plan in a controlled document repository with version control and a complete, auditable record of all changes.
- [ ] Define and document incident response responsibilities, including: the Chief Information Security Officer (CISO) for overall responsibility, the incident response (IR) manager for day-to-day management, and the security operations centre (SOC) team for triage and coordination. Also list who should receive incident updates.
- [ ] Create an incident classification (taxonomy) and define what counts as a reportable incident, then set incident response performance measures (key performance indicators) and identify the resources required.
- [ ] Add an annex for personal data (personally identifiable information (PII)) breach notifications, including decision criteria, approval steps, how notifications will be sent, and record-keeping.
- [ ] Set up an approval process that requires annual sign-off from the Chief Information Security Officer (CISO) and the Head of Information Security Governance, and also approval after any major system or organisational changes.
- [ ] Limit access to the plan to authorised roles and groups, and allow edits only with controlled permissions that can be traced back to the person who authorised them.
- [ ] Share the approved plan with the security operations centre (SOC) shift leads, incident response (IR) team members, and IT Operations managers, and communicate updates to the agreed organisational groups.


---

#### IR-8.1 — Breaches (Enhancement)

This requirement is about making sure that, when a security incident involves people’s personal information, the organisation can quickly and responsibly decide what to do next. Without a clear plan, the organisation may contact the wrong people too late, miss required notifications under law or contract, or underestimate the real impact on those affected—such as embarrassment, distress, inconvenience, or unfair treatment.

To meet this expectation, the organisation must include these steps in its incident response plan:

- A documented way to decide whether affected individuals and/or other organisations (including oversight bodies) need to be informed.
- A structured assessment of how much harm is likely and what negative effects could occur, followed by choosing practical actions to reduce that harm.
- A process to identify which privacy rules apply, so they are followed during the incident handling.

The plan should also reflect any breach-notification procedures required by law, regulation, or internal policy.

##### PII breach notification decision support in IR plan

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Conduct gap analysis of current IRP against IR-8(1) enhancement for PII breach notification (including notice decision requirements, harm standards, mitigation requirements, and privacy requirement identification) | Compliance Manager | Enterprise | 16h | — |
| Draft dedicated “PII Breach Notification Decision Support” section for the IRP, including documented notification decision workflow (triggers/factors, evidence expectations, escalation/approval roles, and timing considerations) | System Design Authority | Enterprise | 24h | — |
| Define and document structured harm assessment template and scoring/threshold guidance (individual harms, downstream/other negative impacts, and safety implications where applicable) | Data Protection Officer | Enterprise | 20h | — |
| Create mitigation selection approach and linkage rules (map assessment outputs to specific mitigation actions and communications adjustments; include decision rationale recording requirements) | Security Engineer | Enterprise | 16h | — |
| Establish and maintain a privacy requirements register referenced by the playbook (jurisdictional variations, required notice recipients, and how requirements are identified/applied during incident handling) | Data Protection Officer | Enterprise | 24h | — |
| Add audit-ready evidence capture requirements to the IRP section (what evidence to collect, how to document rationale/timing, and minimum audit trail fields for notification decisions) | Compliance Manager | Enterprise | 12h | — |
| Validate the updated IRP section through tabletop exercise for a PII breach scenario and produce an evidence pack demonstrating decision rationale, harm assessment outputs, mitigation selection, and privacy requirements used | Project Manager | Enterprise | 20h | — |
| Finalise, publish, and roll out the IRP update (version control, internal communications, and training for incident response, privacy/legal, SOC/forensics, and communications stakeholders) | Operations Lead | Enterprise | 18h | — |

**Total Estimated Effort:** 150h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Update the incident response plan (IRP) by adding a dedicated section for the personal information (PII) breach playbook. This should cover: the notification decision process, how harm is assessed, how mitigation actions are linked, and how privacy requirements are applied.
- [ ] Define and document what events or factors trigger notifications for personal information (PII) breaches, what evidence must be provided, and when decisions must be made.
- [ ] Assign named responsibilities for (1) deciding whether to send notifications, (2) privacy and legal review, and (3) approving communications, including clear escalation routes if issues arise.
- [ ] Create and standardise a harm assessment template that records the likely harms and other negative impacts that are relevant to the organisation.
- [ ] Create a “mitigation-to-harm” mapping in the playbook so that the selected actions are clearly linked to, and justified by, the results of the assessment.
- [ ] Create and keep up to date a privacy requirements register that accounts for local legal rules (jurisdiction-aware), and link it to the personal information (PII) breach response playbook.
- [ ] Run a tabletop exercise for a personal information (PII) breach to confirm that the incident response plan (IRP) produces a clear, audit-ready explanation, a complete record of evidence, and the correct mitigation and notification actions.


---

### IR-9 — Information Spillage Response (Control)

This requirement is about responding quickly and carefully when information is sent to the wrong place by mistake, or when it is later found to be more sensitive than expected. If there is no clear response, the information could spread further, be accessed by people who should not have it, and cause legal, financial, and reputational harm.  

The organisation must ensure that the Incident Response Lead, the security operations centre (SOC) analysts, and the owner of the affected system are clearly responsible for handling these incidents, including identifying exactly what information was involved. They must alert the Incident Response Lead and the affected system owner using a communication route that is not linked to the original mistake. They must then immediately isolate the affected system or component, remove the information that was sent in error, and check whether anything else may have been contaminated.  

Finally, they must document what happened, keep relevant records for review, update risk assessments, and notify the required stakeholders in line with the organisation’s incident procedures.

##### Automated spill response workflow with safe alerting and containment

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define “spill case” data model and required fields (expected vs actual classification/impact, affected systems, data identifiers/hashes/message IDs, timestamps, storage media, severity, evidence pointers) and map to IR-9 evidence requirements | Compliance Manager | Enterprise | 24h | — |
| Design workflow orchestration with audit logging and mandatory gates (case creation → assignment → non-spill alert → containment/eradication steps → spread analysis → evidence/risk/stakeholder notifications) including role-based authorisation and approval points | System Design Authority | Enterprise | 32h | — |
| Implement integrations to ingest signals from DLP/CASB/email/file-transfer/cloud audit and create/update spill cases (including classification/impact mismatch discovered after the fact) | Platform Engineer | Enterprise | 56h | £18,000 |
| Implement automated assignment using on-call/rotation and authoritative asset-to-owner mapping (Incident Response Lead, SOC analysts, affected system owner) with fallback/escalation rules | Security Engineer | Enterprise | 24h | — |
| Implement “non-spill” alerting channel enforcement (secure ticketing + phone/SMS escalation) with explicit exclusion of the original spill mechanism/thread; include message templates and audit trail | Operations Lead | Enterprise | 40h | £6,000 |
| Build containment/eradication runbook automation with verification steps (revoking sessions/tokens, quarantining/deleting by object identifiers where supported, API/listing/access checks, and recording “not applicable” outcomes) | DevOps Lead | Enterprise | 72h | £12,000 |
| Implement spread analysis using dependency/data-lineage mappings and downstream propagation queries (shared-folder propagation, sync/replication logs, object versioning, messaging fan-out) and record additional potentially contaminated components | Security Engineer | Enterprise | 48h | — |
| Evidence, risk, and stakeholder notification workflow gates (log/case artefact preservation, risk assessment update references, stakeholder notification per incident procedures) plus end-to-end testing and audit-ready reporting | Quality Assurance Lead | Enterprise | 40h | — |

**Total Estimated Effort:** 336h  
**Total Estimated Cost:** £36,000

###### Actions Required for Compliance

- [ ] Define the sources used to detect spills, and link their events to a standard spill case format, including the expected versus actual classification and impact, the systems affected, and the relevant data identifiers.
- [ ] Set up automated creation and assignment of spill incidents to the Incident Response Lead, security operations centre (SOC) analysts, and the owner of the affected system, based on the on-call rota and a record of which assets belong to which owners.
- [ ] Set up alerts so that notifications sent to responders use an approved communication channel that does not risk spreading the spill, and that is separate from the original spill method.
- [ ] Create runbook-led containment and removal steps for each supported type of storage (for example, revoke active sessions and tokens, and isolate or delete items using their object identifier), with recorded checks to confirm the actions were completed successfully.
- [ ] Run spread-analysis checks using propagation, synchronisation, and replication logs, along with records showing how systems depend on each other and how data moves between them. Also require that any systems that could be contaminated are identified and recorded.
- [ ] Before closing the spill case, make sure evidence is collected and recorded, that the risk assessment update references are documented, and that the required stakeholder notifications have been completed.


---

#### IR-9.2 — Training (Enhancement)

This requirement is about making sure the right people know exactly what to do if sensitive information is accidentally shared or leaked. Without regular, job-specific training, staff may not notice a leak quickly, may take the wrong first steps, or may contact the wrong people. This can lead to avoidable harm, such as financial loss, legal issues, or damage to trust.  

To meet this expectation, the organisation must provide information spillage response training to staff who have responsibilities for incident handling and information security at least once every year, and again whenever their role changes. The training must clearly explain each person’s responsibilities during an information spillage and the specific actions they must take. It must be based on the organisation’s documented incident-handling plan and security approach.  

The organisation must also keep reliable records showing who completed the training and when, so the yearly and role-change timing can be checked.

##### Role-based spillage response training with annual and role-change recert

- Category: Software
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Develop spillage response training curriculum mapped to the incident response plan (module objectives, individual responsibilities, step-by-step actions, and evidence handling/notification routes) | Cyber Security Lead | Enterprise | 40h | — |
| Define role-to-training audience mapping (incident responders, SOC/monitoring analysts, IT security operations, escalation owners, system/application owners) and maintain the mapping as an auditable artefact | Compliance Manager | Enterprise | 16h | — |
| Configure LMS course structure and role-based assignment rules (including annual recertification scheduling and role-change-triggered re-enrolment) | Platform Engineer | Enterprise | 24h | — |
| Implement IdP/HR-ITSM role-change integration to drive LMS enrolment/entitlement updates (group mapping, event handling, and test scenarios) | DevOps Lead | Enterprise | 32h | £8,000 |
| Configure auditable completion records and reporting exports (user identifier, training/module, assignment date, completion date, completion status; retention-ready report templates) | Security Engineer | Enterprise | 16h | — |
| Validate content-to-procedure alignment and run pilot completion testing with a sample of users across roles; remediate gaps and obtain sign-off | Quality Assurance Lead | Enterprise | 20h | — |
| Establish operational runbook for annual cadence and role-change triggers (monitoring, exception handling, evidence retention, and periodic review) | Service Delivery Manager | Enterprise | 12h | — |

**Total Estimated Effort:** 160h  
**Total Estimated Cost:** £8,000

###### Actions Required for Compliance

- [ ] Create an information leakage response training programme linked to the incident response plan, and set out who is responsible for each part and what actions are required in every module.
- [ ] Define and keep up to date a list that links each role to the training audience, aligned with incident response responsibilities.
- [ ] Set up the learning management system (LMS) to assign spill training based on the user’s group membership in the identity provider (IdP) for each defined role.
- [ ] Set up an annual re-check (recertification) schedule for the defined group of users within the learning management system (LMS).
- [ ] Set up role-change triggers so that when a user’s role changes (through Human Resources or IT service management to the identity provider), the learning management system automatically assigns the required spill training and records whether it has been completed.
- [ ] Set up learning management system (LMS) reporting and exports to produce audit-ready evidence showing each user’s training and completion date/status, and keep the records for as long as required by the organisation’s retention policy.


---

#### IR-9.3 — Post-spill Operations (Enhancement)

This expectation is about keeping work going when sensitive information has accidentally been exposed, so staff are not left waiting for repairs. If there are no clear steps after an incident, staff may be unable to do their jobs while affected systems are being fixed. They may also be tempted to use unsafe systems or access the wrong information, which could make the impact of the exposure worse.  

The organisation must therefore write and follow clear, documented post-incident procedures. Once a system is treated as contaminated, these procedures must immediately activate only pre-approved ways to continue work around the problem. They must move affected duties to clean (non-impacted) systems that are ready to use, and they must give impacted staff temporary access only to the approved data sets they need to continue their tasks.  

This temporary access must last only until the organisation confirms that corrective actions are complete, and then it must be removed. The organisation must also keep records showing what was done and who was responsible.

##### Post-spill continuity runbook with approved workarounds and time-limited access

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define “Spill Mode” runbook scope, triggers, and controlled sequence (activation → workaround enablement → duty reassignment → temporary access → evidence/closure) including environment-awareness (prod/test/DR) | Project Manager | Enterprise | 24h | — |
| Create and approve the “approved workaround catalogue” mapped to business roles and impacted system components; include enable/disable criteria and audit fields (trigger time, contaminated system IDs, workaround IDs, approver) | Compliance Manager | Enterprise | 32h | — |
| Define “clean system” targets and duty-to-clean-system routing mappings (ITSM/workflow queues, application routing rules, job schedulers) and produce routing validation evidence requirements | System Design Authority | Enterprise | 40h | — |
| Define “approved data sets” list and access model for Spill Mode (scope, dataset allow-list, gating rules, expiry policy, accountable approval workflow, revocation triggers) | Data Protection Officer | Enterprise | 32h | — |
| Implement Spill Mode orchestration in the application/automation layer (feature flags/config switches for approved workarounds; routing updates to clean targets; time-bounded access enablement via IdP/authorisation integration) | Platform Engineer | Enterprise | 96h | — |
| Implement audit-ready evidence logging and reporting (step timestamps, contaminated/clean identifiers, workaround IDs, duty reassignment mapping, access grant/revocation records) integrated with SIEM/logging standards | Security Engineer | Enterprise | 48h | — |
| Implement time-bounded access revocation automation and “Remediation Complete” closure workflow (automatic/manual revocation, expiry enforcement, end-of-Spill Mode controls) | DevOps Lead | Enterprise | 40h | — |
| Execute tabletop + controlled drill in non-prod to verify acceptance criteria and produce an evidence pack (approved-only workarounds, clean routing, time-bounded dataset access, revocation on completion) | Quality Assurance Lead | Enterprise | 24h | £3,000 |

| Total Estimated Effort | Total Estimated Cost |
|---:|---:|
| 336h | £3,000 |

###### Actions Required for Compliance

- [ ] Draft and get approval for a “Spill Mode” post-incident runbook that clearly sets out the three procedures—(1) activating the workaround, (2) reassigning duties, and (3) granting temporary, pre-approved access to data—and specifies the conditions that trigger it and when it can be closed.
- [ ] Create and keep an approved list of workarounds, linked to business roles and the system components affected by each workaround.
- [ ] Define clear “clean system” targets and set up duty-to-clean-system routing rules for each business process that is affected.
- [ ] Set up identity and access controls for “Spill Mode” so temporary access is only allowed to approved data sets, and automatically ends after a set expiry time.
- [ ] Integrate the runbook with IT service management (ITSM), workflow tools, and security orchestration, automation and response (SOAR) so that staff duty changes and access permissions are carried out and recorded in a clear, auditable order.
- [ ] Test the full “Spill Mode” process from start to finish (a tabletop exercise plus a technical drill) and confirm that the recorded evidence includes: timestamps, the people who approved actions, workaround IDs, routing mappings, and that access is removed when remediation is completed.


---

#### IR-9.4 — Exposure to Unauthorized Personnel (Enhancement)

This requirement is about preventing confidential information from being used or shared if someone sees it by mistake or without permission. If this is not dealt with quickly, the information could be copied, shared, or acted on, and the organisation could also break strict legal rules that apply to certain types of information. This could cause serious financial loss, regulatory action, and reputational damage.

The organisation must be able to recognise immediately when a person has been exposed to information they are not authorised to access. It must then remove their access to the affected information right away and keep them under supervision while the situation is assessed.

The person must receive a clear briefing on what they are allowed to do only on a need-to-know basis. They must sign a non-disclosure agreement before any further handling of the information. They must also be told about the relevant legal and compliance rules that apply to the specific type of information involved, including export rules, health information rules, personal data rules, and contractor security obligations where relevant.

Any spill or exposure must be reported to Security within one hour, including the key details. The information must be kept contained until Security formally confirms that the person may proceed.

##### Automated exposure containment workflow with legal briefing & NDA

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define exposure detection triggers and evidence model (data classification tags, role-mismatch signals, DLP/view/copy events, log identifiers) and produce an implementation-ready trigger specification | Security Engineer | Enterprise | 40h | — |
| Design and implement automated containment actions (session termination, resource-level access revocation, linked repository blocking, “no further handling” enforcement) with idempotent, auditable execution | Platform Engineer | Enterprise | 80h | — |
| Implement Security case automation with mandatory fields and 60-minute SLA notification (case creation, evidence attachments, timer/alerting, escalation path) | Operations Lead | Enterprise | 56h | — |
| Build NDA + legal briefing gating workflow (regulatory-tag-to-briefing/NDA mapping, e-sign/ack flow where permitted, case-linked completion status, exception handling for legally unavailable scenarios) | Compliance Manager | Enterprise | 72h | £25,000 |
| Implement clearance/escort containment gate (system-side re-access lock until Security clearance recorded; define clearance workflow states and audit trails; integrate with IAM/authorisation checks) | IAM / Platform Engineering | Enterprise | 64h | — |
| Integrate observability and audit reporting (end-to-end traceability from trigger → containment → case → briefing/NDA → clearance; retention alignment; dashboards for SOC review) | Cyber Security Lead | Enterprise | 40h | — |
| Execute test plan and go-live readiness (table-top + technical tests for false positives/negatives, SLA timing verification, security regression, runbook + operator training, change management support) | Quality Assurance Lead | Enterprise | 48h | — |

**Total Estimated Effort:** 400h  
**Total Estimated Cost:** £25,000

###### Actions Required for Compliance

- [ ] Define and put in place alerts (“exposure triggers”) based on the type of data and any regulatory labels, so that every time someone views, accesses, or copies the data, the activity is recorded and can be audited.
- [ ] Set up automatic log-out (session termination) and revoke access to the affected information and any linked repositories, based on the specific resources involved.
- [ ] Link the workflow to the incident or ticket system so it creates a Security case with required evidence fields, and ensure notifications are sent within a 60-minute service level agreement (SLA).
- [ ] Set up a briefing and non-disclosure agreement (NDA) check so that no further handling can take place until the case records show that the briefing has been acknowledged and the NDA has been completed.
- [ ] Add a security clearance checkpoint that blocks re-enabling access or any further handling until formal clearance is recorded.
- [ ] Set up audit logs and retention periods for detecting triggers, recording containment actions, tracking when briefings and non-disclosure agreements (NDAs) are completed, and documenting clearance decisions.

