### PL-1 — Policy and Procedures (Control)

This requirement is about making sure the organisation has a clear, written plan for how it will protect people’s information and meet its privacy responsibilities, and that staff know how to follow that plan in practice. Without this, different teams may work in different directions, legal and regulatory duties could be missed, and lessons from audits or real incidents may not lead to timely improvements—leaving the organisation exposed to avoidable harm.

The organisation must create and document an organisation-wide security and privacy planning policy. This policy must explain its purpose, what it covers, who is responsible for what, leadership’s commitment, how departments work together, and how the organisation will meet compliance obligations in line with relevant laws, regulations, internal rules, and guidance.

The Chief Information Security Officer must oversee creating, documenting, and sharing the policy and the supporting procedures.

The policy must be reviewed and updated at least every year, and also after material regulatory or operational changes, audit findings, security incidents or breaches, major changes to the organisation’s architecture, and changes to key requirements. The procedures must be reviewed and updated at least every year, and also after material changes to processes or systems, new or updated requirements, major lessons from incidents, changes in roles, and major changes to integrations.

##### CISO-owned security & privacy planning policy and procedures framework

- Category: Manual
- Priority: Critical

###### WHAT
Create an organisation-wide **security and privacy planning policy** and supporting **planning procedures** that explain how the organisation plans and implements the PL-family controls across IT systems and, where applicable, OT systems.

###### WHY (control requirement)
PL-1 requires planning policy and procedures for the controls in the PL family that are implemented within systems and organisations. The guidance highlights that the **risk management strategy** is a key input, that the **security and privacy programmes work together**, and that simply listing the controls is not enough—the documents must explain the organisation’s planning approach and how it is put into practice.

###### HOW (specific steps/approach)
1. **Create a single source of truth**: publish an organisation-level “Security & Privacy Planning Policy” (or a tightly governed set of policies) covering purpose, scope, management commitment, coordination between the security and privacy programmes, roles and responsibilities, and how compliance is achieved.
2. **Define the policy owner and governance**: appoint the **Chief Information Security Officer (CISO)** as the official responsible for managing the planning policy and procedures.
3. **Create planning procedures**: document the “how to” for implementing the planning policy (for example, how risk informs planning, how control owners contribute, how approvals happen, and what evidence is produced for audits).
4. **Set dissemination lists**: share the policy with **security and privacy programme leadership, risk management, and compliance personnel**; share the procedures with **security and privacy programme leadership, system owners, and control owners**.
5. **Set review/update triggers and timing**:
   - **Policy**: review and update **at least annually** and when there is a **material regulatory or operational change**, including triggers such as **audit findings**, **security incidents or breaches**, **changes to laws/regulations/standards**, and **major architecture changes**.
   - **Procedures**: review and update **at least annually** and when there is a **material process or system change**, including triggers such as **new or updated control requirements**, **significant lessons learned from incidents**, **changes to roles and responsibilities**, and **major OT/IT integration changes**.
6. **Use templates and evidence**: provide standard templates for system or mission planning outputs (for example, inputs for security and privacy plans) and an “evidence pack” checklist, so system owners can implement consistently without creating local variations.

###### WHO (role responsible)
- **Chief Information Security Officer (CISO)**: accountable for managing, maintaining, and sharing the planning policy and procedures.
- **Security and Privacy Programme Leadership**: co-develop and validate the policy and procedure content and ensure collaboration.
- **Risk Management and Compliance Personnel**: align the risk strategy and compliance approach.
- **System Owners and Control Owners**: use the procedures and templates to produce planning outputs.

###### Acceptance criteria
- An approved, documented **organisation-level planning policy** exists, is approved by the **CISO**, and clearly states purpose, scope, roles and responsibilities, coordination between the security and privacy programmes, and compliance alignment.
- Documented **planning procedures** exist that describe implementation steps (not just a repeat of the controls) and explain how risk informs planning and how evidence is produced.
- Dissemination can be demonstrated (for example, controlled publication and recipient lists) to the specified groups of personnel.
- Review/update records show the policy is reviewed at least **annually** and after the defined triggers; procedures are reviewed at least **annually** and after the defined triggers.
- Templates and the evidence checklist are available and used by system owners to produce planning outputs consistently.

###### Actions Required for Compliance

- [ ] Draft and get approval for an organisation-wide Security and Privacy Planning Policy, owned by the Chief Information Security Officer (CISO).
- [ ] Define and document planning procedures that explain how risk information is used to guide planning, and how evidence of planning is produced.
- [ ] Publish the policy and procedures in a controlled document repository, and share them with the specified recipient groups.
- [ ] Create standard templates and an evidence pack checklist for system owners to use when producing planning outputs.
- [ ] Set and document review and update schedules: review the policy every year and whenever defined triggers occur; review the procedures every year and whenever defined triggers occur.
- [ ] Record and keep the results of reviews and the reasons for any changes so they can be audited (including version history, approval records, and distribution logs).


---

### PL-2 — System Security and Privacy Plans (Control)

This requirement is about making sure the organisation has clear, up-to-date plans for how each system will be run safely and how it will protect people’s privacy. Without these plans, important details can be missed—such as what the system does, what information it uses, who is responsible, what other systems it connects to, which risks matter, and what safeguards are in place—leading to avoidable misuse of data, privacy harm, or security weaknesses.

To meet this expectation, the organisation must create and keep two documents for each system: a system security plan and a system privacy plan. These plans must match the organisation’s overall system blueprint, describe the system’s components and operating environment, name the people responsible, list the information involved, explain the chosen level of risk and why, describe the main threats, include the results of privacy risk checks for personal data, and summarise the security and privacy measures (including any justified changes), as well as the risk decisions behind key design choices.

Before the system is used, the plans must be reviewed and approved by the authorising official. They must be shared with the system owner, authorising official, security assessor and privacy officer. The plans must be updated at least every year and whenever major changes are made, and they must be protected from unauthorised viewing or editing.

##### Maintain authorisation-approved security & privacy plan per system boundary

- Category: Manual
- Priority: Critical

###### WHAT
Create and keep up to date system security and privacy plans (either combined or separate). These plans must cover the system and its parts that sit within the organisation’s defined authorisation boundary. They must explain:
- the system’s security and privacy requirements;
- the security and privacy measures chosen to meet those requirements (including any adjustments and the values used);
- the results of privacy risk assessments (where personal data is handled);
- the main security and privacy design decisions; and
- who is responsible for carrying out security and privacy activities.

###### WHY (control requirement)
PL-2 requires that system security and privacy plans:
- are limited to the system and its components within the defined authorisation boundary;
- give an overview of the security and privacy requirements and the measures selected to meet them;
- explain how each selected measure is intended to be used in this system, with enough detail to allow correct implementation and later checking;
- are “live” documents that are updated throughout the system development life cycle;
- include enough information (including the selected measure parameter values) to allow clear compliance checks and later risk decisions;
- are reviewed and updated at least every year and whenever there are major changes to the system or environment;
- are coordinated with named people/roles and shared with the people who need them; and
- are protected from unauthorised access or changes.

###### HOW (specific steps/approach)
Set up a controlled, system-specific plan set as the “single source of truth” in your document or governance, risk and compliance (GRC) system. Use a structured template that forces the required sections and links to evidence, and use a workflow that links plan approval to the authorising official.

1. **Define the system boundary and scope**: create and maintain a “system boundary register” that shows how the application or service fits within the authorisation boundary (including any hybrid information technology (IT) and operational technology (OT) integration points, if relevant). Link this to enterprise architecture records such as the service catalogue entry, integration map, and reference architecture.
2. **Complete the required plan content using a structured template**: include, at minimum, system components, day-to-day operating context, and the types of information the system processes, stores, or transmits. Also include the security classification with the reasons for it, the threats that are relevant, and—where personal data exists—the privacy risk assessment results and outcomes.
3. **Link requirements to measures, including adjustments and parameter values**: for each selected measure or enhancement, record how it is applied in this system context. Clearly record any parameter choices by stating the exact value used or by referencing the controlling standard or baseline.
4. **Record key security and privacy design decisions and risk decisions**: document the reasons for major design choices and the risk decisions that follow from them. Do not include full technical design specifications—use references to the design and implementation documents instead.
5. **Set lifecycle governance and update triggers**: review at least **annually** and whenever there are major changes to the system or environment. Require updates when issues arise, designs change, or measure tailoring changes.
6. **Control approval, sharing, and protection**: send the plan for approval to the **authorising official** before it is used. Share controlled copies with the **system owner**, **authorising official**, **security control assessor**, and **system privacy officer**. Limit editing to the plan owner and authorised roles, and protect the plan from unauthorised viewing or modification.

###### WHO (role responsible)
- **System owner**: maintains the plan content and the linked evidence.
- **Information security manager / privacy officer**: ensures security and privacy requirements and privacy risk assessment results are correctly reflected.
- **Authorising official**: reviews and approves the plan before the system is implemented.
- **Security control assessor**: receives the approved plan to plan the assessment.
- **IT operations lead / change management board**: ensures plan updates are triggered and coordinated with major changes.

###### Acceptance criteria
- The plan set covers the system and components within the defined authorisation boundary and references the system boundary register.
- The plan includes the reasons for the security classification, the threats of concern, and—if personal data is processed—the privacy risk assessment results.
- Each selected measure or enhancement is mapped to the system context with clear tailoring and parameter values (either by stating the value or by referencing) that are sufficient for later assessment.
- The plan is reviewed **annually** and updated when there are major system or environment changes, with an auditable record of changes.
- There is an approval record from the authorising official before implementation.
- Controlled sharing is evidenced for the system owner, authorising official, security control assessor, and system privacy officer.
- Access controls prevent unauthorised viewing or editing of the plan content.

###### Actions Required for Compliance

- [ ] Create or update the system boundary register and link it to the enterprise architecture records for the application and its integrations.
- [ ] Create the system security and privacy plan(s) using a controlled template. The template must include mandatory sections covering: components, context, types of information, the reasons for how information is categorised, identified threats, and the resulting privacy risk outcomes.
- [ ] For each selected control or enhancement, link it to the system context and record any tailoring or parameter choices using the exact values or a clear reference.
- [ ] Record the main security and privacy design decisions and the risk judgements made for each one, and point to the detailed design and implementation documents where needed.
- [ ] Route the plan for authorising official review and approval before any implementation or major change release.
- [ ] Provide controlled copies to the system owner, the authorised official, the security control assessor, and the system privacy officer, and record evidence showing that the copies were distributed.
- [ ] Set the plan review to happen at least once every year and also whenever there are major changes to the system or environment. Put access controls in place to prevent unauthorised people from viewing or editing it.


---

### PL-4 — Rules of Behavior (Control)

This expectation is about making sure everyone who is allowed to use your organisation’s systems understands the rules for doing so and agrees to follow them. Without clear, agreed rules, people may accidentally misuse information, mishandle sensitive data, or ignore privacy responsibilities. This can lead to security incidents, financial loss, reputational damage, and harm to customers or staff.

To meet this expectation, the organisation must:
- write clear, plain-language rules for expected behaviour when using information and systems, including what is expected for security and privacy;  
- give these rules to each person before they are granted access;  
- collect a recorded acknowledgement from each person (for example, a signed form or an electronic agreement) confirming they have read, understood, and agreed to comply; and  
- not grant access until that acknowledgement is in place.

The organisation must also review and update the rules at least every 12 months. If the rules change, it must require people who previously acknowledged them to read the updated version and re-acknowledge within 30 days, and it must keep records of reviews and updates.

##### IAM workflow gate for role-based Rules of Behaviour acknowledgement

- Category: Software
- Priority: Critical

###### WHAT
Put in place “Rules of Behaviour” that match each person’s role, and manage them as controlled, version-controlled documents. Require every person to give a documented acknowledgement **before** they are set up to use the application (and any managed/mediated operational technology (OT) access route). If the rules are changed, require people to acknowledge the updated version within the agreed timeframe.

###### WHY (control requirement)
PL-4 requires that Rules of Behaviour are set based on users’ roles and responsibilities. It also requires that privileged users and general users are separated where relevant, that people receive the rules and provide a **documented acknowledgement** (for example, an electronic agreement checkbox/radio button or a signature), and that access is not granted until the acknowledgement is recorded. The organisation’s defined parameters require the rules to be reviewed and updated at least every **12 months**, and re-acknowledgement within **30 days** of updates.

###### HOW (specific steps/approach)
1. **Create and maintain controlled rules content**: Create separate Rules of Behaviour for **general** users and **privileged** users (and any additional role variations needed for different responsibilities). Keep them as version-controlled documents with a named owner and a review date.
2. **Share the rules through the access process**: During the identity/access request journey, show the requester the current rules version (or the correct role-based variant) before any provisioning step.
3. **Record documented acknowledgement**: Require an electronic agreement action (checkbox/radio button) that captures: the user’s identity, the rules document name/version, the date and time, and the confirmation text (read/understood/agreed to comply).
4. **Block provisioning/access until acknowledgement is recorded**: Set up the identity and access management (IAM) workflow so that provisioning to the application (and any IT-managed access route to OT jump hosts) is blocked until an acknowledgement record exists for the current rules version.
5. **Automate re-acknowledgement when rules change**: When the rules are updated, mark the previous version as replaced and automatically flag affected users to re-acknowledge. Ensure re-acknowledgement is completed within **30 days** before access is granted or kept (for example, limit access to the minimum needed or revoke/disable access until completed—choose the option that best fits operational constraints).
6. **Keep evidence for audit**: Store acknowledgement events and the link between users and the rules version in an auditable record (identity provider (IdP)/IAM audit logs plus a compliance record store). Keep the review/update evidence to show the **12-month** review cycle is followed.

###### WHO
- **Information Security / Compliance Lead**: owns the Rules of Behaviour, the review schedule, and approvals.
- **IAM Engineer / Identity Platform Team**: builds the workflow gate, captures acknowledgement, and enforces re-acknowledgement.
- **Application Owner**: confirms the access/provisioning integration points and any operational constraints for privileged versus general access.

###### Acceptance criteria
- For new users, the application (and any mediated OT access route) is **not provisioned** until a recorded acknowledgement exists for the current rules version.
- Acknowledgement records include the user identity, rules version, and timestamp, and can be retrieved for audit.
- The Rules of Behaviour are reviewed/updated at least every **12 months**, with evidence retained.
- After a rules update, users who previously acknowledged must re-acknowledge and complete this within **30 days**; access is restricted/revoked until completion (using the chosen enforcement method).
- Privileged and general users receive the correct Rules of Behaviour variant(s) based on their role and responsibilities.

###### Actions Required for Compliance

- [ ] Create versioned “Rules of Behaviour” documents for both general users and privileged users, with named owners and scheduled review dates.
- [ ] Set up the identity and access management (IAM) access request process so that the correct rules for the user’s role are shown before any provisioning step is carried out.
- [ ] Add an electronic acknowledgement (a checkbox or radio button) that records the user’s identity, the rules version, and the date and time (timestamp).
- [ ] Put a control in place that blocks access until the current rules version has been acknowledged and recorded.
- [ ] Automatically re-acknowledge rules when they are updated, and complete this process within 30 days to keep access active.
- [ ] Store and keep audit evidence that links each user’s acknowledgement to the specific rules version and the related review and update activity.


---

#### PL-4.1 — Social Media and External Site/Application Usage Restrictions (Enhancement)

This requirement is about making sure staff use social media and other public websites or apps responsibly, especially when they are acting on behalf of the organisation. Without clear guidance, people could accidentally share confidential or personal information publicly, harm the organisation’s reputation, or create accounts on external services in ways that reveal sensitive access details.

To meet this expectation, the organisation must publish clear, written rules for how staff should behave when using social media, social networking sites, and external websites or applications for official duties. These rules must explain when and how organisational information may be posted on public pages, and they must require prior approval before any organisational information is published publicly.

The rules must also prohibit staff from using organisation-provided identifiers (such as work email addresses) or authentication secrets (such as passwords) to set up external accounts, unless an approved exception process is in place.

The organisation must appoint specific named people to manage these rules, review and update them when needed, and share them with authorised staff. Authorised staff must sign to confirm they have read the rules. The organisation must also support the rules with relevant procedures and role-based training, and keep records showing that the rules and training have been provided.

##### External communications rules with approval and account-creation exceptions

- Category: Manual
- Priority: High

###### WHAT
Create and maintain written, role-specific **rules of behaviour** for using **social media, social networking, and external websites/applications** when staff use them for official duties or when organisational information is involved. The rules must include: (1) restrictions on what may be posted publicly and when prior approval is required, (2) clear prohibitions on using **organisational identifiers** (for example, work email addresses) and **authentication secrets** (for example, passwords) to create external accounts, and (3) an exception/authorisation process for any required deviations.

###### WHY (control requirement)
NIST SP 800-53 **PL-4(1)** enhancement requires the organisation’s **rules of behaviour** to include **restrictions** on social media and external website/application use. This must specifically address the risk of disclosing **non-public organisational information** (including **personally identifiable information (PII)** and system account information) and prevent unauthorised parties from obtaining such information directly or by making reasonable guesses.

###### HOW (specific approach)
1. **Publish one authoritative document** (for example, “External Communications & External Account Creation Rules of Behaviour”) in an organisation-controlled repository (single sign-on (SSO)/intranet) with version control.
2. **Define scope and terms** in the document: what counts as social media/external websites/apps, what counts as **official duties**, what is **organisational information**, and what is **non-public information** (explicitly include PII and system account information).
3. **Add explicit posting restrictions**: require prior approval before publishing any organisational information on public social media/external websites; include content categories (for example, marketing/press releases versus technical/operational details) and the approval authority for each category.
4. **Add explicit account-creation restrictions**: prohibit creating external accounts using organisational-provided identifiers and authentication secrets (for example, work email/password). If an exception is necessary, require a documented exception request that states the business reason, the compensating controls, and the named approver.
5. **Assign named responsibilities**: appoint accountable roles for maintaining the rules, reviewing exceptions, and updating content; ensure the rules are reviewed on a defined schedule (for example, at least annually or whenever there is a material change).
6. **Make the rules operational through a workflow**: implement a ticket/workflow route for (a) public posting approvals and (b) external account creation exceptions, ensuring approvals are recorded and can be audited.
7. **Communicate and obtain acknowledgement**: require authorised staff to acknowledge the rules (during initial onboarding and when roles change; and periodically re-acknowledge).
8. **Provide role-based training** aligned to the rules (for example, the public posting approval process, what not to post, how to request an exception, and how to report suspected misuse) and keep evidence of completion.

###### WHO
- **Information Security / Security Governance Lead**: owns the rules framework and ensures definitions of non-public information are accurate.
- **Communications/PR Lead**: owns posting categories and approval authorities for public communications.
- **Service Desk / Workflow Owner**: implements and maintains the approval/exception workflow and keeps evidence.
- **Line Managers / Human Resources (HR)**: ensure staff acknowledgement and training completion are enforced for authorised users.

###### Acceptance criteria
- A current, version-controlled rules document exists and is available to authorised personnel.
- The rules clearly state: (a) prior approval is required for public posting of organisational information, and (b) organisational identifiers and authentication secrets must not be used to create external accounts except through an approved exception process.
- Named approvers and responsibilities are documented for posting approvals and account-creation exceptions.
- A workflow/ticket process exists that records approval decisions and exception justifications.
- Evidence is available for: user acknowledgements, role-based training completion, and exception/posting approval records for a sample of recent activities.

###### Actions Required for Compliance

- [ ] Create and publish a version-controlled document called **“External Communications & External Account Creation Rules of Behaviour”**. Include clear definitions of what counts as **non-public information**, including **personal data (PII)** and **system account information**.
- [ ] Set rules that require prior approval before any organisational information is published publicly on social media or on external websites and applications.
- [ ] Define and publish clear rules that forbid anyone from using organisational identifiers or authentication secrets to create external accounts, and set out the specific criteria for any exceptions.
- [ ] Set up an approval process that can be audited for (a) approvals to publish content publicly and (b) exceptions to create external accounts, recording the approver’s identity and the reason for the approval.
- [ ] Assign named owners to maintain the rules, review exceptions, and update the content, and set a regular review schedule.
- [ ] Introduce role-based training and require authorised staff to confirm they understand the rules during onboarding or when their role changes, and then again at regular intervals afterwards.
- [ ] Keep records showing acknowledgements, completion of training, and a sample of recent approvals and exceptions for postings for audit purposes.


---

### PL-7 — Concept of Operations (Control)

This requirement is about having a clear, up-to-date “how we will run it” plan for each system. The plan should explain, in day-to-day practice, how the organisation will protect information and respect people’s privacy. Without this, teams may run the system in different ways, miss important privacy steps, or fail to update procedures when the system changes. This increases the risk of information being handled incorrectly, personal information being used in the wrong way, and unclear responsibilities during incidents.

To meet this expectation, the organisation must create a **Concept of Operations** that describes how the system will be operated from both an information protection and privacy perspective. This should be stored in the system’s planning documents (such as the security and/or privacy plan) and treated as a “living document”.

It must be reviewed at least every 12 months, and also whenever there are material changes to how the system operates, how it is built, or the organisation’s security or privacy requirements. Updates must be made when the review shows the document is no longer accurate.

##### Controlled, system-specific CONOPS with annual and change-trigger reviews

- Category: Manual
- Priority: High

###### WHAT
Create and maintain a **system-specific Concept of Operations (CONOPS)** that explains how the application will be run in practice, including clear **information security** and **privacy** practices. Keep it in the system’s planning and development documentation (for example, the **security plan** and/or **privacy plan**) and treat it as a **living document**.

###### WHY (control requirement)
PL-7 requires that the CONOPS is a living document that is **kept up to date throughout the system development life cycle**, is **checked during system design reviews** to confirm it matches the planned controls, system design, and day-to-day operating procedures, and is **reviewed and updated at least every year** and whenever there are **material changes** to how the system operates, its design, or its security/privacy requirements.

###### HOW (specific approach)
Set up a governance process that links the CONOPS to the system development life cycle stages and keeps evidence that reviews and updates have been completed:
1. **Create a system-specific CONOPS template** (for each application) with sections covering: intended operational use, roles and responsibilities, operating procedures, security-related operations (for example, access administration, handovers for monitoring and response, and backup/disaster recovery operations), privacy-related operations (for example, data handling, retention, and processes to support people’s rights), and how the CONOPS aligns with the planned controls and system design.
2. **Put the CONOPS under formal document control** in the organisation’s document system (controlled metadata, version control, named owner, and restricted access). Ensure the **security plan and/or privacy plan** clearly points to the current CONOPS (document name and section references).
3. **Define checks at each system development life cycle stage**: at the design review, require evidence that the CONOPS still matches the planned controls, system design, and operating procedures; at go-live, require security and privacy sign-off that the CONOPS matches the operating procedures.
4. **Set a review schedule and trigger for changes**: schedule an **at least annual** review by the system owner, the security planning lead, and the privacy lead. Also trigger an immediate CONOPS review when a change is identified as **material** (for example, a change to the system design, a change to the operating model, or a change to security/privacy requirements). Link the trigger to the relevant change records (for example, a change record and/or architecture decision record).
5. **Keep records of review evidence and results**: for each review, record the review date, who reviewed it, the result (updated or no change), and—if updated—what sections changed and how those updates are reflected in the security/privacy plans.

###### WHO
- **System Owner / Application Owner**: responsible for keeping the CONOPS up to date and ensuring reviews happen.
- **Security Planning Lead (or Chief Information Security Officer (CISO)/Information Security representative)**: confirms alignment with security controls and system design.
- **Privacy Lead / Data Protection Officer (DPO) (where applicable)**: confirms privacy practices and alignment with privacy requirements.
- **Document Controller / Governance, Risk and Compliance (GRC) Administrator**: ensures document control, version control, and auditability.

###### Acceptance criteria
- A **system-specific CONOPS** exists and is stored using controlled document management.
- The **security plan and/or privacy plan** references the current CONOPS.
- The CONOPS has a documented **review at least annually**, including evidence of who reviewed it and the outcome.
- The CONOPS is reviewed and updated (or explicitly confirmed as still accurate) when **material changes** occur, with evidence of the trigger and the review outcome.
- Review outcomes are reflected in the **security/privacy plans** (and any other referenced planning or system development life cycle documents) when updates are made.

###### Actions Required for Compliance

- [ ] Create a CONOPS (concept of operations) template for each system. It should set out the day-to-day security and privacy procedures, and show how these match the planned controls and the system design (architecture).
- [ ] Publish the concept of operations (CONOPS) in a controlled document management system with a named owner, version control, and restricted access.
- [ ] Update the system security plan and/or privacy plan to point to the current concept of operations (CONOPS) (include the document name and the relevant section references).
- [ ] Set up software development life cycle (SDLC) gate requirements so that design reviews and go-live release require proof that the concept of operations (CONOPS) is consistent, and require formal sign-off.
- [ ] Set up a workflow to review the CONOPS (concept of operations) at least once every year, involving security and privacy reviewers, and require completion of a mandatory checklist.
- [ ] Link the CONOPS (concept of operations) review triggers to change management, so that any material changes to operations, architecture, or security and privacy requirements trigger an immediate review.
- [ ] Keep an auditable review record that shows the review date, who reviewed, the result, and what was changed at each section level, with clear links back to the planned updates.


---

### PL-8 — Security and Privacy Architectures (Control)

This requirement is about creating, documenting, and regularly updating a clear plan for how your system will protect information and people’s personal data, and how that plan matches the organisation’s overall way of designing systems. Without this, confidential business information could be exposed, records could be changed or damaged, services could stop working, and personal data could be handled in ways that cause unnecessary privacy harm.

To meet this expectation, the organisation must produce two documents for the system: a security plan and a privacy plan. Together, they must explain what needs to be protected, how personal data will be handled to reduce privacy risk, how the system’s approach fits with the organisation’s overall architecture, and what the system depends on from external suppliers or services. These plans and architectures must be reviewed at least every year and also whenever the organisation’s architecture changes. Any planned changes must then be reflected in the system’s security plan, privacy plan, day-to-day operating description, importance and recovery priorities, internal procedures, and procurement or purchasing documents. Records must be kept showing the reviews and updates.

##### Versioned security & privacy architecture with interface protection

- Category: Manual
- Priority: Critical

###### WHAT
Create and keep up to date a **system-level security and privacy design** that matches the organisation-wide designs in **PM-7**. This system-level design must include, at system level: a clear description of the design; where security and privacy responsibilities sit (including the required controls); security and privacy information for **external interfaces**; what information is shared through those interfaces; and the **protective measures** linked to each interface. Keep this design under configuration control, and make sure it is reviewed and updated **every year and whenever the enterprise architecture changes**.

###### WHY (control requirement)
**PL-8** requires that the system’s security and privacy designs are **consistent with the organisation-wide designs** in **PM-7**, are **part of and developed alongside enterprise architecture**, and include the security/privacy details at interface level and the protective measures. These designs must be **reviewed and updated throughout the SDLC**, and specifically at least **every year and when the enterprise architecture changes** (frequency: annual and whenever enterprise architecture changes).

###### HOW (specific steps/approach)
1. **Create one combined design document (or two linked documents)** under configuration control that includes:
   - **Security design**: confidentiality, integrity and availability objectives, trust boundaries, component responsibilities, and the security controls assigned to each part.
   - **Privacy design**: categories of personal data, purposes, how long data is kept and related principles, privacy requirements, and the privacy controls assigned to each part.
   - **Enterprise alignment**: clear mapping to the enterprise security/privacy designs (PM-7) and to the enterprise architecture target state (for example, reference components, standards, and patterns).
   - **External dependencies**: identify external information services/service providers, assumptions, and what you expect from them (including availability and data-handling expectations).
   - **Interface protection**: for each external interface, document what is exchanged and the protective measures (for example, the authentication/authorisation approach, encryption while data is in transit and when stored, integrity checks, logging/monitoring points, and any privacy-relevant handling).
   - **Operational impact**: priorities for restoring information and system services, and any user roles/access privileges only where they are part of the design allocation.
2. **Set up an architecture review process** that triggers:
   - a planned **annual review**, and
   - an **enterprise architecture change-triggered review** (per pl-08_odp frequency).
   Keep evidence of the review (for example, review record, change log, approvals) and ensure updates are reflected in system planning documents (security plan, privacy plan, CONOPS, restoration/criticality priorities, and procurement requirement packs).
3. **Use the design outputs in procurement and design reviews**:
   - Add security/privacy requirements derived from the design into RFP/RFQ responses and design review checklists (preliminary and critical design reviews).
   - Make sure external supplier/service provider requirements reflect the design’s interface protection and dependency assumptions.
4. **Keep configuration-controlled baselines**:
   - Store the design under configuration management with versioning, change control, and traceability back to the current implemented design.
   - Use the baseline as the reference point for implementation and for later reviews.

###### WHO (role responsible)
- **System Security Architect / Security Engineering Lead**: owns the security design content and the interface protection measures.
- **Privacy Officer / Privacy Architect**: owns the privacy design content (personal data processing, minimisation, retention, and rights handling where applicable).
- **Enterprise Architecture Lead (or delegated enterprise architecture governance)**: checks consistency with enterprise architecture and alignment to PM-7.
- **Configuration Manager / GRC Lead**: ensures configuration control, evidence is captured, and SDLC review integration is in place.

###### Acceptance criteria
- The system has a configuration-controlled security and privacy design that explicitly includes: confidentiality, integrity and availability security allocation; privacy allocation for personal data processing; alignment to PM-7; external dependencies; and **interface-level** security/privacy information plus protective measures for each external interface.
- Evidence shows the design was reviewed **at least every year**, and also reviewed/updated when the enterprise architecture changed (per pl-08_odp).
- Changes to the design can be traced to updates in the system security plan, privacy plan, CONOPS/operational description, restoration/criticality priorities, and procurement requirement packs.
- Design review documents (preliminary and critical design reviews) reference the design and confirm that planned changes are included before implementation.

###### Actions Required for Compliance

- [ ] Create a configuration-controlled system security and privacy architecture that covers confidentiality, integrity and availability (CIA), how personal information is processed (including personal identifiable information (PII)), and the specific controls that have been assigned.
- [ ] Clearly link the system design to the organisation-wide security and privacy architecture described in PM-7, and to the enterprise architecture target state.
- [ ] Document each external interface, including: what information is exchanged, the security and privacy requirements, and the safeguards used to protect that interface.
- [ ] Identify and record any outside dependencies and assumptions (including whether the service is available when needed and how data is expected to be handled) for external information services or providers.
- [ ] Set up a review process that runs every year and also whenever an enterprise architecture change is made, and keep the proof of each review (approvals, a record of the changes, and the reasons for them).
- [ ] Update all downstream documents (security plan, privacy plan, concept of operations/operational description, restoration priorities, and procurement requirement packs) whenever the architecture changes.


---

#### PL-8.1 — Defense in Depth (Enhancement)

This requirement is about building security and privacy in layers, so an attacker has to get past several protections before they can cause harm. Without this, one weak point could allow someone to enter the wrong part of your systems, pretend to be a user, read or change sensitive information, or stay hidden for longer—making damage more likely and harder to detect in time.

The organisation is expected to design both its security and privacy plans using a defence-in-depth approach. This includes using network separation, extra identity checks (such as a code sent to a phone), giving people only the minimum access they need, protecting data both when it is stored and when it is sent, using standard safe settings, and carrying out ongoing alerts and checks across key areas. These areas include the perimeter and internal networks, the boundary between operational technology and information technology, the computers and applications, the data storage, and the monitoring layer.

The organisation must also ensure these measures work together without interfering with each other, and document how they are coordinated.

##### Defense-in-depth architecture with coordinated layered control allocation

- Category: Manual
- Priority: Critical

###### WHAT must be done
Design the system’s **security and privacy architectures** using a **defence-in-depth** approach. This means placing several security and privacy protections in different places and layers, so an attacker must overcome **multiple coordinated protections** to achieve their goals.

###### WHY (control requirement)
PL-8(1) requires that the security and privacy architectures are designed so attackers must defeat **multiple protections**. This increases the attacker’s effort and the chance of being detected, while also ensuring **coordination** so one protection does not cause **unintended effects** (for example, system lockout or a chain reaction of alarms). The guidance points to architectural approaches such as **modularity/layering** (SA-8(3)), **separating system functions from user functions** (SC-2), and **isolating security functions** (SC-3).

###### HOW (specific steps/approach)
1. **Create an architecture allocation matrix** that shows how the required defence-in-depth protections are assigned to the defined **locations and architectural layers**, including:
   - Perimeter and internal network zones
   - OT/IT demilitarised boundaries
   - Host and application layers
   - Data layer
   - Security monitoring layer  
   The matrix must clearly assign: **network segmentation, multi-factor authentication (MFA), least privilege, encryption at rest/in transit, secure configuration baseline settings, and continuous monitoring** to each relevant layer/location.
2. **Define trust boundaries and allowed connections** between layers/zones (including OT/IT boundaries), and document how segmentation limits sideways movement and reduces the overall impact if something goes wrong.
3. **Coordinate how protections work together, using guardrails, to prevent unintended effects**:
   - Define administrative access routes so MFA and least privilege do not disrupt day-to-day operations (for example, emergency “break-glass” access with compensating controls).
   - Set monitoring and detection tuning rules to avoid **alarm overload** and repeated cascading alerts during configuration changes.
   - Provide operational runbooks for what to do if segmentation or secure configuration baseline enforcement blocks traffic (including how to roll back or request exceptions).
4. **Produce both security and privacy architecture documents** using the same layered allocation logic (not only encryption). The privacy allocation must explain how layered protections safeguard personal data across the same layers (for example, access restrictions, secure transport/storage, and monitoring for unauthorised access).
5. **Make the design ready for audit and traceable in day-to-day delivery**:
   - Record the architectural decisions, assumptions, and reasons for each protection-to-layer assignment.
   - Link the allocation matrix to implementation standards (for example, baseline templates, identity policies, and logging/detection coverage) so the design can be carried into build, deployment, and change activities.

###### WHO (role responsible)
- **Solution/Enterprise Architect** (owns the architecture and allocation matrix)
- **Security Architecture Lead** (owns coordination/guardrails and the audit evidence structure)
- **Identity and Access Management (IAM) Lead** (owns the MFA/least privilege allocation details)
- **Network/Operational Technology (OT) Security Engineer** (owns segmentation and OT/IT boundary connection definitions)
- **Application/Data Security Engineer** (owns encryption and secure configuration baseline allocation)
- **Security Operations Centre (SOC) / Monitoring Lead** (owns continuous monitoring coverage and alert tuning guardrails)

###### Acceptance criteria
- A completed **security architecture** and **privacy architecture** document exists. Each document includes an **allocation matrix** mapping the required defence-in-depth protections to all specified layers/locations.
- The architecture includes documented **trust boundaries** and **allowed connections** showing that an attacker must pass through multiple protections (for example, segmentation + identity/authorisation + encryption + secure configuration + monitoring).
- Documented **coordination/guardrails** exist showing how protections avoid unintended effects (lockout and alarm overload), with defined operational handling.
- Evidence shows the design is **traceable** to operational standards (baseline templates, identity policy requirements, and logging/detection expectations) and can be reviewed for audit purposes.

###### Actions Required for Compliance

- [ ] Create a security architecture allocation matrix that assigns responsibility for each of the following controls to every defined layer/location: network segmentation, multi-factor authentication (MFA), least privilege, encryption for data stored and data sent, secure configuration baselines, and continuous monitoring.
- [ ] Create a privacy architecture allocation matrix that uses the same layered allocation approach to protect personal data across the same layers and locations.
- [ ] Define trust boundaries and the permitted network, application, and data connections between: the perimeter and internal zones; the operational technology (OT) and information technology (IT) demilitarised boundaries; the host and application layer; the data layer; and the security monitoring layer.
- [ ] Set document-coordination safeguards (for example, a “break-glass” emergency access approach, clear rules for handling exceptions and rollbacks, and monitoring alert-tuning) to prevent user lockouts and repeated alarm floods.
- [ ] Record the reasons and assumptions behind where each control is assigned to each layer, so there is clear, audit-ready evidence that can be traced back.
- [ ] Review the overall design with the identity and access management (IAM) team, the network and operational technology (OT) security team, the application and data security team, and the security operations centre (SOC) leads, and obtain formal approval.


---

#### PL-8.2 — Supplier Diversity (Enhancement)

This requirement is about not depending on a single supplier for key security tools across different parts of your business. The aim is to reduce the risk that a weakness in one supplier’s product could affect both your main on-site data centre systems and your operational technology (OT) network areas. If you use the same supplier everywhere, you increase the chance that the same security gap exists in both places.

To lower this risk, the organisation must buy security tools from different suppliers for the on-premises data centre environment than for the OT network segments. This applies to:
- tools for malware protection,
- tools that help detect suspicious activity on devices, and
- tools that record what happened on systems.

The organisation should include this in its purchasing rules, check before buying that the suppliers are different, and keep clear records showing which supplier was chosen for each tool in each environment. This should also include any approved exceptions, with reasons, where the same supplier cannot be used.

##### Enforce supplier diversity for in-scope security controls by environment

- Category: Software
- Priority: Critical

###### WHAT must be done
Put in place a supplier-diversity rule that can be enforced, so that for the organisation-defined **controls** ({{ insert: param, pl-08.02_odp.01 }}) assigned to the organisation-defined **locations and architectural layers** ({{ insert: param, pl-08.02_odp.02 }}), each assigned control comes from **different suppliers** (i.e., supplier_onprem ≠ supplier_ot for each in-scope control type across the defined environments).

###### WHY (control requirement)
NIST SP 800-53 **PL-8(2) Supplier Diversity (Enhancement)** requires: “Require that {{ insert: param, pl-08.02_odp.01 }} assigned to {{ insert: param, pl-08.02_odp.02 }} are obtained from different suppliers.” This reduces the risk of a single supplier failing and increases the chance that at least one product will detect problems (for example, malware or gaps in monitoring/telemetry) across different environments.

###### HOW (specific steps/approach)
1. **Create a supplier-diversity policy model** that, at minimum, includes: (a) the in-scope security-relevant control types from {{ insert: param, pl-08.02_odp.01 }} (for example, malware protection, endpoint detection and response, logging/monitoring), (b) the in-scope environments/architectural layers from {{ insert: param, pl-08.02_odp.02 }} (for example, on-premises data centre versus operational technology network segments), and (c) the rule **supplier(environment A, control type) ≠ supplier(environment B, control type)**.
2. **Build the rule into procurement and architecture approval checkpoints**, so that a purchase request or vendor selection cannot be approved unless the selected suppliers for each in-scope control type are different across the defined environments.
3. **Add policy checks in the workflow system** (for example, an IT service management and procurement workflow) that stop submissions when supplier choices break the diversity rule for any in-scope control type and environment pair.
4. **Keep audit-ready records at approval time**, including: selected supplier names, control type, environment mapping, approver identity, dates and times, and references to the approved system security plan and architecture documents.
5. **Allow exceptions only through a controlled exception process**, which records the affected control types, environments, impacted systems, the compensating measures, and the approval decision trail (so the organisation can still demonstrate its compliance position).
6. **Confirm deployment plans match the approved choices** by requiring the architecture approval documents to name the chosen suppliers for each environment/control type. (Any mismatch between planned and actual deployment is out of scope here and should be handled by separate inventory and configuration controls.)

###### WHO (role responsible)
- **Information Security Governance Lead / Compliance Owner**: defines the in-scope control types and environments and owns the supplier-diversity policy.
- **Procurement Operations Lead**: ensures the procurement workflow captures supplier selections and exception handling.
- **Enterprise Architecture Lead**: ensures system security plan and architecture approvals reference the chosen suppliers for each environment.
- **GRC/ITSM Workflow Administrator**: implements and maintains the policy checks and the evidence capture.

###### Acceptance criteria
- For every in-scope control type in {{ insert: param, pl-08.02_odp.01 }} and every in-scope environment in {{ insert: param, pl-08.02_odp.02 }}, the approval workflow enforces **supplier_onprem ≠ supplier_ot** (or the equivalent mapping for the defined environments).
- Purchase requests and architecture approvals cannot be completed when the diversity rule is broken, unless an approved exception exists with recorded reasons and compensating measures.
- Audit evidence is produced, including supplier selections, environment/control mapping, approver identity, dates and times, and references to the approved architecture and security plan documents.

###### Actions Required for Compliance

- [ ] Set out the security-relevant control types that are in scope for {{ insert: param, pl-08.02_odp.01 }} and the in-scope environments and architectural layers for {{ insert: param, pl-08.02_odp.02 }}
- [ ] Create a supplier-diversity policy model that links each in-scope control type to each in-scope environment, with the rule that the supplier used for one environment must be different from the supplier used for another environment (supplier for environment A ≠ supplier for environment B).
- [ ] Update the procurement and IT service management (ITSM) purchase request forms to record which supplier is selected for each in-scope control type and each environment.
- [ ] Set up policy checks in the workflow system so that approvals are blocked when supplier selections break the diversity rule.
- [ ] Add an architecture approval step that requires the system security plan and architecture documents to name the selected suppliers for each environment and each control type.
- [ ] Set up an auditable exception process (including the reason for the exception and any compensating measures) for cases where the diversity requirement cannot be met.


---

### PL-9 — Central Management (Control)

This requirement is about managing security and privacy work from one place in the organisation, so the same rules are used everywhere. Without this, different teams might follow different practices, creating gaps that attackers (or simple mistakes) could take advantage of—for example, unauthorised access, weak ways of handling user accounts, poor change management, missing records of what happened, delayed detection of problems, or unclear plans for protecting personal data.

To meet this expectation, the organisation must centrally plan, set up, check, formally approve, and keep under ongoing review the security and privacy measures it has chosen. This includes areas such as:
- who is allowed to access systems
- how accounts are created and changed
- how important events are recorded and monitored
- how changes are approved and verified
- how incidents and unusual events are handled
- how data is protected
- how system and privacy planning is documented

Where full central management is not possible, the organisation must clearly run a hybrid approach: the parts that can be managed centrally must be managed centrally, and the rest must be managed at system level.

##### Central control plane for centrally managed controls and evidence

- Category: Software
- Priority: Critical

###### WHAT must be done
Manage the organisation’s selected security and privacy controls and related processes (PL-9 parameter **pl-09_odp**) in a single, consistent way across the whole organisation. This means planning, putting them in place, checking they work, approving them, and monitoring them—using an approach that is standardised and can be audited.

###### WHY (control requirement)
PL-9 requires the organisation to **centrally manage** the selected controls and related processes defined in **pl-09_odp**. Central management must cover the full lifecycle: planning → implementation → assessment → authorisation → monitoring. It should also support standardisation and ongoing monitoring. If full central management is not practical, the control must be handled as a **hybrid**, with clear boundaries.

###### HOW (specific steps/approach)
Set up a central “control plane” that turns centrally defined requirements into practical, enforceable measures across systems—while also producing the evidence needed for audits.

1. **Create centrally managed control packs** for every item in **pl-09_odp** (for example: AC-2(1..4), AC-4(all), AC-17(1..3,9), AC-18(1,3..5), AC-19(4), AC-22, AC-23, AT-2(1..4), AU-3, AU-6(1,3,5,6,9), AU-7(1..2), AU-11, AU-13, AU-16, CA-2(1..3), CA-3(1..3), CA-7(1), CA-9, CM-2(2), CM-3(1,4), CM-4, CM-6, CM-6(1), CM-7(2,4,5), CM-8(all), CM-9(1), CM-10, CM-11, CP-7(all), CP-8(all), SC-43, SI-2, SI-3, SI-4(all), SI-7, SI-8). Each pack must state: the centrally managed requirement, where it is enforced, what logging/monitoring data is needed, and what evidence documents must be produced.
2. **Clearly define the hybrid boundary** for any systems where central enforcement is not possible. Keep a centrally governed record of: (a) what is centrally managed and (b) what stays managed at system level, including any compensating controls and the system-level evidence required.
3. **Standardise implementation using central enforcement services** aligned to the control packs:
   - **Identity and access enforcement** for AC-2/AC-4/AC-17/AC-18/AC-19/AC-22/AC-23 using the enterprise identity provider (IdP) and role-based access control (RBAC) and least-privilege models.
   - **Audit logging and monitoring** for AU-3/AU-6/AU-7/AU-11/AU-13/AU-16 by sending events to the enterprise security information and event management (SIEM) and monitoring platform using consistent formats, agreed retention periods, and alerting.
   - **Configuration and change governance** for CM-2/CM-3/CM-4/CM-6/CM-7/CM-8/CM-9/CM-10/CM-11 using standard baselines, drift detection, and centrally defined change approval and verification workflows.
   - **Planning and incident/response support** for CP-7/CP-8 and SC-43/SI-2/SI-3/SI-4/SI-7/SI-8 through centrally maintained templates, runbooks, and reporting requirements.
4. **Automate checks and evidence production**: run scheduled control checks (configuration compliance, coverage of logging, adherence to access policies, and completeness of change records) and produce audit-ready evidence packages for each system/environment (development/testing/production/disaster recovery). These packages must reference the centrally managed control packs.
5. **Centralise authorisation support and ongoing monitoring**: use assessment results to feed into the organisation’s authorisation and continuous monitoring workflow, including tracking remediation actions to completion, and providing dashboards to support risk-based decisions.

###### WHO (role responsible)
- **Information Security Governance Lead / GRC Manager**: owns the PL-9 control packs, the hybrid boundary definitions, and integration into the authorisation and continuous monitoring workflow.
- **Security Engineering Lead**: implements the central enforcement points (identity provider policies, SIEM pipelines, configuration and change automation).
- **System Owners / Application Owners**: ensure each system/environment is connected to the central mechanisms and provide any required system-level evidence where hybrid applies.
- **IT Operations / Platform Engineering**: maintains baseline compliance automation and operational runbooks.

###### Acceptance criteria (verifiable)
- A centrally maintained, version-controlled set of **control packs** exists covering **all items listed in pl-09_odp**, each with defined enforcement points and required evidence documents.
- A documented **hybrid management boundary** exists for any parts that cannot be enforced centrally, and the evidence clearly shows which requirements are centrally managed versus managed at system level.
- For each onboarded system/environment, automated evidence packages show that centrally managed controls are in place and have been assessed (for example: access policy compliance, logging coverage, and configuration/change compliance).
- Assessment results are integrated into the organisation’s **authorisation and continuous monitoring** process, with remediation actions tracked to completion.
- Central monitoring dashboards and alerts demonstrate ongoing monitoring of the effectiveness of centrally managed controls (not just one-off assessments).

###### Actions Required for Compliance

- [ ] Define and publish centrally managed control packs that cover every control or process item listed in `pl-09_odp`, including the points where controls are enforced and the required evidence documents.
- [ ] Document the “hybrid boundary” for any requirements that cannot be enforced centrally, and set out the compensating controls and what system-level evidence is expected.
- [ ] Put in place central controls to enforce access and account rules, to record and monitor audit activity, and to manage configuration and change approvals in line with the control packs.
- [ ] Set up security information and event management (SIEM) and monitoring processes to standardise how events are collected, linked together, used to trigger alerts, and stored for centrally managed audit requirements.
- [ ] Automate scheduled checks of control compliance (baseline compliance, logging coverage, adherence to access rules, and completeness of change records) and produce evidence packs that can be audited for each system or environment.
- [ ] Use the results of assessments in the organisation’s approval and ongoing monitoring process, including tracking fixes until they are completed (to closure).


---

### PL-10 — Baseline Selection (Control)

This requirement is about selecting the right protection for a system before problems occur. If the organisation does not start with a sensible set of security and privacy measures, it may not protect important information enough. That can lead to loss, damage, or misuse of data; disruption to services; harm to individuals; breaches of legal or contractual responsibilities; and wider effects on other organisations or the wider nation.

To meet this expectation, the organisation must:
- analyse what information the system handles and how it is used;
- assess what harm could result if the system or information is lost or compromised; and
- use the results of both system-level and organisation-wide risk reviews to decide which protection package to apply.

The chosen package must also reflect stakeholder needs, the organisation’s mission and business requirements, and any legal, regulatory, policy, or contractual requirements, including any required add-ons that are approved by the organisation or at federal level.

Finally, the organisation must record which protection package was selected, the reasons for the selection, and evidence that it was formally approved by authorised personnel.

##### Risk-informed baseline selection with documented rationale and approval

- Category: Manual
- Priority: Critical

###### WHAT must be done
Choose and formally record an appropriate security control baseline from **NIST Special Publication (SP) 800-53** for the application system. Include any required additions or “overlays”, based on stakeholder needs, applicable requirements, the system’s information categories and how the system handles them (store/process/transmit), and the results of both system-level and organisation-level risk assessments.

###### WHY (control requirement)
**PL-10** requires the organisation to **select a control baseline for the system**. The guidance says this choice must be driven by:
- **stakeholder needs**
- **mandates** (laws, executive orders, directives, policies, regulations, standards, guidelines, and contractual requirements)
- **risk and impact analysis**, including the adverse effects of losing or compromising the system on **operations and assets, individuals, other organisations, or the Nation**
using the **system and organisation risk assessment results**.

The selected baseline must be **tailored** to manage risk in line with mission and business constraints (see **PL-11**).

###### HOW (specific steps/approach)
1. **Prepare a system baseline intake pack**: system boundary, an overview of the system design (including multi-tier structure and separation between environments), a data inventory mapped to **information types** (what is processed/stored/transmitted), and summaries of data flows for each environment (production, testing, and disaster recovery).
2. **Compile a mandates register** for the system: list all applicable legal, regulatory, policy, and contractual requirements, plus any organisation-approved or federal-approved baseline overlays/add-ons that must be included.
3. **Run a baseline selection workshop** with Security, Privacy (if applicable), Risk, Architecture, and Service Owners to capture **stakeholder needs** (mission/business requirements, expectations for confidentiality/integrity/availability, privacy expectations, and operational constraints).
4. **Carry out impact/criticality analysis** for each **information type** and processing mode (for example, customer/employee/financial/operational data; credentials; telemetry) to determine the adverse impact of loss or compromise across the areas described in the **PL-10** guidance.
5. **Use risk assessment results**: review system-level risk assessment outputs (threats, vulnerabilities, likelihood, and impact) and the organisation’s risk position and risk management approach (risk appetite, standard exceptions, and common control gaps) to support the baseline choice.
6. **Select the named baseline and overlays**, then document the tailoring decisions (what is added or removed and why) so the baseline can be traced to mandates, information types, impact analysis, and risk assessment outcomes.
7. **Obtain formal approval** from authorised roles (for example, the Chief Information Security Officer (CISO) / Head of Risk / Privacy lead as appropriate) and store the baseline selection record in a controlled repository with version control. Ensure that later security and privacy planning refers to the approved baseline selection record.

###### WHO (role responsible)
- **Accountable**: CISO (or equivalent security governance lead) and Head of Risk (and Privacy lead where privacy is in scope).
- **Responsible**: Security Architect / Information Security Manager to run the workshop and produce the baseline selection record; Risk Manager to incorporate risk assessment outputs; Application Owner to provide the system’s information types and processing details.

###### Acceptance criteria
- A **named control baseline** (and any required overlays/add-ons) is selected for the application system.
- The baseline selection record includes traceability to: **stakeholder needs**, **mandates register**, **information types** (processed/stored/transmitted), **impact/criticality analysis**, and **system and organisation risk assessment results**.
- Tailoring decisions are clearly documented and justified.
- The baseline selection record is **formally approved** by authorised personnel and stored as audit-ready evidence (versioned and with controlled access).

###### Actions Required for Compliance

- [ ] Put together a system intake pack that includes the types of information handled and how it moves through the system (store, process, and transmit) for each environment.
- [ ] Create and keep up to date a mandates register that lists the baseline overlays and add-ons required for the system.
- [ ] Run an initial workshop to agree on the baseline by capturing stakeholders’ needs and limitations
- [ ] For each type of information and each way it is processed, carry out an impact and criticality assessment using the adverse impact dimensions.
- [ ] Review the system-level and organisation-wide risk assessment results, and link them to the reasons for choosing the baseline.
- [ ] Choose the approved baseline and record all tailoring decisions with clear evidence linking them to the requirements (mandates), the impact assessment, and the risk findings.
- [ ] Get formal approval from authorised roles and save the baseline selection record in a controlled, version-managed repository.


---

### PL-11 — Baseline Tailoring (Control)

This requirement is about making sure your organisation’s security and privacy plans fit your actual circumstances, rather than being copied from a generic template. If you do not do this, you may waste time on protections that do not matter to your business, or you may miss important safeguards because you did not properly consider your organisation’s purpose, how your systems work, the types of harm that could realistically happen, and other factors that affect success.

To meet this expectation, the organisation must:
- choose the starting set of security and privacy requirements
- decide what to change, add, remove, or adjust
- record clear reasons for each decision using business impact or criticality analysis, risk assessments, and the organisation’s approach to risk
- decide which parts of the system the requirements apply to
- identify protections that can be shared across parts of the system
- choose alternative protections if anything is reduced
- set any required settings
- add extra measures where gaps are identified

Finally, the organisation must update and keep records in the system security plan and the privacy plan. This must be supported by relevant design information, information about data and stakeholders, and information from provider contracts. Named people must be responsible for planning and implementation.

##### Tailoring pipeline to generate justified PL-11 security/privacy baselines

- Category: Software
- Priority: Critical

###### WHAT
Set up a controlled tailoring workflow (supported by automation) that takes the organisation’s chosen security and privacy control baseline(s) and applies agreed tailoring actions. These actions include setting the scope, marking common controls, adding compensating controls, setting parameter values, adding extra controls where needed, and assigning requirements to system components and external providers. The workflow must produce traceable, version-controlled updates to the system security plan and privacy plan, including how the controls will be implemented and why.

###### WHY (control requirement)
PL-11 requires tailoring the selected control baseline by applying specified tailoring actions. The guidance for tailoring actions requires: identifying and designating common controls, applying scoping considerations, choosing compensating controls when baseline controls are changed or removed, setting values for control parameters, adding extra controls when needed, and providing information for how the controls will be implemented—based on mission and business functions, the operating environment, threats and vulnerabilities, and other factors that affect mission success.

###### HOW (specific steps/approach)
1. **Create a baseline catalogue** in a controlled repository containing: the selected baseline(s), any approved overlays, and the list of common controls and candidate compensating controls.
2. **Record tailoring actions as structured decision notes** (for example: add/remove/adjust/parameterise) with required fields: the affected control(s), the scoping scope (which system components and environments), parameter values (where applicable), compensating-control mapping (when reducing/changing/removing baseline controls), and links to supporting evidence.
3. **Apply tailoring rules through policy-as-code** so tailoring cannot be published unless the required justification and equivalence checks are completed (for example: if a baseline control is reduced or removed, a compensating control must be selected and the coverage/equivalence justification must be recorded; overlay constraints must not be broken).
4. **Produce plan outputs from the tailoring decisions**: generate the tailored control set, the allocation of requirements to system components and external providers (including contract or statement of work requirement lists), and the implementation information to insert into the **system security plan** and **privacy plan**.
5. **Keep review and update records**: require named approvers (security and privacy plan owners) to approve tailoring decisions and exceptions; keep version history and the underlying risk and criticality evidence used to justify tailoring.
6. **Link to system lifecycle documents**: connect tailoring inputs to system design documentation (trust boundaries, data flows, separation of environments), data classification, and risk assessment outputs so scoping is accurate.

###### WHO (role responsible)
- **Information Security Officer / Security Governance Lead**: owns the tailoring workflow and approval checkpoints for security plan updates.
- **Privacy Officer / Data Protection Lead**: owns privacy plan tailoring approvals and privacy-specific justification.
- **System Owner / Application Security Lead**: provides system design, scoping inputs, and implementation mapping.
- **Procurement/Contract Manager (with Security/Privacy input)**: ensures external provider requirement allocation is reflected in contractual documents.

###### Acceptance criteria
- Tailoring decisions for the application produce a **tailored control set** that reflects scoping, common-control designation, compensating controls (where applicable), parameter values, and any added controls.
- Every tailoring action has **documented justification** linked to mission and business functions, the operating environment, threats and vulnerabilities, and other relevant conditions.
- The **system security plan** and **privacy plan** are updated with the tailored controls, implementation information, and requirement allocation to system components and external providers.
- All tailoring outputs are **version-controlled and ready for audit**, with named approvals and retained evidence links.
- Policy-as-code checks prevent publication when compensating-control justification/equivalence or overlay constraints are missing or invalid.

###### Actions Required for Compliance

- [ ] Create a controlled baseline catalogue that includes selected baselines, approved add-ons, standard controls, and proposed compensating controls.
- [ ] Create a structured decision template with mandatory sections for defining the scope, listing the parameter values, mapping any compensating controls, and linking the supporting evidence.
- [ ] Set up automated policy checks to confirm compensating controls are equivalent and that overlay rules are followed before publishing.
- [ ] Use tailoring inputs together with system design documents, data classification, and evidence of risk and criticality to ensure accurate project scope and correct allocation of requirements.
- [ ] Create and review customised lists of controls, assign each requirement to the relevant system components, and extract the required contract terms from external provider agreements.
- [ ] Update the system security plan and privacy plan using version-controlled tailoring outputs, and obtain named approvals for both the security and privacy plans.

