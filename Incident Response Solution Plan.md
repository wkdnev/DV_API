### IR-1 — Policy and Procedures (Control)

This requirement is about making sure the organisation has a clear, written plan for what to do when something goes wrong, and that the right people know it. Without an up-to-date incident response policy and practical procedures, a serious event could be handled inconsistently, important decisions could be delayed, evidence could be mishandled, legal and regulatory duties could be missed, and recovery could take longer and cost more.

The organisation must create, document, and share an organisation-wide incident response policy. This policy must explain its purpose, what it covers, the roles and responsibilities, management commitment, how different parts of the business will work together, and how compliance will be met. It must also align with relevant laws, regulations, organisational policies, standards, and guidance.

An Incident Response Policy Owner within the Chief Information Security Officer (CISO) office must manage the development, documentation, and distribution of both the policy and the procedures.

The policy and procedures must be reviewed and updated at least every year and after major security incidents, audit findings, breach notifications, significant legal or regulatory changes, Cybersecurity Maturity Model Certification (CMMC) assessment results, or major changes to systems or architecture. They must be shared with the relevant leadership team, incident responders, security, privacy, legal and compliance, IT/operational technology (IT/OT) operations managers, and system owners.

##### IR policy & procedures governed by IRPO with event-driven reviews

- Category: Manual
- Priority: Critical

###### WHAT
Create and maintain an organisation-wide incident response (IR) policy and the step-by-step IR procedures that support it, and share them with the relevant people and roles.

###### WHY (control requirement)
IR-1 requires an incident response policy and procedures that cover the incident response requirements the organisation has put in place. The guidance also requires that the policy and procedures align with the organisation’s risk management approach and with all relevant laws, regulations, directives, policies, standards, and guidelines. It further requires that the security and privacy teams work together when developing them. The guidance also makes clear that simply repeating the requirements is not enough—the policy and procedures must be meaningful for the organisation and explain how incident response will actually be carried out.

###### HOW (specific approach)
1. **Set up governance and ownership**: appoint an **Incident Response Policy Owner (IRPO)** within the Chief Information Security Officer (CISO) office to manage the creation, documentation, and distribution of the policy and procedures.
2. **Create an organisation-wide IR policy** (the single source of truth) that includes: purpose, scope/coverage, leadership commitment, coordination between teams, defined roles and responsibilities, and alignment to applicable legal and regulatory obligations and organisational standards.
3. **Create supporting IR procedures** as practical guidance for how to carry out incident response (not just a repeat of the requirements). The procedures should describe how the organisation will run incident response activities, such as incident intake and triage, escalation, investigation, coordination for containment, eradication, and recovery, handling evidence, communications, and post-incident review and lessons learned. Include input from the security and privacy teams (for example, privacy impact considerations and legal or compliance notification triggers).
4. **Define who receives what**: share the **policy** with: CISO, security operations centre (SOC) leadership, incident responders, security engineering, the privacy officer, legal and compliance, IT operations, and system owners. Share the **procedures** with: SOC analysts, on-call incident responders, operational technology (OT) security engineers, IT operations, network and security administrators, system owners, the privacy officer, and legal and compliance.
5. **Set review and update triggers**: review and update the **policy and procedures at least annually and after triggering events**, including major security incidents, audit findings, breach notifications, material changes to laws or regulations, outcomes from Capability Maturity Model Certification (CMMC) assessments, and significant system or architecture changes.
6. **Use controlled document management**: publish the policy and procedures in an approved repository with version control, a change history, and a confirmation mechanism (for example, acknowledgement by the required roles) so the latest versions are easy to find and can be audited.

###### WHO
- **IRPO (CISO office)**: owns the full lifecycle of the IR policy and procedures (drafting, approval, publishing, distribution, and review triggers).
- **SOC leadership and incident responders**: confirm the procedures are usable in day-to-day operations.
- **Security engineering and IT/OT operations managers**: ensure the procedures reflect real operational workflows and escalation routes.
- **Privacy officer and legal/compliance**: provide privacy and legal requirements, including notification and record-keeping considerations.

###### Acceptance criteria
- An organisation-wide IR policy exists, is approved through the IRPO/CISO governance process, and clearly defines purpose, scope, roles and responsibilities, coordination, leadership commitment, and alignment to compliance requirements.
- Incident response procedures exist as practical implementation guidance (runbooks/step-by-step instructions) and are mapped to how incident response is carried out in the organisation.
- The policy and procedures are shared with the defined people and roles, with evidence of access and acknowledgement.
- Review and update requirements are enforced: at least **annually** and after each defined triggering event; records show the last review date and the reason for any updates.
- The security and privacy teams have contributed to the policy and procedures (with documented review and approval evidence).

###### Actions Required for Compliance

- [ ] Appoint an Incident Response Policy Owner (IRPO) within the Chief Information Security Officer (CISO) office and publish their governance responsibilities.
- [ ] Draft and get approval for an organisation-wide incident response policy that sets out its purpose, what it covers, who is responsible for what, how people coordinate during incidents, management’s commitment, and how it aligns with relevant compliance requirements.
- [ ] Create incident response procedures as step-by-step implementation guides (runbooks), using input from the security and privacy programme.
- [ ] Share the policy with the people or teams listed for policy communication, and share the procedures with the people or teams listed for procedure communication, using a controlled document repository.
- [ ] Set up a documented process to review and update policies and procedures every year and after each defined event: a major incident, an audit finding, a breach notification, a material legal or regulatory change, a CMMC outcome, or a significant change to the system architecture.
- [ ] Collect and keep evidence that information was shared or accessed, and that security, privacy, and legal reviews were completed and approved, so the organisation is ready for audit.


---

### IR-2 — Incident Response Training (Control)

This requirement is about ensuring the right people are trained to respond quickly and correctly when something goes wrong. Without regular, job-specific training, staff may not notice suspicious activity, may report problems late, or may take the wrong actions during an incident. This can cause more disruption, loss of sensitive information, and longer recovery times.

The organisation must provide incident-response training to all relevant system users based on their responsibilities within 30 days of taking on an incident-response role or receiving the related system access. Training must also be refreshed whenever system changes mean it is no longer up to date. Everyone with these responsibilities must complete a refresher at least once every year.

The organisation must also review the training materials at least every quarter and update them after incident-response plan testing results, lessons learned from real incidents, audit or assessment findings, and changes to relevant laws, directives, regulations, policies, standards, or guidance.

##### Automate role-based IR training enrolment and quarterly content updates

- Category: Software
- Priority: Critical

###### WHAT
Set up an incident response (IR) training programme that can be checked and audited, and that is based on job roles. It must: (1) deliver initial training within **30 days** of someone taking on an IR role or getting relevant system access, (2) provide **annual refresher** training, and (3) ensure the IR training materials are **reviewed every quarter** and **updated** when specific events occur. These events include: results from IR plan testing, lessons learned from real incidents, audit or assessment findings, and changes to relevant laws, directives, regulations, policies, standards, or guidelines.

###### WHY (control requirement)
The U.S. National Institute of Standards and Technology (NIST) **IR-2 Incident Response Training** requires that incident response training is linked to assigned roles and responsibilities, with training depth appropriate to each role (for example, general users versus system administrators versus incident responders). The organisation’s requirements are:
- **time period**: training for system users within **30 days** of taking on an IR role or responsibility
- **frequency (delivery)**: **annually** for refresher training
- **frequency (content review/update)**: **quarterly** reviews
- **events** that trigger content review/update: IR plan testing results, lessons learned from actual incidents, audit or assessment findings, and changes to applicable laws, directives, regulations, policies, standards, or guidelines.

###### HOW (specific steps/approach)
###### 1) Define which roles get which training, and when it is due
- Create a controlled set of training materials (a curriculum catalogue) made up of modules for different roles (for example, “recognise/report suspicious activity” for general users; “forensics/data collection/reporting/recovery/restoration” for responders).
- Define how “authoritative role/access information” (such as job role, membership of an identity group, or access permissions) maps to the correct training modules.
- Calculate due dates based on the date/time when (a) the person takes on the role, or (b) the person is granted the relevant access, ensuring the **30-day** requirement is met.

###### 2) Automate enrolment and keep proof of completion
- Link the identity provider (for example, Microsoft Entra ID or Okta) with the learning management system (LMS) (or training platform) so that when someone is assigned an IR role or gains relevant access, they are automatically enrolled in the correct module(s).
- Configure the LMS/workflow to record audit-ready evidence, including: enrolment date/time, module version, completion status, and completion date/time.

###### 3) Ensure annual refresher training happens
- Set up annual training schedules by role category, with “due by” dates and automatic reminders.
- Monitor who has not completed training and send exceptions to the responsible governance owner for follow-up and correction.

###### 4) Review training content every quarter and update it in a controlled way
- Set up a document-controlled process for training materials, including version identifiers.
- Run a quarterly review process that creates an approval record and publishes the “latest approved” module version to the LMS.
- When triggers occur (IR plan testing results, lessons learned, audit or assessment findings, or legal/policy/standard changes), create a change request to update the relevant training items and decide whether affected roles must be re-enrolled based on the impact assessment.

###### 5) Produce audit-ready reporting
- Generate regular compliance reports showing: who was trained, when (initial training within 30 days; annual refresh), which module version they completed, and the approvals for each quarterly review/update.

###### WHO (role responsible)
- **Cybersecurity/Incident Response Programme Owner**: owns the training curriculum, manages incoming trigger information, and confirms quarterly approval outcomes.
- **Identity and Access Management (IAM) / Identity Engineering Lead**: ensures the authoritative role/access information drives enrolment.
- **LMS/Training Platform Administrator**: sets up automated enrolment, scheduling, and evidence capture.
- **Internal Audit/Compliance (or Governance, Risk and Compliance (GRC))**: checks that audit-ready evidence is complete and that exceptions are handled correctly.

###### Acceptance criteria
- For every person assigned an IR role or granted relevant IR-related access, the system records completion of the correct role-based IR training **within 30 days**.
- All relevant people complete **annual refresher** training at least once every year.
- IR training materials are **reviewed at least quarterly**, with recorded approvals and module version tracking.
- Training materials are updated after each defined trigger event, and affected roles are re-enrolled when the change impact assessment indicates it is required.
- Audit reports can show: enrolment and completion date/times, module versions, quarterly review approvals, and a clear link from each trigger event to the resulting update.

###### Actions Required for Compliance

- [ ] Define which training modules map to each role, and set the depth of each module based on responsibility (user versus administrator versus incident responder).
- [ ] Link trusted identity and access management (IAM) and human resources (HR) role or access information with the learning management system (LMS) to automatically enrol users and set due dates for 30 days ahead.
- [ ] Set up the learning management system (LMS) to record evidence that can be audited, including the module version, the time a learner enrolled, and the time the learner completed the module.
- [ ] Arrange annual refresher training for each role category, with automated reminders and a process to route follow-up when someone does not complete the training.
- [ ] Set up a quarterly process to review content, with approvals tracked by version, and publish only the most recently approved module.
- [ ] Set up a process to collect information from incident response (IR) plan testing results, lessons learned, audit and assessment findings, and legal or policy changes. Use this information to update the training curriculum and decide what parts of the programme need re-enrolment.
- [ ] Produce regular compliance reports that show, for each user, the training linked to their required role, the due date, the module version, and the quarterly approval.


---

#### IR-2.1 — Simulated Events (Enhancement)

This requirement is about making sure people practise dealing with real-life emergencies, not just reading about them. Without realistic practice, staff may hesitate, miss important steps, or contact the wrong people when something goes wrong. This can delay action, increase damage, and raise the risk of harm to customers’ personal information.  

The organisation is expected to include realistic simulated incident scenarios in its incident response training. It should use its incident response policy and incident response plan as the basis for what participants must do, including each role’s specific responsibilities and key decisions.  

Training should follow the organisation’s training procedures, course content, and materials. It should clearly show participants how to carry out their own duties during the simulations, including any privacy-related responsibilities where relevant.  

The organisation must also keep records showing the simulated events were included, delivered, completed, and reviewed. Any follow-up actions should be used to improve future training.

##### Role-based simulated incident injects mapped to IR plan actions

- Category: Manual
- Priority: High

###### WHAT
Add realistic, role-based simulated incident events (“injects”) to incident response training. Participants must carry out the specific actions and make the specific decisions set out in the organisation’s incident response policy and incident response plan.

###### WHY (control requirement)
IR-2(1) (Enhancement) requires simulated events to be included in incident response training, so staff can practise the required response during crisis situations. The guidance also highlights that simulations help staff understand their individual responsibilities and the exact actions they must take.

###### HOW (specific steps/approach)
1. **Create a scenario library** of simulated incidents that match the application’s threat landscape (for example: compromised credentials leading to unauthorised access, ransomware affecting availability, suspicious data exfiltration, malicious application programming interface (API) activity). Each scenario must include: objectives, realism level, expected participant actions, and the exact incident response plan steps/decision points it is designed to test.
2. **Link each inject to plan/policy actions** using a scenario-to-plan mapping matrix. For each inject, state which incident response plan step(s) and policy decision point(s) should be triggered (for example: when to declare an incident, escalation thresholds, evidence preservation requirements, notification/communications triggers, and role-specific responsibilities).
3. **Define role cards and required actions** for each participant role (for example: security operations centre (SOC)/monitoring analyst, application owner, information technology (IT) operations, incident commander, communications lead, and privacy lead where applicable). Role cards must require participants to take specific actions (for example: start the incident workflow, request and collect specific evidence items, carry out containment steps within agreed limits, draft updates for stakeholders), not just discuss what they would do.
4. **Run time-limited exercises with controlled inject delivery** (tabletop or a blended tabletop using pre-prepared monitoring/log evidence). Injects should be delivered at set times and include evidence consistent with the organisation’s monitoring and logging tools (for example: security information and event management (SIEM) alert summaries, sample logs, email headers, and endpoint indicators). This ensures participants practise using the same information sources they would use in a real incident.
5. **Record auditable training evidence and results**: capture attendance, scenario/inject identifiers, actions taken by participants, decisions made, facilitator checklist results, and the after-action review (AAR) findings. Link each outcome to the specific incident response plan/policy sections that were exercised.
6. **Use AAR findings to improve future training**: keep a corrective action log from AARs and update scenario scripts, role cards, and training materials for the next training cycle.

###### WHO (role responsible)
- **Incident Response Training Lead** (owns the scenario library, mapping matrix, and exercise schedule)
- **Incident Response Manager/Incident Commander** (checks that injects and required actions match the incident response plan/policy)
- **Facilitators (Security Operations and Application/IT Operations representatives)** (deliver injects, run checklists, and capture evidence)
- **Privacy Lead (where applicable)** (ensures privacy-related responsibilities are covered in relevant scenarios)

###### Acceptance criteria
- Each simulated incident scenario has a documented mapping to incident response plan steps and policy decision points, and this mapping is reviewed and approved by the incident response function.
- Exercises include role cards that require participants to carry out concrete, plan-aligned actions (not only discussion), and facilitator checklists confirm completion.
- Training records exist for each exercise cycle showing scenario/inject IDs, participant attendance, actions/decisions taken, and AAR outcomes linked to the plan/policy sections exercised.
- At least one improvement from an AAR is implemented into updated scenario scripts, role cards, and training materials before the next exercise cycle.

###### Actions Required for Compliance

- [ ] Create a library of simulated incident scenarios that are relevant to the application, and set clear learning objectives for each scenario.
- [ ] Create a mapping matrix that links each “inject” to the specific steps and decision points in the incident response plan and policy.
- [ ] Create role cards and facilitator checklists that require participants to carry out specific actions that match the plan.
- [ ] Prepare test “inject” files using the organisation’s real monitoring and logging sources (for example, security information and event management (SIEM) alert summaries and sample logs) so they closely match real-world activity.
- [ ] Run time-limited practice exercises with controlled scenario prompts, and record who attended, what happened in each scenario, and what decisions were made.
- [ ] Carry out an after-action review and update the scenario scripts, role cards, and training materials to reflect the corrective actions.


---

#### IR-2.2 — Automated Training Environments (Enhancement)

This requirement is about giving incident response teams a realistic practice environment so they can rehearse how to react to real problems, rather than only discussing them. Without this, staff may not know what to do when something goes wrong, may miss important steps, may handle key information incorrectly, or may communicate too late. This can turn a problem that could be managed into a larger service outage, loss, or a privacy breach.

The organisation must provide an automated training setup that runs tabletop-style exercises. These exercises should use timed, pre-set prompts that add new information as the session continues. During each prompt, trainees must follow the organisation’s step-by-step incident response procedures. The system must record what trainees did and when, store the evidence for later review, and automatically produce a score after the exercise, highlighting strengths and areas for improvement.

The exercises and scoring must match the organisation’s incident response policy, training approach, course content, training materials, and any relevant plans and records. They must also include staff who have responsibilities for incident response, information security, and privacy.

##### Automated IR training platform with injects, playbooks, evidence scoring

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated incident response training environment that runs **tabletop exercises and inject-based simulations**, guides trainees through the organisation’s incident response playbooks, **captures evidence that can be retrieved later**, and **automatically produces after-action scores/results**.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 **IR-2(2)** enhancement requires: **“Provide an incident response training environment using {{ insert: param, ir-02.02_odp }}.”** The organisation-defined parameter **ir-02.02_odp** specifies **automated tabletop and inject-based simulations with playbook-led actions, evidence capture, and after-action scoring**.

###### HOW (specific steps/approach)
1. **Define scenario-to-playbook mapping**: For each step in an incident response playbook, create a matching training “required action” with clear, measurable checks (for example: the right decision, the required escalation, a time window for action, and complete communications).
2. **Author inject-based scenarios**: Build a library of scenarios where each exercise follows a scripted sequence of injects (for example: first alert, containment trigger, request for evidence, escalation decision). Each inject adds new information and requires trainees to carry out the mapped playbook actions.
3. **Implement guided trainee interaction**: Configure the platform so trainees respond to each inject using playbook-aligned methods (for example: completing a checklist, updating a case/ticket, submitting a decision through a form, or using guided communication templates). Ensure responses are tied to the current stage of the inject.
4. **Automate evidence capture and retention**: Record, at minimum, the time and date, the inject stage, the trainee’s identity and role, the actions/decisions submitted, and any uploaded supporting material. Store evidence in an auditable, tamper-evident way so it can be reviewed later.
5. **Automate after-action scoring**: Score each inject stage using a defined marking guide (for example: correct actions, missed steps, late escalations, incomplete evidence). Produce an after-action report/scorecard that points to the captured evidence and highlights strengths and areas for improvement.
6. **Align training content to governance documents**: Make sure scenario scripts and scoring guides are based on the organisation’s incident response policy, training procedures/curriculum/materials, and relevant incident response/security/privacy plans and records.
7. **Include relevant roles**: Configure participation so incident response roles and information security/privacy responsibilities are represented (for example: role-based views and required actions that reflect those responsibilities).

###### WHO (role responsible)
- **Incident Response Lead / Incident Response (IR) Programme Owner**: owns playbook mapping, scenario design, and approval of the scoring guides.
- **Security Training Lead**: ensures alignment to the training curriculum and exercise governance.
- **Platform Owner / Engineering Lead**: builds the training environment configuration/integration and the evidence/scoring automation.
- **Data Protection Officer (where applicable)**: checks that privacy-related injects, required actions, and scoring criteria are appropriate.

###### Acceptance criteria
- The platform runs **tabletop + inject-based** exercises with a scripted inject timeline.
- Each inject stage requires **playbook-driven actions** mapped to the organisation’s incident response playbook steps.
- For every required action, the platform produces **retrievable evidence** (time-stamped, linked to the trainee’s role, and linked to the inject stage).
- The platform automatically generates an **after-action scorecard/report** based on the captured evidence and the agreed marking guides.
- Scenario content and scoring are clearly aligned to the organisation’s incident response policy/procedures/curriculum/materials and relevant security/privacy plans and records.
- Exercises cover both incident response and information security/privacy responsibilities through role-based participation and required actions.

###### Actions Required for Compliance

- [ ] Create a scenario authoring template that links each step in every incident response playbook to the required actions during the injection stage and to the scoring rules (scoring rubrics).
- [ ] Create an initial set of “inject” scenario tests (the minimum viable set) that matches the organisation’s incident response (IR) policy, training programme, and relevant security and privacy plans.
- [ ] Set up the training platform to send time-based prompts and require trainees to respond using the correct playbook steps for the current stage of the scenario.
- [ ] Set up automated evidence capture for every required action (date and time, training stage, trainee identity and role, and what was submitted) and store it in a secure, audit-ready repository that can show if anything has been changed.
- [ ] Set up automated after-action scoring that generates a scorecard or report. The report should reference the evidence that was captured and show the results against the agreed scoring criteria (rubric).
- [ ] Run a pilot exercise with incident response (IR), security, and privacy stakeholders, and get approval that the scoring and required actions match the agreed playbooks and procedures.
- [ ] Document the exercise runbook (how to start scenarios, manage participants, and collect evidence and scorecards) and add it to the organisation’s training governance processes.


---

#### IR-2.3 — Breach (Enhancement)

This requirement is about making sure people can recognise when sensitive information may have been exposed or accessed in the wrong way, and understand exactly what to do next. Without clear training, staff may miss early warning signs, report problems late, or treat a suspected incident as harmless—allowing harm to spread and personal details to be misused.

The organisation must provide practical, plain-language training that explains what counts as a data breach. This includes situations involving personal information, whether the problem is confirmed or only suspected, and whether it happens through emails and files, printed documents, or even spoken conversations.

The training must also set out the organisation’s step-by-step process for reporting both confirmed and suspected breaches, including who to contact and what information to include. This should be reinforced through discussion-based practice sessions that simulate real breach scenarios, so staff can follow the reporting process under pressure.

##### Breach recognition & reporting training with PII scenarios

- Category: Manual
- Priority: Critical

###### WHAT must be done
Provide incident response training that helps staff **spot and respond to a breach**, including the organisation’s **process for reporting a breach**. Training must stress that staff should report **both confirmed and suspected breaches**, and must include breaches involving **personally identifiable information (PII)**. Training should also include **tabletop exercises** that simulate a breach.

###### WHY (control requirement)
NIST IR-2(3) (Enhancement) requires incident response training on how to **spot and respond to a breach**, including the organisation’s **breach reporting process**. It also specifically requires reporting **confirmed and suspected** breaches involving information in **any medium or form** (including **paper, spoken (oral), and electronic**). It further requires **tabletop exercises** that simulate a breach.

###### HOW (specific steps/approach)
1. **Create a breach training programme** matched to staff roles (for example: reception/front-of-house, human resources (HR), customer service, information technology (IT) support, security operations centre (SOC)/monitoring, system/application owners, privacy officers, contractors). Set clear completion targets and how often training must be refreshed.
2. **Build a scenario library** that clearly labels each scenario as **confirmed** or **suspected**, with examples across all media:
   - **Electronic**: a misdirected email containing sensitive/PII data; suspected compromise of login details that could lead to unauthorised access; unauthorised access to a shared drive.
   - **Paper**: records filed in the wrong place; lost or unattended paper or device storage media containing PII.
   - **Oral**: overheard disclosure of customer/employee details; spoken disclosure to someone who is not authorised; suspected social engineering during a call.
   Include scenarios focused on PII, and state clearly that **PII incidents are treated as breaches**.
3. For every scenario, use the same decision and response structure:
   - “Is this **confirmed or suspected**?”
   - “What makes it a breach (loss of control, compromise, unauthorised disclosure, or unauthorised acquisition)?”
   - “Immediate actions” (for example: stop further exposure, preserve relevant details, and do not investigate beyond the guidance provided).
   - “How to report” using the organisation’s breach reporting process: **who to report to**, **reporting channel**, **what details to include**, and the **expected timescale**.
4. **Deliver the training** using a learning platform (e-learning for basic awareness, plus sessions led by a facilitator for higher-risk roles). Make sure training is available to all relevant staff and contractors.
5. **Run tabletop exercises** at least annually (or more often based on risk or past incidents) using the scenario library. Each exercise must test:
   - recognising the difference between confirmed and suspected breaches,
   - applying the correct immediate actions,
   - using the correct breach reporting process (including how to handle PII),
   - escalation routes and decision points.
   Record the results as evidence that can be audited (for example: attendance, exercise outcomes, identified gaps, and remediation actions).
6. **Review the content together** with information security and privacy stakeholders to ensure PII breach responsibilities and reporting details match organisational policy.
7. **Check training effectiveness** using short scenario-based questions (for example: quizzes or practical decision prompts) to confirm that staff can correctly classify confirmed versus suspected breaches and choose the correct reporting steps.

###### WHO (role responsible)
- **Information Security / Incident Response Lead**: owns training requirements, the scenario library structure, and tabletop exercise design.
- **Privacy Officer / Data Protection Lead**: confirms how PII breaches are handled and the reporting details that apply.
- **HR / Learning and Development (L&D)**: runs training delivery, tracks completion, and manages the refresh schedule.
- **Business/Application Owners and SOC/IT Support Managers**: ensure the right people attend based on their role and support remediation of any gaps identified.

###### Acceptance criteria
- Training content explicitly covers: breach recognition, how to classify confirmed versus suspected breaches, response actions, and the organisation’s breach reporting process (who/how/what details/timescale).
- Training includes scenarios for **electronic, paper, and oral** media, and includes **PII breach** examples where relevant.
- Tabletop exercises are completed and produce auditable evidence of participation and outcomes (including identified gaps and remediation actions).
- Completion records are kept for all relevant roles, and scenario-based checks show that learners can correctly identify and report both suspected and confirmed breaches.

###### Actions Required for Compliance

- [ ] Create a role-based training plan (training matrix) for all staff who may come across or report suspected security breaches.
- [ ] Create a library of breach scenarios for electronic, paper, and spoken (oral) information, clearly marked as either confirmed or suspected.
- [ ] For every scenario, include the organisation’s breach reporting steps (who to report to, which channel to use, what information to include, and the required timeframe).
- [ ] Review training materials together with information security and privacy stakeholders to ensure that any personal data (PII) incident is handled as a data breach.
- [ ] Provide baseline training and run guided training sessions led by facilitators for higher-risk roles, and record when each participant completes the training.
- [ ] Run tabletop exercises using the scenario library, and record outcomes and follow-up fixes in a way that can be audited.
- [ ] Set up scenario-based checks to confirm that learners can correctly identify and report suspected and confirmed data breaches.


---

### IR-3 — Incident Response Testing (Control)

This requirement is about making sure your organisation can respond effectively when something goes wrong, by regularly testing how your incident response team would act. Without these checks, you might only find out too late that your plans are unclear, people do not know their roles, key steps take too long, or the response causes unnecessary disruption to services, important resources, or even affected individuals.

To meet this expectation, the organisation must test its incident response capability for the relevant system every quarter using three types of exercises:
- a tabletop exercise (a structured discussion)
- a parallel simulation (a simulated incident handled alongside normal work without fully stopping)
- a full interrupt simulation (a more disruptive test that interrupts normal operations to check end-to-end readiness)

Before each quarter’s testing, it must prepare a test plan and materials. After each test, it must record the results, including evidence that the approach worked and any impacts on organisational operations, assets, and individuals, and keep these records so they can be reviewed.

##### Quarterly IR testing with tabletop, parallel, and full interrupt

- Category: Manual
- Priority: Critical

###### WHAT must be done
Test how well the organisation can respond to incidents for the specified system **every quarter** using the agreed tests: **tabletop exercise**, **parallel simulation**, and **full interrupt simulation**.

###### WHY (control requirement)
NIST **IR-3** requires the organisation to **test how effective** its incident response capability is for the system at the agreed **frequency**, using the agreed **test types**. The testing must be strong enough to spot weaknesses or gaps, and should help determine the effects on day-to-day operations, assets, and people where relevant.

###### HOW (specific steps/approach)
Set up a repeatable quarterly incident response testing cycle for the target system:
1. **Create or update an incident response (IR) test plan** for the quarter that covers the system scope, objectives, roles and responsibilities, how scenarios are chosen, what evidence must be collected, and how effectiveness will be measured (including any required assessment of impacts on day-to-day operations, assets, and people where relevant).
2. **Prepare test materials** for each required test type:
   - **Tabletop exercise**: a structured scenario, prompts for decisions and checks, a walkthrough of communications, and a decision log template.
   - **Parallel simulation**: carry out incident response actions while normal operations continue; define what will be monitored and what operational impact measures will be recorded.
   - **Full interrupt simulation**: define the controlled interruption approach, pre-approved continuity or rollback steps, and safety or stop conditions to manage service and operational risk.
3. **Run all three tests** within the quarter, making sure each test produces records that can be audited (attendance/participation records, decision or timeline logs, actions taken, and measured outcomes).
4. **Record and keep the results** in a controlled repository, including:
   - Evidence of effectiveness (for example, how quickly key response steps were carried out, whether decisions were complete, and whether containment or eradication steps were successful where applicable to the scenario).
   - Documented impacts on day-to-day operations and assets; include impacts on people where relevant.
   - Identified weaknesses or gaps, and corrective actions with named owners and due dates.
5. **Review and improve**: hold a post-test review to confirm what the testing shows about effectiveness, update playbooks/checklists/runbooks, and ensure corrective actions are tracked to completion before the next quarterly cycle.

###### WHO (role responsible)
- **Incident Response Lead / security operations centre (SOC) Manager**: owns the quarterly IR test plan, execution, and results.
- **System Owner / Application Owner**: confirms the scenarios are relevant and that operational impact assumptions are realistic.
- **Information Security (and Privacy where applicable)**: ensures evidence requirements and impact assessments meet organisational expectations.
- **IT/OT Operations Lead** (where applicable): provides continuity or rollback constraints for parallel and full interrupt simulations.

###### Acceptance criteria
- For the specified system, **incident response effectiveness is tested at least quarterly**.
- Each quarterly cycle includes **all three** test types: **tabletop exercise**, **parallel simulation**, and **full interrupt simulation**.
- For each test, there is an **auditable set of test plan and materials** and an **auditable results record** that includes effectiveness evidence and documented impacts on operations and assets (and people where relevant).
- Corrective actions are recorded with owners and due dates, and are tracked to completion before the next cycle.

###### Actions Required for Compliance

- [ ] Set the quarterly incident response (IR) test timetable for the specified system, and confirm which test types are required: tabletop exercise, parallel simulation, and full interrupt simulation.
- [ ] Create an incident response (IR) test plan template for each quarter that covers the scope, objectives, who is responsible, what evidence is expected, and prompts to assess the impact.
- [ ] Develop and get approval for scenario packs and runbooks for each type of test, including decision records, checklists, and instructions for monitoring and collecting evidence.
- [ ] Complete the tabletop exercise, run the parallel simulation, and carry out the full interruption simulation within the quarter. Record auditable results, including attendance, timelines, decisions made, and actions taken.
- [ ] Record and store test results in a secure, controlled system, including evidence that the tests worked and any effects on the organisation’s day-to-day operations and assets (and on individuals where relevant).
- [ ] Carry out a review after the test to identify any shortcomings, agree corrective actions with named owners and due dates, and monitor progress until everything is completed before the next quarterly cycle.


---

#### IR-3.1 — Automated Testing (Enhancement)

This requirement is about making sure your incident response team can practise how they would react to real problems, using automated test runs rather than guesswork. Without this, you may only find out too late that people do not follow the correct steps, important actions are missed, or the process fails when repeated pressure is applied—leaving customers and the business exposed during a real incident.  

The organisation is expected to run automated tabletop and step-by-step response rehearsals using a system that can carry out the response plan. The system should be given clearly fake alerts, and the results should be checked using recorded evidence from the systems, not opinions or screenshots.  

The tests must use realistic scenarios and run in environments that reflect how you operate, including repeated or higher-volume situations to test the team’s capability under stress. A test plan must be in place. Results must be recorded, checked against the plan and procedures, reviewed by the named responsible roles, and kept as auditable records for future learning and improvement.

##### SOAR synthetic-alert harness with log-evidence incident response tests

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated way to test incident response by repeatedly running the organisation’s incident response process. This will be done by running **security orchestration, automation and response (SOAR)** playbooks using **synthetic alerts** and then checking the results using **log-based evidence**. Tests must run using realistic scenarios in realistic environments. Results must be recorded and reviewed against an incident response testing plan.

###### WHY (control requirement)
The **National Institute of Standards and Technology (NIST) incident response (IR-3(1))** enhancement requires: **“Test the incident response capability using {{ insert: param, ir-03.01_odp }}.”** The organisation-defined parameter **ir-03.01_odp** specifies **“automated tabletop and playbook execution using SOAR with synthetic alerts and log-based validation.”** The guidance also expects the automated approach to provide broader coverage, use realistic scenarios/environments, and put the capability under pressure.

###### HOW (specific steps/approach)
1. **Define a scenario catalogue** linked to incident response procedures (for example: phishing → triage and escalation; suspicious login → containment; malware alert → containment, eradication, and lessons learned). Each scenario must state what the playbook should do and what measurable results are expected.
2. **Create a synthetic alert harness** that generates controlled, clearly non-production alerts/events with realistic details (asset, user, severity, timestamps) and a **unique Run ID** for each test run. Put the Run ID into the synthetic alert so it carries through into tickets, notifications, and evidence records.
3. **Build SOAR playbooks as testable procedures**: make sure each step produces measurable outputs (for example: ticket reference created, notification message ID, evidence object ID, escalation case ID). If a step depends on conditions, define the expected path for each scenario.
4. **Add log-based validation rules** (similar to “assertions” written as code) that check authoritative logs (SOAR execution logs, **security information and event management (SIEM)** / security operations centre (SOC) logs, ticketing audit logs, endpoint detection and response (EDR) / SIEM action logs, and email delivery logs where applicable). Confirm the expected events occur within defined time windows (for example: “within T minutes, a ticket is created and an escalation is sent”).
5. **Run tests in realistic environments** using the same integrations, identity context, and logging/monitoring routes used in production (but targeting non-production systems). Add a configurable **stress/repeat mode** (for example: a burst of N synthetic alerts over M minutes) with safe throttling and clear stop conditions to prevent unintended load.
6. **Record and package results** for each Run ID into an auditable evidence pack containing: a SOAR run summary, a step-by-step execution trace, validation query results (including timestamps and record identifiers), and any exceptions.
7. **Review and approve outcomes**: send the evidence pack to the named incident response testing responsible roles (and security oversight roles as required by governance) to decide pass/fail. For failures, record the remediation actions taken, and obtain sign-off before closing the test cycle.

###### WHO (role responsible)
- **Incident Response Lead / SOC Manager**: owns the scenario catalogue, expected outcomes, and review of evidence packs.
- **SOAR Engineer / Automation Engineer**: builds the synthetic alert harness, Run ID propagation, playbooks, and validation logic.
- **Security Operations / SIEM Analyst**: confirms the log sources and validation queries use authoritative evidence.
- **Information Security Governance / Compliance** (as applicable): ensures results are retained and the review/approval workflow is followed.

###### Acceptance criteria
- Synthetic alerts are generated and tagged with a unique Run ID for every automated test run.
- For each defined scenario, the SOAR playbook runs end-to-end and produces measurable outputs.
- Log-based validation rules confirm expected outcomes using authoritative logs (with timestamped evidence) for each Run ID.
- Evidence packs are produced for every run and are reviewed with documented pass/fail decisions and remediation actions.
- Tests can be run in realistic environments and support a configurable stress/repeat mode without exceeding defined safety limits.

###### Actions Required for Compliance

- [ ] Create a catalogue of incident response scenarios, linked to the incident response procedures, with clearly defined measurable outcomes that are expected to be achieved.
- [ ] Set up a synthetic alert test system that creates alerts in a non-production environment and adds a unique “Run ID” to all downstream outputs and records.
- [ ] Update security orchestration, automation and response (SOAR) playbooks so that every step produces measurable results that can be checked and verified (for example, ticket IDs, message IDs, evidence IDs, and escalation IDs).
- [ ] Create validation checks that use official log records to confirm that the expected events occur within the agreed time periods.
- [ ] Set up realistic test runs using the same integration and logging routes as the live (production) environment, but run them against non-production systems.
- [ ] Add a configurable stress or repeat mode, with safe rate limiting and clear stop conditions.
- [ ] For each Run ID, create an evidence pack that can be audited, and send it to the named reviewers for recorded pass/fail decisions and approval of any required fixes (remediation).


---

#### IR-3.2 — Coordination with Related Plans (Enhancement)

This requirement is about making sure your plans for handling serious incidents are developed together with the teams responsible for other key emergency and recovery plans. This way, everyone understands their role and follows the same approach. Without this coordination, practice exercises can create a misleading impression of readiness, messages may be sent through the wrong routes, critical services may not be restored in line with your recovery plans, and the people responsible for safety, communications, and business continuity may end up working against each other during a real event.

To meet this expectation, the organisation must:
- identify who is responsible for each relevant plan that could be affected
- involve those people in incident response exercises and drills
- make sure the exercise steps, responsibilities, and the records kept afterwards match the incident response plan and the related plans for business continuity, disaster recovery, continuity of operations, contingency, crisis communications, critical infrastructure, and occupant emergency, including information and privacy responsibilities.

##### Coordinate incident response exercises with related plan owners

- Category: Manual
- Priority: High

###### WHAT
Coordinate incident response testing (exercises and drills) with the parts of the organisation responsible for the related plans (for example: business continuity, disaster recovery, continuity of operations, contingency, crisis communications, critical infrastructure, and occupant emergency plans). Make sure responsibilities, triggers, communications, and the write-up after the exercise match what each plan requires.

###### WHY (control requirement)
IR-3(2) requires that incident response testing is coordinated with the parts of the organisation responsible for related plans. This helps prevent conflicting actions during real incidents and ensures the results from exercises are sent to the correct plan owners.

###### HOW (specific approach)
1. **Create and maintain a Related-Plan Owner Matrix** that links each incident response exercise type or scenario to the named plan owners responsible for each related plan category (business continuity/disaster recovery/continuity of operations/contingency/crisis communications/critical infrastructure/occupant emergency as applicable).
2. **Set exercise participation requirements for each scenario** in the matrix, including: required roles, which parts of each plan must be tested, and which triggers or decision points must match each related plan.
3. **Use standardised exercise packs** (templates) that require clear references to the correct plan versions and owners. This includes: role cards, scenario prompts (“injects”), references to communication channels, and an evidence checklist.
4. **Add a pre-exercise coordination approval step** in the organisation’s workflow system (for example, information technology service management (ITSM) or ticketing). The exercise cannot be scheduled or approved unless the required plan owners (and Information Security and Privacy representatives where relevant to information and privacy responsibilities) have reviewed and confirmed their in-scope sections.
5. **Run after-action reporting with plan-owner sign-off**: require each related-plan owner to review the parts of the after-action report that affect their plan(s), and record improvement actions with named owners and due dates.
6. **Keep evidence that can be audited**: store attendance and participation records, approved exercise packs, sign-offs, communication references, and the after-action report showing improvement actions linked back to the relevant plan owners.

###### WHO
- **Incident Response Programme Manager / Incident Response (IR) Lead**: owns the matrix, templates, and the exercise governance approval process.
- **Business Continuity/Disaster Recovery/Continuity of Operations/Contingency/Crisis Communications/Critical Infrastructure/Emergency Plan Owners**: provide scenario participation, confirm that triggers and roles align, and sign off the relevant parts of the after-action report.
- **Information Security and Privacy representatives** (where applicable): confirm that testing communications, data handling, and privacy obligations are followed.

###### Acceptance criteria
- For each completed incident response exercise or drill, the exercise pack includes clear references to the relevant related plans (including version and owner) and names the participating plan owners.
- Pre-exercise approval evidence shows that all required related-plan owners reviewed and confirmed their in-scope sections.
- After-action reports include sections reviewed by plan owners, and improvement actions recorded with named owners and due dates.
- The evidence repository contains: the approved exercise pack, participation/attendance records, sign-offs, and the after-action report linked to the relevant plan owners.

###### Actions Required for Compliance

- [ ] Identify and record the organisation’s owners for each plan category that could be affected by incident response testing.
- [ ] Create a “Related Plan Owner Matrix” mapping exercise that links each scenario or type to the required plan owners and the plan sections that are in scope.
- [ ] Update the incident response exercise pack templates so they must include: references to the plan version, named participants responsible for the plan, and an evidence checklist.
- [ ] Set up a pre-exercise approval step in the workflow system. This step must be signed off by all required owners of the related plans (and by Security and Privacy teams where applicable).
- [ ] Run the exercises using the approved materials and record who took part, how each role was carried out, and which communication channels were used as proof.
- [ ] Require each related plan owner to approve (sign off) the parts of the after-action report that affect their plan(s), and record the improvement actions, including the responsible owner and the due date.
- [ ] Store and keep verifiable records that link each exercise or drill to the relevant plans, approvals, and improvement actions.


---

#### IR-3.3 — Continuous Improvement (Enhancement)

This requirement is about learning from real practice so your incident response works in the moment, not just in documents. If organisations do not regularly test their incident response and then use the results to improve, they may respond too slowly, make the wrong decisions under pressure, and repeat the same mistakes—turning manageable incidents into expensive disruption, reputational damage, and harm to customers or staff.

To meet this expectation, the organisation must run incident-response tests and use both:
- descriptive feedback (for example, observations and interview notes), and
- measured results (for example, timings and scores)

to judge how effective the response process is and to identify specific improvements.

The organisation must also produce performance measures and metrics that are accurate, interpreted in the same way each time, and set out so that another competent person could repeat the same evaluation using the same evidence.

The organisation should:
- record the test results,
- clearly explain how each metric was calculated,
- keep the records for later checking,
- assign named people to carry out the testing and evaluation, and
- involve staff with information security and privacy responsibilities in the assessment and improvement decisions.

##### Incident response test scorebook with qualitative/quantitative metrics

- Category: Manual
- Priority: High

###### WHAT must be done
Implement a recurring incident-response testing programme that uses **both qualitative and quantitative data** from the tests to assess how effective incident response is and to drive improvements. Produce **incident-response metrics** that are **accurate, interpreted in the same way every time, and can be repeated by another competent person**, and keep auditable records showing **how each metric was calculated**.

###### WHY (control requirement)
IR-3(3) (Enhancement) requires using **qualitative and quantitative data from testing** to support **continuous improvement** in incident-response performance. The guidance also explains that clear metrics and evaluation criteria help the incident-response function work as intended and reduce the impact of incidents.

###### HOW (specific steps/approach)
1. **Create an incident-response (IR) testing evidence framework** (in the incident-response testing playbook) that defines:
   - **Qualitative evidence sources** (for example: observer notes, descriptions of decision-making steps, communication clarity ratings, reasons for checklist pass/fail outcomes, interview notes).
   - **Quantitative evidence sources** (for example: time to detect, time to triage, time to contain, number of systems isolated, false positive/false negative rates for detection validation, whether ticket and security automation workflow service levels were met, and the proportion of playbook steps completed).
2. **Define a standardised “scorebook”** for each test scenario that includes, for every metric:
   - Metric definition and purpose.
   - Required data inputs and which evidence sources are allowed.
   - Calculation method (including assumptions and rounding rules).
   - Interpretation guidance (how to classify results consistently).
   - Reproducibility notes (which timestamps/events to use, and how to handle missing or unclear data).
3. **Run a blended testing schedule** aligned to incident-response plan coverage:
   - Tabletop exercises to gather qualitative evidence about decision-making, coordination, and communications.
   - Controlled technical drills (for example: detection and containment simulations in a safe subset or sandbox) to gather quantitative timing and outcome evidence.
4. **Hold a structured evaluation workshop after each test**:
   - Check that evidence is complete and that scoring is consistent with the scorebook.
   - Calculate quantitative metrics using the documented methods.
   - Compare qualitative findings with quantitative results to identify specific, practical improvements (for example: changes to the playbook steps, adjustments to escalation routes, improvements to logging and alert settings, corrections to security automation workflow steps).
5. **Publish the metrics and keep audit-ready records**:
   - Store the test report, including references to the raw evidence, the scorebook version used, how each metric was derived, and the final metric results.
   - Make sure another competent person can reproduce the metrics using the same evidence and the documented calculation steps.
6. **Assign named responsibilities** for testing and evaluation:
   - Name the test lead, evidence recorder(s), metric calculator(s), and reviewer(s) (including information security and privacy representatives where relevant to incident handling and data processing).

###### WHO (role responsible)
- **Incident Response Manager / Security Operations Centre (SOC) Lead**: owns the testing programme, scorebook governance, and evaluation workshops.
- **Security Operations / Detection Engineering**: provides quantitative evidence measurement and support for metric calculations.
- **Privacy Officer / Data Protection Lead (as applicable)**: reviews privacy-relevant incident handling evidence and how metrics are interpreted.
- **Application Owner / Engineering Lead**: implements improvements arising from test findings.

###### Acceptance criteria
- For each executed incident-response test, the organisation produces a report containing:
  - At least one **qualitative** and one **quantitative** metric derived from testing.
  - A documented **metric derivation** (inputs, calculation methods, assumptions, and interpretation rules) consistent with the scorebook.
  - Evidence references sufficient for **reproduction** of the metrics by another competent person.
  - Named individuals responsible for evidence capture, scoring, and review.
- Metrics are calculated using the same scorebook version and interpretation guidance across all tests.
- Improvement actions are tracked to completion (for example: updates to the playbook/runbook, detection tuning, changes to escalation) with links to the metrics and evidence that justified them.

###### Actions Required for Compliance

- [ ] Define the types of evidence (qualitative and quantitative) to use when testing incident response in an incident response testing playbook.
- [ ] Create and version a metric scorecard that includes metric definitions, calculation formulas, assumptions, and rules for how to interpret the results.
- [ ] Set up a regular combined tabletop exercise and technical practice schedule, aligned to the incident response plan scenarios.
- [ ] Run each test and record proof that it meets the scorebook requirements, including the time it was run and the reasons for each decision.
- [ ] Run a post-test review workshop to calculate the results, compare them with the qualitative feedback, and choose specific improvements.
- [ ] Produce an audit-ready test report that shows the measured results (metrics) and the documented steps used to calculate them, and keep the report for later rechecking.


---

### IR-4 — Incident Handling (Control)

This requirement is about making sure the organisation deals with serious problems in a planned, repeatable way, rather than improvising under pressure. If incidents are handled inconsistently, the organisation may miss important evidence, allow damage to spread, restore systems incorrectly, and fail to learn from what happened. This leaves the organisation exposed to repeated harm, disruption to services, and potential breaches involving personal information.

To meet this expectation, the organisation must have clear, documented incident-handling procedures. These procedures must match its incident response plan and cover the full process: preparing in advance, recognising and understanding what is happening, stopping the impact, removing the cause, and safely bringing services back. The organisation must also coordinate these actions with plans for keeping essential operations running during disruption.

After each incident, the organisation must review what worked and what did not, update its procedures, refresh training, and practise through tests or exercises. It must then apply these improvements consistently across the organisation, so that the level of thoroughness, effort, coverage, and results are predictable every time.

##### Playbook-based incident handling with cross-team coordination

- Category: Manual
- Priority: Critical

###### WHAT
Implement a playbook-based incident handling capability that carries out the organisation’s incident response plan phases (preparation, detection and analysis, containment, eradication, recovery). It must use standard ways to record evidence, clearly coordinate across teams, and follow a structured “lessons learned” process to improve over time.

###### WHY (control requirement)
IR-4 requires an incident handling capability that is built into the organisation’s day-to-day mission and business activities, and that brings in the right parts of the organisation. It must handle incident-related information from multiple sources (for example: audit monitoring, physical access monitoring, network monitoring, user and administrator reports, and supply chain events). It must ensure suspected security incidents (including suspicious emails) and suspected supply chain incidents are handled effectively. The capability must also link incident handling to contingency planning and keep improving based on lessons learned.

###### HOW (specific steps/approach)
1. **Create incident playbooks mapped to the incident response plan (IRP) phases** for at least: suspicious email, suspected unauthorised access, malware or ransomware-like activity, and suspected supply chain compromise (counterfeit hardware or malicious code). Each playbook must include: triage criteria, detection and analysis steps, containment decision points, eradication actions, recovery and “back to service” checks, and closure criteria.
2. **Set up a cross-functional coordination model (responsibility assignment and escalation paths)** covering mission and business owners, system owners, the authorising official (AO), human resources (HR), physical security, personnel security, legal, the risk executive/function, operations, and procurement. This must ensure the playbooks clearly trigger the right people based on incident type and impact.
3. **Bring together multiple incident intake sources** into a case management workflow (for example: security information and event management (SIEM) and security orchestration, automation and response (SOAR) alerts, endpoint and network telemetry, identity events, physical access monitoring anomalies, and user or administrator reports). Make sure each source is recorded as a single, consistent incident record.
4. **Record evidence throughout the whole process**: every step in each playbook must capture timestamps, affected assets, actions taken, collected evidence, queries used, approvals obtained, and verification results (including chain-of-custody where applicable). Evidence retention must follow the organisation’s logging and records requirements.
5. **Link to contingency planning** by adding clear “continuity switch” actions in each playbook (for example: switch to alternate services, run manual operations, or start the disaster recovery (DR) runbook). Document what triggers the decision and who is responsible.
6. **Create a lessons-learned workflow** that updates playbooks and procedures, training content, and tabletop or exercise scenarios in versioned releases. Require proof that updates are completed, and link each change back to the outcomes from incident reviews.

###### WHO
- **Incident Response Lead / security operations centre (SOC) Manager**: owns the playbooks, evidence standards, and the case workflow.
- **System Owners / Application Owners**: approve containment and recovery actions for their systems.
- **Legal, HR, Physical Security, Personnel Security, and Procurement**: provide guidance triggered by incident types (for example: suspected breaches and supply chain events).
- **Authorising Official (AO) / Risk Executive**: approves decisions about risk and impact, and approves escalation outcomes.
- **Operations / Disaster Recovery (DR) Lead**: checks and validates continuity and DR switch actions.

###### Acceptance criteria
- Playbooks exist for the required incident types and are clearly mapped to the incident response plan (IRP) phases, with defined closure criteria.
- A documented responsibility assignment and escalation path exists, and playbooks reference it for each incident type.
- Incident intake from at least security information and event management (SIEM) and security orchestration, automation and response (SOAR), endpoint and network telemetry, and user or administrator reports is routed into one case management workflow with consistent evidence recording.
- Evidence recording is demonstrated in recent incident records (or tabletop exercise outputs), showing timestamps, evidence collected, approvals, and verification results.
- Playbooks include documented continuity and disaster recovery (DR) switch actions, with named roles and decision triggers.
- Post-incident reviews produce versioned updates to playbooks and procedures and to training and exercise plans, with proof of completion and traceability back to the review findings.

###### Actions Required for Compliance

- [ ] Create incident playbooks aligned to the incident response plan phases for: suspicious emails, unauthorised access, malware or ransomware-like activity, and suspected supply chain compromise.
- [ ] Create a cross-functional RACI (responsible, accountable, consulted, informed) and an escalation matrix that covers the mission or business owners, system owners, the accountable officer (AO), Legal, Human Resources (HR), physical security, personnel security, the risk executive, Operations, and Procurement.
- [ ] Set up one incident case workflow that brings together and standardises reports from the security information and event management (SIEM) system, the security orchestration, automation and response (SOAR) platform, endpoint and network monitoring, physical access monitoring, and reports from users and administrators.
- [ ] Set required evidence-collection fields and approval or verification checks for every step in each playbook, including the date and time, supporting records, which assets were affected, and the results.
- [ ] Add clear actions for switching to business continuity and disaster recovery (DR) in each playbook, including the decision triggers for when to switch. Reference the relevant business continuity and DR runbooks and the named roles responsible.
- [ ] Set up a “lessons learned” review process that creates updated, version-controlled playbooks and procedures, along with any required training and exercise changes, and that clearly links each update to the review findings.


---

#### IR-4.1 — Automated Incident Handling Processes (Enhancement)

This requirement is about making sure that when something goes wrong, your team can respond in a consistent, well-documented way, using the right automated tools. Without this, incidents may be handled differently each time, important evidence could be missed or recorded incompletely, and it would be difficult to show what happened, who did what, and what tools were used during the investigation. This leaves the organisation exposed to repeat problems and poor decision-making.

To meet this expectation, the organisation must support its incident-handling process with:
- an online incident management system
- tools that capture live evidence from running systems
- tools that record complete network traffic for later review
- forensic analysis tools to examine evidence in a structured way

The organisation must also:
- document in its incident response policy and incident handling procedures how these tools are used
- describe this support in system design and configuration documentation
- keep audit records showing the tools were used
- ensure the incident response plan and system security plan clearly include these automated mechanisms, with named responsibilities for incident handling and information security that cover their use.

##### Automated incident case workflows with live response, full PCAP and forensics

- Category: Software
- Priority: Critical

###### WHAT
Implement an automation-supported incident handling capability that uses an **online incident management system** to run consistent, step-by-step (workflow-driven) incident handling. The system must automatically trigger **live response data collection**, **full network packet capture**, and **forensic analysis tools**. Ensure the automated actions are described in the incident handling procedures and in the system design and configuration documentation. Confirm that every automated evidence action creates records that can be audited, and that each record is linked to the relevant incident case.

###### WHY (control requirement)
NIST SP 800-53 **IR-4(1)** enhancement requires: **“Support the incident handling process using {{ insert: param, ir-04.01_odp }}.”** The organisation-defined parameter **ir-04.01_odp** specifies automated mechanisms including an **online incident management system**, **live response data collection**, **full network packet capture**, and **forensic analysis tools**. The guidance also expects automated mechanisms such as an online incident management system and tools for live response data, full packet capture, and forensic analysis.

###### HOW (specific steps/approach)
1. **Deploy and enable an online incident management system** (case management) integrated with an orchestration or automation engine (for example, **security orchestration, automation and response (SOAR)**). Ensure each incident case uses structured fields (incident type, affected assets, evidence checklist, approvals, and timestamps).
2. **Create incident playbooks (runbooks)** for the defined incident types. Each playbook must clearly specify:
   - which **live response data** to collect (volatile evidence and relevant endpoint, process, and network information that your environment allows),
   - when to start and stop **full network packet capture** (time-limited windows and defined capture points, such as authorised sensors/span/tap collectors or approved host-based capture locations),
   - how to package and transfer evidence to **forensic analysis tools**.
3. **Integrate live response tools** so playbooks can trigger evidence collection using the minimum necessary permissions (least privilege) and strong authentication. Ensure the collected outputs are automatically attached to the correct case record.
4. **Integrate full packet capture** so playbooks can automatically start capture at the designated capture points and keep the capture files for the required investigation period. Include integrity controls (for example, hashing) and chain-of-custody information.
5. **Integrate forensic analysis tools** so evidence ingestion is automated (for example, indexing, hashing, and metadata capture). Ensure results are written back to the case (including analyst notes, findings, and references to the evidence).
6. **Implement auditability and linkage**: every automated action (case creation, evidence collection start/stop, capture completion, evidence transfer, forensic ingestion) must generate audit records in central logging and **security information and event management (SIEM)**. These records must be linked to the incident case ID.
7. **Document support in governance documents**: update the incident response plan and the system security plan to reference the automated mechanisms. Also update the incident handling procedures and the system design and configuration documentation to explain how the tools are used (including responsibilities and operational limits).

###### WHO (role responsible)
- **Cybersecurity Incident Response Lead**: owns playbook/runbook definitions and procedure updates.
- **Security Automation/SOAR Engineer**: implements integrations and workflow logic.
- **Security Operations Centre (SOC) / Incident Response (IR) Analysts**: check evidence completeness and confirm the approach is practical to operate.
- **System Owner / Infrastructure Lead**: ensures capture points and tool deployment are operationally safe and approved.
- **Information Security Governance / Compliance**: checks that audit evidence and documentation match requirements.

###### Acceptance criteria
- For at least the defined incident types, an incident case in the online incident management system can be started, and the workflow automatically triggers **live response collection**, **full packet capture** (on approved capture points), and **forensic tool ingestion**.
- Evidence outputs are automatically linked to the correct incident case and include integrity information (for example, hashes) and chain-of-custody fields.
- Central audit logs/SIEM contain case-linked records showing each automated mechanism was carried out (start/stop/completion and evidence transfer/ingestion events).
- The incident response plan and system security plan explicitly reference the automated mechanisms. Incident handling procedures and system design/configuration documentation must explain how the mechanisms are used and by whom.

###### Actions Required for Compliance

- [ ] Choose and set up an online incident management system, including case fields for evidence checklists and approval steps.
- [ ] Set up security orchestration, automation and response (SOAR) workflows that link each type of incident to a step-by-step playbook. Each playbook should define what to do during live response, what network data to capture, and what forensic checks to carry out.
- [ ] Set up live incident-response tools to collect evidence and attach it to the correct incident record, using the minimum access permissions needed (least-privilege access).
- [ ] Set up automated full network traffic recording so it can start and stop at approved recording points during defined, time-limited investigation periods.
- [ ] Integrate forensic analysis tools to automatically collect evidence, record evidence integrity information, and store the analysis results back in the case file.
- [ ] Set up central audit logging so that every automated evidence action is recorded and linked to the incident case reference ID.
- [ ] Update the incident response plan, system security plan, incident handling procedures, and system design and configuration documentation to explain the automated mechanisms used and who is responsible for each part.


---

#### IR-4.2 — Dynamic Reconfiguration (Enhancement)

This requirement is about being able to quickly change the protection rules for your networks while an incident is happening, so you can limit damage rather than waiting for a long fix. Without this, an attacker could keep getting through the same access points, keep triggering the same alerts, or keep reaching the parts of your systems you were trying to contain—making the breach worse and harder to control.

To meet this expectation, the organisation must include, as part of its incident response capability, the ability to:
- dynamically update router rules
- update traffic allow/block rules on firewalls or network security devices (“guards”)
- adjust the settings of intrusion detection or prevention sensors
- update firewall or guard filter rules

This must cover network edge routers, firewalls/guards, intrusion detection/prevention sensors, and OT (operational technology) network segmentation gateways.

The organisation must also:
- set clear time targets for completing these changes
- document how it will carry out these changes in its incident response and security plans (including system design and configuration details)
- ensure only authorised staff can make these changes safely
- keep records showing what was changed, who made the change, and when—including evidence that the changes were completed within the agreed time targets

##### Automated incident reconfiguration playbooks for network/security/OT

- Category: Software
- Priority: Critical

###### WHAT
Set up incident-response “dynamic reconfiguration” using pre-approved, parameter-based playbooks that can quickly change:
- **Router rules**
- **Access control lists (ACLs)**
- **Intrusion detection and prevention system (IDS/IPS) settings**
- **Firewall/guard filter rules**
for the defined **system components**: **network edge routers, firewalls/guards, IDS/IPS sensors, and operational technology (OT) network segmentation gateways**.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) incident response (IR-4(2)) enhancement requires that the organisation’s incident response capability **includes dynamic reconfiguration** of the specified **types** for the specified **components**, with **specific time limits** for completing the changes.

###### HOW (specific steps/approach)
1. **Define a reconfiguration capability catalogue**: create a list that maps each allowed change type (router rule changes, ACL updates, IDS/IPS setting changes, firewall/guard filter rule updates) to the exact device or configuration actions your environment supports (for example: route-map/ACL entries, firewall rule enable/disable, IDS/IPS policy switches, segmentation gateway rule updates).
2. **Create “policy-as-code” playbooks**: store playbooks in version control (with peer review) so each change type is implemented as a separate, parameter-based set of actions (including rollback steps). Each playbook must:
   - apply only to the approved component classes (edge routers, firewalls/guards, IDS/IPS sensors, OT segmentation gateways),
   - include pre-checks (device is reachable, configuration version/state is correct, rules/policies compile and validate),
   - include post-checks (the rule/policy was applied successfully; expected changes to traffic/alerts occur; no unintended loss of access to critical services).
3. **Enforce time limits in orchestration**: configure the orchestration workflow so each change type must complete within organisation-defined time budgets (for example: “router rule change within X minutes”, “IDS/IPS setting change within Y minutes”). The workflow must record start and end times, and automatically fail and roll back if the time limits are exceeded.
4. **Restrict execution to authorised incident roles**: connect to the organisation’s identity system and **role-based access control (RBAC)** so only authorised incident responders (or an approved “step-up” approval) can trigger the playbooks. Use a dedicated service account with the minimum required permissions, and allow only approved management actions.
5. **Automatically produce audit evidence**: ensure every playbook run creates an incident-linked audit record containing: incident ID, affected component(s), reconfiguration type, settings applied, who triggered it (human approver and/or automation identity), timestamps, results of pre-checks and post-checks, and whether rollback occurred (and the outcome).
6. **OT safety constraints**: for OT segmentation gateways, include OT-specific safeguards in the playbooks (for example: maintenance window requirements if your OT governance requires them, strict limits to only the affected zone, and conservative rollback conditions) so dynamic reconfiguration can be carried out safely during incidents.

###### WHO
- **Cybersecurity Incident Response Lead**: owns the reconfiguration capability catalogue, time limits, and approval workflow.
- **Network Security Engineering (security operations centre (SOC)/network security (NetSec))**: writes and maintains the playbooks/templates and validation logic.
- **OT/Industrial Control Systems Engineer**: confirms OT-safe constraints and rollback criteria for segmentation gateways.
- **Platform/Automation Engineer**: implements orchestration, identity integration, and audit logging.

###### Acceptance criteria
- For each required **reconfiguration type** (router rules, ACL updates, IDS/IPS setting changes, firewall/guard filter rule updates), there is an approved playbook that can be executed against each required **component class** (edge routers, firewalls/guards, IDS/IPS sensors, OT segmentation gateways).
- Playbooks enforce **organisation-defined time limits** and provide evidence that the change completed within those time limits (or automatically roll back/fail with a recorded reason).
- Only **authorised incident roles** can trigger the reconfiguration (and the identity used is recorded in audit logs).
- Each execution produces incident-linked audit evidence including the triggering identity, affected components, settings applied, timestamps, and results of pre-checks and post-checks.
- OT segmentation gateway playbooks include OT-specific safety safeguards and rollback behaviour that has been validated by OT engineering.

###### Actions Required for Compliance

- [ ] Define the approved dynamic reconfiguration catalogue that maps each reconfiguration type to the configuration building blocks it supports for each component type.
- [ ] Set up incident containment playbooks that are version-controlled and use parameters, with built-in checks before and after actions, and a rollback option, for routers, firewalls/guards, intrusion detection and prevention systems (IDS/IPS), and operational technology (OT) network segmentation gateways.
- [ ] Set up orchestration workflows to enforce the organisation’s time limits for each type of reconfiguration, and to record the start and end times for every run.
- [ ] Link playbook execution to enterprise identity and role-based access control (RBAC) so only authorised incident roles can make changes, and ensure automation uses the minimum necessary permissions with pre-approved (allow-listed) credentials.
- [ ] Set up audit logs linked to each incident that record the incident ID, the affected component(s), the type of reconfiguration, the parameters applied, who carried out the change, the relevant dates and times, and the results of the checks and any rollback.
- [ ] Work with operational technology (OT) engineering to check that the OT network-splitting gateway playbooks are correct, so that during incidents the scope and rollback rules are safe for OT systems and are followed.


---

#### IR-4.3 — Continuity of Operations (Enhancement)

This expectation is about keeping the organisation working when something goes wrong. It requires clear steps for what to do during serious incidents. Without this, a system failure caused by mistakes in design or build, or disruption from deliberate attacks (whether aimed at the organisation or not), could stop key services, delay urgent work, or force an uncontrolled shutdown at the worst possible time.

The organisation must first define and document the types of incidents that will trigger continuity actions. These include:
- malfunctions caused by design or implementation errors or missing elements
- targeted malicious attacks
- untargeted malicious attacks

The organisation must also define and document the continuity actions it may take in response, including:
- orderly reduction of system capability
- controlled system shutdown
- switching to manual work or alternative technology
- using misleading tactics to reduce harm
- routing information through alternative paths
- operating in a special “under attack” reserved mode

Staff responsible for incident handling, with input from information security leads, must be assigned to decide and carry out these actions. They must be supported by written procedures, plans, and practical mechanisms. The organisation must keep records showing the actions taken were intended to keep the organisation’s mission and business functions running.

##### Continuity incident playbooks with incident-class decision support

- Category: Software
- Priority: Critical

###### WHAT
Set up an organisation-approved decision framework for business continuity. It must (1) classify the type(s) of incident and (2) automatically point responders to the matching, pre-approved continuity actions. This ensures the organisation can continue its mission and key business activities.

###### WHY (control requirement)
National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 **IR-4(3)** (enhancement) requires the organisation to **identify the types of incidents** and **take specific actions in response** to keep the mission and business functions running. The guidance also says incident response actions may include **gradually reducing system capability, shutting systems down in an orderly way, switching to manual processing or an alternative technology, using deception measures, switching to alternative ways of sharing information, or using a special “under-attack reserved mode”**. It also requires the organisation to consider conflicts with expectations in **IR-4(5)** about automatically disabling capabilities.

###### HOW (specific steps/approach)
1. **Define incident types and link them to actions** in a single “continuity playbook” document, using the organisation’s agreed categories:
   - Incident types: **failures caused by design or implementation mistakes or omissions; targeted malicious attacks; untargeted malicious attacks**.
   - Continuity actions: **orderly reduction of system capability; system shutdown; switch to manual mode or alternative technology; deception measures; alternative information flows; operate in an under-attack reserved mode**.
2. **Create decision rules for incident types** that responders can use during live incidents. Build a simple classification checklist into the incident process (for example, prompts in the case template) to distinguish:
   - **Design/implementation failure** (for example: regression, configuration defect, missing component, repeatable failure after a change), versus
   - **Targeted attack** (for example: persistence on specific high-value assets, identity/behaviour consistent with adversary targeting), versus
   - **Untargeted attack** (for example: widely spread “commodity” malware affecting many assets with no specific focus).
3. **Embed the action playbooks into the incident response process** (and reference them in the system security plan / incident response plan). Once an incident type is selected, the correct action set should be shown, including the approvals needed:
   - Let the security operations centre (SOC) / operations team trigger **orderly reduction** and **alternative information flows**, using defined pre-checks.
   - Require an **Incident Commander / authorised continuity authority** to approve high-impact actions such as **system shutdown** and **under-attack reserved mode**.
4. **Put continuity actions into operational “runbooks” that can be executed** using the application’s operational tools:
   - **Orderly reduction**: pre-defined feature switches, throttling, or reduced-functionality modes.
   - **Manual/alternative technology fallback**: a documented and tested procedure to switch to an approved alternative workflow (for example: a manual processing queue, read-only reporting, or an alternative integration route).
   - **Alternative information flows**: pre-set alternative endpoints/queues for critical read/reporting functions, with integrity checks and audit logging.
   - **Deception measures** (where feasible): pre-approved decoy endpoints or “honey tokens” for the application layer.
   - **Under-attack reserved mode**: a controlled operating mode that reduces exposure and changes behaviour (for example: restricts write operations, applies stricter request checks, routes to safe paths). It should only be enabled through an approved workflow.
5. **Keep audit-ready records**: record every continuity decision and action taken (incident type chosen, action(s) executed, approver identity, timestamps, and result) and retain evidence in line with the organisation’s enterprise logging and retention requirements.
6. **Test and verify**: run tabletop exercises and controlled technical tests that simulate each incident type, and confirm the correct action set is selected and carried out without breaking safety or operational constraints.

###### WHO
- **Incident Commander / Continuity Lead**: approves high-impact continuity actions (shutdown, under-attack reserved mode).
- **SOC Analyst / Application Operations Lead**: classifies the incident using the checklist and carries out the permitted actions (orderly reduction, alternative information flows).
- **Information Security Lead**: reviews and signs off the incident-type decision rules and the allowed action mappings.
- **Application Owner / Platform Engineer**: builds and maintains the executable runbooks (feature switches, alternative endpoints/queues, reserved mode).

###### Acceptance criteria
- The organisation has a documented continuity playbook under version control that clearly maps the three incident types to the allowed continuity actions.
- Incident process prompts enable responders to select an incident type using a practical checklist that distinguishes targeted versus untargeted activity and design/implementation failures.
- High-impact actions (shutdown and under-attack reserved mode) follow a documented approval workflow; lower-impact actions can be carried out by authorised roles.
- Continuity mechanisms (reduced capability mode, manual/alternative fallback, alternative information flows, reserved mode) are implemented, can be used operationally, and generate audit logs showing the reasons for decisions and the actions taken.
- At least one exercise per incident type demonstrates correct classification and successful execution of the mapped continuity actions.

###### Actions Required for Compliance

- [ ] Create a continuity playbook that is tracked in version control, linking incident categories (ir-04.03_odp.01) to the required actions (ir-04.03_odp.02), including the approval levels needed for each action.
- [ ] Create an incident response checklist that helps responders categorise each incident as one of the following: a design or implementation failure, a targeted attack, or an untargeted attack.
- [ ] Integrate the “classification to action” mapping into the security operations centre (SOC) / security orchestration, automation and response (SOAR) or incident case management workflow so the system shows the correct set of actions.
- [ ] Set up safeguards to keep services running during problems, switch to backup information routes, and enable a protected “under attack” mode, with audit logging enabled.
- [ ] Write down and test the manual or alternative technology fallback steps, and make sure they can be accessed during incidents.
- [ ] Run practice “tabletop” and hands-on technical exercises for each type of incident, and keep records showing that the correct actions were chosen and carried out.


---

#### IR-4.4 — Information Correlation (Enhancement)

This requirement is about making sure the organisation can connect what happened during an incident with the specific actions people took, so there is one clear, organisation-wide picture. Without this, different teams may record events separately, which can leave gaps in understanding who did what, when, and why. That can slow down learning, lead to repeated mistakes, and result in poor decisions about prevention, communication, and how personal data is handled.

To meet this expectation, the organisation must:
- define which incident information sources must be linked to which recorded response actions
- name the people responsible for making these links and for ensuring information and privacy responsibilities are met
- specify who is allowed to receive the combined results

It must also set out documented processes and ensure incident-handling steps capture the details needed. This should be supported by planned and configured mechanisms that create and keep records showing the connections, along with reports.

Finally, the organisation must use these linked reports to produce an organisation-wide view and keep audit evidence showing the links and the review carried out by the relevant roles.

##### Case ID correlation linking incident evidence to response actions

- Category: Software
- Priority: Critical

###### WHAT must be done
Set up an organisation-wide incident linking capability that brings together incident information from multiple systems and connects it to the specific, individual actions taken to respond. This should produce one single view that can be checked and verified during audits.

###### WHY (control requirement)
NIST SP 800-53 **IR-4(4) Information Correlation** requires the organisation to **link incident information with the specific actions taken during incident response** to create an **organisation-wide view** of how incidents are identified and handled. The guidance explains that threat activity may only be understood by combining information from different sources and reporting processes.

###### HOW (specific steps/approach)
1. **Define what will be linked and how it is structured**: Agree a minimum set of linking fields (for example, an authoritative **Incident/Case ID**, a time window, affected assets or entities, the detection source, and structured identifiers for response actions). Document which incident information sources must be linked (for example, security information and event management (SIEM) alerts, endpoint detection and response (EDR) detections, ticket updates, and authentication and administration audit logs) and which response action records must be linked (for example, containment, eradication, and investigation steps recorded in the incident workflow).
2. **Create one authoritative Incident/Case ID at the start**: Make sure every incident gets an authoritative Case ID at the beginning of handling, and that all later evidence and response actions are attached to that same Case ID. Do not create separate “shadow” cases that are not linked.
3. **Automate linking and adding context**: Configure security information and event management (SIEM), security orchestration, automation and response (SOAR), and any monitoring or endpoint integrations to automatically create or link to the Case ID. Also enrich the case timeline with linked detections, relevant entities (such as user, device, or service), and references to evidence.
4. **Record response actions in a structured way**: Require incident handlers to record response actions as structured workflow updates (who did what, when, and why; action type; and approvals where relevant). This ensures the actions can be linked to the incident evidence timeline.
5. **Limit access to authorised users and keep audit records**: Use role-based access control (RBAC) so only authorised roles can view the linked outputs. Keep the linking records (including the case audit trail, linkage records, and versions of the linking rules) for audit purposes and to support organisational learning.
6. **Add privacy and security checks before sharing**: If linked outputs include personal data, apply data minimisation and redaction where possible. Ensure privacy and security review checks are built into the case workflow before organisation-wide linking reports are exported.

###### WHO (role responsible)
- **Incident Response Lead / SOC Manager**: owns the linking scope, the Case ID process at triage, and the requirement to record response actions in a structured way.
- **Security Engineering (SIEM/SOAR/Incident response tooling)**: builds the integrations, linking rules, and evidence enrichment.
- **Application Owner / Data Protection Officer (where applicable)**: confirms that privacy and security checks and data minimisation are applied to linked outputs.
- **Identity and Access Management (IAM) / Platform Security**: ensures role-based access control and audit logging for linked case views.

###### Acceptance criteria
- For a representative sample of incidents, evidence from at least **two different sources** (for example, SIEM plus EDR, or SIEM plus audit logs) is linked to the **same authoritative Case ID**.
- For each incident, the linked output includes a **timeline that connects incident evidence to structured response actions** (not just free-text notes).
- Linked outputs are available only to **authorised roles**, and the system keeps **audit evidence** showing the linkage (including Case ID creation, evidence attachment, linking rule versions, and case workflow actions).
- For incidents involving personal data, linked exports and reports must go through **documented privacy and security checks**, and demonstrate data minimisation and redaction where feasible.

###### Actions Required for Compliance

- [ ] Define and document the correlation scope: the incident information sources that are required and the required response action records that must be linked.
- [ ] Create an official Incident or Case ID at triage, and require that all evidence collected and all response actions taken are linked to that same ID.
- [ ] Set up security information and event management (SIEM) and security orchestration, automation and response (SOAR) connections so that cases are automatically linked and enriched with related detections and supporting evidence references.
- [ ] Update the incident workflow so that response actions are recorded in structured fields (who, what, when, why, and action type) rather than as free-text only.
- [ ] Set up role-based access control (RBAC) so only authorised people can view and export linked case information, and turn on audit logging to record events related to connections and workflow activity.
- [ ] Add privacy and security checks (gate) and minimise data use by masking or redacting personal information where it is feasible for correlated outputs that include personal data.
- [ ] Test using a sample of past incidents to confirm that all related events are correctly linked from start to finish, and produce an audit-ready correlation report.


---

#### IR-4.5 — Automatic Disabling of System (Enhancement)

This requirement is about making sure your systems can protect themselves by automatically switching off when something seriously wrong is detected. If a cyber-attack interferes with how the system works or steals organisational information, or if a major software fault occurs that could affect your ability to carry out your mission—or even put people’s safety at risk—the system should not continue running in a dangerous state.

To meet this expectation, the organisation must:
- set clear, agreed trigger conditions for these two types of problems;
- configure the system so it can automatically disable itself when they occur; and
- ensure the disabling behaviour can be changed through configuration by authorised people, without rebuilding the system.

The organisation must also:
- document how the triggers and disabling actions work;
- include this in its security and incident response plans;
- assign responsibility for what happens next; and
- check that automatic disabling does not harm business continuity, resolving any conflicts using appropriate safeguards.

##### Configurable auto-disable on integrity/exfiltration/serious error

- Category: Software
- Priority: Critical

###### WHAT
Set up a configurable capability that automatically puts the system into a disabled state when it detects **security violations**. These include: **(1) cyber-attacks that damage system integrity or steal organisational information**, and **(2) serious software errors** that could harm organisational missions or functions (and could also put safety at risk, where relevant).

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) **IR-4(5)** enhancement requires: “Implement a configurable capability to automatically disable the system if {{ insert: param, ir-04.05_odp }} are detected.” The guidance also says organisations must check whether automatic disabling conflicts with business continuity requirements in **CP-2** or **IR-4(3)**.

###### HOW (specific approach)
###### 1) Define measurable trigger conditions (configurable)
Create a configuration-based set of triggers with three categories, each linked to measurable detection signals:
- **Integrity compromise**: for example, detection of unauthorised changes to privileged settings, unexpected changes to critical software files/configurations, alerts from integrity monitoring, or evidence of tampering.
- **Exfiltration**: for example, confirmed or strongly correlated outbound data theft indicators (data loss prevention (DLP), user and entity behaviour analytics (UEBA), security information and event management (SIEM) correlation), unusual data flows to unauthorised destinations, or confirmed policy violations.
- **Serious software error**: for example, repeated crash cycles, failed safety/mission-critical health checks, signs of corruption, or error states that could significantly impair mission functions.

###### 2) Implement an automatic “disable/safe” mode (not necessarily full power-off)
Provide a system-level **Disable Mode** that the detection capability can trigger automatically. The disabling action must be pre-defined and configurable, for example:
- stop or reduce the scale of services that affect mission delivery,
- block outgoing network traffic and/or revoke active sessions or access tokens,
- switch to a read-only or reduced “safe” mode where continuity allows,
- isolate workloads/instances and prevent further processing of sensitive data.

###### 3) Make behaviour configurable by authorised personnel
Provide configuration options for:
- whether the capability is enabled,
- trigger thresholds and suppression windows (to reduce false alarms),
- scope (which services, tenants, or instances are disabled),
- disable action type (safe mode versus stopping services versus blocking outgoing traffic),
- required confirmation or override steps (where continuity requirements mean it is needed).

###### 4) Integrate with enterprise detection and orchestration
Connect detection events from existing enterprise tools (for example, SIEM, extended detection and response (XDR), DLP, and observability alerting) to an orchestration mechanism that can trigger Disable Mode using authenticated, auditable control actions (for example, deployment or orchestration application programming interfaces (APIs), feature flags, service management, or infrastructure automation).

###### 5) Resolve CP-2 / IR-4(3) continuity conflicts
Before enabling this in live environments, confirm that Disable Mode fits continuity requirements:
- ensure there is a safe fallback (for example, read-only mode, reduced service, or controlled failover),
- define when automatic disabling happens immediately versus when it requires an override,
- document operational impact and recovery steps.

###### WHO
- **Application Owner / Engineering Lead**: implement Disable Mode and the safe fallback behaviour.
- **Cybersecurity Detection Engineering**: define and tune detection signals for integrity compromise, exfiltration, and serious software errors.
- **Platform/DevOps Engineering**: implement the orchestration/invocation mechanism and configuration management.
- **Security Governance / Incident Response Lead**: approve trigger definitions, continuity safeguards, and override/response procedures.

###### Acceptance criteria
- The system has a **Disable Mode** that can be triggered automatically and in a predictable (deterministic) way.
- Trigger conditions for **integrity compromise**, **exfiltration**, and **serious software errors** are implemented as **configurable** rules/thresholds.
- When a configured trigger occurs in a test environment, the system moves to the configured disabled/safe state within an agreed time window and carries out the configured disable actions.
- Disable Mode configuration (enablement, thresholds, scope, action parameters) can be changed only by **authorised** personnel and is fully **auditable** (who/what/when).
- A documented continuity assessment confirms there is no unacceptable conflict with **CP-2** / **IR-4(3)**; safe fallback and recovery steps are validated through tabletop exercises and/or technical testing.

###### Actions Required for Compliance

- [ ] Set up configurable trigger rules to detect (using measurable signals) integrity compromise, data exfiltration, and serious software errors.
- [ ] Implement a **Disable Mode** (a safe or reduced-function state) with pre-approved disable actions, such as **stopping or reducing services**, **blocking outbound network traffic**, **revoking user sessions**, and **quarantining workloads**.
- [ ] Integrate detection events from security information and event management (SIEM), extended detection and response (XDR), data loss prevention (DLP), and observability into an authenticated, auditable orchestration process that triggers Disable Mode.
- [ ] Set up configuration settings for activation, alert thresholds and suppression time windows, the scope of what is covered, and the type of action to take when disabling, then store these settings in a controlled configuration management system.
- [ ] Test the continuity safeguards by checking that **Disable Mode** meets the requirements of **CP-2/IR-4(3)**, and document the safe fallback and recovery steps.
- [ ] Carry out tabletop exercises and technical checks to confirm that approved configuration changes are recorded, and that the system disables as expected when the trigger conditions occur.


---

#### IR-4.6 — Insider Threats (Enhancement)

This requirement is about being prepared to deal with problems caused by people on the inside, such as staff or contractors who misuse their access, act carelessly, or deliberately cause harm. If the organisation does not have a clear way to respond to insider threats, concerns may be overlooked, important evidence may be lost, decisions may be delayed, and the organisation could face financial loss, disruption, or the exposure of sensitive information.

To meet this expectation, the organisation must have a documented incident response policy and step-by-step procedures that clearly cover insider-threat incidents. These must be supported by practical reporting and handling processes that incident responders can follow. The organisation must also keep relevant documentation showing how key systems are built and configured, and maintain an incident response plan and a system security plan that set out what to do and who to involve, including how issues are escalated and how information is communicated.

Finally, the organisation must keep the records needed to investigate and manage these incidents, and be able to demonstrate that the approach works in practice.

##### Insider-threat incident handling playbooks in case management

- Category: Software
- Priority: High

###### WHAT
Set up an incident-handling capability specifically for insider-threat incidents. Use documented, step-by-step insider-threat playbooks that are carried out through the organisation’s incident and case management workflow. The capability must cover triage, investigation, containment, eradication, recovery, and lessons learned. It must also use standardised ways to handle evidence and keep records in a way that is ready for audit.

###### WHY (control requirement)
NIST IR-4(6) (Enhancement) requires: **“Implement an incident handling capability for incidents involving insider threats.”** The guidance says insider threats need **specific incident-handling capabilities** so the organisation can respond **appropriately and quickly**.

###### HOW (specific steps/approach)
1. **Create insider-threat scenarios and decision points** in the incident procedures and playbooks (for example: staff or contractors misusing credentials, unauthorised privileged actions, attempts to take data out of the organisation, sabotage or disruption, and negligent mishandling). Each scenario must link to the triage questions and response actions that are required.
2. **Build the playbooks into the case-management workflow** so that when an alert or report is received, the workflow asks the case handlers for the required information (suspected insider identity, affected systems, time window, suspected behaviour, potential impact, and any immediate safety or containment needs) and sends the case to the correct escalation route.
3. **Standardise how evidence is captured and preserved** within the workflow. Set out what evidence must be collected (identity and access events, privileged actions, changes to admin consoles or configurations, relevant application logs, data-access and audit trails, and any available endpoint or user activity information). Also define where evidence is stored (an unchangeable evidence store or a controlled retention location) and how evidence references are linked to the case.
4. **Define containment and escalation actions for each scenario**, including clear “when to escalate” triggers (for example: suspected credential misuse to the identity and access management lead; suspected data exfiltration to the data protection and forensics lead; suspected plant or operational technology impact to the operational technology liaison where applicable). Make sure containment steps include preserving logs and preventing loss of evidence.
5. **Make investigation outputs consistent**. Require a case timeline, a list of affected data and systems, an initial impact assessment, and a documented decision on eradication and recovery steps. Ensure case closure includes lessons learned and updates to detection and controls.
6. **Run tabletop exercises and check usability**. Run at least one insider-threat tabletop exercise for each major system type (for example: a software-as-a-service application, an on-premises component, and an application programming interface service). Confirm that case handlers can follow the playbooks from start to finish, including evidence handling and escalation.

###### WHO (role responsible)
- **Incident Response Lead / Security Operations Centre (SOC) Manager**: owns the insider-threat playbooks and ensures they are built into the case workflow.
- **Forensics Lead (or a designated digital investigation function)**: defines what evidence is required and how it must be preserved.
- **Identity and Access Management (IAM) Lead**: checks the triage and containment steps for credential misuse and the escalation triggers.
- **Application Owner / Security Engineer**: ensures the right application-specific log sources and configuration references are available to case handlers.

###### Acceptance criteria
- Insider-threat incidents can be handled end-to-end using the playbooks in the case workflow (report → triage → containment → investigation → decision → closure → lessons learned).
- For each insider-threat scenario, the playbook specifies the required triage inputs, evidence to collect, containment and escalation triggers, and closure and lessons-learned requirements.
- Evidence collected during exercises is stored in an auditable, controlled way and is linked to the case record (the case includes a complete set of evidence references and a timeline).
- At least one tabletop exercise per major system type shows that case handlers can run the playbook correctly, with no missing evidence handling or escalation steps.
- The post-exercise review produces documented improvements to playbooks and detections where gaps are found.

###### Actions Required for Compliance

- [ ] Define insider-threat scenarios and, for each one, set out the triage questions to ask, the evidence needed, the containment actions to take, and the conditions that require escalation.
- [ ] Set up the case-management process so it always collects the required insider-threat information and automatically routes or escalates cases based on the scenario.
- [ ] Link security monitoring records (security information and event management (SIEM) logs) and application audit logs to case evidence capture, so evidence collection is built into the workflow.
- [ ] Set up an evidence storage method that can be audited (with tamper-resistant, controlled retention) and automatically link each evidence reference to the case.
- [ ] Create containment playbook steps for each scenario that preserve logs and prevent evidence from being lost before eradication actions are carried out
- [ ] Run tabletop exercises for each major system type and record any differences from expectations, missing evidence, and updates needed to the relevant playbooks.


---

#### IR-4.7 — Insider Threats — Intra-organization Coordination (Enhancement)

This expectation is about making sure that, when an insider threat incident happens, the right people across the organisation work together from start to finish, rather than each team acting on its own. Without clear coordination, important steps could be missed, decisions could be delayed, evidence could be handled incorrectly, and actions taken could conflict with privacy responsibilities or legal requirements—leaving the organisation exposed and making it harder to put things right.

The organisation must clearly identify and assign responsibilities to the Senior Agency Information Security Officer, the Risk Executive (function), the Senior Agency Official for Privacy, legal counsel, human resources, procurement, personnel, physical security, mission or business owners, system owners, and operations personnel. It must also define a documented way for them to coordinate.

The organisation must ensure the full incident journey is covered—preparation, detection and analysis, containment, eradication, and recovery—using its incident response policy, incident handling procedures, incident response plan, insider threat programme plan, insider threat concept of operations, system security plan, privacy plan, and any other relevant records. This includes any arrangements for support from external law enforcement, if such support is used.

##### Insider threat incident command workflow with named coordination entities

- Category: Manual
- Priority: Critical

###### WHAT
Set up an end-to-end way to coordinate how the organisation responds to insider-threat incidents. This must explicitly include the organisation-defined roles and groups (for example: Senior Agency Information Security Officer, Risk Executive (function), Senior Agency Official for Privacy, Legal Counsel, Human Resources, Procurement, Personnel, Physical Security, Mission/Business Owners, System Owners, Operations Personnel). Use one single, repeatable incident command process across the full incident journey: preparation, detection and analysis, containment, eradication, and recovery.

###### WHY (control requirement)
IR-4(7) (enhancement) requires the organisation to **coordinate an insider-threat incident handling capability** that includes the specified roles and groups. The guidance highlights that incident handling needs coordination across many parts of the organisation throughout the full journey (preparation → detection/analysis → containment → eradication → recovery). This includes involving privacy and legal counsel, and may also include support from external law enforcement.

###### HOW (specific steps/approach)
1. **Create an Insider Threat Incident Command (ITIC) charter** that lists the required roles and assigns responsibilities for each stage of the incident journey (preparation, detection/analysis, containment, eradication, recovery). The charter must point to the organisation’s existing records used for insider-threat handling, including: incident response policy, incident handling procedures, incident response plan, insider threat programme plan, insider threat concept of operations (CONOPS), system security plan, privacy plan, and any other relevant records.
2. **Define one coordination process** (the “ITIC workflow”) with documented decision points and handovers. For each decision point, specify:
   - which named role leads and/or approves,
   - what triggers moving to the next stage,
   - what evidence and records must be captured and kept,
   - where privacy and legal counsel must be consulted (for example, before containment actions that affect personal data, and before actions that could have legal implications).
3. **If external law enforcement support is used**, add an annex to the ITIC workflow that sets out the triggers, points of contact, and approval steps for involving external law enforcement. This must align with the organisation’s legal counsel and privacy plan.
4. **Run full end-to-end tabletop exercises** to make the coordination work in practice. The exercises must include the required roles and confirm that responsibilities, approvals, and evidence handling are followed consistently.
5. **Keep audit-ready records**: ensure the ITIC charter, ITIC workflow, exercise results, and any actions agreed after the exercises are stored in controlled document management. These records must be traceable to the insider threat programme plan and the incident response records.

###### WHO (role responsible)
- **Primary owner:** Senior Agency Information Security Officer (as the incident coordination lead under the charter)
- **Approvers/participants:** Risk Executive (function), Senior Agency Official for Privacy, Legal Counsel, Human Resources, Procurement, Personnel, Physical Security, Mission/Business Owners, System Owners, Operations Personnel
- **Support (if applicable):** external law enforcement liaison, coordinated through Legal Counsel

###### Acceptance criteria
- The ITIC charter and ITIC workflow **explicitly include all roles and groups** listed in the organisation-defined parameter `ir-04.07_odp`.
- For each stage of the incident journey (preparation, detection/analysis, containment, eradication, recovery), the workflow sets out **named responsibilities and approval/consultation points** for the required roles and groups.
- Privacy and legal counsel involvement is recorded at the relevant decision points.
- At least one tabletop exercise has been completed within the last 12 months using the ITIC workflow, with documented outcomes and corrective actions.
- Proof of coordination (workflow records, exercise records, and improvement actions) is kept in controlled document management and links to the required insider threat/incident response/privacy/system security records.

###### Actions Required for Compliance

- [ ] Draft an Insider Threat Incident Command (ITIC) charter that lists every organisation named in `ir-04.07_odp` and assigns responsibilities for each lifecycle stage.
- [ ] Publish an ITIC workflow that sets out the decision points, what starts each step, how work is passed between teams, and what evidence and documents are required from preparation through recovery.
- [ ] Add privacy and legal advice consultation steps to the ITIC workflow, and link them to the privacy plan and the incident response records.
- [ ] Add an external law enforcement support annex (only if it is used). It should set out the circumstances that trigger support, the approval steps, and the liaison contact details, coordinated by legal counsel.
- [ ] Run a complete end-to-end tabletop exercise with all required participants, and record the results, any gaps found, and the corrective actions to address them.
- [ ] Store the ITIC charter, workflow, exercise evidence, and improvement actions in a controlled document management system, with clear traceability to the insider threat programme plan and the incident response plan.


---

#### IR-4.8 — Correlation with External Organizations (Enhancement)

This requirement ensures that if something goes wrong, your organisation does not handle the incident in isolation. Instead, it must share the right incident information with key external partners so everyone can build a shared understanding of what is happening. Without this, you may miss important clues, wrongly judge how serious the incident is, or take slower or less effective action because other organisations may have identified the same threat first.

To meet this expectation, the organisation must put in place a clear process for coordinating with the Department of Defense (DoD) and coalition partners, the United States Computer Emergency Readiness Team (US-CERT), Certified Controlled Goods and Services (CMMC) assessment bodies, and managed service providers. This includes naming specific people responsible for information security and privacy oversight, and for coordinating incidents.

The organisation must also document:
- which external organisations it will work with
- what information will be shared, including observable signs, which systems are affected, severity, key timing details, and the remediation actions taken or planned
- how incoming information will be compared with its own records
- who to contact at each partner

During incidents, the organisation must share and combine the agreed information, use the combined view to improve response decisions, and keep records showing what was shared and what the comparison found. These coordination steps must be reflected in its incident response policy, procedures, incident response plan, system security plan, and privacy plan.

##### External incident sharing & correlation workflow with partner playbooks

- Category: Manual
- Priority: High

###### WHAT
Set up a controlled process to work with external organisations defined by the organisation (for example: Department of Defense (DoD) and coalition partners, United States Computer Emergency Readiness Team (US-CERT), Cybersecurity Maturity Model Certification (CMMC) assessment bodies, and managed service providers). The process should bring together and share agreed incident information (incident indicators, affected systems, severity, timelines, and remediation actions) to create a shared, cross-organisation view of incident awareness.

###### WHY (control requirement)
National Institute of Standards and Technology (NIST) Incident Response (IR)-4(8) enhancement requires the organisation to **coordinate with external organisations** to **correlate and share** the specified incident information. This is to achieve a **cross-organisation perspective on incident awareness** and enable **more effective incident responses**.

###### HOW (specific steps/approach)
1. **Define external partner scope and contacts**: Keep an approved “external incident coordination register” that lists each external organisation category, the purpose of coordination, and named contacts (incident coordination lead, security approver, privacy approver, and escalation contact).
2. **Standardise the incident information package**: Create procedure templates that clearly state the exact information to share—**incident indicators, affected systems, severity, timelines, and remediation actions**—including any required translation (for example, mapping the organisation’s internal severity terms to the severity language expected by partners).
3. **Set approval gates and redaction rules**: Require security approval for technical content and privacy approval for any personal data handling. Apply redaction or limiting rules so that only the agreed incident information is shared.
4. **Use a repeatable correlation method**: Define a repeatable workflow that takes external indicators, standardises them, matches them to the organisation’s internal monitoring and asset information, and updates the organisation’s incident record with the correlation results to support cross-organisation awareness.
5. **Run the process during incidents**: During an incident, the incident commander starts the relevant playbook, confirms the approval gates are met, completes the correlation, and then shares the approved incident information package with the relevant external organisations.
6. **Keep evidence for audit purposes**: Record what was shared, who it was shared with, when it was shared, what correlation results were produced, and which playbook/approval decision was used. Link these records to the incident handling case.
7. **Link to existing plans**: Ensure the incident response plan, system security plan, and privacy plan reference the external coordination workflow and the external incident coordination register.

###### WHO (role responsible)
- **Incident Response Lead / Security Operations Centre (SOC) Manager**: owns the playbooks, starts the workflow, and ensures correlation is carried out.
- **Information Security Officer (ISO) / Security Approver**: approves the technical incident information to be shared.
- **Privacy Officer / Data Protection Lead**: approves any personal data handling and the redaction approach.
- **External Liaison / Contract Manager (where applicable)**: maintains the partner register and contact details.

###### Acceptance criteria
- An approved external incident coordination register exists and includes the organisation-defined external organisations and named contacts.
- Incident-sharing templates/procedures specify and enforce sharing of **incident indicators, affected systems, severity, timelines, and remediation actions**.
- Security and privacy approval gates are enforced before any information is shared externally.
- A documented correlation workflow exists and is used to produce correlation outcomes linked to incident records.
- Evidence is kept showing: (a) what was shared, (b) who it was shared with, (c) when it was shared, and (d) the correlation results, for at least one tested incident scenario.
- Incident response/system security/privacy plans reference the external coordination workflow and the partner register.

###### Actions Required for Compliance

- [ ] Create and get approval for an external incident coordination register that lists the external organisations defined by the organisation and the named contact people for each.
- [ ] Create standard incident-sharing templates that list the signs of an incident, which systems are affected, the severity, key dates and times, and the steps to fix it.
- [ ] Put in place security and privacy approval checkpoints, and define rules for how incident information is redacted or limited before it is shared.
- [ ] Document and put into day-to-day operation a process that links external warning signs to internal monitoring data and information about affected assets, and records the results of each correlation.
- [ ] Update the incident response plan, system security plan, and privacy plan to reference the external coordination workflow and the partner register.
- [ ] Set up records of evidence for every external sharing event, including what was shared, who shared it, and when, and link those records to the relevant incident case.


---

#### IR-4.9 — Dynamic Response Capability (Enhancement)

This requirement is about being able to respond quickly and adapt during an incident. It relies on ready-to-use instructions, the right monitoring and containment actions, and automated fixes when appropriate. Without this, an organisation may respond too slowly, follow the wrong steps, or fail to limit the impact—allowing problems to spread, services to stay disrupted, or sensitive information to be exposed.

To meet this expectation, the organisation must use its incident playbooks based on its mission and business processes, its system-level detection and containment capabilities, and its automated remediation workflows to handle incidents. It must also be able to quickly deploy new or replacement versions of these capabilities while the incident is still ongoing.

The organisation must keep clear, documented incident handling procedures. It must maintain an incident response plan and a system security plan, and it must keep system design and configuration documentation showing how these response capabilities work together. Finally, it must keep audit records of the actions taken during response, and it must have defined organisational processes and named people responsible for incident handling and information security.

##### Incident response capability pipeline with in-incident deployment

- Category: Software
- Priority: High

###### WHAT
Set up a controlled, version-controlled “dynamic response capability” pipeline that packages and deploys (1) mission/business incident response playbooks, (2) system-level detection and containment components, and (3) automated fix (remediation) workflows as signed, tested items. The pipeline must allow deploying a new or replacement set of capabilities during an active incident, with rollback and audit proof.

###### WHY (control requirement)
NIST IR-4(9) (enhancement) requires using the organisation-defined **dynamic response capabilities** (parameter **ir-04.09_odp**) to respond to incidents. This includes timely deployment of **new or replacement organisational capabilities** at both the mission/business process level and the system level during incident handling.

###### HOW (specific steps/approach)
1. **Define capability item types and information**: describe each playbook, detection/containment component, and remediation workflow as a versioned item with key information (owner, which systems it applies to, triggers, required proof outputs, and the rollback target).
2. **Create a capability library and automated checks**: store the items in a controlled library. Add automated checks (data format checks, dependency checks, unit tests for workflow logic, and “dry-run” simulations that confirm required proof fields and updates to tickets).
3. **Apply permission and deployment rules using policy-as-code**: set rules for what can run automatically versus what needs approval (for example, containment actions may be auto-approved; remediation may require incident commander approval unless it is low risk). Ensure the incident commander can choose a capability version during the incident.
4. **Sign and move items through environments**: sign capability packages and move them from development to testing to live using the organisation’s release/change controls, ensuring only approved signed versions can be deployed.
5. **Connect to the incident response platform for deployment during the incident**: link the pipeline to the SOAR (security orchestration, automation and response) / incident automation layer (or equivalent automation runner) so that, during an incident, authorised responders can deploy the replacement capability set to the relevant systems.
6. **Add rollback and proof (evidence) creation**: make sure every deployed capability has a previous known-good version and supports fast rollback. Automatically record deployment actions, the selected capability version, and results of execution for audit records.

###### WHO (roles responsible)
- **Cybersecurity Incident Response Lead / Incident Commander**: authorises deployment of replacement capabilities during incidents.
- **Security Automation Engineer / SOAR Engineer**: builds and maintains playbooks, detection/containment components, and remediation workflows.
- **Application/Platform Engineering Lead**: ensures integration with the application platform and environment boundaries.
- **Change/Release Manager**: ensures promotion and approval steps match organisational governance.
- **Security Governance/Compliance**: checks that audit proof is complete and mapped to IR-4(9).

###### Acceptance criteria
- During an active incident, an authorised incident commander can deploy a **new or replacement** capability set (playbook + detection/containment + remediation workflow) to the relevant systems.
- Deployed capability sets are **versioned, signed, and traceable** back to library entries (repository commits) and approval records.
- Automated validation checks run before promotion, and deployments produce **audit records** including capability version, deployment time, operator identity, and execution/proof outputs.
- Rollback to a previous known-good capability version is shown and recorded.
- Proof outputs needed for audit (for example, workflow execution logs, containment/remediation confirmations, and ticket/incident references) are consistently produced.

###### Actions Required for Compliance

- [ ] Define and document the types of incident response materials you will use—such as response playbooks, detection and containment modules, and remediation workflows—along with the required information (metadata) and the proof (evidence) each one must produce.
- [ ] Set up a continuous integration (CI) validation process that uses a code repository, including checks against the required data format (schema), automated tests for the workflow, and “dry run” simulations to confirm evidence and ticket updates before they are applied.
- [ ] Use policy-as-code to set deployment authorisation rules, so you control which actions can run automatically and which actions need incident commander approval.
- [ ] Package the capability artefacts and apply a digital signature to them, then move them through development to testing to production (dev → test → prod) only after using the existing change and release approval process.
- [ ] Integrate the pipeline with the incident response orchestration and security orchestration, automation and response (SOAR) layer so that, during an incident, a chosen replacement capability version can be deployed.
- [ ] Set up rollback so you can return to a previously verified “known-good” version of the capability, and make sure every deployment and execution produces records that are ready for audit.


---

#### IR-4.10 — Supply Chain Coordination (Enhancement)

This expectation is about making sure that if something goes wrong anywhere in your supply chain, you coordinate with the other organisations involved, rather than dealing with it on your own. Without clear coordination, a problem caused by a supplier, a supplier’s supplier, a product or component, the way something is developed, or even distribution and warehousing could go unnoticed, slow down recovery, and leave you unable to meet your legal reporting duties.

To meet this expectation, your organisation must:
- define what counts as a supply-chain incident
- identify which partners you will coordinate with
- assign named people who are responsible for coordinating and sharing information

You must include this in your incident response policy, procedures, and plans. You must also ensure your contracts and service agreements with suppliers and service providers clearly state what incident information will be shared, with whom, and how— including support for any reporting you are required to make to government oversight bodies.

Where coordination is needed, you should also obtain and review key partners’ incident handling plans.

##### Contractual supply-chain incident cooperation framework and partner packs

- Category: Manual
- Priority: Critical

###### WHAT
Set up a standard, contractually enforceable way to work with relevant supply-chain partners when a supply-chain incident happens. This includes agreeing what information will be shared, how it will be shared securely, how issues will be escalated, and how the approach supports any required reporting to government.

###### WHY (control requirement)
NIST Special Publication 800-53 **IR-4(10)** requires the organisation to **coordinate incident handling for supply-chain events with other organisations involved in the supply chain**. It also expects that how supply-chain incident information is protected and shared is covered in **information exchange agreements**, and that the organisation can support **reporting incidents to government oversight bodies** (for example, the Federal Acquisition Security Council).

###### HOW (specific steps/approach)
1. **Define the scope of supply-chain incidents and the situations that trigger action** using a reusable template used across contracts and incident response procedures. Include incidents involving primary and sub-tier providers, IT products, system components, development processes and personnel, and distribution and warehousing facilities.
2. **Create a “Supply-chain Incident Cooperation” contract / service level agreement (SLA) clause set** that states:
   - Which partners are included (primary and sub-tier where applicable).
   - Notification timeframes (initial notice and how often follow-up updates will be provided).
   - What incident information is shared (for example: incident summary, affected products or components, likely impact, remediation actions, and—where appropriate—how relevant indicators and evidence will be handled).
   - How information is shared (secure channel, named contacts, and what disclosures are allowed and required).
   - Escalation routes and expectations for joint coordination (who takes part, who makes decisions, and how often updates will be provided).
   - Clear support for any incident reporting obligations to government oversight bodies, aligned to your organisation’s legal and reporting process.
3. **Link these clauses to your incident response governance** by referencing your organisation’s **incident response policy and procedures**, **incident response plan**, and relevant sections of your supply-chain risk management and system security plan, so coordination is not handled informally.
4. **Require partners to provide and renew “incident coordination packs”**:
   - Collect the partner’s incident handling plan (or equivalent procedures) and store it in a controlled repository with version control.
   - Create a partner-specific mapping (responsible, accountable, consulted, informed) of internal roles versus partner roles, including 24/7 escalation contacts where needed.
5. **Apply procurement and contract lifecycle controls** so onboarding and renewal cannot be completed unless the incident cooperation framework is accepted and the partner-specific coordination pack is included.

###### WHO (role responsible)
- **Head of Procurement / Contracting Lead**: ensures the clauses are included and enforced throughout the contract lifecycle.
- **Chief Information Security Officer (CISO) / Incident Response Lead**: owns the supply-chain incident definition, coordination procedures, and alignment to the incident response plan.
- **Legal / Compliance Counsel**: checks that the government reporting support wording is valid and that disclosure limits are met.
- **Third-Party Risk Manager**: manages partner onboarding requirements and maintains the repository of partner incident handling plans.

###### Acceptance criteria
- Contract templates and SLAs include clear supply-chain incident cooperation and information-sharing clauses covering: scope, notification timeframes, information content, secure sharing method, escalation routes, and support for government reporting.
- For every in-scope partner, an approved partner-specific incident coordination pack exists (named contacts and roles, escalation routes), and the partner’s incident handling procedures have been collected and are version-controlled.
- There is evidence that procurement onboarding and renewal cannot be completed without accepting the required clauses and pack.
- Incident response procedures reference the coordination framework and explain how joint communications and updates will be managed.

###### Actions Required for Compliance

- [ ] Define and document a standard definition of a supply-chain incident and the conditions that trigger notifications. This should cover primary and sub-tier suppliers, information technology (IT) products and components, software development processes and personnel, and distribution and warehousing facilities.
- [ ] Publish a standard contract/service-level agreement (SLA) clause set for “Supply-chain incident cooperation” that covers: what information must be shared, how it will be shared securely, the named points of contact, the escalation routes, and the notification and follow-up timeframes.
- [ ] Update the incident response policy and procedures, and the incident response plan, to reference the supply-chain incident cooperation framework and the expected approach for joint communications.
- [ ] Create partner onboarding and renewal requirements to collect each partner’s incident response plan (or an equivalent document), and produce a partner-specific incident coordination pack that includes responsibilities (RACI) and clear escalation routes.
- [ ] Set up a contract approval checkpoint so procurement cannot complete onboarding or renewal unless the incident cooperation clauses and the partner-specific coordination pack have been accepted.
- [ ] Check with Legal and Compliance that the information-sharing and government reporting wording meets the required reporting duties and any limits on what can be disclosed.


---

#### IR-4.11 — Integrated Incident Response Team (Enhancement)

This requirement is about having a team that is ready to be deployed immediately when something goes wrong, wherever your organisation needs them. Without this, a serious security incident could spread further, important facts could be lost before they are properly recorded, and recovery could take much longer—leaving your people, customers, and day-to-day operations exposed to avoidable harm.

To meet this expectation, your organisation must set up and maintain an integrated incident response team. The team must include the right mix of people to: handle incidents, preserve and examine evidence, analyse malicious software, support technical fixes, and provide immediate operational support. You must also have clear written guidance and plans for how incidents will be handled and prepared for, including links to your wider security and privacy planning. In addition, you must clearly assign who is responsible for incident handling and who makes privacy and security decisions.

Finally, the team must be able to be deployed to any location you identify within 2 hours. You should be able to demonstrate that this is tested and works in practice.

##### Deployable integrated IR pods with 2-hour dispatch evidence

- Category: Manual
- Priority: Critical

###### WHAT
Set up and maintain an incident response team that can be sent to any location identified by the organisation within the required time period ({{ insert: param, ir-04.11_odp }} = **within 2 hours**). This team will work in “incident response pods” (distributed teams). Each pod must be able to: manage the incident, quickly preserve digital evidence, investigate and respond to unauthorised access, and analyse malicious code. The pod must also include engineering and real-time operations staff so it can quickly contain the problem and support recovery.

###### WHY (control requirement)
NIST IR-4(11) (enhancement) requires the organisation to “establish and maintain an integrated incident response team that can be deployed to any location identified by the organisation” within the defined time period (ir-04.11_odp). The guidance also expects the organisation to preserve evidence properly, perform unauthorised access investigation and response, analyse malicious code, and support fast recovery and future prevention.

###### HOW (specific steps/approach)
1. **Set up the integrated incident response team and define pod roles**: Create a formal team charter and a responsibility matrix covering the incident lead, evidence lead (digital evidence preservation), unauthorised access analyst, malicious code analyst (or a clear escalation route), a systems security and privacy engineering liaison, and real-time operations/engineering support. Make sure the team is “integrated” (cross-functional skills) and can be deployed across the organisation for resilience.
2. **Create distributed incident response pods with on-call activation**: Set up multiple regional pods (or one pod with a defined escalation or reinforcement approach) so that incident handling, evidence preservation, and operations support are available immediately. Malicious code analysis must be available either through an on-call rota or rapid escalation.
3. **Define deployable locations and the 2-hour dispatch model**: Keep an official list of deployable locations (for example, sites, data centres, and partner premises where relevant). Document how pods will be dispatched (on-call activation, travel or remote-first actions, and any pre-positioned kits) to show the pod can be deployed within 2 hours.
4. **Prepare response capability at each deployable location**: For each location, ensure approved digital evidence preservation materials and standardised triage and evidence collection tools (including access arrangements) are available. This allows the pod to start evidence preservation and analysis immediately after activation.
5. **Integrate case management and evidence handling**: Use a standard incident case process that triggers rapid evidence preservation steps, evidence recording, and handover to recovery or engineering teams. Ensure the process produces consistent records and supports consistent analysis across pods.
6. **Test and keep proof of timing**: Run location-specific exercises and tabletop scenarios, and carry out at least periodic timed drills. These must measure time-to-dispatch (from activation to pod arrival, or the equivalent remote-first evidence preservation action, based on the documented dispatch model). Keep audit-ready proof that the 2-hour requirement is met for each listed location.

###### WHO (role responsible)
- **Head of Cybersecurity / Computer Security Incident Response Team (CSIRT) Manager**: owns the integrated incident response team charter, pod model, and governance.
- **Incident Response Pod Leads (regional)**: ensure role coverage, readiness, and delivery of evidence preservation and analysis.
- **Security Operations Centre (SOC) / CSIRT Operations Manager**: owns on-call activation, integration of the case process, and scheduling exercises.
- **Forensic Lead / Malware Analyst Lead**: ensures digital evidence preservation and malicious code analysis capability.
- **Privacy and Security Engineering Liaison**: ensures privacy and security decision support is available during incidents.

###### Acceptance criteria
- A formal integrated incident response team charter exists, with responsibilities matching the required expertise areas (incident handling, digital evidence preservation, unauthorised access investigation and response, malicious code analysis, engineering and real-time operations support).
- A documented list of deployable locations exists, and for each location there is demonstrable evidence that the integrated incident response pod can be deployed within **2 hours** (per ir-04.11_odp) using the defined dispatch model.
- For each deployable location, evidence preservation and response materials (and access arrangements) are pre-positioned or available to enable rapid evidence preservation and analysis.
- Evidence of timed exercises and drills (including timing measures) is retained and shows the 2-hour dispatch requirement is met for all listed locations.
- The incident case process supports rapid evidence preservation, proper documentation, and handover to recovery and mitigation activities.

###### Actions Required for Compliance

- [ ] Set up the integrated incident response team and publish a responsibilities matrix covering incident handling, preserving evidence, investigating intrusions, analysing malicious code, coordinating with privacy and security engineering, and providing real-time operational support.
- [ ] Set up distributed incident response (IR) teams (“IR pods”) with clear on-call responsibilities and coverage for key roles, including a rota or a fast escalation route for analysing suspected malicious code.
- [ ] Create and keep an up-to-date, official list of deployable locations. For each location, document the dispatch approach to ensure the 2-hour requirement is met.
- [ ] Set up approved forensic and evidence-preservation kits, and the access arrangements needed to use them, at every location where teams may be deployed, so that forensic evidence can be preserved immediately and quickly.
- [ ] Set up a standard incident case process that starts evidence preservation, ensures the incident is documented, and hands the case over to the recovery and mitigation teams.
- [ ] Run time-based, location-specific practice drills and tabletop exercises, and keep audit-ready records showing that dispatch happens within 2 hours for every listed location.


---

#### IR-4.12 — Malicious Code and Forensic Analysis (Enhancement)

This expectation is about making sure that, after something suspicious happens, the organisation closely reviews any harmful code and any remaining traces found on the affected systems. The goal is to understand what the attacker did. Without this, the business may overlook hidden damage, fail to remove the real cause, and repeat the same mistakes in future incidents—leaving the organisation vulnerable to the same or similar attacks.

The organisation must follow its incident response and forensic procedures to identify and analyse any malicious code that remains. It must also review other leftover evidence, such as suspicious files, scripts, or data. This work must be carried out in a controlled, isolated environment to avoid spreading or destroying evidence.

The organisation then needs to record and keep the results of both analyses. These records should be used to learn how the attacker operated and to improve future incident handling, with clear responsibilities, approved analysis methods, and supporting documentation such as audit logs and case notes.

##### Isolated malware lab workflow for post-incident code/artifact analysis

- Category: Software
- Priority: Critical

###### WHAT
After a security incident, the organisation must **check any malicious software** and **any leftover items** still on affected systems. This must be done in a **controlled, isolated environment**. The organisation must then **write up and keep** the results of the analysis.

###### WHY (control requirement)
NIST SP 800-53 **IR-4(12)** requires the organisation to **analyse malicious software and/or other leftover items** that remain on the system after the incident. The guidance highlights that careful analysis in an **isolated environment** can help uncover an attacker’s **tactics, techniques, and procedures (TTPs)**, improving future incident response.

###### HOW (specific steps/approach)
Set up a repeatable, auditable “evidence-to-analysis” process that is started as part of incident response and produces structured forensic outputs.

1. **Trigger and define what to check after containment/eradication**: In the incident response playbook, add a clear step after containment and eradication to look for suspected leftovers (for example: dropped files, web shells, persistence mechanisms, changed scripts/services, suspicious scheduled tasks/cron jobs, registry “run” keys, cloud identity and access management (IAM) or OAuth grants, and mailbox rules).
2. **Collect evidence with chain-of-custody**: For each suspected item, collect a standard set of evidence for the platform (for example: file hashes, timestamps, file locations, process history where available, and relevant logs). Create an evidence manifest and record who collected what, when, and from where.
3. **Analyse only in an isolated malware analysis environment**: Use a dedicated analysis lab with **no direct connection to production networks** (and limit or disable outbound connections where feasible). Restrict access to forensic analysts only, and reset or snapshot the lab between cases.
4. **Do static analysis first, then dynamic analysis**:  
   - **Static**: calculate hashes, review metadata, check text strings, review embedded configuration, and extract indicators (domains, IP addresses, URLs, registry keys, and command templates).  
   - **Dynamic**: run the item only in the isolated environment, using monitoring to observe behaviour (such as process and file creation, persistence attempts, and network attempts captured within the lab).
5. **Check leftover items beyond the software itself**: Look for persistence and remaining traces (startup items, services, cron jobs, scheduled tasks, changed binaries/scripts, configuration changes, cloud authorisations, and other signs the compromise may still be active).
6. **Produce structured outputs that are ready to keep**: Store a case report that includes: what was found, how it was analysed, the evidence manifest, indicators (hashes/locations/domains/URLs), observed behaviour, and inferred TTPs. Keep the evidence and reports in the case management system with access logging.
7. **Use the results to improve detection**: Turn the extracted indicators and behaviours into detection engineering outputs (for example: security information and event management (SIEM) rules, endpoint detection and response (EDR) hunting queries, and security orchestration, automation and response (SOAR) enrichment steps). Record how each result links back to the incident case.

###### WHO (role responsible)
- **Incident Response Lead / security operations centre (SOC) Manager**: ensures the process is started and scoped correctly.
- **Digital Forensics Analyst / Malware Analyst**: collects evidence and performs analysis in the isolated lab.
- **Security Engineering (Detection Engineering)**: turns indicators and behaviours into monitoring and detection actions.
- **Case Management Owner**: ensures evidence and reports are retained, access is controlled, and audit logs are kept.

###### Acceptance criteria
- For at least one recent incident (or a validated tabletop exercise using sample items), the organisation produces an **evidence manifest** and a **structured analysis report** covering both **malicious software** and **residual artifacts**.
- All dynamic analysis is performed in the **isolated malware analysis environment** (with no route to production network connectivity).
- Reports include **indicators** (hashes and/or domains/URLs/paths) and **observed behaviour** sufficient to support TTP inference.
- Evidence and reports are retained with **documented chain-of-custody** and **access logging**.
- Extracted indicators and behaviours are clearly used to update at least one detection or hunting output, with traceability back to the incident case.

###### Actions Required for Compliance

- [ ] Update the incident response playbook to add a post-containment step to identify any remaining malicious code and related files or records, so they can be analysed.
- [ ] Define and put in place a standard “evidence manifest” format that records item details such as file checksums (hashes), the date and time (timestamps), file locations (paths), and relevant logs, and includes chain-of-custody information.
- [ ] Set up a dedicated, isolated malware analysis laboratory with limited access, controlled outbound internet connections, and the ability to take snapshots and reset the system to a clean state.
- [ ] Create an analysis runbook that carries out static analysis first, and only runs dynamic analysis inside an isolated laboratory.
- [ ] Create a structured analysis report template that captures: indicators, what was observed during activity, any remaining or continuing effects, and the likely tactics, techniques, and procedures (TTPs) inferred from the evidence.
- [ ] Set up retention and access logging for evidence manifests and analysis reports within the case management system
- [ ] Automate the transfer of extracted indicators and behaviours into security information and event management (SIEM) and endpoint detection and response (EDR) detection and hunting tools, with clear traceability back to the incident case.


---

#### IR-4.13 — Behavior Analysis (Enhancement)

This expectation is about noticing the clear signs that someone is probing or attacking your systems, and then working out exactly what they targeted and when. Without this, unusual activity—such as attempts to trigger decoy traps and secret “tripwires”, or suspicious behaviour during highly trusted log-ins—could be missed or misread, leaving you exposed to theft, disruption, or repeated attacks before you understand what happened.

To meet this requirement, the organisation must analyse any unusual or suspected hostile behaviour connected to its deception environment (honeypots and canary tokens), as well as activity during privileged access sessions and the related authentication records. This analysis must follow the organisation’s incident response policy and incident response plan, the documented monitoring methods it uses, and the actual monitoring records and relevant system settings.

The analysis must identify the specific resources that were targeted and the timing, apply the organisation’s agreed rules for what counts as genuinely suspicious versus likely false alarms, and clearly document the approach and evidence. This ensures the outcome can be traced and acted on.

##### Evidence-linked behaviour analysis playbooks for deception & privileged access

- Category: Software
- Priority: Critical

###### WHAT
Set up evidence-based investigation guides (often called “detection-as-code”) that review unusual or suspected hostile behaviour connected to the organisation’s defined **deception environments/resources** (for example, honeypots and canary tokens) and **privileged access sessions and authentication logs**. The guides must produce clear conclusions about **which resources were targeted** and **when**.

###### WHY (control requirement)
NIST SP 800-53 **IR-4(13)** (enhancement) requires the organisation to **analyse unusual or suspected hostile behaviour** in, or connected to, the organisation-defined **environments or resources** (parameter: `ir-04.13_odp`). The guidance also says that deception environments (including what was targeted and when) and unusual external behaviour (for example, changes in usage patterns) should be analysed using documented monitoring and incident response processes.

###### HOW (specific steps/approach)
1. **Create an investigation record template** for the guides. At minimum, it must capture: the targeted resource identifiers (for example, decoy/canary token ID, honeypot service/endpoint, admin portal/application, account), the analysis time window (start/end or the trigger time), the evidence log sources and fields, and the reasoning for the decision linked to the organisation’s defined thresholds.
2. **Build investigation workflows** (for example, security orchestration and automated response, and security information and event management (SIEM) automation) for:
   - **Deception alerts**: honeypot hits and canary token triggers.
   - **Privileged access anomalies**: privileged session information from privileged access management (PAM) and identity provider (IdP) (where available), plus linked admin actions.
   - **Authentication anomalies**: authentication events from the identity provider and SIEM (success/failure, multi-factor authentication (MFA), session start/end, and relevant session context).
3. **Collect evidence using documented monitoring methods**: each guide must pull data from the **actual monitoring records** for the defined time window, and must reference the exact log sources/fields used (including how time zones are handled and the correlation keys used to link events).
4. **Link events to targeted resources and timing**: use the deception platform’s token/decoy identifiers and the privileged/authentication event details to determine **which resources were targeted** and **when** (including rebuilding the incident timeline).
5. **Use the organisation’s defined thresholds for false alarms**: the guide must require an explicit threshold choice and record how that choice affects whether activity is treated as suspicious or likely harmless.
6. **Document the approach and evidence for audit purposes**: ensure the investigation output is a consistent, traceable record that can be reviewed and acted on, in line with the organisation’s incident response policy/plan.

###### WHO
- **Cybersecurity Detection Engineering / Security Operations Centre (SOC) Engineering**: builds the investigation guides, evidence templates, and automation.
- **Incident Response Lead**: checks that the approach matches the incident response policy/plan and the threshold rules.
- **Identity and Access Management (IAM) / Privileged Access Management (PAM) Owners**: provide the required telemetry mappings and correlation identifiers.
- **Security Operations Centre (SOC) Analysts**: use and review the guide outputs; provide feedback to improve thresholds and evidence fields.

###### Acceptance criteria
- For deception alerts (honeypot/canary), the guide output must identify **(a)** the specific decoy/token/resource targeted and **(b)** the incident timeline (at least the trigger time and the derived time window), with referenced evidence sources/fields.
- For privileged access and authentication events, the guide output must identify **(a)** the privileged/admin resource(s) and the account/session details involved and **(b)** the correlated timing window, with referenced evidence sources/fields.
- Each investigation record must include an explicit **threshold decision rationale** (false-positive/false-negative) and must be traceable to the organisation’s documented monitoring records.
- The guides must be clearly aligned to the organisation’s **incident response policy/plan** (for example, the required steps and documentation fields match the documented process).

###### Actions Required for Compliance

- [ ] Define and publish a standard format for recording investigations of IR-4(13) evidence, including specific resource identifiers to target and the time periods to analyse.
- [ ] Set up security automation playbooks using security information and event management (SIEM) and security orchestration, automation and response (SOAR) so that they respond when honeypots are triggered or when canary token alerts occur, and automatically gather evidence from the log sources listed in the documentation.
- [ ] Set up linked playbooks that review records of privileged access sessions and authentication activity to rebuild what happened over time and spot which administrator resources were specifically targeted.
- [ ] Set up playbooks to point to the exact log sources and fields, and ensure evidence collection uses time-window queries that follow the same time zone.
- [ ] Build the organisation’s agreed false positive and false negative thresholds into the playbook decision rules, and require a clear reason for the chosen threshold in every investigation record.
- [ ] Check that the playbook outputs match the incident response policy and plan, and run tabletop exercises to confirm that the right resources and timing are identified correctly.


---

#### IR-4.14 — Security Operations Center (Enhancement)

This requirement is about having a dedicated team that continuously monitors your organisation’s computer systems and networks, detects suspicious activity early, and coordinates a quick, sensible response. Without this, problems such as unauthorised access, malicious software (malware), or data theft can go unnoticed for too long, giving attackers more time to cause damage, disrupt services, or take advantage of weaknesses before anyone acts.

To meet this expectation, the organisation must set up and keep running a Security Operations Centre, either in-house or through a specialist provider, staffed by people with the right skills. It must clearly define who is responsible for handling incidents, who is responsible for managing service disruptions, and who is responsible for day-to-day monitoring.

The organisation must also maintain written procedures for incident handling and day-to-day operations, including an incident response plan and a contingency plan. It must ensure the team can collect and combine relevant security information from different parts of the environment so they can understand what is happening and take timely action.

##### Establish staffed SOC with SIEM correlation and incident workflows

- Category: Manual
- Priority: Critical

###### WHAT
Set up and run a Security Operations Centre (SOC) that continuously watches the organisation’s computer systems and networks. It should spot, investigate, and deal with cyber security incidents using security-relevant information collected from multiple places (for example, perimeter defences, network equipment, and endpoint monitoring tools).

###### WHY (control requirement)
NIST SP 800-53 **IR-4(14)** requires the organisation to **set up and maintain a SOC**. The guidance also says the SOC must be the main team responsible for **ongoing protection of the cyber infrastructure**. It must **spot, investigate, and respond to incidents quickly**, and put in place a mix of technical, management, and operational measures to **monitor, combine, link, analyse, and respond** to threat and security-relevant information from **multiple sources**.

###### HOW (specific approach)
###### 1) Define how the SOC will operate (people, process, coverage)
- Create an operating model that sets out coverage (for example, 24/7 or business hours with an on-call rota), escalation routes, and who is responsible for each stage of detection, investigation, containment, and recovery (including clear RACI ownership).
- Assign appropriately skilled technical and operational staff (for example, security analysts, incident response staff, and systems security engineers) and document what each role is responsible for.

###### 2) Bring in security data from multiple sources and link it together
- Configure the enterprise security information and event management (SIEM) system (or an equivalent security analytics platform) to collect security-relevant event data from:
  - **Perimeter defences** (for example, secure web gateway, firewalls, email security, and distributed denial of service (DDoS) controls)
  - **Network devices** (for example, routers, switches, and virtual private network (VPN) concentrators)
  - **Endpoint monitoring feeds** (for example, endpoint detection and response (EDR) telemetry from servers and workstations)
- Put events into consistent formats, ensure clocks are synchronised (using network time protocol (NTP)), and add helpful context (for example, tagging identities and asset importance) so the SOC can combine and link related events.

###### 3) Set up clear “detect to respond” steps with analyst involvement
- Create SOC workflows that follow the full incident process (acknowledge → triage → analyse → contain → remove the cause (eradicate) → recover → lessons learned).
- Use runbooks (security orchestration, automation, and response (SOAR)-style where available) to automate repeatable tasks (for example, adding context, creating tickets, collecting evidence, and suggesting containment actions), while requiring analyst approval before taking disruptive actions.

###### 4) Keep SOC and incident procedures documented, and test them
- Maintain documented SOC operating procedures and incident response procedures that match the SOC workflow.
- Make sure the SOC capability can be tested: run tabletop exercises and/or technical checks (for example, simulate representative alerts) and record results and improvements.

###### 5) Keep audit-ready proof that detection and response were timely
- For each incident, record the timing (timestamps), the detection source(s), investigation findings, actions taken, approvals (where required), and the reason for closing the incident.
- Track operational performance measures (for example, mean time to acknowledge (MTTA), mean time to resolve (MTTR), alert accuracy, and coverage gaps) and use them to improve detections and response.

###### WHO
- **SOC Manager / Security Operations Lead**: owns the SOC operating model, staffing plan, escalation arrangements, and governance.
- **Security Analysts (SOC)**: carry out triage, investigation, and evidence-based response actions.
- **Incident Response Lead**: owns incident response procedures, coordinates activity, and ensures learning after incidents.
- **Security Engineering / SIEM Engineer**: owns telemetry connections, event formatting, correlation rules, and runbooks.

###### Acceptance criteria
- A SOC is formally established, with documented roles, responsibilities, and a coverage model.
- The SIEM (or equivalent) collects and links security-relevant events from at least perimeter defences, network devices, and endpoint monitoring feeds.
- Documented SOC operating procedures and incident response procedures exist and are used in practice.
- Incident workflows include timely detection, analyst-led triage and investigation, and recorded evidence of actions taken.
- The SOC capability is tested (for example, tabletop exercises and/or detection validation) with documented results and follow-up remediation actions.

###### Actions Required for Compliance

- [ ] Define the security operations centre (SOC) operating model, including the hours it covers work, how issues are escalated, and who is responsible for detection, initial assessment, containment, and recovery (RACI).
- [ ] Assign security operations centre (SOC) roles (security analysts, incident response personnel, and security engineers) and document their responsibilities and required skills.
- [ ] Set up security information and event management (SIEM) and security analytics to collect security activity data from perimeter defences, network devices, and endpoint agents
- [ ] Set up event normalisation, time synchronisation, and added context (identity and asset criticality) so that related events can be linked together and you get a complete, end-to-end view of what is happening.
- [ ] Create security operations centre (SOC) incident workflows and playbooks that require human approval before taking disruptive actions, aligned to the incident lifecycle.
- [ ] Document security operations centre (SOC) operating procedures and incident response procedures, and run tabletop exercises and detection validation tests with recorded results.
- [ ] Create incident records that are ready for audit, including where the issue was detected, the analysis performed, who approved it, what actions were taken, and why the incident was closed.


---

#### IR-4.15 — Public Relations and Reputation Repair (Enhancement)

This requirement is about protecting the organisation’s public reputation when something goes wrong, and then actively rebuilding trust afterwards. If an incident becomes public or makes the organisation look bad, rumours and incomplete information can spread quickly. This can damage relationships with customers, partners, and other key people, and make it harder to continue normal day-to-day work.  

To meet this expectation, the organisation must treat public-facing incidents as a trigger to start planned public communications. It should decide in advance what will be said and how it will be shared. It must also include specific reputation-repair actions as part of its incident response, with the aim of restoring confidence among the people it serves.  

The organisation should set out these responsibilities in its incident response policy, procedures, and plans. It should ensure that the right named people are responsible for handling incidents and communications, and keep records showing that public relations and reputation-repair actions were carried out.

##### Incident PR playbooks and reputation repair workflow

- Category: Manual
- Priority: High

###### WHAT
Create and run public-relations (PR) response playbooks that are triggered when an incident becomes public (for example, media attention, a regulator notice, viral social media posts, or a public customer escalation). The playbooks must set out what communications will be sent, who must approve them, how often updates will be issued, and the specific actions needed to rebuild trust with the people affected.

###### WHY (control requirement)
IR-4(15) (Enhancement) guidance requires a strategy and planned actions to deal with incidents that come to the attention of the general public or that make the organisation look negative. This includes proactive reputation repair to re-establish trust and confidence.

###### HOW (specific steps/approach)
1. **Define what counts as “public visibility”** in the incident response plan (for example: “publicly reported outage”, “breach notification required”, “request for an executive statement”, “regulator enquiry received”, “major customer escalation to public channels”).
2. **Create PR playbooks for each type of incident** (for example: ransomware/data exposure/service outage/identity compromise). Each playbook should include approved holding statements, steps to verify facts, messages tailored to different groups (customers/partners/regulators/employees), and a schedule for how often updates will be issued.
3. **Set up an approval process** in the incident management and information technology service management (ITSM) system so that PR releases require sign-off by named roles (for example: Incident Response lead plus Communications/PR lead plus Legal/Privacy, where relevant) before anything is published.
4. **Record reputation-repair actions as part of every public incident**: for each public incident, the incident record must include a tracked list of reputation-repair actions (for example: customer remediation steps, transparency/reporting commitments, service restoration commitments) linked to the affected groups.
5. **Capture audit-ready evidence automatically and consistently**: store drafts, final statements, approval times, publication times, and proof that reputation-repair actions have been completed, all within the incident record.
6. **Limit access to PR tools and communication channels** using enterprise identity controls (role-based access control (RBAC), least privilege, and phishing-resistant multi-factor authentication (MFA) for PR approvers) to prevent unauthorised communications.
7. **Run regular tabletop exercises** for the PR playbooks using realistic scenarios to test that triggers are detected correctly, approvals happen on time, messages are accurate, and reputation-repair actions are carried out.

###### WHO
- **Incident Response Lead / Security Operations Centre (SOC) Manager**: activates the playbooks based on the triggers and ensures the incident record is complete.
- **Communications/PR Lead**: owns the messaging templates, update schedule, and publication coordination.
- **Legal/Privacy (where applicable)**: approves legally sensitive statements and any notification-related content.
- **Chief Information Security Officer (CISO)** / Information Security: ensures communications align with verified security facts and the incident scope.
- **ITSM/Workflow Owner**: implements and maintains the approval process and evidence capture.

###### Acceptance criteria
- Public-visibility triggers are documented and linked to playbook activation in the incident response plan.
- For each public incident, the incident record includes: (a) the activated playbook reference, (b) approval evidence for every published statement, (c) publication timestamps, and (d) a tracked reputation-repair action list linked to affected groups, including completion evidence.
- PR approvals are enforced through workflow controls (nothing is published without the required sign-off).
- Access to PR tools and channels is limited to named roles using least privilege, with phishing-resistant multi-factor authentication (MFA) for approvers.
- At least one tabletop exercise per year validates end-to-end PR activation, approval, and reputation-repair execution.

###### Actions Required for Compliance

- [ ] Document the situations that make information publicly visible, and link each one to a specific incident response playbook in the incident response plan.
- [ ] Create incident response playbooks for the most common incident types. Each playbook should include holding statements, frequently asked questions (FAQs), verification steps, and a schedule for how often updates will be provided.
- [ ] Set up the IT service management (ITSM) incident process so that named approvals are required before anything is publicly released. Approvals must come from the Incident Response lead, the Communications/Public Relations (PR) lead, and Legal/Privacy where applicable.
- [ ] Add a “reputation repair” action workstream to the incident record template. Link it to the affected stakeholders and include clear, measurable proof that the work has been completed.
- [ ] Record evidence for public relations (PR) activity in the incident file, including drafts, approvals, publication dates and times, and confirmation that reputation repair has been completed.
- [ ] Limit access to tools used to run pull requests and to publish content, using least-privilege roles and phishing-resistant multi-factor authentication (MFA) for approvers.
- [ ] Run and record at least one tabletop exercise each year to check that the trigger activates correctly, approvals happen at the right time, messages are accurate, and reputation-repair actions are carried out as intended.


---

### IR-5 — Incident Monitoring (Control)

This requirement is about making sure every security incident is noticed, recorded, and fully dealt with, with a clear written record. Without this, incidents can be missed, important details can be lost, and the organisation may not be able to understand what happened, protect people and systems properly, or learn how to stop the same problem happening again.

The organisation is expected to track every incident by creating and maintaining a separate record for it, keeping the record’s current status up to date as the incident moves from the first report through investigation and resolution, and recording enough information to support later investigation and review. It should collect incident information from all relevant sources, such as alerts from system or network monitoring, reports from incident response teams, user complaints, reports from supply-chain partners, audit and physical-access monitoring, and reports from users and administrators.

It must also have documented procedures and named responsibilities for incident monitoring, ensure these are reflected in its incident response planning and related plans, and keep the records and supporting evidence available and retrievable for authorised staff.

##### Incident register with mandatory fields, status timeline, and evidence links

- Category: Software
- Priority: Critical

###### WHAT must be done
Set up an incident monitoring capability that **tracks and records incidents** by creating a **separate, unique incident record for each incident**, keeping its **current status** along with a **history/timeline of status changes**, and recording **enough information and references to supporting evidence** to support investigations (forensics) and later review, as well as identifying patterns and trends.

###### WHY (control requirement)
NIST IR-5 requires the organisation to **track and document incidents**. The guidance says that documenting incidents means keeping records for **each incident**, including its **status** and other relevant information needed for **forensics** and for **assessing incident details, trends, and how incidents are handled**. Incident information can come from multiple sources, for example: monitoring alerts, incident response team reports, user complaints, supply chain partners, audit monitoring, physical access monitoring, and user or administrator reports.

###### HOW (specific steps/approach)
1. **Define a standard incident record format** in the incident management system (case/incident register) with required fields: unique incident ID, incident type/source, time detected/reported, affected assets/services, initial description, current status, status history/timeline, assigned owner/team, and fields for investigation notes and outcomes from the post-incident review.
2. **Set up status tracking with enforced stages** (for example: Reported → Triage → Investigating → Contained → Resolved/Closed) and require every status change to include: date and time, the user or role making the change, and a short reason. Make sure the system keeps an **unchangeable record** (audit trail) of all status changes.
3. **Link evidence to incidents**: connect the incident record to the organisation’s controlled evidence/log storage (for example, a log vault, packet capture storage, and endpoint detection and response (EDR) investigation reports). The incident record must store **references/links** to specific evidence items (not just written summaries) so authorised staff can retrieve the material needed for forensics.
4. **Allow incident intake from multiple sources** by connecting common reporting channels to the same incident register: security information and event management (SIEM) and security orchestration, automation and response (SOAR) alerts, EDR alerts, helpdesk/email-to-ticket, and (where applicable) partner/audit/physical access monitoring feeds. Each intake must use the same incident record format and fill in the incident’s source fields.
5. **Add post-incident review fields and templates** to support trend analysis: impact assessment, contributing factors/root cause (as determined), lessons learned, and follow-up actions with owners and due dates. Require these fields (or an explicit “not yet available” state with justification) before closure.
6. **Run the monitoring as part of day-to-day operations** by assigning responsibilities in the workflow (for example, triage owner, investigation owner, evidence curator) and ensuring the incident response plan points to the incident register workflow so incident monitoring is carried out consistently.

###### WHO (role responsible)
- **Cybersecurity Incident Response Lead**: owns the incident record format, the status stages, and the requirements for closure and post-incident review.
- **Security Operations Centre (SOC)/Incident Management Team**: runs the intake workflows, updates triage/investigation information, and ensures evidence links are created.
- **Platform/Integration Engineer**: builds the integrations for SIEM/SOAR/EDR/helpdesk and the evidence repository.
- **Data Protection/Privacy Officer (where applicable)**: checks that retention and access rules for incident records and evidence references match privacy requirements.

###### Acceptance criteria
- For every incident intake event (from connected sources), the system creates a **unique incident record** with all required fields completed.
- Each incident record shows a **complete status history/timeline** including timestamps, who made each change, and the reason for each change.
- Incident records include **evidence references/links** to controlled evidence items sufficient to support forensics.
- Closure requires completion (or a justified delay) of **post-incident review** fields (impact, lessons learned, and follow-up actions with owners and due dates).
- The incident register keeps an **audit trail** showing who updated status and when.

###### Actions Required for Compliance

- [ ] Create an incident record template with required fields for a unique ID, current status, timeline, affected assets, investigation notes, and the results of the post-incident review.
- [ ] Set up incident “life cycle” stages and require specific details whenever an incident status changes (time, who or what role made the change, and the reason). Keep an unchangeable audit record of every change.
- [ ] Integrate security information and event management (SIEM), security orchestration, automation and response (SOAR), and endpoint detection and response (EDR) alert sources to automatically create or link related incidents in the central incident register.
- [ ] Combine helpdesk, email, and other reporting channels into a single incident reporting process, using consistent categorisation for the type of source.
- [ ] Set up a way to link incident records to the controlled evidence and log repository, and require that every investigation step includes a reference to the relevant evidence.
- [ ] Create templates for post-incident reviews and require them to be completed (or formally delayed with a valid reason) before the incident is closed.


---

#### IR-5.1 — Automated Tracking, Data Collection, and Analysis (Enhancement)

This requirement is about ensuring security incidents are recorded, collected, and reviewed in a consistent, automated way, rather than relying on scattered emails or guesswork. Without this, important information about what happened, when it happened, and who is dealing with it can be missed or lost, which delays action and increases the risk that the same issue repeats or causes greater harm.

The organisation is expected to use its Department of Defence (DoD) incident ticketing system and security operations centre (SOC) case management database to track every incident. It must automatically gather incident details from its monitoring alerts and from information collected from devices and networks, and store everything in a central incident repository for later review.

It must also automatically analyse the incident information using its built-in analysis rules, automated response workflows, and forensic analysis dashboards. At the same time, it must keep clear written procedures, records, and plans showing how monitoring is carried out and who is responsible, with the ability to support monitoring around the clock.

##### Automate incident tracking, collection, and analysis via IR + SIEM/SOAR

- Category: Software
- Priority: Critical

###### WHAT
Set up automated incident tracking, data collection, and analysis using the organisation’s approved automated tools: the Department of Defence (DoD) incident response (IR) ticketing system, the security information and event management (SIEM) incident database, and 24x7 security operations centre (SOC) monitoring tools. Make sure all incidents are recorded in a single central incident repository. Incident details should be automatically gathered from SIEM alerts and endpoint and network activity data, then automatically analysed using SIEM correlation rules, security orchestration, automation and response (SOAR) playbooks, and forensic analytics dashboards.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 **IR-5(1)** enhancement requires that the organisation **track incidents and collect and analyse incident information using {{ insert: param, ir-5.1_prm_1 }}**. The guidance expects automated mechanisms such as **electronic incident databases** and **network monitoring devices**.

###### HOW (specific steps/approach)
1. **Define one incident/case identifier approach** (case ID) used as the matching key across the DoD IR ticketing system, SIEM incident database, SOAR orchestration, and telemetry sources.
2. **Automate incident creation and linking**: configure the SIEM to either (a) create incident records in the DoD IR ticketing system automatically, or (b) link SIEM-generated incidents to existing IR cases without manual re-entry. Ensure the required structured details (time, affected assets, users, detection source, severity, indicators) are mapped into the case.
3. **Automate collection from telemetry**: connect endpoint and network monitoring feeds so that relevant activity data (for example, process and network events, authentication events, flow records, and intrusion detection system/intrusion prevention system (IDS/IPS) alerts) is automatically attached to the correct IR case using the case ID and/or matching keys (asset/user/time window).
4. **Automate analysis**:
   - Set up **SIEM correlation rules** to produce correlation summaries and write the results into the structured fields of the case.
   - Use **SOAR playbooks** to add context to the case (asset and user details), retrieve the relevant activity data and evidence, and record the playbook run status and outputs in the case timeline.
   - Link **forensic analytics dashboards** so standard investigation views (for example, timeline reconstruction, entity/graph views, and user and entity behaviour analytics (UEBA) outputs) are produced and automatically attached to the case.
5. **Ensure central storage and auditability**: store incident information centrally in the incident repository, including an audit trail that records ingestion, enrichment, analysis outputs, and evidence attachments.
6. **Run the workflow for 24x7 monitoring**: ensure the automated process is continuously available for SOC operations (including defined failover/retry behaviour for integrations) so incident tracking and analysis support 24x7 monitoring.

###### WHO (role responsible)
- **SOC Engineering Lead / Security Automation Engineer**: implement SIEM-to-IR integration, SOAR playbooks, and telemetry ingestion.
- **SOC Manager**: confirm the workflow meets operational expectations and produces the required triage and analysis outcomes.
- **IR/Incident Response Lead**: approve the case data structure, the evidence handling approach, and the analysis outputs needed for investigations.

###### Acceptance criteria (verifiable)
- For a test incident generated in the SIEM, an IR case is **automatically created or linked** within an agreed time window, with the correct structured fields completed.
- For the same incident, **endpoint and network telemetry** relevant to the case is **automatically attached** to the IR case (no manual copy/paste required).
- **SIEM correlation outputs** appear in the case as structured analysis results.
- **SOAR playbooks** run automatically for the defined detection patterns and record execution status and outputs in the case timeline.
- **Forensic dashboard outputs** are generated and automatically linked/attached to the case.
- The incident repository includes an **audit trail** covering ingestion, enrichment, analysis, and evidence attachment actions.
- The workflow runs continuously for 24x7 SOC monitoring (integration outages trigger defined retry/failover behaviour and do not silently drop incident data).

###### Actions Required for Compliance

- [ ] Define and put in place one consistent incident or case reference number across the Department of Defense (DoD) incident response (IR) process, security information and event management (SIEM), security orchestration, automation and response (SOAR), and all telemetry data sources.
- [ ] Set up security information and event management (SIEM) so it can automatically create or connect incident records in the Department of Defense (DoD) incident ticketing system, using mapped structured fields.
- [ ] Integrate endpoint and network monitoring data so that any alerts or evidence are automatically linked to the correct incident response (IR) case using matching correlation keys.
- [ ] Set up security information and event management (SIEM) rules to combine related alerts and automatically write the resulting summaries and analysis into structured case fields.
- [ ] Develop and deploy security orchestration, automation and response (SOAR) playbooks to add useful information to cases, gather evidence, carry out only authorised actions, and record the playbook results in the case timeline.
- [ ] Connect forensic analytics dashboards to automatically create and link standard investigation reports to the incident response (IR) case.
- [ ] Test the full end-to-end service to ensure it runs correctly 24 hours a day, 7 days a week, using test incidents, and confirm that the audit trail covers the full process from data intake and enrichment through analysis and attaching evidence.


---

### IR-6 — Incident Reporting (Control)

This requirement is about making sure that if anyone suspects something has gone wrong—such as suspicious activity, a possible data breach, or unusual system behaviour—they report it quickly to the organisation’s incident reporting team. The risk it addresses is that delays or unclear reporting can allow harm to spread, make the problem harder to contain, and increase the chance that sensitive information is lost or misused before the right people can act.  

To meet this expectation, the organisation must clearly state who is responsible for reporting, provide simple instructions and practical ways for staff to submit reports, and ensure suspected incidents are reported within 24 hours of the concern being noticed.  

When a report is made, the organisation must send the incident details to the Security Operations Centre incident response lead and also to the Department of Defence (DoD) Cyber Incident Reporting mailbox, and keep records and supporting documents showing what was reported and when.

##### Identity-authenticated incident reporting workflow with SOC routing

- Category: Software
- Priority: Critical

###### WHAT
Set up an identity-checked process for reporting a “suspected incident” that creates a time-stamped Security Operations Centre (SOC) case and automatically notifies the named reporting authorities.

###### WHY (control requirement)
IR-6 requires staff to report suspected incidents to the organisation’s incident response capability within the defined **time period**, and to report incident information to the defined **authorities**. The organisation’s defined parameters are:
- **time period:** staff must report suspected incidents **within 24 hours** of becoming aware of the suspicion.
- **authorities:** incident information must be reported to the **Security Operations Centre (SOC) incident response lead** and the **Department of Defense (DoD) Cyber Incident Reporting mailbox**.

###### HOW (specific steps/approach)
1. **Create one organisation-approved reporting channel** (for example, an internal web/mobile portal or an in-app form) with a guided “suspected incident” submission process.
2. **Link the portal to the organisation’s identity system** using single sign-on (SSO), so submissions are verified and linked to a specific user account (including contractors/partners where applicable).
3. **Link submissions to SOC case management**, so each report automatically creates a case/ticket that includes: submission time, reporter identity, affected system/asset (if provided), incident category, and the reporter’s description and attachments.
4. **Automatically notify the required authorities**:
   - send/route the case to the **SOC incident response lead**; and
   - send a structured incident notification to the **DoD Cyber Incident Reporting mailbox** (using an approved email connection or secure messaging), including the same key information.
5. **Make the 24-hour reporting expectation operational** by adding workflow time checks and escalation rules (for example, SOC acknowledgement/triage escalation if the case is not acted on within an internal target), while ensuring the system records the submission time for audit purposes.
6. **Keep audit-ready records**: store the submission record, case timeline, notification delivery status, and supporting attachments in line with the organisation’s retention requirements.

###### WHO
- **Application owner / Security engineering lead:** implement the reporting process and integrations.
- **SOC incident response lead:** receives routed cases and confirms acknowledgement/triage.
- **Identity and access management (IAM) team:** supports identity system integration and access controls.
- **Compliance/Governance, Risk and Compliance (GRC):** checks evidence and confirms alignment to IR-6 reporting authorities and timing requirements.

###### Acceptance criteria
- A user can submit a “suspected incident” report through the approved channel, and the submission is **time-stamped** and linked to an authenticated identity.
- For each submission, the system automatically:
  - creates a SOC case and routes/assigns it to the **SOC incident response lead**; and
  - sends an incident notification to the **DoD Cyber Incident Reporting mailbox** with the required information.
- Evidence exists for each report showing **what was reported and when** (submission time, case creation time, and notification delivery status).
- The solution demonstrates it can meet the **within 24 hours** expectation (for example, by testing a submission and confirming the workflow records the submission time and sends authority notifications immediately).

###### Actions Required for Compliance

- [ ] Design and publish an organisation-approved “suspected incident” reporting form or portal, and use it as the single place to submit reports.
- [ ] Integrate the portal with the organisation’s identity provider (IdP) so that submissions are authenticated and include the required user details (attributes).
- [ ] Set up security operations centre (SOC) case management so that every submission automatically creates a case, including time and date stamps and all required information fields.
- [ ] Set up automated routing and assignment of each security incident to the security operations centre (SOC) incident response lead, and automatically notify the Department of Defense (DoD) Cyber Incident Reporting mailbox.
- [ ] Add automated workflow timing and escalation rules, and make sure the submission, case, and notification dates and times are recorded so there is audit evidence.
- [ ] Check that end-to-end reporting works by submitting tests, and confirm that evidence is kept so you can see what was reported and when.


---

#### IR-6.1 — Automated Reporting (Enhancement)

This expectation is about ensuring that, when something goes wrong, the organisation automatically creates and shares the correct incident report. It should not depend on people copying, pasting, or remembering steps. Without this, important information could be delayed, sent to the wrong people, left out, or shared in different formats, which increases the risk that problems spread further or are not dealt with quickly and properly.

To meet this expectation, the organisation must use automated incident reporting methods that:
1. use incident-reporting software to generate or prepare the report,
2. send the report to the named recipients using automatically generated emails, and
3. publish incident reports on the organisation’s website, with automatic updates when the content changes.

This approach must follow the organisation’s incident reporting policy and procedures. It must also be supported by how the systems are designed and set up, as shown in the relevant plans and documentation, and there must be records to prove that the automation works as intended.

##### Automated incident reporting via IR platform email and web publishing

- Category: Software
- Priority: Critical

###### WHAT
Set up automated incident reporting so that, when an incident happens, the system automatically creates the incident report, sends it to the approved recipients, and publishes or updates it on the organisation’s website—without anyone having to copy and paste information manually.

###### WHY (control requirement)
NIST Special Publication 800-53 Incident Reporting (IR-6(1)) (enhancement) requires: **“Report incidents using {{ insert: param, ir-06.01_odp }}.”** The organisation-defined parameter **ir-06.01_odp** specifies **automated mechanisms** (automated incident response tools, automated email notifications, and website posting with automatic updates). This enhancement is only met when incident reporting is done through these automated mechanisms.

###### HOW (specific steps/approach)
1. **Use an incident management / security orchestration, automation and response (SOAR)-capable platform as the workflow engine** (the system that holds the incident record and produces the report content).
2. **Set reporting triggers that match the incident lifecycle** in the platform (for example, when an incident is marked “confirmed” or when a severity threshold is reached), and link those triggers to the organisation’s incident reporting process.
3. **Set up automated report creation** using templates that pull the required incident details (timestamps, severity, affected services, evidence links, and impact/containment actions) from the incident record.
4. **Set up automated email notifications** from the platform to the recipients listed in **IR-6b** (use recipient groups or roles from the platform and identity integration, rather than manually entered email addresses).
5. **Set up website publishing with automatic updates** by connecting the platform to the organisation’s website/content management system (CMS):
   - Prefer an application programming interface (API) or webhook “push” from the platform to the CMS, or
   - Use a scheduled, read-only synchronisation job that generates incident pages from the incident record.
   Make sure the website updates whenever the incident report content changes (for example, status, severity, or evidence updates).
6. **Secure the integration paths** (use least-privilege service identities, allow only approved destination addresses, and restrict administrative access) so the automated reporting cannot be altered.
7. **Keep audit-ready proof that the automation worked as intended**:
   - Workflow execution logs from the platform for report creation,
   - Email delivery logs (message identifiers, timestamps, and recipient list), and
   - Website publish/update logs (page or version identifiers and timestamps).

###### WHO (role responsible)
- **Security Operations Lead / Incident Manager**: owns the mapping of the incident reporting workflow to IR-6b and checks the report content.
- **Platform Owner (SecOps/IT service management (ITSM)/SOAR)**: sets up templates, triggers, and notification rules.
- **Web/CMS Owner**: sets up the publishing connection and ensures updates happen automatically.
- **Identity and access management (IAM) / Integration Engineer**: sets up least-privilege service identities and network restrictions for the integration endpoints.

###### Acceptance criteria
- When an incident reaches the configured reporting trigger state, the platform **automatically generates** the incident report content.
- The platform **automatically sends** the report by email to the **IR-6b recipients** (no manual emailing required).
- The platform **automatically publishes and updates** the incident report on the website when the incident report content changes.
- There is evidence from at least one end-to-end test incident showing: workflow execution, email delivery, and website publish/update events, including timestamps and identifiers.

###### Actions Required for Compliance

- [ ] Choose and set up an incident management and security automation, orchestration, and response (SOAR) platform to run the incident reporting process as the workflow engine.
- [ ] Define the stages of an incident and link each stage to the automated reporting triggers that match the organisation’s incident reporting procedure.
- [ ] Create incident report templates in the platform that automatically fill in the required fields from the incident record.
- [ ] Set up automated email alerts for the IR-6b recipient groups or job roles, and confirm that the email delivery records are being captured.
- [ ] Integrate the platform with the organisation’s website/content management system (CMS) so incident reports are automatically published and kept up to date, using an application programming interface (API) and/or webhooks, or a scheduled synchronisation.
- [ ] Set up service accounts with the minimum permissions needed (least-privilege) and restrict network access using an allow-list for the email and website publishing integrations.
- [ ] Run an end-to-end test incident and keep records of evidence for workflow completion, email delivery, and website publish or update events.


---

#### IR-6.2 — Vulnerabilities Related to Incidents (Enhancement)

This requirement ensures that, when a security incident occurs, any weaknesses identified during that incident are quickly escalated to the right decision-makers. The real-world risk is that a problem found part-way through an incident could be overlooked or treated as a one-off event, leaving the same weakness in place so it can be exploited again—leading to further disruption, loss, or harm to the organisation and the people it serves.

To meet this expectation, the organisation must:
- identify any system weaknesses linked to the reported incident;
- record them in the incident report; and
- submit the details through its established incident reporting process to the system owner, the mission or business owner, the senior information security lead, the senior privacy lead, the authorised decision-maker, and the risk executive.

The organisation must then analyse the findings with these leaders, use the results to prioritise what to fix first, begin appropriate remedial actions, and keep records showing what was reported, analysed, and decided.

##### Incident-to-vulnerability reporting workflow to required leadership roles

- Category: Software
- Priority: Critical

###### WHAT
Set up an incident-handling process that captures vulnerabilities found during security incidents, records them in the organisation’s incident reporting system, and sends the vulnerability details to the required people/roles for analysis and risk-based prioritisation.

###### WHY (control requirement)
NIST Special Publication 800-53 **IR-6(2)** requires that **system vulnerabilities linked to reported incidents** are **reported to the people or roles named in param: ir-06.02_odp**. The guidance also requires that vulnerabilities related to incidents are analysed by organisational staff, including **system owners, mission/business owners, senior agency information security officers, senior agency officials for privacy, authorising officials, and the risk executive (function)**. The analysis must then be used to prioritise and start mitigation.

###### HOW (specific steps/approach)
1. **Extend the incident reporting record** to include clear fields for “vulnerability discovered”, affected asset(s)/component(s), evidence links, suspected weakness type, and confidence/impact notes.
2. **Add an incident triage gate**: if an incident is marked as uncovering a vulnerability, the workflow must automatically create a “vulnerability associated with incident” section/package within the same incident record (or a linked vulnerability record) using the captured evidence.
3. **Route for analysis to the required roles** (as per **ir-06.02_odp**) using workflow approvals/notifications that are auditable and time-stamped (no informal email handling).
4. **Require analysis outputs before closing the incident**: the workflow must record that the required roles reviewed the vulnerability linked to the incident and documented their decisions (for example, prioritisation outcome, mitigation started, or a documented risk acceptance route).
5. **Start mitigation based on analysis results**: create or attach remediation tasks in the organisation’s change/vulnerability management process, using severity-based service-level agreements and linking them back to the incident/vulnerability package.
6. **Keep audit-ready evidence**: ensure the incident record retains the vulnerability details, proof of role involvement, analysis notes/decisions, and links to mitigation tasks.

###### WHO (role responsible)
- **Security Operations Lead / Incident Manager**: owns the workflow design, triage gate, and incident record requirements.
- **System Owner / Mission-Business Owner**: provides technical and business impact input during analysis.
- **Senior Information Security Officer & Privacy Senior Official**: confirms security and privacy implications.
- **Authorising Official & Risk Executive (function)**: records risk decisions and prioritisation outcomes.
- **Governance, Risk and Compliance (GRC) / Compliance Analyst**: checks that audit evidence for IR-6(2) is complete.

###### Acceptance criteria
- For any incident where analysts identify a vulnerability, the incident record includes a complete “incident-related vulnerability” package (affected assets/components, evidence links, and weakness description).
- The workflow sends the vulnerability package to **all roles listed in ir-06.02_odp** and records evidence of their involvement.
- The incident cannot be closed (or marked resolved) without recording analysis outcomes and either starting mitigation or documenting the risk decision route.
- Mitigation tasks created from the analysis must be traceable back to the incident/vulnerability package and be auditable.

###### Actions Required for Compliance

- [ ] Update the incident reporting template to include fields for vulnerability information linked to the incident, including affected systems or components, links to supporting evidence, the weakness type, and the confidence and impact levels.
- [ ] Set up an incident triage rule that creates a vulnerability package whenever an incident is labelled as uncovering a vulnerability.
- [ ] Set up a workflow that routes the vulnerability report for review and approval to the roles listed in **ir-06.02_odp**, and keep time-stamped records showing who took part.
- [ ] Require a closure check that confirms the captured analysis results have been reviewed by the required roles, and that there is a recorded decision showing how issues were prioritised and mitigated, or how the risk decision was made.
- [ ] Integrate the workflow with the organisation’s change and vulnerability management process to create trackable repair tasks, with response times based on severity (service level agreements, SLAs).
- [ ] Check that audit evidence is being produced correctly by running test incidents and confirming that each incident record links to the vulnerability details, shows which roles were involved, records the analysis decisions made, and includes the mitigation actions taken.


---

#### IR-6.3 — Supply Chain Coordination (Enhancement)

This requirement is about making sure that, if something goes wrong that involves a supplier’s product or part of your supply chain, you quickly and clearly inform the right external parties about what happened. If you do not, the supplier and other involved organisations may not be able to stop the problem, protect customers, or fix the root cause—allowing the same weakness to spread through deliveries, installations, or ongoing services.

To meet this expectation, the organisation must:
- define what counts as a supply-chain-related incident
- name specific people to coordinate reporting
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

###### WHAT
Set up an incident-handling process that, once a **supply-chain-related incident** is identified, automatically coordinates and records the **external incident information** that must be sent to the **product/service provider** and other **supply-chain organisations involved**, and (where applicable) the relevant **supply-chain governance body**.

###### WHY (control requirement)
This requirement from NIST IR-6(3) enhancement says: **“Provide incident information to the provider of the product or service and other organizations involved in the supply chain or supply chain governance for systems or system components related to the incident.”** It also expects us to decide **what information to share** based on the incident and the **benefit gained** from informing external organisations.

###### HOW (specific steps/approach)
1. **Define the trigger and scope**: Update your incident categories to include supply-chain incident types (for example: compromised supplier update, malicious dependency, tainted component, breach of a supplier-hosted service, or compromise during distribution/warehousing). For each type, identify the affected roles: **supplier/provider/integrator/distributor/reseller**.
2. **Create a “Supply-chain Coordination” playbook** in your incident management system (for example, ServiceNow/Jira). The playbook must require structured information for outbound notifications, including: affected component/product identifiers, affected versions/serial numbers, time of detection/identification, a summary of impact, indicators (where applicable), containment actions taken, and the **actions requested from the provider**.
3. **Apply policy-based sharing checks** (policy-as-code or equivalent workflow rules) to enforce:
   - approval for what can be shared (for example, sensitive indicators, forensic evidence, references to customer data),
   - correct recipient selection based on the supplier/provider mapping and contractual/service-level agreement (SLA) notification clauses,
   - escalation to supply-chain governance bodies **where applicable** (for example, governance routing rules set up to meet the organisation’s procurement/governance obligations).
4. **Automate recipient selection** using a maintained list of supplier/provider parties (from procurement, supplier management, and contract information) so the workflow sends notifications to the correct external parties (provider, integrators, distributors, resellers, and so on) for the affected component.
5. **Keep evidence for audit purposes** for every external notification: a summary of the message content (or template reference), recipients, dates and times, approvers, and the reason the information was appropriate and justified.

###### WHO (role responsible)
- **Incident Response Lead / Security Operations Centre (SOC) Lead**: starts the supply-chain incident playbook and ensures the incident is classified correctly.
- **Supply-Chain Risk Manager / Procurement Security**: maintains the supplier/provider mapping and governance routing rules.
- **Information Security (or Security Governance) Approver**: approves what information is safe and appropriate to share.
- **Legal/Contracts (as needed)**: confirms contractual/SLA notification requirements and whether the supply-chain governance body applies.

###### Acceptance criteria
- A supply-chain incident can be classified using the defined categories and triggers the workflow.
- For each triggered incident, the system produces an auditable record showing: **who was notified**, **what was shared**, **when**, **who approved**, and **why**.
- The workflow automatically selects the correct external parties based on maintained supplier/provider mappings and contractual/SLA notification requirements.
- Notification routing to the governance body is implemented for applicable cases (configured according to the organisation’s procurement/governance obligations).
- External notifications cannot be sent unless all required playbook fields are completed and the required approvals are obtained for sensitive content.

###### Actions Required for Compliance

- [ ] Extend the incident categories to include supply-chain incident types, and link each type to the supplier or provider roles that are affected.
- [ ] Create a supply-chain coordination playbook and define the required outbound notification fields in the incident management system.
- [ ] Set up policy-based sharing controls that require approval before sharing sensitive indicators, and apply rules to ensure recipients are selected correctly.
- [ ] Add supplier or provider party mapping from procurement, vendor management, and contract information into the process used to decide who the recipient should be.
- [ ] Set up routing rules for the governance body to handle relevant supply-chain governance obligations (for example, the Financial Account Security Controls (FASC) where applicable).
- [ ] Enable auditable records for every external notification, including the recipients, date and time, approvers, a summary of the message template and content, and the reason for sending it.


---

### IR-7 — Incident Response Assistance (Control)

This expectation is about making sure people have a clear, reliable way to get help when something goes wrong, so they can quickly understand what to do and how to report it. Without this, suspicious events or real incidents may be dealt with in different ways, reported too late, or reported without enough detail. That can make damage worse, slow down recovery, and increase the risk of harm to customers and the organisation.

To meet this expectation, the organisation must provide an incident support route as part of its incident response capability. It must be available to users of the relevant systems and include practical guidance on both handling incidents and reporting them. This should be delivered through agreed support options such as a help desk, an assistance team, or an automated reporting and tracking process. It must also include access to specialist forensic support and, where needed, services to support consumer redress.

The organisation must name specific people responsible for this support, make sure they can access the tools needed to provide help, document the support process in its incident response documents, and keep its privacy and system security plans connected to how support is provided.

##### Incident report & triage service desk with guided playbooks

- Category: Software
- Priority: Critical

###### WHAT
Provide an incident response support service that is part of the organisation’s incident response capability and gives system users clear guidance on what to do and how to report incidents. Deliver this through a user-facing support route (service desk portal, phone, or email-to-ticket) that automatically creates and tracks tickets, uses guided step-by-step instructions for users, routes each ticket to the correct incident response team, and escalates to digital forensics and (where needed) consumer redress.

###### WHY (control requirement)
IR-7 requires the organisation to “provide an incident response support resource, integral to the organizational incident response capability” that offers advice and help to system users for the “handling and reporting of incidents”. The guidance specifically includes help desks, support groups, automated ticketing systems to open and track incident response tickets, and access to digital forensics services or consumer redress services when required.

###### HOW (specific steps/approach)
1. **Create one incident reporting entry point** in the service desk (portal form + phone + email-to-ticket) and publish it on the application’s user help or landing pages and in internal support documentation. Make sure it is clearly labelled **“Incident reporting / Report & Triage”**.
2. **Use guided, role-appropriate instructions** during the ticket intake process (for example: suspected phishing, suspected malware, unauthorised access, data exposure). Each set of instructions must include:
   - immediate actions (what to do now),
   - prompts to preserve evidence (what not to change or delete),
   - required reporting details (what to include).
3. **Automate ticket capture and tracking**: connect the service desk to the enterprise identity provider so tickets are created with user and context information (user, group or role, device or location where available, and timestamps) without asking users to paste sensitive information. Set ticket stages to match the incident response process (for example: **Received → Triaged → Assigned → Investigating → Contained/Eradicated → Recovered → Closed**) and require fields for evidence and communications.
4. **Route tickets to the correct incident response queue** using automated rules based on incident category, affected system or application, severity, and business unit. Ensure triage and assignment responsibilities are reflected in the workflow (queue ownership, named resolver groups, and escalation routes).
5. **Add escalation steps for specialist services**: include clear workflow actions to request **digital forensics** (create a forensics work order and trigger required approvals) and, where applicable, **consumer redress/legal review** (create a separate work order and trigger the required approval chain).
6. **Document and link the support process** in the organisation’s incident response documentation. Ensure the system security plan and privacy plan reference the incident response support mechanism and escalation routes (for example: where the support route is accessed, what information is collected, and how it is handled).

###### WHO
- **Cybersecurity Incident Response Lead**: owns the incident response support workflow, the guided instructions (playbooks), and the escalation logic.
- **Service Desk Manager / IT Operations**: configures the service desk intake, ticket stages, routing rules, and tracking.
- **Privacy Officer (or Data Protection Lead)**: checks that privacy-plan links are correct and that intake fields minimise personal data.
- **Forensics/Legal/Redress stakeholders**: confirm the acceptance criteria for when to escalate to digital forensics and consumer redress.

###### Acceptance criteria
- Users can access a clearly identified incident reporting support route for the application and receive guided instructions for both handling and reporting.
- Tickets are automatically created and tracked end-to-end, with status changes that can be audited and that align to the incident response workflow.
- Tickets capture enough incident context through identity integration and guided prompts, without requiring users to provide unnecessary sensitive information.
- Automated routing sends tickets to the correct incident response queue, and workflow ownership enforces triage and assignment responsibilities.
- The workflow includes clear, tested escalation to digital forensics and (where required) consumer redress/legal review.
- The incident response documentation, system security plan, and privacy plan reference the support mechanism and escalation routes, and evidence of this linkage is available for audit.

###### Actions Required for Compliance

- [ ] Set up one single “Incident reporting / Report and triage” contact route in the service desk (portal, phone, and email-to-ticket) for the application’s users.
- [ ] Create guided incident intake checklists that include immediate actions to take, prompts to preserve evidence, and the required information fields for reporting.
- [ ] Link the service desk to the organisation’s identity provider so ticket details are filled in automatically (user identity, role or group, and time stamps), using data minimisation.
- [ ] Set up automated rules to route support tickets to the correct incident response triage teams, and require specific evidence and communication details before tickets can move to the next stage of the workflow.
- [ ] Create workflow escalation actions that generate forensics work orders and, where applicable, consumer redress and legal review work orders, with approval triggers.
- [ ] Update the incident response documentation. Also make sure the system security plan and the privacy plan clearly name the support mechanism and the escalation routes.


---

#### IR-7.1 — Automation Support for Availability of Information and Support (Enhancement)

This requirement is about ensuring help for urgent incidents is always available, even outside normal working hours, and that people are kept informed automatically. Without it, staff may find it harder to get the right guidance when something goes wrong. Support requests could be delayed because someone has to record them manually, and requesters might not receive timely updates—allowing problems to worsen or creating confusion about what is happening.

To meet this expectation, the organisation must run a 24/7 incident response assistance portal that automatically accepts support requests, immediately confirms receipt with a reference number, and sends proactive status updates to the requester by email and through an approved secure messaging channel, based on how the ticket progresses.

The organisation must also clearly define who is allowed to use the portal, assign named responsibilities for operating and overseeing it, involve information security oversight, document the assistance procedures and how the automated features work, keep records of the portal’s design and configuration, and be able to show that the portal and notifications work as intended.

##### 24x7 incident response portal with automated ticketing and proactive updates

- Category: Software
- Priority: Critical

###### WHAT
Set up an organisation-approved incident response help portal that is available **24 hours a day, 7 days a week (24x7)**. It must use **automated mechanisms** to: (1) provide incident response information and support when requested, and (2) automatically **receive, confirm, and proactively update** the person who raised the request about the incident response progress.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 **Incident Response (IR)-7(1)** enhancement requires improving how available incident response information and support are, using the organisation-defined **automated mechanisms** (parameter **ir-07.01_odp**). The guidance specifically allows **push or pull** support, including proactively sharing incident response information and using automated help processes.

###### HOW (specific steps/approach)
1. **Portal capability (24x7, authorised access):** Provide a web and/or application programming interface (API)-based help portal that authorised users can access. Requesters can submit requests, and incident response support staff can manage them. Link the portal to the organisation’s identity service for authentication and role-based authorisation.
2. **Automated ticket intake:** Configure the portal so that each submission automatically creates an incident-response ticket in the organisation’s IT service management (ITSM) or ticketing system, without any manual logging step.
3. **Automated acknowledgement:** Immediately after a submission, automatically generate an acknowledgement that includes a **ticket reference**, and send it to the requester through the portal response and/or an approved notification method.
4. **Proactive status updates (email + secure messaging):** Set up workflow-based notification rules so that when the ticket moves between agreed stages (for example: received → triaged → assigned → in progress → resolved), the requester receives proactive updates via **email** and an **approved secure messaging** channel. Make sure notifications are triggered by ticket stage/state changes.
5. **Operational governance and evidence:** Keep documented procedures covering how the portal is used, how automated notifications are configured and managed, and how incident response support roles operate. Retain audit-ready design and configuration evidence (for example: workflow/state definitions, notification templates/rules, and integration diagrams).
6. **Prove availability and automation works:** Use monitoring to show the portal is reachable **24x7** and that automated processes function correctly (for example: automated tests that submit a ticket and confirm the acknowledgement and at least one follow-up notification are delivered).

###### WHO
- **Incident Response Lead / Service Owner:** Owns the portal workflow definitions, ticket stages, and the content/logic used for notifications.
- **ITSM/Platform Engineer:** Builds the integration between the portal and the ticketing system, implements workflow automation, and ensures notifications are delivered.
- **Information Security (oversight):** Approves the secure messaging channel, reviews access controls, and checks that audit evidence is valid.
- **Operations/Site Reliability Engineering (SRE):** Runs monitoring, automated tests, and maintains **24x7** service availability.

###### Acceptance criteria
- A requester can submit an incident response request through the portal at any time, and a ticket is created automatically.
- The requester receives an automated acknowledgement containing a ticket reference immediately after submission.
- As the ticket moves through the agreed stages, the requester receives proactive status updates via **email** and secure messaging, triggered by ticket stage/state changes.
- Only authorised roles can access and manage tickets; requester access is limited to submitting requests and receiving updates.
- Monitoring evidence confirms portal availability (**24x7** reachability) and automated notification delivery (acknowledgement and at least one stage-change update) during testing.
- Audit-ready documentation exists for how the portal is used, how the automated mechanisms are configured, and the system design/configuration evidence.

###### Actions Required for Compliance

- [ ] Choose and set up the 24/7 incident response support portal, and link it to the organisation’s identity provider so only authorised users can access it.
- [ ] Set up automated ticket intake so that when someone submits a request through the portal, an incident-response ticket is automatically created in the IT service management (ITSM) system.
- [ ] Set up an immediate automated acknowledgement that sends the requester a ticket reference through the portal response and/or a notification.
- [ ] Define the stages a ticket can go through, and link each change of stage to proactive notification rules for email and approved secure messaging.
- [ ] Set up secure messaging integration with audit logging for every outbound status update
- [ ] Create and keep audit-ready records covering how the portal is used, how automated notifications are set up, and how the workflow and its states are designed
- [ ] Set up continuous monitoring and automated test checks to confirm the portal is reachable 24 hours a day, 7 days a week, and that messages are successfully received and notifications are delivered.


---

#### IR-7.2 — Coordination with External Providers (Enhancement)

This requirement is about making sure your organisation can work smoothly with outside specialists when something goes wrong, so help is arranged quickly and clearly. Without a direct, agreed way of working and named contacts, an incident could be dealt with slowly or differently each time. Important information might not be shared quickly, and the outside provider might not know who to contact or what to do, which increases the risk of damage to systems and disruption to the business.

To meet this expectation, your organisation must set up a clear working relationship with each external provider that helps protect, monitor, analyse, detect, and respond to unauthorised activity on your systems and networks. You must also identify and document the specific incident-response team members who will be the main points of contact for each provider.

Your organisation should ensure its incident response documents and procedures explain how help will be requested and coordinated. It should also provide the named contacts to the relevant providers in advance, so coordination can start before any incident occurs.

##### Provider incident-response addendum and named liaison contacts

- Category: Manual
- Priority: High

###### WHAT
Agree in advance and document how the organisation will work with each external provider that helps with incident handling (for example, monitoring, detection, analysis, and response). Also name the specific internal incident-handling team members who will be the main contacts for each provider.

###### WHY (control requirement)
IR-7(2) (Enhancement) guidance expects agreements with external providers to clearly set out roles and responsibilities before an incident happens. This includes naming internal incident-handling contacts so coordination can start quickly and consistently.

###### HOW (specific steps/approach)
1. **Create a standard incident-handling cooperation addendum** and attach it to every relevant external provider contract or service agreement. The addendum must define: when the provider should be involved, the cooperation process, what the provider is expected to do (to support triage, analysis, detection, and response), acknowledgement and escalation timeframes, expectations for handling evidence, and limits on what information can be shared.
2. **Keep a controlled “provider liaison pack”** (documented and version-controlled) that, for each provider, lists: the service scope, the named internal incident-handling liaison(s), backup liaison(s), out-of-hours contact details, and the escalation route (including who can approve any containment actions the provider helps with).
3. **Update the organisation’s incident-handling procedures** to explicitly refer to the liaison pack and set out the step-by-step way to request provider help (for example, which contact channel to use, what incident details to provide, and how handover and evidence transfer will work).
4. **Share the liaison pack contacts with each provider** using an authorised route (for example, through contract management or a security governance process). Require providers to confirm they have received the information and to keep their own contact and escalation details up to date.
5. **Check coordination readiness** by running a tabletop exercise for each critical provider (at least once a year). This should test: the correct contact is selected, escalation happens on time, and roles and responsibilities match the addendum.

###### WHO (role responsible)
- **Information Security / SOC Manager**: owns the incident-handling cooperation addendum template, liaison pack structure, and procedure updates.
- **Contract/Procurement Manager**: ensures the addendum is included in provider agreements.
- **Incident Response Lead / Security Operations Lead**: names the incident-handling liaisons and ensures procedures reference the liaison pack.
- **Application/Infrastructure Owners (as needed)**: confirm the provider’s scope and any technical constraints for the application environment.

###### Acceptance criteria
- Every external provider that supports monitoring, detection, analysis, and response has a signed incident-handling cooperation addendum covering roles, workflow, escalation, and information-sharing limits.
- The provider liaison pack lists named internal incident-handling team members (and backups) for each provider, with reliable out-of-hours contact details and a clear escalation route.
- Incident-handling procedures reference the liaison pack and explain how to request and coordinate assistance.
- Evidence is available that providers were given the named contacts and have confirmed receipt.
- For each critical provider, at least one tabletop exercise has been completed within the last 12 months, showing correct escalation and coordination behaviour.

###### Actions Required for Compliance

- [ ] Create a draft template for a standard incident-response cooperation addendum. It should cover: when to start cooperation (triggers), the step-by-step workflow, what each service provider must do, escalation time limits, how evidence is handled, and the limits on what information can be shared.
- [ ] For each external provider that supports monitoring, detection, analysis, or response, attach the addendum and obtain their signature.
- [ ] Create and keep up to date a controlled provider liaison pack. It should list each provider’s incident response (IR) contacts, backup contacts, out-of-hours contacts, and the escalation routes to use.
- [ ] Update the incident response procedures to point to the liaison pack and set out a clear, step-by-step process for requesting help from the provider and handing over information.
- [ ] Share the named liaison contacts with each provider through an approved method, and record each provider’s confirmation that they received them.
- [ ] Run scenario-based tabletop exercises for each critical provider to confirm the correct contact is chosen, escalation happens at the right time, and responsibilities match the addendum.


---

### IR-8 — Incident Response Plan (Control)

This requirement is about having a clear, trusted “playbook” for what to do when something goes wrong, so the organisation can respond quickly and in the same way every time, rather than improvising under pressure. Without a well-prepared plan, key decisions may be delayed, responsibilities may be unclear, the wrong people may get involved, and important information may be shared incorrectly—leading to greater damage and longer recovery. Where personal data is involved, it can also result in missed or inappropriate notifications to the right oversight bodies or affected individuals.

The organisation must create and keep up to date an incident response plan that explains:
- how the response capability will be built and run
- how the response is organised
- how it fits with the wider business
- what counts as a reportable incident
- how performance will be measured
- what resources and management support are needed
- how incident information will be shared internally and with relevant external parties

The plan must be approved by the chief information security officer (CISO) and the Head of Information Security Governance at least once every year, and after major system or organisational changes. Copies must be distributed to security operations centre (SOC) shift leads, incident response team members, and IT Operations managers.

Any updates must be communicated to the incident response (IR) manager and SOC shift leads, and also to the CISO office, the SOC, and IT Operations change management. The plan must be protected so it cannot be viewed or changed without authorisation.

##### Single-source IR plan with approvals, distribution, and PII breach workflow

- Category: Manual
- Priority: Critical

###### WHAT
Create and maintain one single, authoritative **Incident Response Plan** that sets out the organisation’s incident response structure, roles and responsibilities, what counts as a reportable incident, the incident response measures the organisation will use, the resources and management support required, and how information will be shared internally and externally. This includes a specific process for deciding whether to notify oversight organisations or affected individuals when an incident involves **personally identifiable information (PII)**.

###### WHY (control requirement)
**Incident Response (IR)-8** requires a coordinated approach to incident response and expects the organisation to consider coordination and information sharing with external organisations (including service providers and supply chain partners). For breaches involving **PII**, the plan must include a process to decide whether notification to oversight organisations and/or affected individuals is appropriate, and to ensure that notification is made where required. The plan must be reviewed and approved at least annually and after major system or organisational changes. Updates must be distributed and communicated to the designated people and relevant organisational areas.

###### HOW (specific steps/approach)
1. **Create the IR Plan as a “single source of truth”** in a controlled document repository (for example, an enterprise document management system) with version control and an auditable record of changes.
2. **Include all required content**, covering: (a) the incident response capability roadmap and how it fits the organisation, (b) named responsibilities (Chief Information Security Officer (CISO) overall, IR Manager day-to-day, security operations centre (SOC) triage and coordination), (c) incident categories and what makes an incident reportable, (d) incident response measures/key performance indicators (KPIs), (e) required resources and management support expectations, and (f) internal and external information sharing procedures.
3. **Add a dedicated PII breach notification workflow** as an annex, including: decision criteria for whether to notify oversight organisations and/or affected individuals, approval/authorisation steps, notification message templates, timing and escalation triggers, and record-keeping requirements.
4. **Set approval and re-approval triggers** so the plan is approved by the **CISO** and the **Head of Information Security Governance** at least **annually** and **after major system or organisational changes**. Link the re-approval trigger to the organisation’s change management records.
5. **Define how the plan and updates are distributed and communicated**: distribute the approved plan (and annex index) to **SOC shift leads, IR team members, and IT Operations managers**. Communicate changes to the **IR Manager and SOC shift leads**, and to the **CISO office, SOC, and IT Operations change management**.
6. **Prevent unauthorised disclosure and unauthorised changes**: limit access to named roles/groups; require **multi-factor authentication (MFA)** for incident response roles; allow “edit” permissions only for authorised approvers and incident response governance roles; ensure every change is traceable to an individual and includes a timestamp.

###### WHO
- **CISO**: overall ownership of the incident response plan and final approval.
- **Head of Information Security Governance**: co-approval of the plan.
- **IR Manager**: day-to-day maintenance of the plan, coordination of updates, and ensuring the PII breach notification workflow is followed.
- **SOC shift leads / SOC / IT Operations managers**: recipients of the plan and operational users of the incident response playbooks.
- **Change Management function**: provides triggers and evidence for what counts as a “major system or organisational change” that requires re-approval.

###### Acceptance criteria
- The organisation has an Incident Response Plan document with an auditable version history.
- The plan is approved by the **CISO** and **Head of Information Security Governance** at least **annually** and after each recorded **major system/organisational change**.
- The plan clearly defines: responsibilities (CISO/IR Manager/SOC), reportable incident criteria, incident response measures, resources/management support, and internal/external information sharing.
- The plan includes a PII breach notification decision and execution process (oversight and/or affected individuals) with defined approvals and record-keeping.
- The approved plan is distributed to the defined organisational areas (SOC, IR team, IT Operations) and recipients (SOC shift leads, IR team members, IT Operations managers).
- Changes to the plan are communicated to the defined roles/organisational areas (IR Manager, SOC shift leads, CISO office, SOC, IT Operations change management).
- Access to the plan is restricted and changes are controlled with traceable authorisation (no unauthorised viewing or editing).

###### Actions Required for Compliance

- [ ] Create the incident response plan in a controlled document repository with version control and a complete, auditable record of all changes.
- [ ] Define and document incident response responsibilities, including: the Chief Information Security Officer (CISO) for overall oversight, the Incident Response (IR) Manager for day-to-day management, and the Security Operations Centre (SOC) team for triage and coordination. Also document who should receive incident communications.
- [ ] Create an incident classification (taxonomy) and define what counts as a reportable incident, then set incident response performance measures (key performance indicators) and identify the resources required.
- [ ] Add an annex for personal information (PII) breach notifications, including the decision criteria, approval steps, how notifications will be sent, and what records will be kept.
- [ ] Set up an approval process that requires annual sign-off from the Chief Information Security Officer (CISO) and the Head of Information Security Governance, and also requires their approval after any major system or organisational changes.
- [ ] Limit access to the plan to authorised roles and groups, and allow edits only with controlled permissions that are fully traceable to the person who authorised them.
- [ ] Share the approved plan with the security operations centre (SOC) shift leads, incident response (IR) team members, and IT Operations managers, and communicate any updates to the agreed organisational groups.


---

#### IR-8.1 — Breaches (Enhancement)

This requirement ensures that when a security incident involves personal information about people, the organisation can quickly and responsibly decide what to do next. Without a clear plan, the organisation may contact the wrong people too late, miss required notifications under law or contract, or underestimate the real impact on those affected—such as embarrassment, distress, inconvenience, or unfair treatment.

To meet this expectation, the organisation must include these steps in its incident response plan:  
- A documented method for deciding whether affected individuals and/or other organisations (including oversight bodies) must be informed.  
- A structured assessment of the likely harm and possible negative effects, followed by selecting practical actions to reduce that harm.  
- A process to identify which privacy rules apply, so they are followed during the handling of the incident.

The plan should also include any breach-notification procedures required by law, regulation, or internal policy.

##### PII breach notification decision support in IR plan

- Category: Manual
- Priority: Critical

###### WHAT
Update the organisation’s Incident Response Plan (IRP) for breaches involving personally identifiable information (PII) to include a documented, privacy-led decision process for:
1) whether affected individuals and/or other organisations (including oversight bodies) must be notified,
2) a structured assessment of the likely harm to individuals and other negative impacts,
3) choosing and linking mitigation actions to the assessment results, and
4) identifying and applying all relevant privacy requirements (for example, legal, regulatory, and policy breach-notification procedures).

###### WHY (control requirement)
IR-8(1) (Enhancement) requires that the IRP for breaches involving PII explicitly covers breach-notification procedures. This includes the decision requirements for whether to notify, the standards for assessing harm, the mitigation and other specific requirements, and how to identify the privacy requirements that apply. This enables the organisation to decide and act quickly and responsibly.

###### HOW (specific steps/approach)
1. **Create a PII breach section in the IRP** that includes:
   - A **notification decision process** with documented triggers/factors (for example: the likelihood of unauthorised access, evidence of data being taken, the types of data/categories of PII, the number of people affected, affected countries/regions, and whether the data was encrypted or hashed, and whether the encryption keys were compromised).
   - **Named decision roles and escalation routes** (for example: the security operations centre (SOC) or incident commander starts the process; the privacy officer or legal team confirms which privacy requirements apply; the communications lead drafts the notification; the incident commander approves the notification decision).
2. **Use a structured harm assessment template** that records:
   - Likely harms to individuals (at minimum: embarrassment, distress, inconvenience, and unfair treatment; and also other negative impacts relevant to the organisation, such as identity fraud risk, financial loss, reputational harm, discrimination risk, and any safety implications where applicable).
   - Other negative impacts beyond the main harms (for example: disruption to the affected organisations, increased fraud attempts, extra support burden, and reputational impact).
3. **Link mitigation actions to harm outcomes** in the playbook (for example: account resets or lockouts, targeted customer support scripts, credit monitoring or identity protection offers where appropriate, adjustments to communications content, containment actions, and data minimisation/retention actions).
4. **Maintain a privacy requirements register** referenced by the playbook, covering the breach-notification procedures required by law, regulation, or policy. This should include any differences by country/region and the required recipients of notices (individuals, affected organisations, and oversight bodies).
5. **Add requirements for audit-ready evidence** to the IRP section:
   - What evidence must be collected to support the notification decision (for example: forensic findings and logs, data classification labels, indicators of data being taken, encryption status, affected countries/regions, and the timeline).
   - How the organisation records the reasons for the decision and when it was made.

###### WHO
- **Incident Response Lead / Incident Commander**: owns the IRP update and gives final approval for the notification decision.
- **Privacy Officer / Data Protection Lead**: confirms which privacy requirements apply and the harm/notification thresholds.
- **Legal Counsel (as required)**: confirms regulatory/legal notification duties and any oversight-body requirements.
- **SOC Analyst / Forensics Lead**: provides the facts about the breach and the evidence needed for the assessment.
- **Communications Lead**: prepares the notices and coordinates delivery once approval is given.

###### Acceptance criteria
- The IRP includes a dedicated PII breach section with a documented notification decision process (triggers/factors, evidence expectations, and escalation/approval roles).
- The IRP includes a structured harm assessment method and a mitigation selection approach that is explicitly linked to the assessment outcomes.
- The IRP references a maintained privacy requirements register and shows how relevant privacy requirements are identified and applied during breach handling.
- For a test incident involving PII, the organisation can produce an audit trail showing: (a) the reasons for the notification decision, (b) the harm assessment outputs, (c) the mitigation actions selected, and (d) the privacy requirements used to justify the approach.

###### Actions Required for Compliance

- [ ] Update the incident response plan (IRP) by adding a dedicated section for a personal information (PII) breach playbook. This section should cover the notification decision process, how harm is assessed, how mitigation actions are linked, and how privacy requirements are applied.
- [ ] Define and document what events or factors trigger notifications for personal information (PII) breaches, what evidence must be provided, and when decisions must be made.
- [ ] Assign named responsibilities for: deciding notifications, validating privacy and legal requirements, and approving communications, including clear escalation routes if issues arise.
- [ ] Create and standardise a harm assessment template that records the likely harms and other negative impacts that are relevant to the organisation.
- [ ] Create a “mitigation-to-harm” mapping in the playbook so that the selected actions are clearly justified by the results of the assessment.
- [ ] Create and keep up to date a privacy requirements register that accounts for local legal rules (jurisdiction-aware), and link it to the personal information (PII) breach response playbook.
- [ ] Run a tabletop exercise for a personal information (PII) breach to confirm that the incident response plan (IRP) produces a clear, audit-ready explanation, a complete record of supporting evidence, and the correct mitigation and notification actions.


---

### IR-9 — Information Spillage Response (Control)

This requirement is about responding quickly and carefully when information is accidentally sent to the wrong place, or when it is later found to be more sensitive than expected. If there is no clear response, the information could spread further, be accessed by people who should not have it, and cause legal, financial, and reputational harm.  

The organisation must ensure that the Incident Response Lead, the security operations centre (SOC) analysts, and the owner of the affected system are clearly responsible for handling these incidents, including identifying exactly what information was involved. They must alert the Incident Response Lead and the affected system owner using a communication route that is not linked to the original mistake. They must then immediately isolate the affected system or component, remove the exposed information, and check whether anything else may have been affected.  

Finally, they must record what happened, keep relevant evidence for review, update risk assessments, and notify the required stakeholders in line with the organisation’s incident procedures.

##### Automated spill response workflow with safe alerting and containment

- Category: Software
- Priority: Critical

###### WHAT must be done
Set up an automated, auditable “information spill response” process that starts when a spill is detected (including when a classification/impact mismatch is found later). The process must assign named, accountable responders, alert them using an approved communication route that is not linked to the spill itself, and guide the work to contain the issue, remove the cause, analyse how it may have spread, and complete the required evidence, risk, and stakeholder actions.

###### WHY (control requirement)
IR-9 requires the organisation to **respond to information spills** using actions based on:
- the spilled information’s classification/impact,
- the affected system’s security capabilities,
- the contaminated storage media, and
- the context of authorised access.

The response must **avoid using the same methods that caused the spill** to prevent further spread. It must also include the right corrective actions for the contamination (isolate/remove) and follow-up steps (record what happened, preserve evidence, update risk assessments, and inform the right stakeholders).

###### HOW (specific steps/approach)
1. **Detect and open a spill case**: Combine signals from data loss prevention (DLP), cloud access security broker (CASB), email, file transfer, and cloud audit logs, along with alerts for classification/label mismatches, to create a “spill case” that includes:
   - sending and receiving systems,
   - data identifiers (file/object identifiers, hashes, message identifiers),
   - expected versus actual classification/impact,
   - the time it occurred, and
   - the affected storage media.
2. **Assign accountable roles**: Automatically assign the **Incident Response Lead**, **security operations centre (SOC) analysts**, and the **affected system owner** using the organisation’s on-call/rotation schedule and an authoritative mapping of assets to owners.
3. **Alert via non-spill communication**: Inform the assigned roles using an approved channel **not connected to the spill method** (for example, a secure ticket plus phone or text message escalation). This must **exclude** the original sharing portal/email thread used for the spill.
4. **Containment and eradication runbooks**: Use guided steps based on the case severity (classification/impact) and system capability, such as:
   - cancelling relevant sessions/tokens,
   - quarantining the affected share/folder/object where supported, and
   - deleting or quarantining the specific spilled objects using their identifiers.
   Then confirm the removal using API checks, listings, and access checks.
5. **Spread analysis**: Check where the information may have moved after the spill (for example, shared-folder propagation, synchronisation/replication logs, object version history, and message “fan-out”). Use dependency and data-lineage information to identify other potentially contaminated systems or components.
6. **Evidence, risk, and notifications**: Apply mandatory workflow checkpoints to:
   - record the spill,
   - preserve evidence (logs, case records, object identifiers, and timestamps),
   - update risk assessments, and
   - notify the required stakeholders according to the organisation’s incident procedures.

###### WHO (role responsible)
- **Incident Response Lead**: owns the spill case, approves how severity/classification is handled, and ensures containment/removal decisions are appropriate.
- **SOC analysts**: carry out initial triage, collect evidence, and perform spread analysis.
- **Affected system owner**: performs (or authorises) system-specific containment/removal actions and confirms the results.
- **Platform/Security Automation engineer**: builds the workflow integrations and runbooks.

###### Acceptance criteria
- A spill event automatically creates a spill case with the required details (expected versus actual classification/impact, affected systems, and data identifiers).
- The workflow assigns the Incident Response Lead, SOC analysts, and affected system owner without manual intervention.
- Alerts are sent using an approved **non-spill** communication route (no notifications are sent via the original spill channel).
- Containment and eradication steps are carried out (or explicitly recorded as not applicable), and confirmation of removal is documented.
- Spread analysis identifies and records any additional potentially contaminated systems or components.
- The case includes recorded actions, preserved evidence, references to updated risk assessments, and stakeholder notifications aligned to incident procedures.

###### Actions Required for Compliance

- [ ] Define the sources used to detect spills and link their events to a standard spill case format, including: expected versus actual classification and impact, the systems affected, and the relevant data identifiers.
- [ ] Set up an automated process to create spill incident cases and assign them to the Incident Response Lead, security operations centre (SOC) analysts, and the owner of the affected system, based on the on-call rota and a mapping of each asset to its responsible owner.
- [ ] Set up alerting so that notifications sent to responders use an approved communication channel that does not risk spreading the spill, and that is separate from the original spill mechanism.
- [ ] Create runbook-led containment and removal steps for each supported type of storage (for example, revoke active sessions and access tokens, and quarantine or delete items using their object identifier), with documented checks to confirm the actions were completed successfully.
- [ ] Run spread-analysis checks using propagation, synchronisation, and replication logs, along with dependency and data-lineage maps, and require that any systems that may be contaminated are recorded.
- [ ] Before closing the spill case, make sure evidence is collected and recorded, that the risk assessment update references are documented, and that the required stakeholder notification steps are completed.


---

#### IR-9.2 — Training (Enhancement)

This requirement is about making sure the right people know exactly what to do if sensitive information is accidentally shared or leaked. Without regular, job-specific training, staff may not spot a leak quickly, may take the wrong first steps, or may contact the wrong people. This can cause avoidable harm, such as financial loss, legal issues, or damage to trust.

To meet this expectation, the organisation must provide information spillage response training to staff who have responsibilities for handling incidents and protecting information at least once every year, and again whenever their role changes. The training must clearly set out each person’s responsibilities during a leak and the specific actions they must take. It should be based on the organisation’s documented incident-handling plan and security approach.

The organisation must also keep reliable records showing who completed the training and when, so the yearly and role-change timing can be checked.

##### Role-based spillage response training with annual and role-change recert

- Category: Software
- Priority: High

###### WHAT
Provide information spillage response training to the relevant people at a set interval, and again whenever their job role changes. Use training material that matches the organisation’s incident response plan, and keep completion records that can be audited.

###### WHY (control requirement)
NIST IR-9(2) (Enhancement) requires: “Provide information spillage response training {{ insert: param, ir-09.02_odp }}.” The organisation-defined parameter sets the **frequency** as **annually and when roles change**. The guidance also requires incident response training on a regular basis so staff understand their **own responsibilities** and the **specific actions** they must take when information spillage incidents happen.

###### HOW (specific steps/approach)
Set up a central, role-based training programme delivered through the organisation’s learning management system (learning platform, LMS). Link it to the organisation’s identity provider (IdP) and to human resources/information technology service management (HR/ITSM) role information.

1. **Create a spillage response training curriculum** that matches the incident response plan steps for information spillage (for example: detection and triage, immediate containment, handling evidence, notification and escalation routes, communications, and actions after the incident). Make sure each module clearly states each person’s **responsibilities** and the **exact actions** they must take.
2. **Set the training audience by role** (incident responders, security operations centre (SOC) or monitoring analysts, IT security operations, escalation owners, and system or application owners for relevant services). Maintain a role-to-training mapping that aligns with the incident response plan.
3. **Set up LMS role-based enrolment** using identity provider (IdP) group membership (or entitlements), so people are automatically enrolled into the spillage training when they move into a defined role.
4. **Apply the required timing**: schedule annual re-training for the defined audience, and assign training immediately when role changes occur (for example, when HR/ITSM updates update IdP groups).
5. **Keep records and evidence**: ensure the LMS stores audit-ready records, including the user identifier, training title/module, assignment date, completion date, and completion status. Keep exportable reports for audit.
6. **Check training matches the current plan**: require curriculum owners to link each learning objective to the relevant step(s) in the incident response plan, so the training stays consistent with the current procedures.

###### WHO (role responsible)
- **Information Security / Incident Response Lead**: owns the training content and ensures it maps to the incident response plan.
- **LMS/IdP Administrator (identity and access management (IAM) team)**: sets up role-based enrolment and role-change triggers.
- **HR/ITSM Process Owner**: ensures role changes are passed through to IdP groups/entitlements.
- **Compliance/Audit Liaison**: checks that training evidence exports are produced and retained.

###### Acceptance criteria
- Training is provided to the defined audience **at least annually** and **when roles change** (as per ir-09.02_odp frequency).
- Training covers **individual responsibilities** and **specific actions** during an information spillage incident, and it is clearly linked to the incident response plan procedures.
- For a sample of users, the organisation can produce audit-ready evidence showing **who completed** the training and **when** (including completion after a role change).

###### Actions Required for Compliance

- [ ] Develop an information spill response training programme that matches the incident response plan steps, and set out each person’s responsibilities and required actions for every training module.
- [ ] Define and keep up to date which training each role needs, based on the role’s responsibilities in incident response.
- [ ] Set up the learning management system (LMS) to assign spill training based on users’ group membership in the identity provider (IdP) for each defined role.
- [ ] Set up an annual re-check (recertification) schedule for the defined group of users in the learning management system (LMS).
- [ ] Set up role-change triggers so that when a user’s role is updated (through human resources or IT service management to the identity provider), the learning management system assigns the required spill training and records completion.
- [ ] Set up learning management system (LMS) reporting and exports to produce audit-ready evidence (who completed training, what training they completed, and the completion date and status), and keep records for as long as required by organisational policy.


---

#### IR-9.3 — Post-spill Operations (Enhancement)

This requirement is about keeping work going after sensitive information has been accidentally exposed, so staff are not left waiting for repairs. If there are no clear steps to follow after the incident, staff may be unable to do their jobs while affected systems are being cleaned, or they may be tempted to use unsafe systems or access the wrong information, which could make the impact of the incident worse.  

The organisation must therefore write and follow clear, documented procedures for after the spill. Once a system is treated as contaminated, these procedures must immediately activate only pre-approved ways to continue work around the problem. They must move affected duties to clean (non-impacted) systems that are ready to use, and give affected staff temporary access only to the approved data sets they need to continue their tasks.  

This temporary access must last only until the organisation confirms that corrective actions are complete. It must then be removed. The organisation must also keep records showing what was done and who was responsible.

##### Post-spill continuity runbook with approved workarounds and time-limited access

- Category: Software
- Priority: Critical

###### WHAT
Put in place documented “after a spill” procedures. If an information spill affects systems, these procedures must let the people who are affected keep doing their assigned work while the contaminated systems are corrected. The procedures must: (1) switch on approved spill workarounds, (2) move affected duties to clean systems, and (3) give temporary access to approved data sets until the corrective work is finished.

###### WHY (control requirement)
NIST Special Publication 800-53 Incident Response (IR)-9(3) (enhancement) requires: “Implement the following procedures to ensure that organizational personnel impacted by information spills can continue to carry out assigned tasks while contaminated systems are undergoing corrective actions: {{ insert: param, ir-09.03_odp }}.” The organisation-defined parameter specifies procedures to “Activate spill impact workarounds, reassign affected duties to clean systems, and provide temporary access to approved data sets until corrective actions complete.”

###### HOW (specific approach)
Create and run a single “Spill Mode” after-spill runbook/playbook for the application and the environments that support it (production plus any impacted tiers). The runbook must start when a system is declared contaminated (by the incident commander / incident response lead). It must then carry out the three required actions in a controlled, auditable order:

1) **Activate only approved workarounds**
- Keep an “approved workaround catalogue” linked to business roles and the parts of the system that may be affected (for example: an alternative user interface/workflow, read-only mode, an alternative service address, or a manual fallback process).
- When Spill Mode starts, the playbook enables only the workarounds from the catalogue that match the impacted roles.
- Record: the start time, the contaminated system identifier(s), the workaround(s) activated, and who approved it.

2) **Reassign duties to clean systems**
- Predefine “clean system” targets for each business process (for example: an alternative environment, a read-only replica, a separated reporting instance, an approved staging data set, or a disaster recovery (DR) environment that is not contaminated).
- The playbook updates how work is routed (for example: IT service management (ITSM) or workflow queues, application routing rules, or job schedulers) so affected duties run against the clean targets.
- Record: the affected duties and people, the reassignment mapping, and confirmation that work is now routed to clean systems.

3) **Provide temporary access to approved data sets**
- Define a set of “approved data sets” that are safe to use during Spill Mode (for example: data sources that have been explicitly checked as not contaminated, or approved replicas/snapshots).
- Use identity and access controls so access is granted only to users within the Spill Mode scope and only to the approved data sets.
- Limit access to a defined time period (expiry) that matches when remediation is expected to finish. Access must be approved by someone accountable, and access must be removed automatically or manually once remediation is confirmed complete.
- Record: the access granted details (who/what/when), the expiry/removal time, and evidence that access was removed.

4) **Evidence and closure**
- Make sure the playbook produces audit-ready records: timestamps for each step, accountable owners, the contaminated/clean system identifiers, workaround identifiers, and evidence of access granted and removed.
- Include a formal “Remediation Complete” confirmation step that ends Spill Mode and removes temporary access.

**Implementation notes for this application context**
- Use the organisation’s central identity provider and access management (for example: an enterprise identity provider with conditional access and role-based access control) to enforce “approved-only” and time-limited access.
- Link the runbook to existing ITSM/workflow tools so duty reassignment and access requests are logged and can be traced.
- Ensure the runbook is aware of the environment (production versus test/disaster recovery) and uses the application’s existing separation model.

###### WHO
- **Incident Response Lead / Incident Response Commander**: declares contamination and authorises starting Spill Mode and confirming remediation is complete.
- **Information Security (or nominated delegate)**: approves the workaround catalogue and the approved data sets; authorises temporary access.
- **Application Owner / Business Process Owner**: defines which duties map to which clean systems and confirms that work can continue safely.
- **Identity and Access Management (IAM) / Platform Engineering**: implements access controls, expiry, and access removal automation.
- **ITSM/Automation Engineer (or security operations centre (SOC) automation team)**: implements playbook orchestration and evidence logging.

###### Acceptance criteria
- A documented after-spill runbook exists for the application and clearly covers the three required procedures: approved workaround activation, duty reassignment to clean systems, and temporary access to approved data sets until corrective actions are complete.
- When Spill Mode is triggered in a test/tabletop exercise or controlled drill, the system produces evidence that:
  - only approved workarounds were activated,
  - affected duties were routed to the predefined clean systems,
  - temporary access was granted only to approved data sets and was time-limited,
  - access was removed when remediation was confirmed complete.
- Audit evidence includes timestamps, accountable approvers, contaminated/clean system identifiers, workaround identifiers, and records of access granted and access removed.

###### Actions Required for Compliance

- [ ] Draft and get approval for a “Spill Mode” post-incident runbook that clearly sets out the three procedures—(1) activating a workaround, (2) reassigning duties, and (3) granting temporary, pre-approved access to data—and specifies the conditions that trigger it and when it can be closed.
- [ ] Create and keep an approved list of workarounds, linked to business roles and the system components they affect.
- [ ] Define clear “clean system” targets and the routing rules for sending work to the clean system for each business process that is affected.
- [ ] Set up identity and access controls for “Spill Mode” so temporary access is restricted to approved data sets and automatically ends after a set expiry time.
- [ ] Integrate the runbook with IT service management (ITSM), workflow tools, and security orchestration, automation and response (SOAR) so that duty changes and access grants are carried out and recorded in a clear, auditable order.
- [ ] Test the full “Spill Mode” process from start to finish (a tabletop exercise plus a technical drill) and confirm that the recorded evidence includes: timestamps, the people who approved actions, workaround reference IDs, routing details, and confirmation that access is removed when remediation is completed.


---

#### IR-9.4 — Exposure to Unauthorized Personnel (Enhancement)

This requirement is about preventing information from being used or shared if someone sees it by mistake or without permission. If this is not dealt with quickly, confidential information could be copied, shared, or used, and the organisation could also break strict legal rules that apply to certain types of information. This could lead to serious financial, regulatory, and reputational harm.

The organisation must be able to recognise immediately when a person has been exposed to information they are not authorised to access, remove their access to the affected information straight away, and keep them supervised while the situation is assessed.

The person must receive a clear briefing on what they are allowed to do only on a need-to-know basis, sign a non-disclosure agreement before any further handling, and be told about the relevant legal and compliance rules that apply to the specific information involved. This includes rules relating to export, health information, personal data, and contractor security obligations where applicable.

Any spill or exposure must be reported to Security within one hour, including the key details. The information must be kept contained until Security formally confirms that the person may proceed.

##### Automated exposure containment workflow with legal briefing & NDA

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated, auditable process that starts when a person is found to have accessed information outside the access they are authorised to use. The process must:  
1) quickly remove or limit the person’s access to the affected information and related systems,  
2) make sure the person receives a “need-to-know” briefing and signs a non-disclosure agreement (NDA) before they handle anything further,  
3) report the incident (“spill” or exposure) to Security within 1 hour, and  
4) keep the person escorted/contained until Security formally confirms they are cleared.

###### WHY (control requirement)
NIST IR-9(4) (enhancement) requires: “Employ the following controls for personnel exposed to information not within assigned access authorizations: {{ insert: param, ir-09.04_odp }}.” The guidance also requires that exposed staff are made aware of the laws, executive orders, directives, regulations, policies, standards, and guidance that apply to the information, including the restrictions that apply because of the exposure.

###### HOW (specific steps/approach)
1. **Define what counts as an exposure and what is included**: Configure detection rules that identify “access to information outside assigned access authorisations” using clear signals available in the system (for example: access to a restricted folder/document label, data loss prevention (DLP) “view/copy” activity on regulated datasets, events showing the person’s role does not match what they accessed, or policy violations linked to data classification tags).  
2. **Immediately limit access in the systems**: When a trigger is detected, automatically end any active sessions and remove access to the specific information and any connected locations (for example: storage locations, document libraries, dataset endpoints). Block any further access attempts until Security clearance is recorded.  
3. **Create a Security case with required details and a 1-hour response time**: Automatically open an incident/spill case in the organisation’s ticketing and incident response system, including required evidence (who, what information/resource, when and where the exposure was detected, how it was detected, and the relevant log references). Ensure Security is notified within **60 minutes** of the discovery.  
4. **Provide the right briefing and require NDA sign-off**: Create a guided “Exposure Acknowledgement” pack based on the information’s regulatory labels (for example: ITAR/EAR, HIPAA, GDPR, CMMC, where relevant). Require the exposed person to confirm they understand the restrictions and sign an NDA (electronic signature where legally acceptable) **before** any further handling is allowed. Keep proof of completion that can be audited and linked to the case.  
5. **Escort/contain until formal clearance**: Add a clearance check so the person cannot regain access or handle anything further until Security records formal clearance in the case system. For physical or operational escort, Security/Facilities must complete a manual step, but the system-based restriction must still remain in place.  
6. **Audit and improve over time**: Keep records showing how the trigger was detected, what access was removed, completion of the briefing and NDA, and Security clearance. Review false alarms and missed detections, and update the detection rules and regulatory mapping.

###### WHO (role responsible)
- **Security Operations / security operations centre (SOC)**: Own the incident/spill case process, ensure the 1-hour notification, and record formal clearance.  
- **Identity and Access Management (IAM) / Platform Engineering**: Implement automated session ending, access removal, and the clearance check that blocks access.  
- **Data Protection/Compliance (Legal/Privacy/Export Control as applicable)**: Maintain the mapping between regulatory labels and the briefing/NDA content.  
- **Application Owner**: Ensure the application produces the required audit signals and that resource tagging/classification is accurate.

###### Acceptance criteria
- A test exposure event results in: **(a)** access/session removal for the affected information within minutes, **(b)** a Security case created with the required evidence, and **(c)** Security notified within **60 minutes**.  
- The exposed person cannot handle anything further until **briefing acknowledgement** and **NDA signing** are completed (or it is explicitly recorded that this is not applicable or not legally possible) and Security clearance is recorded.  
- The person remains blocked from re-access until Security records formal clearance; audit logs must show the access block was enforced.  
- The briefing content is selected correctly based on the information’s regulatory labels (ITAR/EAR/HIPAA/GDPR/CMMC where applicable) and is evidenced in the case record.

###### Actions Required for Compliance

- [ ] Define and put in place “exposure triggers” based on the data’s classification and regulatory labels, so that any access, viewing, or copying is recorded in an auditable way.
- [ ] Set up automatic log-out (session termination) and remove access to the affected information and any linked repositories, based on the specific resources involved.
- [ ] Link the workflow to the incident or ticket system so it creates a Security case that requires specific evidence fields, with a 60-minute notification service level agreement (SLA).
- [ ] Set up a briefing and non-disclosure agreement (NDA) check so that any further handling is blocked until the case records show that the briefing has been acknowledged and the NDA has been completed.
- [ ] Add a security clearance checkpoint that blocks re-enabling access or any further handling until formal clearance is recorded.
- [ ] Set up audit logs and retention periods for detecting triggers, recording containment actions, tracking when briefings and non-disclosure agreements (NDAs) are completed, and documenting clearance decisions.

